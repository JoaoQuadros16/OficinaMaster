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
        private List<Veiculo> todosVeiculos = new List<Veiculo>();

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

        private int? ObterClienteSelcionado()
        {
            if (cboCliente.Items == null)
            {
                MessageBox.Show("Selecione um veículo.");
                return null;
            }

            Cliente cliente = (Cliente)cboCliente.SelectedItem;
            return cliente.Id;
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

            VeiculoService veiculoService = new VeiculoService();
            todosVeiculos = veiculoService.ListarVeiculo(out mensagemErro);

            if (!string.IsNullOrEmpty(mensagemErro))
            {
                MessageBox.Show("Erro ao carregar veículos: " + mensagemErro);
                return;
            }

            cboVeiculo.DisplayMember = "Modelo";
            cboVeiculo.ValueMember = "Id";
            cboVeiculo.DataSource = null;
            cboVeiculo.Enabled = false; // só libera depois de escolher o cliente

            cboCliente.DisplayMember = "NomeExibicao";
            cboCliente.ValueMember = "Id";
            cboCliente.DataSource = clientes;
            cboCliente.SelectedIndex = -1;
        }
        private void cboCliente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int? clienteId = ObterClienteSelcionado();

            if (clienteId == null)
            {
                cboVeiculo.DataSource = null;
                cboVeiculo.Enabled = false;
                return;
            }

            List<Veiculo> veiculosDoCliente = todosVeiculos
                .Where(v => v.ClienteId == clienteId.Value)
                .ToList();

            cboVeiculo.DataSource = veiculosDoCliente;
            cboVeiculo.SelectedIndex = -1;
            cboVeiculo.Enabled = true;
        }

        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            OrdemServico ordemServico = new OrdemServico();
            ordemServico.ClienteId = ObterClienteSelcionado() ?? 0;
            ordemServico.VeiculoId = cboVeiculo.SelectedValue != null ? (int)cboVeiculo.SelectedValue : 0;
            ordemServico.DescricaoProblema = txtProblema.Text;
            ordemServico.DataAbertura = DateTime.Now;
            ordemServico.Status = "ABERTA";

            string mensagemErro;

            OrdemServicoService ordemServicoService = new OrdemServicoService();
            bool sucesso = ordemServicoService.CadastrarOS(ordemServico, out mensagemErro);

            if (!string.IsNullOrEmpty(mensagemErro))
            {
                MessageBox.Show("Erro ao cadastrar OS: " + mensagemErro);
                return;
            }

            if (sucesso)
            {
                MessageBox.Show("Ordem de serviço cadastrada com sucesso!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Falha ao cadastrar ordem de serviço.");
            }
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
