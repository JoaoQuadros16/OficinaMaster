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
    public partial class FrmDeletarProduto: Form
    {
        public FrmDeletarProduto()
        {
            InitializeComponent();
        }

        private readonly Estoque estoque = new Estoque();

        private void CarregarProduto()
        {
            dataGridView1.DataSource = estoque.ListarProdutos();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = estoque.BuscarProduto(txtPesquisa.Text);
        }
        private void FrmDeletarProduto_Load(object sender, EventArgs e)
        {
            CarregarProduto();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarProduto();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
            string nome = dataGridView1.CurrentRow.Cells["Nome"].Value.ToString();
            int quantidade = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Quantidade"].Value);

            DialogResult resposta = MessageBox.Show(
            $"Deseja excluir o produto?\n\n" +
            $"Código: {id} \n" +
            $"Nome: {nome} \n"+
            $"Quantidade: {quantidade}",
            "Confirmar exclusão",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                if(quantidade > 0)
                {
                    MessageBox.Show("Produto possuí saldo no estoque !");
                    return;
                }
                else 
                {
                    // Excluir o produto
                    estoque.DeletarProduto(id);
                    CarregarProduto();

                    MessageBox.Show("Produto excluído com sucesso!");
                }
            }
            else
                return;
        }
    }
}
