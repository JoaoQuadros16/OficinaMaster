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
            List<OrdemServico> ordensServico = ordemServicoService.ListarOrdensServico(out mensagemErro);

            if (!string.IsNullOrEmpty(mensagemErro))
            {
                MessageBox.Show("Erro ao carregar ordens de serviço: " + mensagemErro);
                return;
            }

            //melhora visualização da tabela
            dgvOrdens.DataSource = ordensServico;
            dgvOrdens.Columns["ClienteId"].Visible = false;
            dgvOrdens.Columns["VeiculoId"].Visible = false;
            dgvOrdens.Columns["ClienteNome"].HeaderText = "Cliente";
            dgvOrdens.Columns["DescricaoProblema"].HeaderText = "Descrição";
            dgvOrdens.Columns["VeiculoDescricao"].HeaderText = "Veículo";
        }

        private void FrmOrdensServico_Load(object sender, EventArgs e)
        {
            CarregarOrdens();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
        }

        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dtpInicio_ValueChanged(object sender, EventArgs e)
        {
        }

        private void dtpFim_ValueChanged(object sender, EventArgs e)
        {
        }

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

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            
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
