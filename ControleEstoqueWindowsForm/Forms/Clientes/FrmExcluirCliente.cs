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
            Cliente cliente = clienteService.BuscarIDCliente(_idCliente);

            if (cliente == null)
            {
                MessageBox.Show("Cliente não encontrado.");
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
            clienteService.DeletarCliente(_idCliente);

            MessageBox.Show("Cliente excluído com sucesso!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
