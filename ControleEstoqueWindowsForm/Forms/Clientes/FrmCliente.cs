using System;
using System.Windows.Forms;
using ControleEstoqueWindowsForm.Models;
using ControleEstoqueWindowsForm.Services;
using ControleEstoqueWindowsForm.Forms;
using System.Collections.Generic;


namespace ControleEstoqueWindowsForm
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }
        public void CarregarClientes()
        {
            ClienteService clienteService = new ClienteService();
            List<Cliente> listaClientes = clienteService.ListarClientes();

            dataGridView1.DataSource = listaClientes;
            dataGridView1.Columns["NomeExibicao"].Visible = false;
        }
        private void FrmClientes_Load(object sender, EventArgs e)
        {
            // TODO: carregar a lista de clientes no dataGridView1
            CarregarClientes();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            // TODO: filtrar a lista de clientes conforme o texto digitado
            ClienteService clienteService = new ClienteService();
            dataGridView1.DataSource = clienteService.PesquisarCliente(txtPesquisa.Text);
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            // TODO: abrir o FrmCadastroCliente
            FrmCadastroCliente tela = new FrmCadastroCliente();
            tela.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // TODO: abrir tela de edição para o cliente selecionado no dataGridView1
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecione um cliente para editar.");
                return;
            }

            int idCliente = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

            FrmEditarCliente tela = new FrmEditarCliente(idCliente);
            tela.ShowDialog();
            CarregarClientes();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // TODO: confirmar e excluir o cliente selecionado no dataGridView1

            int idCliente = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
            FrmExcluirCliente tela = new FrmExcluirCliente(idCliente);
            tela.ShowDialog();

            CarregarClientes();

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            // TODO: recarregar a lista de clientes
            CarregarClientes();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            // TODO: fechar esta tela / voltar ao menu anterior
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // TODO: atalho para editar o cliente ao dar duplo clique na linha 
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecione um cliente para editar.");
                return;
            }

            int idCliente = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
            FrmEditarCliente tela = new FrmEditarCliente(idCliente);
            tela.ShowDialog();

            CarregarClientes();
        }
    }
}
