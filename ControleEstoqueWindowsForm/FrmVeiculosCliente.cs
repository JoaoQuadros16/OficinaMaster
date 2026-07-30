using ControleEstoqueWindowsForm.Models;
using ControleEstoqueWindowsForm.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ControleEstoqueWindowsForm
{
    public partial class FrmVeiculosCliente : Form
    {
        private int idCliente;
        private VeiculoService veiculoService = new VeiculoService();

        public FrmVeiculosCliente(int _idCliente)
        {
            InitializeComponent();
            idCliente = _idCliente;
        }

        private void FrmVeiculosCliente_Load(object sender, EventArgs e)
        {
            CarregarVeiculos();
        }

        private void CarregarVeiculos()
        {
            string mensagemErro;
            List<Veiculo> todos = veiculoService.ListarVeiculo(out mensagemErro);

            string debug = "idCliente buscado: " + idCliente + "\n\n";
            foreach (var v in todos)
            {
                debug += "Veiculo Id " + v.Id + " -> ClienteId: " + v.ClienteId + "\n";
            }
            MessageBox.Show(debug); // DEBUG

            if (!string.IsNullOrEmpty(mensagemErro))
            {
                MessageBox.Show("Erro ao carregar veículos: " + mensagemErro);
                return;
            }

            List<Veiculo> doCliente = todos.Where(v => v.ClienteId == idCliente).ToList();

            dgvVeiculos.DataSource = doCliente;

            if (dgvVeiculos.Columns["ClienteId"] != null)
                dgvVeiculos.Columns["ClienteId"].Visible = false;
            if (dgvVeiculos.Columns["NomeCliente"] != null)
                dgvVeiculos.Columns["NomeCliente"].Visible = false;
        }

        private int? ObterIdVeiculoSelecionado()
        {
            if (dgvVeiculos.CurrentRow == null)
            {
                MessageBox.Show("Selecione um veículo.");
                return null;
            }

            Veiculo veiculo = (Veiculo)dgvVeiculos.CurrentRow.DataBoundItem;
            return veiculo.Id;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            // depois: abrir tela de cadastro de novo veículo, passando idCliente
            // FrmCadastroVeiculo tela = new FrmCadastroVeiculo(idCliente);
            // if (tela.ShowDialog() == DialogResult.OK) CarregarVeiculos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int? idVeiculo = ObterIdVeiculoSelecionado();
            if (idVeiculo == null) return;

            FrmEditarVeiculos tela = new FrmEditarVeiculos(idVeiculo.Value);
            if (tela.ShowDialog() == DialogResult.OK)
            {
                CarregarVeiculos();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int? idVeiculo = ObterIdVeiculoSelecionado();
            if (idVeiculo == null) return;

            DialogResult confirmacao = MessageBox.Show("Deseja realmente excluir este veículo?", "Confirmar", MessageBoxButtons.YesNo);
            if (confirmacao != DialogResult.Yes) return;

            // depois: veiculoService.ExcluirVeiculo(idVeiculo.Value, out mensagemErro);
            // CarregarVeiculos();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}