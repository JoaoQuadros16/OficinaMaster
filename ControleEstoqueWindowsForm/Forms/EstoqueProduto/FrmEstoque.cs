using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleEstoqueWindowsForm.Models;
using ControleEstoqueWindowsForm.Validacoes;

namespace ControleEstoqueWindowsForm
{
    public partial class FrmEstoque : Form
    {
        private Estoque estoque = new Estoque();

        public FrmEstoque()
        {
            InitializeComponent();
        }

        private void CarregarProdutos()
        {
            string mensagemErro;
            List<Produto> produtos = estoque.BuscarProduto(txtPesquisa.Text, out mensagemErro);

            if (!string.IsNullOrEmpty(mensagemErro))
            {
                MessageBox.Show("Erro ao carregar produtos: " + mensagemErro);
            }

            dgvProdutos.DataSource = produtos;
            AjustarGrade();
        }

        private void AjustarGrade()
        {
            dgvProdutos.Columns["Id"].HeaderText = "Código";
            dgvProdutos.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvProdutos.Columns["Id"].Width = 80;

            dgvProdutos.Columns["Nome"].HeaderText = "Produto";

            dgvProdutos.Columns["Quantidade"].HeaderText = "Saldo";
            dgvProdutos.Columns["Quantidade"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvProdutos.Columns["Quantidade"].Width = 100;
            dgvProdutos.Columns["Quantidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // saldo zerado em vermelho: precisa repor
            foreach (DataGridViewRow linha in dgvProdutos.Rows)
            {
                int saldo = Convert.ToInt32(linha.Cells["Quantidade"].Value);
                if (saldo == 0)
                {
                    linha.DefaultCellStyle.ForeColor = Color.Firebrick;
                }
            }
        }

        private void FrmEstoque_Load(object sender, EventArgs e)
        {
            if (Sessao.UsuarioLogado.Nivel_acesso != "Administrador")
            {
                grpDados.Enabled = false;
                grpMovimentacao.Visible = false;
                btnExcluir.Visible = false;
            }
            CarregarProdutos();
            ModoNovo();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            CarregarProdutos();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarProdutos();
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow linha = dgvProdutos.Rows[e.RowIndex];

                txtCodigo.Text = linha.Cells["Id"].Value.ToString();
                txtNome.Text = linha.Cells["Nome"].Value.ToString();
                txtSaldo.Text = linha.Cells["Quantidade"].Value.ToString();
                txtValor.Text = linha.Cells["Valor"].Value.ToString();

                ModoEdicao();
            }
        }
        private void ModoNovo()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtSaldo.Clear();
            txtQuantidade.Clear();
            rdbEntrada.Checked = false;
            rdbSaida.Checked = false;

            lblModo.Text = "Novo produto";
            lblSaldo.Text = "Quantidade inicial:";
            txtSaldo.ReadOnly = false;
            txtSaldo.BackColor = Color.White;
            grpMovimentacao.Enabled = false;

            txtNome.Focus();
        }
        private void ModoEdicao()
        {
            txtQuantidade.Clear();
            rdbEntrada.Checked = false;
            rdbSaida.Checked = false;

            lblModo.Text = "Editando produto";
            lblSaldo.Text = "Saldo atual:";
            txtSaldo.ReadOnly = true;
            txtSaldo.BackColor = Color.WhiteSmoke;
            grpMovimentacao.Enabled = true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ModoNovo();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                CadastraProduto();
            }
            else
            {
                EditaProduto();
            }
        }

        private void CadastraProduto()
        {
            Produto produto = new Produto();
            produto.Nome = txtNome.Text.Trim();

            // quantidade inicial vazia = 0
            int quantidade = 0;
            if (!string.IsNullOrWhiteSpace(txtSaldo.Text))
            {
                if (!int.TryParse(txtSaldo.Text, out quantidade))
                {
                    MessageBox.Show("Informe uma quantidade válida.");
                    return;
                }
            }
            produto.Quantidade = quantidade;
            produto.Valor = decimal.Parse(txtValor.Text);

            string mensagemErro;
            bool sucesso = estoque.CadastrarProduto(produto, out mensagemErro);

            if (sucesso)
            {
                MessageBox.Show("Produto cadastrado com sucesso!");
                CarregarProdutos();
                ModoNovo();
            }
            else
            {
                MessageBox.Show(mensagemErro);
            }
        }

        private void EditaProduto()
        {
            Produto produto = new Produto();
            produto.Id = int.Parse(txtCodigo.Text);   // preenchido pelo sistema, sempre numérico
            produto.Nome = txtNome.Text.Trim();
            produto.Valor = decimal.Parse(txtValor.Text);

            string mensagemErro;
            bool sucesso = estoque.AlterarProduto(produto, out mensagemErro);

            if (sucesso)
            {
                MessageBox.Show("Produto alterado com sucesso!");
                CarregarProdutos();
                ModoNovo();
            }
            else
            {
                MessageBox.Show(mensagemErro);
            }
        }

        private void btnLancar_Click(object sender, EventArgs e)
        {
            int saldoAtual = int.Parse(txtSaldo.Text);

            int quantidade;
            if (!int.TryParse(txtQuantidade.Text, out quantidade) || quantidade <= 0)
            {
                MessageBox.Show("Informe uma quantidade válida.");
                return;
            }

            if (rdbEntrada.Checked)
            {
                saldoAtual += quantidade;
            }
            else if (rdbSaida.Checked)
            {
                saldoAtual -= quantidade;
            }
            else
            {
                MessageBox.Show("Selecione Entrada ou Saída.");
                return;
            }

            Produto produto = new Produto();
            produto.Id = int.Parse(txtCodigo.Text);
            produto.Quantidade = saldoAtual;

            string mensagemErro;
            bool sucesso = estoque.AlterarEstoque(produto, out mensagemErro);

            if (sucesso)
            {
                MessageBox.Show("Estoque atualizado!");
                txtSaldo.Text = saldoAtual.ToString();
                CarregarProdutos();
                ModoEdicao();   // continua no mesmo produto para lançar outra movimentação
            }
            else
            {
                MessageBox.Show(mensagemErro);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Selecione um produto na lista.");
                return;
            }

            int id = int.Parse(txtCodigo.Text);
            int saldo = int.Parse(txtSaldo.Text);

            if (saldo > 0)
            {
                MessageBox.Show("Produto possui saldo no estoque! Zere o saldo antes de excluir.");
                return;
            }

            DialogResult resposta = MessageBox.Show(
                "Deseja excluir o produto?\n\n" +
                "Código: " + id + "\n" +
                "Nome: " + txtNome.Text,
                "Confirmar exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                string mensagemErro;
                bool sucesso = estoque.DeletarProduto(id, out mensagemErro);

                if (sucesso)
                {
                    MessageBox.Show("Produto excluído com sucesso!");
                    CarregarProdutos();
                    ModoNovo();
                }
                else
                {
                    MessageBox.Show(mensagemErro);
                }
            }
        }

        // ============================================================
        // Formatação
        // ============================================================

        private void txtSaldo_Leave(object sender, EventArgs e)
        {
            if (!txtSaldo.ReadOnly)
            {
                Formatador.Aplicar(txtSaldo, Formatador.FormatarQuantidade);
            }
        }

        private void txtQuantidade_Leave(object sender, EventArgs e)
        {
            Formatador.Aplicar(txtQuantidade, Formatador.FormatarQuantidade);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
