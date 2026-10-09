using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleEstoqueWindowsForm.Validacoes;
using ControleEstoqueWindowsForm.Services;
using ControleEstoqueWindowsForm.Models;

namespace ControleEstoqueWindowsForm
{
    public partial class FrmServicos : Form
    {
        public FrmServicos()
        {
            InitializeComponent();
        }

        // Carrega a grade usando o texto da busca e o estado do "Mostrar inativos".
        // Busca vazia traz todos os serviços.
        public void CarregarServicos()
        {
            ServicoServices servicoServices = new ServicoServices();
            string mensagemErro;
            List<Servico> servicos = servicoServices.PesuqisarServicos(txtPesquisa.Text, chkMostrarInativos.Checked, out mensagemErro);

            if (!string.IsNullOrEmpty(mensagemErro))
            {
                MessageBox.Show("Erro ao carregar serviços: " + mensagemErro);
            }

            dgvServicos.DataSource = servicos;
            AjustarGrade();
        }

        private void AjustarGrade()
        {
            dgvServicos.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvServicos.Columns["Id"].Width = 60;

            dgvServicos.Columns["Descricao"].HeaderText = "Descrição";

            dgvServicos.Columns["Valor"].HeaderText = "Valor (R$)";
            dgvServicos.Columns["Valor"].DefaultCellStyle.Format = "N2";
            dgvServicos.Columns["Valor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // com a caixa desmarcada todos são ativos, então a coluna não precisa aparecer
            dgvServicos.Columns["Ativo"].Visible = chkMostrarInativos.Checked;

            foreach (DataGridViewRow linha in dgvServicos.Rows)
            {
                bool ativo = Convert.ToBoolean(linha.Cells["Ativo"].Value);
                if (!ativo)
                {
                    linha.DefaultCellStyle.ForeColor = Color.Gray;
                }
            }
        }

        private void FrmServicos_Load(object sender, EventArgs e)
        {
            if (Sessao.UsuarioLogado.Nivel_acesso != "Administrador")
            {
                grpDados.Enabled = false;
            }
            CarregarServicos();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            CarregarServicos();
        }

        private void chkMostrarInativos_CheckedChanged(object sender, EventArgs e)
        {
            CarregarServicos();
        }

        private void dgvServicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow linha = dgvServicos.Rows[e.RowIndex];

                txtCodigo.Text = linha.Cells["Id"].Value.ToString();
                txtDescricao.Text = linha.Cells["Descricao"].Value.ToString();
                txtValor.Text = Convert.ToDouble(linha.Cells["Valor"].Value).ToString("N2");
                chkAtivo.Checked = Convert.ToBoolean(linha.Cells["Ativo"].Value);
                lblModo.Text = "Editando serviço";
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                CadastraServico();
            }
            else
            {
                EditaServico();
            }
        }

        private void CadastraServico()
        {
            Servico servico = new Servico();
            servico.Descricao = txtDescricao.Text;

            double valor;
            if (!double.TryParse(txtValor.Text, out valor))
            {
                MessageBox.Show("Informe um valor válido.");
                return;
            }
            servico.Valor = valor;
            servico.Ativo = chkAtivo.Checked;

            ServicoServices servicoServices = new ServicoServices();
            string mensagemErro;
            bool sucesso = servicoServices.CadastrarServico(servico, out mensagemErro);

            if (sucesso)
            {
                MessageBox.Show("Serviço cadastrado com sucesso!");
                CarregarServicos();
                LimparCampos();
            }
            else
            {
                // não limpa os campos: o usuário corrige e tenta de novo
                MessageBox.Show(mensagemErro);
            }
        }

        private void EditaServico()
        {
            Servico servico = new Servico();
            int id;
            if (!int.TryParse(txtCodigo.Text, out id))
            {
                MessageBox.Show("Informe um código válido.");
                return;
            }
            servico.Id = id;
            servico.Descricao = txtDescricao.Text;

            double valor;
            if (!double.TryParse(txtValor.Text, out valor))
            {
                MessageBox.Show("Informe um valor válido.");
                return;
            }
            servico.Valor = valor;
            servico.Ativo = chkAtivo.Checked;

            ServicoServices servicoServices = new ServicoServices();
            string mensagemErro;
            bool sucesso = servicoServices.EditarServico(servico, out mensagemErro);

            if (sucesso)
            {
                MessageBox.Show("Serviço editado com sucesso!");
                CarregarServicos();
                LimparCampos();
            }
            else
            {
                MessageBox.Show(mensagemErro);
            }
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            Formatador.Aplicar(txtValor, Formatador.FormatarValor);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarServicos();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimparCampos()
        {
            txtCodigo.Clear();
            txtDescricao.Clear();
            txtValor.Clear();
            chkAtivo.Checked = true;
            lblModo.Text = "Novo serviço";
            txtDescricao.Focus();
        }
    }
}