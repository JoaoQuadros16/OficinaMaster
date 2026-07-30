using ControleEstoqueWindowsForm.Models;
using ControleEstoqueWindowsForm.Services;
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
    public partial class FrmVeiculo: Form
    {
        private VeiculoService veiculoService = new VeiculoService();
        public FrmVeiculo()
        {
            InitializeComponent();
        }
        public void CarregarVeiculos()
        {
            string mensagemErro; 
            VeiculoService veiculoService = new VeiculoService();
            List<Veiculo> listaVeiculos = veiculoService.ListarVeiculo(out mensagemErro);

            dgvVeiculos.DataSource = listaVeiculos;
            dgvVeiculos.Columns["ClienteId"].Visible = false;
        }
        private void FrmVeiculo_Load(object sender, EventArgs e)
        {
            CarregarVeiculos();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmCadastrarVeiculo tela = new FrmCadastrarVeiculo();
            tela.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvVeiculos.CurrentRow == null)
            {
                MessageBox.Show("Selecione um cliente para editar.");
                return;
            }

            int idVeiculo = Convert.ToInt32(dgvVeiculos.CurrentRow.Cells["Id"].Value);

            FrmEditarVeiculos tela = new FrmEditarVeiculos(idVeiculo);
            tela.ShowDialog();
            CarregarVeiculos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            CarregarVeiculos();
        }

        private void dgvVeiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string mensagemErro;
            dgvVeiculos.DataSource = veiculoService.PesquisarNomeCliente(textBox1.Text, out mensagemErro);

            if (!string.IsNullOrEmpty(mensagemErro))
            {
                MessageBox.Show("Erro ao pesquisar: " + mensagemErro);
            }
        }
    }
}
