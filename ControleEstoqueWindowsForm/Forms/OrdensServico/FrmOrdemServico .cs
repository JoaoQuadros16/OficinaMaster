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
        private List<OrdemServicoItemServico> servicosDaOS = new List<OrdemServicoItemServico>();

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
        public void CarregaInformações()
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
            grpServicos.Enabled = false;

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

            //SERVIÇO
            ListaServicos();

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

            servicosDaOS = ordemServicoService.ListarServicosDaOS(_idOrdem, out mensagemErro);

            if (!string.IsNullOrEmpty(mensagemErro))
            {
                MessageBox.Show("Erro ao carregar serviços da OS: " + mensagemErro);
            }

            AtualizarGridServicos();
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
            CarregaInformações();
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

            OrdemServicoService ordemServicoService = new OrdemServicoService();
            string mensagemErro;

            if (_idOrdem == 0)
            {
                ordemServico.DataAbertura = DateTime.Now;
                ordemServico.Status = "ABERTA";

                int novoId = ordemServicoService.CadastrarOS(ordemServico, out mensagemErro);
                if (novoId == 0)
                {
                    MessageBox.Show("Falha ao salvar ordem de serviço: " + mensagemErro);
                    return;
                }

                _idOrdem = novoId;
                txtNumero.Text = novoId.ToString("D6");
                txtDataAbertura.Text = ordemServico.DataAbertura.ToString("dd/MM/yyyy HH:mm");
                cboCliente.Enabled = false;
                cboVeiculo.Enabled = false;

                ListaServicos();
                grpServicos.Enabled = true;

                MessageBox.Show("OS Nº " + novoId + " criada. Agora adicione os serviços.");
            }
            else
            {
                ordemServico.Id = _idOrdem;
                bool sucesso = ordemServicoService.AtualizarOS(ordemServico, servicosDaOS, out mensagemErro);

                if (sucesso)
                {
                    MessageBox.Show("Ordem de serviço salva com sucesso!");
                }
                else
                {
                    MessageBox.Show("Falha ao salvar ordem de serviço: " + mensagemErro);
                }
            }
        }

        // ---------------- Serviços ----------------
        private void ListaServicos()
        {
            ServicoServices servicoServices = new ServicoServices();
            string mensagemErro; 
            List<Servico> servicos = servicoServices.ListarServicos(out mensagemErro);

            if (!string.IsNullOrEmpty(mensagemErro))
            {
                MessageBox.Show("Erro ao carregar serviços: " + mensagemErro);
                return;
            }
            cboServico.DisplayMember = "Descricao";
            cboServico.ValueMember = "Id";
            cboServico.DataSource = servicos;
            cboServico.SelectedIndex = -1;
            
        }
        private void AtualizarGridServicos()
        {
            dgvServicos.DataSource = null;
            dgvServicos.DataSource = servicosDaOS;

            dgvServicos.Columns["Id"].Visible = false;
            dgvServicos.Columns["OrdemServicoId"].Visible = false;
            dgvServicos.Columns["ServicoId"].Visible = false;
            dgvServicos.Columns["Descricao"].HeaderText = "Serviço";
            dgvServicos.Columns["Valor"].DefaultCellStyle.Format = "N2";

            decimal subtotal = 0;
            foreach (OrdemServicoItemServico item in servicosDaOS)
            {
                subtotal = subtotal + item.Valor;
            }
            lblSubtotalServicos.Text = "Subtotal: R$ " + subtotal.ToString("N2");
        }
        private Servico ServicoSelecionado()
        {
            if (cboServico.SelectedItem == null)
            {
                return null;
            }
            return (Servico)cboServico.SelectedItem;
        }
        private void cboServico_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void cboServico_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboServico.SelectedItem == null)
            {
                txtValorServico.Clear();
                return;
            }

            Servico servico = (Servico)cboServico.SelectedItem;
            txtValorServico.Text = servico.Valor.ToString("N2");
        }

        private void btnAdicionarServico_Click(object sender, EventArgs e)
        {
            Servico servico  = ServicoSelecionado();
            if (servico == null)
            {
                MessageBox.Show("Selecione um serviço.");
                return;
            }
            decimal valor;
            if (!decimal.TryParse(txtValorServico.Text, out valor) || valor <= 0)
            {
                MessageBox.Show("Informe um valor válido, maior que zero.");
                txtValorServico.Focus();
                return;
            }

            OrdemServicoItemServico item = new OrdemServicoItemServico();
            item.OrdemServicoId = _idOrdem;
            item.ServicoId = servico.Id;
            item.Valor = valor;

            OrdemServicoService ordemServicoService = new OrdemServicoService();
            string mensagemErro;
            item.OrdemServicoId = _idOrdem;
            item.ServicoId = servico.Id;
            item.Descricao = servico.Descricao;
            item.Valor = valor;

            servicosDaOS.Add(item);
            AtualizarGridServicos();

            cboServico.SelectedIndex = -1;
            txtValorServico.Clear();

        }

        private void btnRemoverServico_Click(object sender, EventArgs e)
        {
            if (dgvServicos.CurrentRow == null)
            {
                MessageBox.Show("Selecione um serviço para remover.");
                return;
            }

            OrdemServicoItemServico item = (OrdemServicoItemServico)dgvServicos.CurrentRow.DataBoundItem;
            servicosDaOS.Remove(item);
            AtualizarGridServicos();
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
