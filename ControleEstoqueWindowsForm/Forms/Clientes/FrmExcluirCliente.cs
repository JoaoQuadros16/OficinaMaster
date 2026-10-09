using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleEstoqueWindowsForm.Models;
using ControleEstoqueWindowsForm.Services;

namespace ControleEstoqueWindowsForm
{
    public partial class FrmExcluirCliente : Form
    {
        private int _idCliente;

        public FrmExcluirCliente(int idCliente)
        {
            InitializeComponent();
            _idCliente = idCliente;
        }

        private void FrmExcluirCliente_Load(object sender, EventArgs e)
        {
            ClienteService clienteService = new ClienteService();
            string mensagemErro;
            Cliente cliente = clienteService.BuscarIDCliente(_idCliente, out mensagemErro);

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

            lblNomeValor.Text = cliente.Nome;
            lblCpfValor.Text = cliente.Cpf;
            lblTelefoneValor.Text = cliente.Telefone;
            lblEmailValor.Text = cliente.Email;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            ClienteService clienteService = new ClienteService();
            string mensagemErro;
            bool sucesso = clienteService.DeletarCliente(_idCliente, out mensagemErro);

            if (sucesso)
            {
                MessageBox.Show("Cliente excluído com sucesso!");
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
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
