using ControleEstoqueWindowsForm.DAO;
using ControleEstoqueWindowsForm.Models;
using ControleEstoqueWindowsForm.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleEstoqueWindowsForm.Validacoes;

namespace ControleEstoqueWindowsForm
{
    public partial class FrmEditarCliente: Form
    {
        private int _idCliente;
        public FrmEditarCliente(int idCliente)
        {
            InitializeComponent();
            _idCliente = idCliente;
        }
        private void FrmEditarCliente_Load(object sender, EventArgs e)
        {
            ClienteService clienteService = new ClienteService();

            string mensagemErro;
            Cliente cliente =  clienteService.BuscarIDCliente(_idCliente, out mensagemErro);


            if (cliente == null)
            {
                if (!string.IsNullOrEmpty(mensagemErro))
                {
                    MessageBox.Show("Erro ao carregar cliente: " + mensagemErro);
                }
                else
                {
                    MessageBox.Show("Cliente não encontrado.");
                }
                this.Close();
                return;
            }

            txtNome.Text = cliente.Nome;
            txtCpf.Text = Formatador.FormatarCpf(cliente.Cpf);
            txtTelefone.Text = Formatador.FormatarTelefone(cliente.Telefone);
            txtEmail.Text = cliente.Email;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            cliente.Id = _idCliente;
            cliente.Nome = txtNome.Text;
            cliente.Cpf = txtCpf.Text;
            cliente.Email = txtEmail.Text;
            cliente.Telefone = txtTelefone.Text;

            ClienteService clienteService = new ClienteService();
            string mensagemErro;
            bool sucesso = clienteService.AlterarCliente(cliente, out mensagemErro);

            if (sucesso)
            {
                MessageBox.Show("Cliente alterado com sucesso!");
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

        private void btnGerenciarVeiculos_Click(object sender, EventArgs e)
        {
            FrmVeiculosCliente tela = new FrmVeiculosCliente(_idCliente);
            tela.ShowDialog();
        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
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
