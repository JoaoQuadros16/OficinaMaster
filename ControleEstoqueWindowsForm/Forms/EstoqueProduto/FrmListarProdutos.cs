using System;
using System.Collections;
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
    public partial class FrmListarProdutos: Form
    {
        public FrmListarProdutos()
        {
            InitializeComponent();
        }

        public void CarregarProduto()
        {
            Estoque estoque = new Estoque();
            List<Produto> lista = estoque.ListarProdutos();
            dataGridView1.DataSource = lista;
        }
        private void FrmListarProdutos_Load(object sender, EventArgs e)
        {
            CarregarProduto();
        }
        public void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarProduto();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void textPesquisa_TextChanged(object sender, EventArgs e)
        {
            Estoque estoque = new Estoque();
            dataGridView1.DataSource = estoque.BuscarProduto(textPesquisa.Text);
        }
    }
}
