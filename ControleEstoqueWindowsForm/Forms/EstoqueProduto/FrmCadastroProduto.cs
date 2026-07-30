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
    public partial class FrmCadastroProduto: Form
    {
        public FrmCadastroProduto()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();

            produto.Nome = txtNome.Text;
            produto.Quantidade = int.Parse(txtQuantidade.Text);

            Estoque estoque = new Estoque();

            estoque.CadastrarProduto(produto);

            MessageBox.Show("Produto Cadastrado com sucesso !\n");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Cadastro Cancelado !\n");
            txtNome.Clear();
            txtQuantidade.Clear();

            txtNome.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCadastroProduto_Load(object sender, EventArgs e)
        {

        }
    }
}
