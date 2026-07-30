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

            Cliente cliente =  clienteService.BuscarIDCliente(_idCliente);


            if (cliente == null)
            {
                MessageBox.Show("Cliente não encontrado.");
                this.Close();
                return;
            }

            txtNome.Text = cliente.Nome;
            txtCpf.Text = cliente.Cpf;
            txtTelefone.Text = cliente.Telefone;
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
            clienteService.AlterarCliente(cliente);

            MessageBox.Show("Produto Alterado !");
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
    }
}
