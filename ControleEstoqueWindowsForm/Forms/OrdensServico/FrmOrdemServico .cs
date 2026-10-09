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
    public partial class FrmOrdemServico : Form
    {
        private int _idOrdem = 0;
        private int idCliente;
        private ClienteDAO clienteDAO = new ClienteDAO();
        private int? clienteIdPreSelecionado;
        private VeiculoService veiculoService = new VeiculoService();

        // Nova OS
        public FrmOrdemServico()
        {
            InitializeComponent();
        }

        // Abrir OS existente
        public FrmOrdemServico(int idOrdem, int _idCliente)
        {
            InitializeComponent();
            _idOrdem = idOrdem;
            idCliente = _idCliente;
            this.clienteIdPreSelecionado = clienteIdPreSelecionado;
            this.idCliente = idCliente;
        }

        private void CarregarVeiculos()
        {
            string mensagemErro;
            List<Veiculo> todos = veiculoService.ListarVeiculo(out mensagemErro);

            if (!string.IsNullOrEmpty(mensagemErro))
            {
                MessageBox.Show("Erro ao carregar veículos: " + mensagemErro);
                return;
            }

            List<Veiculo> doCliente = todos.Where(v => v.ClienteId == idCliente).ToList();

            dgv.DataSource = doCliente;

            if (dgvVeiculos.Columns["ClienteId"] != null)
                dgvVeiculos.Columns["ClienteId"].Visible = false;
            if (dgvVeiculos.Columns["NomeCliente"] != null)
                dgvVeiculos.Columns["NomeCliente"].Visible = false;
        }

        private void FrmOrdemServico_Load(object sender, EventArgs e)
        {
            ClienteService clienteService = new ClienteService();
            string mensagemErro;
            List<Cliente> clientes = clienteService.BuscarClienteVeiculos(out mensagemErro);

            if (!string.IsNullOrEmpty(mensagemErro))
            {
                MessageBox.Show("Erro ao carregar clientes: " + mensagemErro);
                return;
            }

            cboCliente.DisplayMember = "NomeExibicao";
            cboCliente.ValueMember = "Id";
            cboCliente.DataSource = clientes;
            cboCliente.SelectedIndex = -1;
        }

        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
        }

        // ---------------- Serviços ----------------

        private void cboServico_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnAdicionarServico_Click(object sender, EventArgs e)
        {
        }

        private void btnRemoverServico_Click(object sender, EventArgs e)
        {
        }

        // ---------------- Peças ----------------

        private void cboPeca_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnAdicionarPeca_Click(object sender, EventArgs e)
        {
        }

        private void btnRemoverPeca_Click(object sender, EventArgs e)
        {
        }

        // ---------------- Status ----------------

        private void btnIniciar_Click(object sender, EventArgs e)
        {
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
        }

        private void btnCancelarOS_Click(object sender, EventArgs e)
        {
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grpCabecalho_Enter(object sender, EventArgs e)
        {

        }
    }
}
