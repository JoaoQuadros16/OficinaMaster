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
        private int _idOrdem;
        private int idCliente;
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
        }

        private void CarregarVeiculosDoCliente(int clienteId)
        {
            List<Veiculo> veiculosDoCliente = todosVeiculos
                .Where(v => v.ClienteId == clienteId)
                .ToList();

            cboVeiculo.DataSource = veiculosDoCliente;
            cboVeiculo.SelectedIndex = -1;
            cboVeiculo.Enabled = true;
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

            // OS nova: não tem o que preencher
            if (_idOrdem == 0)
            {
                return;
            }

            OrdemServicoService ordemServicoService = new OrdemServicoService();
            OrdemServico ordem = ordemServicoService.ObterObterPorId(_idOrdem, out mensagemErro);

            if (ordem == null)
            {
                MessageBox.Show("Ordem de serviço não encontrada. " + mensagemErro);
                Close();
                return;
            }

            cboCliente.SelectedValue = ordem.ClienteId;
            CarregarVeiculosDoCliente(ordem.ClienteId);
            cboVeiculo.SelectedValue = ordem.VeiculoId;
            txtProblema.Text = ordem.DescricaoProblema;
            txtNumero.Text = ordem.Id.ToString("D6");

            Text = "Ordem de Serviço Nº " + ordem.Id + " - " + ordem.Status;

            cboCliente.SelectedValue = ordem.ClienteId;
            CarregarVeiculosDoCliente(ordem.ClienteId);
            cboVeiculo.SelectedValue = ordem.VeiculoId;
            txtProblema.Text = ordem.DescricaoProblema;

            cboCliente.Enabled = false;
            cboVeiculo.Enabled = false;


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

            CarregarVeiculosDoCliente(clienteId.Value);

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
            int? clienteId = ObterClienteSelcionado();
            if (clienteId == null)
            {
                MessageBox.Show("Selecione um cliente.");
                return;
            }

            if (cboVeiculo.SelectedValue == null)
            {
                MessageBox.Show("Selecione um veículo.");
                return;
            }

            OrdemServico ordemServico = new OrdemServico();
            ordemServico.ClienteId = clienteId.Value;
            ordemServico.VeiculoId = (int)cboVeiculo.SelectedValue;
            ordemServico.DescricaoProblema = txtProblema.Text;
            txtNumero.Text = ordemServico.Id.ToString("D6");

            OrdemServicoService ordemServicoService = new OrdemServicoService();
            string mensagemErro;
            bool sucesso;

            if (_idOrdem == 0)
            {
                ordemServico.DataAbertura = DateTime.Now;
                ordemServico.Status = "ABERTA";
                sucesso = ordemServicoService.CadastrarOS(ordemServico, out mensagemErro);
            }
            else
            {
                ordemServico.Id = _idOrdem;
                sucesso = ordemServicoService.AtualizarOS(ordemServico, out mensagemErro);
            }

            if (!string.IsNullOrEmpty(mensagemErro))
            {
                MessageBox.Show("Erro ao salvar OS: " + mensagemErro);
                return;
            }

            if (sucesso)
            {
                MessageBox.Show("Ordem de serviço salva com sucesso!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Falha ao salvar ordem de serviço.");
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
