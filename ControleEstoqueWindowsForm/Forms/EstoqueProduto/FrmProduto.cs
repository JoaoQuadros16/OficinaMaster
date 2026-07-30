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
    public partial class FrmProduto: Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCadastroProduto tela = new FrmCadastroProduto();
            tela.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmListarProdutos tela = new FrmListarProdutos();
            tela.ShowDialog();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            FrmAlterarEstoque tela = new FrmAlterarEstoque();
            tela.ShowDialog();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            FrmEditarProduto tela = new FrmEditarProduto();
            tela.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmDeletarProduto tela = new FrmDeletarProduto();
            tela.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
