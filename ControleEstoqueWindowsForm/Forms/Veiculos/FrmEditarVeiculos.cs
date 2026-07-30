using ControleEstoqueWindowsForm.DAO;
using ControleEstoqueWindowsForm.Models;
using ControleEstoqueWindowsForm.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ControleEstoqueWindowsForm
{
    public partial class FrmEditarVeiculos : Form
    {
        private int idVeiculo;
        private Veiculo veiculoAtual;
        private ClienteDAO clienteDAO = new ClienteDAO();
        private VeiculoService veiculoService = new VeiculoService();

        public FrmEditarVeiculos()
        {
            InitializeComponent();
        }

        public FrmEditarVeiculos(int _idVeiculo)
        {
            InitializeComponent();
            idVeiculo = _idVeiculo;
        }

        private void FrmEditarVeiculos_Load(object sender, EventArgs e)
        {
            string mensagemErro;
            try
            {
                veiculoAtual = veiculoService.BuscarVeiculoID(idVeiculo, out mensagemErro);

                MessageBox.Show("ClienteId do veículo: " + veiculoAtual.ClienteId);

                if (veiculoAtual == null)
                {
                    MessageBox.Show("Veículo não encontrado. Erro: " + mensagemErro + " | ID buscado: " + idVeiculo);
                    this.Close();
                    return;
                }

                txtMarca.Text = veiculoAtual.Marca;
                txtModelo.Text = veiculoAtual.Modelo;
                txtPlaca.Text = veiculoAtual.Placa;
                txtAno.Text = veiculoAtual.Ano.ToString();
                txtCor.Text = veiculoAtual.Cor;

                Cliente cliente = clienteDAO.BuscarClienteID(veiculoAtual.ClienteId);
                cboCliente.Items.Clear();
                if (cliente != null)
                {
                    cboCliente.Items.Add(cliente.Nome);
                    cboCliente.SelectedIndex = 0;
                }
                else
                {
                    cboCliente.Items.Add("Cliente não encontrado");
                    cboCliente.SelectedIndex = 0;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar veículo: " + ex.Message);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            veiculoAtual.Modelo = txtModelo.Text;
            veiculoAtual.Marca = txtMarca.Text;
            veiculoAtual.Placa = txtPlaca.Text;

            int ano;
            bool anoValido = int.TryParse(txtAno.Text, out ano);
            if (!anoValido)
            {
                MessageBox.Show("Informe um ano válido.");
                return;
            }
            veiculoAtual.Ano = ano;
            veiculoAtual.Cor = txtCor.Text;

            string mensagemErro;
            bool sucesso = veiculoService.EditarVeiculo(veiculoAtual, out mensagemErro);

            if (sucesso)
            {
                MessageBox.Show("Veículo alterado com sucesso!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(mensagemErro);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void grpDados_Enter(object sender, EventArgs e)
        {

        }
    }
}