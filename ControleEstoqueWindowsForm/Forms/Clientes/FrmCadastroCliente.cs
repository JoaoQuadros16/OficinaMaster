using System;
using System.Windows.Forms;
using ControleEstoqueWindowsForm.Models;
using ControleEstoqueWindowsForm.Services;
using ControleEstoqueWindowsForm.Validacoes;

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
            string mensagemErro;
            int novoClienteId = clienteService.CadastrarCliente(cliente, out mensagemErro);

            if (!string.IsNullOrEmpty(mensagemErro))
            {
                MessageBox.Show("Erro ao cadastrar cliente: " + mensagemErro);
                return;
            }

            DialogResult resposta = MessageBox.Show(
                "Cliente cadastrado com sucesso! Deseja cadastrar um veículo agora?",
                "Cadastrar veículo",
                MessageBoxButtons.YesNo);

            if (resposta == DialogResult.Yes)
            {
                FrmCadastrarVeiculo frmVeiculo = new FrmCadastrarVeiculo(novoClienteId);
                frmVeiculo.ShowDialog();
            }

            // deixa a tela pronta para o próximo cadastro
            LimparCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtCpf.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            txtNome.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
           FrmCliente frmCliente = new FrmCliente();
           frmCliente.Show();
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            Formatador.Aplicar(txtNome, Formatador.FormatarNome);
        }

        private void txtCpf_Leave(object sender, EventArgs e)
        {
            Formatador.Aplicar(txtCpf, Formatador.FormatarCpf);
        }

        private void txtTelefone_Leave(object sender, EventArgs e)
        {
            Formatador.Aplicar(txtTelefone, Formatador.FormatarTelefone);
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            Formatador.Aplicar(txtEmail, Formatador.FormatarEmail);
        }
    }
}
