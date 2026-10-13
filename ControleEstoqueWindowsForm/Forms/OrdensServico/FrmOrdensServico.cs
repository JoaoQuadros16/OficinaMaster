using ControleEstoqueWindowsForm.Models;
using ControleEstoqueWindowsForm.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEstoqueWindowsForm
{
    public partial class FrmOrdensServico : Form
    {
        // evita consultar o banco várias vezes enquanto os filtros iniciais são preenchidos
        private bool carregandoTela = true;

        public FrmOrdensServico()
        {
            InitializeComponent();

            // valores iniciais dos filtros: todas as OS do mês atual
            cboStatus.SelectedIndex = 0;
            dtpInicio.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpFim.Value = DateTime.Today;
        }

        public void CarregarOrdens()
        {
            OrdemServicoService ordemServicoService = new OrdemServicoService();
            string mensagemErro;
            List<OrdemServico> ordens = ordemServicoService.ListarOrdensServico(
                txtPesquisa.Text, dtpInicio.Value, dtpFim.Value, out mensagemErro);

            if (!string.IsNullOrEmpty(mensagemErro))
            {
                MessageBox.Show(mensagemErro);
                return;
            }

            // cards: contam as OS do período e da pesquisa, independente do status escolhido
            lblQtdAbertas.Text = ordens.Count(o => o.Status == "ABERTA").ToString();
            lblQtdAndamento.Text = ordens.Count(o => o.Status == "EM ANDAMENTO").ToString();
            lblQtdFinalizadas.Text = ordens.Count(o => o.Status == "FINALIZADA").ToString();

            // filtro de status: "Aberta" no combo = "ABERTA" no banco
            if (cboStatus.Text != "Todas")
            {
                string status = cboStatus.Text.ToUpper();
                ordens = ordens.Where(o => o.Status == status).ToList();
            }

            dgvOrdens.DataSource = null;
            dgvOrdens.DataSource = ordens;
            AjustarGrade();
        }

        private void AjustarGrade()
        {
            dgvOrdens.Columns["ClienteId"].Visible = false;
            dgvOrdens.Columns["VeiculoId"].Visible = false;

            dgvOrdens.Columns["Id"].HeaderText = "Nº OS";
            dgvOrdens.Columns["ClienteNome"].HeaderText = "Cliente";
            dgvOrdens.Columns["VeiculoDescricao"].HeaderText = "Veículo";
            dgvOrdens.Columns["DescricaoProblema"].HeaderText = "Descrição";
            dgvOrdens.Columns["DataAbertura"].HeaderText = "Abertura";
            dgvOrdens.Columns["DataAbertura"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            dgvOrdens.Columns["DataFinalizacao"].HeaderText = "Finalização";
            dgvOrdens.Columns["DataFinalizacao"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            dgvOrdens.Columns["ValorTotal"].HeaderText = "Total (R$)";
            dgvOrdens.Columns["ValorTotal"].DefaultCellStyle.Format = "N2";
            dgvOrdens.Columns["ValorTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void FrmOrdensServico_Load(object sender, EventArgs e)
        {
            carregandoTela = false;
            CarregarOrdens();
        }

        // ---------------- Filtros ----------------

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (carregandoTela)
            {
                return;
            }
            CarregarOrdens();
        }

        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (carregandoTela)
            {
                return;
            }
            CarregarOrdens();
        }

        private void dtpInicio_ValueChanged(object sender, EventArgs e)
        {
            if (carregandoTela)
            {
                return;
            }
            CarregarOrdens();
        }

        private void dtpFim_ValueChanged(object sender, EventArgs e)
        {
            if (carregandoTela)
            {
                return;
            }
            CarregarOrdens();
        }

        // ---------------- Ações ----------------

        private void dgvOrdens_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            EditarOS();
        }

        private void btnNovaOS_Click(object sender, EventArgs e)
        {
            FrmOrdemServico tela = new FrmOrdemServico();
            tela.ShowDialog(this);
            CarregarOrdens();
        }

        private void btnAbrirOS_Click(object sender, EventArgs e)
        {
            EditarOS();
        }

        private void EditarOS()
        {
            if (dgvOrdens.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma ordem de serviço para abrir.");
                return;
            }

            OrdemServico ordem = (OrdemServico)dgvOrdens.CurrentRow.DataBoundItem;

            FrmOrdemServico tela = new FrmOrdemServico(ordem.Id, ordem.ClienteId);
            tela.ShowDialog();
            CarregarOrdens();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarOrdens();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}