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
    public partial class FrmAlterarEstoque: Form
    {
        public FrmAlterarEstoque()
        {
            InitializeComponent();
        }
        public void CarregarProduto()
        {
            Estoque estoque = new Estoque();
            List<Produto> lista = estoque.ListarProdutos();
            dataGridView1.DataSource = lista;
        }
        private void FrmAlterarEstoque_Load(object sender, EventArgs e)
        {
            CarregarProduto();
        }
        public void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarProduto();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            Estoque estoque = new Estoque();
            dataGridView1.DataSource = estoque.BuscarProduto(txtPesquisa.Text);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtCodigo.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNome.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSaldo.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void btnAlterarSaldo_Click(object sender, EventArgs e)
        {
            int saldoAtual = int.Parse(txtSaldo.Text);
            int quantidade = int.Parse(txtAlteracao.Text);

            if (rdmEntrada.Checked)
            {
                // Entrada
                saldoAtual += quantidade;
            }
            else if (rdmSaida.Checked)
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

            Estoque estoque = new Estoque();
            estoque.AlterarEstoque(produto);

            txtSaldo.Text = saldoAtual.ToString();

            MessageBox.Show("Produto Alterado !");

            CarregarProduto();
        }
    }
}
