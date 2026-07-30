using ControleEstoqueWindowsForm.DAO;
using ControleEstoqueWindowsForm.Models;
using ControleEstoqueWindowsForm.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ControleEstoqueWindowsForm
{
    public partial class FrmCadastrarVeiculo : Form
    {
        private int? clienteIdPreSelecionado;
        private ClienteDAO clienteDAO = new ClienteDAO();
        private VeiculoService veiculoService = new VeiculoService();

        public FrmCadastrarVeiculo()
        {
            InitializeComponent();
        }

        public FrmCadastrarVeiculo(int clienteIdPreSelecionado) : this()
        {
            this.clienteIdPreSelecionado = clienteIdPreSelecionado;
        }

        private void FrmCadastrarVeiculo_Load(object sender, EventArgs e)
        {
            string mensagemErro;
            try
            {
                List<Cliente> clientes = clienteDAO.BuscarClienteVeiculos(out mensagemErro);

                cboCliente.DataSource = clientes;
                cboCliente.DisplayMember = "NomeExibicao";
                cboCliente.ValueMember = "Id";

                if (clienteIdPreSelecionado.HasValue)
                {
                    cboCliente.SelectedValue = clienteIdPreSelecionado.Value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar clientes: " + ex.Message);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (cboCliente.SelectedValue == null)
            {
                MessageBox.Show("Cadastre um cliente antes de cadastrar um veículo.");
                return;
            }

            Veiculo veiculo = new Veiculo();
            veiculo.ClienteId = (int)cboCliente.SelectedValue;
            veiculo.Modelo = txtModelo.Text;
            veiculo.Placa = txtPlaca.Text;
            veiculo.Cor = txtCor.Text;
            veiculo.Marca = txtMarca.Text;

            int ano;
            bool anoValido = int.TryParse(txtAno.Text, out ano);

            if (!anoValido)
            {
                MessageBox.Show("Informe um ano válido.");
                return;
            }

            veiculo.Ano = ano;

            string mensagemErro;
            bool sucesso = veiculoService.CadastrarVeiculo(veiculo, out mensagemErro);

            if (sucesso)
            {
                MessageBox.Show("Veículo cadastrado com sucesso!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(mensagemErro);
            }
        }

        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}