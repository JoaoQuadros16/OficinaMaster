using System;
using System.Windows.Forms;
using ControleEstoqueWindowsForm.Models;
using ControleEstoqueWindowsForm.Services;

namespace ControleEstoqueWindowsForm.Forms
{
    public partial class FrmCadastroCliente : Form
    {
        public FrmCadastroCliente()
        {
            InitializeComponent();
        }
        private void FrmCadastroCliente_Load(object sender, EventArgs e)
        {
            // TODO: inicializações, se necessário
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = txtNome.Text;
            cliente.Cpf = txtCpf.Text;
            cliente.Telefone = txtTelefone.Text;
            cliente.Email = txtEmail.Text;

            ClienteService clienteService = new ClienteService();
            int novoClienteId = clienteService.CadastrarCliente(cliente);

            DialogResult resposta = MessageBox.Show(
                "Cliente cadastrado com sucesso! Deseja cadastrar um veículo agora?",
                "Cadastrar veículo",
                MessageBoxButtons.YesNo);

            if (resposta == DialogResult.Yes)
            {
                FrmCadastrarVeiculo frmVeiculo = new FrmCadastrarVeiculo(novoClienteId);
                frmVeiculo.ShowDialog();
            }

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // TODO: limpar os campos do formulário
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            // TODO: fechar esta tela / voltar ao menu anterior
            this.Close();
        }
    }
}
