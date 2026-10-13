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
        private List<Veiculo> todosVeiculos = new List<Veiculo>();
        private List<OrdemServicoItemServico> servicosDaOS = new List<OrdemServicoItemServico>();
        private List<OrdemServicoPecas> pecasDaOS = new List<OrdemServicoPecas>();

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

            cboCliente.DisplayMember = "NomeExibicao";
            cboCliente.ValueMember = "Id";
            cboCliente.DataSource = clientes;
            cboCliente.SelectedIndex = -1;

            // OS nova: serviços e peças só depois de salvar
            if (_idOrdem == 0)
            {
                AplicarStatus("NOVA");
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

            // SERVIÇOS
            ListaServicos();
            grpServicos.Enabled = true;

            // PEÇAS
            ListaPecas();
            grpPecas.Enabled = true;

            cboCliente.SelectedValue = ordem.ClienteId;
            CarregarVeiculosDoCliente(ordem.ClienteId);
            cboVeiculo.SelectedValue = ordem.VeiculoId;
            txtProblema.Text = ordem.DescricaoProblema;
            txtNumero.Text = ordem.Id.ToString("D6");
            txtDataAbertura.Text = ordem.DataAbertura.ToString("dd/MM/yyyy HH:mm");

            Text = "Ordem de Serviço Nº " + ordem.Id + " - " + ordem.Status;

            cboCliente.Enabled = false;
            cboVeiculo.Enabled = false;

            servicosDaOS = ordemServicoService.ListarServicosDaOS(_idOrdem, out mensagemErro);

            if (!string.IsNullOrEmpty(mensagemErro))
            {
                MessageBox.Show("Erro ao carregar serviços da OS: " + mensagemErro);
            }

            AtualizarGridServicos();

            pecasDaOS = ordemServicoService.ListarPecasOS(_idOrdem, out mensagemErro);

            if (!string.IsNullOrEmpty(mensagemErro))
            {
                MessageBox.Show("Erro ao carregar peças da OS: " + mensagemErro);
            }

            AtualizarGridPecas();

            AplicarStatus(ordem.Status);
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
            if (cboCliente.SelectedItem == null)
            {
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

                ListaPecas();
                grpPecas.Enabled = true;

                AplicarStatus("ABERTA");

                MessageBox.Show("OS Nº " + novoId + " criada. Agora adicione os serviços e as peças.");
            }
            else
            {
                ordemServico.Id = _idOrdem;

                bool sucesso = ordemServicoService.AtualizarOS(ordemServico, servicosDaOS, pecasDaOS, out mensagemErro);

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
            AtualizarTotal();
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
            Servico servico = ServicoSelecionado();
            if (servico == null)
            {
                txtValorServico.Clear();
                return;
            }

            txtValorServico.Text = servico.Valor.ToString("N2");
        }

        private void btnAdicionarServico_Click(object sender, EventArgs e)
        {
            Servico servico = ServicoSelecionado();
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
            item.Descricao = servico.Descricao;
            item.Valor = valor;

            servicosDaOS.Add(item);
            AtualizarGridServicos();

            // repetido de propósito: com DataSource, o primeiro -1 às vezes é ignorado
            cboServico.SelectedIndex = -1;
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

        private void ListaPecas()
        {
            Estoque estoque = new Estoque();
            string mensagemErro;
            List<Produto> produtos = estoque.ListarProdutos(out mensagemErro);

            if (!string.IsNullOrEmpty(mensagemErro))
            {
                MessageBox.Show("Erro ao carregar peças: " + mensagemErro);
                return;
            }

            cboPeca.DisplayMember = "Nome";
            cboPeca.ValueMember = "Id";
            cboPeca.DataSource = produtos;
            cboPeca.SelectedIndex = -1;
        }

        private void AtualizarGridPecas()
        {
            dgvPecas.DataSource = null;
            dgvPecas.DataSource = pecasDaOS;

            dgvPecas.Columns["Id"].Visible = false;
            dgvPecas.Columns["OrdemServicoId"].Visible = false;
            dgvPecas.Columns["ProdutoId"].Visible = false;
            dgvPecas.Columns["Descricao"].HeaderText = "Peça";
            dgvPecas.Columns["Quantidade"].HeaderText = "Qtd";
            dgvPecas.Columns["ValorUnitario"].HeaderText = "Valor unit.";
            dgvPecas.Columns["ValorUnitario"].DefaultCellStyle.Format = "N2";
            dgvPecas.Columns["ValorTotal"].HeaderText = "Total";
            dgvPecas.Columns["ValorTotal"].DefaultCellStyle.Format = "N2";

            decimal subtotal = 0;
            foreach (OrdemServicoPecas item in pecasDaOS)
            {
                subtotal = subtotal + item.ValorTotal;
            }
            lblSubtotalPecas.Text = "Subtotal: R$ " + subtotal.ToString("N2");
            AtualizarTotal();
        }

        // ---------------- Total ----------------

        private void AtualizarTotal()
        {
            decimal total = 0;

            foreach (OrdemServicoItemServico servico in servicosDaOS)
            {
                total = total + servico.Valor;
            }

            foreach (OrdemServicoPecas peca in pecasDaOS)
            {
                total = total + peca.ValorTotal;
            }

            lblTotal.Text = "Total: R$ " + total.ToString("N2");
        }

        private Produto PecaSelecionada()
        {
            if (cboPeca.SelectedItem == null)
            {
                return null;
            }
            return (Produto)cboPeca.SelectedItem;
        }

        private void cboPecas_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Produto produto = PecaSelecionada();
            if (produto == null)
            {
                txtValorPeca.Clear();
                return;
            }

            txtValorPeca.Text = produto.Valor.ToString("N2");
        }

        private void cboPeca_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnAdicionarPeca_Click(object sender, EventArgs e)
        {
            Produto produto = PecaSelecionada();
            if (produto == null)
            {
                MessageBox.Show("Selecione uma peça.");
                return;
            }

            int quantidade;
            if (!int.TryParse(txtQuantidadePeca.Text, out quantidade) || quantidade <= 0)
            {
                MessageBox.Show("Informe uma quantidade válida, maior que zero.");
                txtQuantidadePeca.Focus();
                return;
            }

            if (quantidade > produto.Quantidade)
            {
                MessageBox.Show("Saldo insuficiente. Em estoque: " + produto.Quantidade);
                txtQuantidadePeca.Focus();
                return;
            }

            decimal valor;
            if (!decimal.TryParse(txtValorPeca.Text, out valor) || valor <= 0)
            {
                MessageBox.Show("Informe um valor válido, maior que zero.");
                txtValorPeca.Focus();
                return;
            }

            OrdemServicoPecas item = new OrdemServicoPecas();
            item.OrdemServicoId = _idOrdem;
            item.ProdutoId = produto.Id;
            item.Quantidade = quantidade;
            item.ValorUnitario = valor;
            item.Descricao = produto.Nome;

            pecasDaOS.Add(item);
            AtualizarGridPecas();

            // repetido de propósito: com DataSource, o primeiro -1 às vezes é ignorado
            cboPeca.SelectedIndex = -1;
            cboPeca.SelectedIndex = -1;
            txtQuantidadePeca.Clear();
            txtValorPeca.Clear();
        }

        private void btnRemoverPeca_Click(object sender, EventArgs e)
        {
            if (dgvPecas.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma peça para remover.");
                return;
            }

            OrdemServicoPecas item = (OrdemServicoPecas)dgvPecas.CurrentRow.DataBoundItem;
            pecasDaOS.Remove(item);
            AtualizarGridPecas();
        }

        // ---------------- Status ----------------

        // Ajusta o selo do cabeçalho e o que pode ser editado conforme o status da OS
        private void AplicarStatus(string status)
        {
            lblStatusOS.Text = status;

            if (status == "NOVA")
            {
                lblStatusOS.BackColor = Color.FromArgb(100, 116, 139);   // cinza
                grpServicos.Enabled = false;
                grpPecas.Enabled = false;
                txtProblema.ReadOnly = false;
                btnSalvar.Enabled = true;
                btnFinalizar.Enabled = false;
                btnIniciar.Enabled = false;
                btnCancelarOS.Enabled = false;
            }
            else if (status == "FINALIZADA" || status == "CANCELADA")
            {
                if (status == "FINALIZADA")
                {
                    lblStatusOS.BackColor = Color.FromArgb(22, 163, 74);  // verde
                }
                else
                {
                    lblStatusOS.BackColor = Color.FromArgb(220, 38, 38);  // vermelho
                }

                // OS encerrada: só consulta
                grpServicos.Enabled = false;
                grpPecas.Enabled = false;
                txtProblema.ReadOnly = true;
                btnSalvar.Enabled = false;
                btnFinalizar.Enabled = false;
                btnCancelarOS.Enabled = false;
                btnIniciar.Enabled = false;
            }
            else
            {
                // ABERTA ou EM ANDAMENTO
                if (status == "EM ANDAMENTO")
                {
                    lblStatusOS.BackColor = Color.FromArgb(217, 119, 6);  // laranja
                    btnIniciar.Enabled = false;                           // já foi iniciada
                }
                else
                {
                    lblStatusOS.BackColor = Color.FromArgb(37, 99, 235);  // azul
                    btnIniciar.Enabled = true;
                }

                grpServicos.Enabled = true;
                grpPecas.Enabled = true;
                txtProblema.ReadOnly = false;
                btnSalvar.Enabled = true;
                btnFinalizar.Enabled = true;
                btnCancelarOS.Enabled = true;
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (_idOrdem == 0)
            {
                MessageBox.Show("Salve a OS antes de iniciar.");
                return;
            }

            OrdemServicoService ordemServicoService = new OrdemServicoService();
            string mensagemErro;

            bool sucesso = ordemServicoService.IniciarOS(_idOrdem, out mensagemErro);
            if (!sucesso)
            {
                MessageBox.Show("Não foi possível iniciar a OS: " + mensagemErro);
                return;
            }

            AplicarStatus("EM ANDAMENTO");
            Text = "Ordem de Serviço Nº " + _idOrdem + " - EM ANDAMENTO";
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (_idOrdem == 0)
            {
                MessageBox.Show("Salve a OS antes de finalizar.");
                return;
            }

            DialogResult resposta = MessageBox.Show(
                "Finalizar a OS Nº " + _idOrdem + "?\n\n" +
                "As peças serão baixadas do estoque e a OS não poderá mais ser alterada.",
                "Finalizar OS",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resposta != DialogResult.Yes)
            {
                return;
            }

            OrdemServicoService ordemServicoService = new OrdemServicoService();
            string mensagemErro;

            // 1. grava o que está na tela, para a baixa usar exatamente essas peças
            OrdemServico ordemServico = new OrdemServico();
            ordemServico.Id = _idOrdem;
            ordemServico.DescricaoProblema = txtProblema.Text;

            bool salvou = ordemServicoService.AtualizarOS(ordemServico, servicosDaOS, pecasDaOS, out mensagemErro);
            if (!salvou)
            {
                MessageBox.Show("Falha ao salvar a OS antes de finalizar: " + mensagemErro);
                return;
            }

            // 2. finaliza: status, data e baixa no estoque, tudo ou nada
            bool finalizou = ordemServicoService.FinalizarOS(_idOrdem, servicosDaOS, pecasDaOS, out mensagemErro);
            if (!finalizou)
            {
                MessageBox.Show("Não foi possível finalizar a OS: " + mensagemErro);
                return;
            }

            AplicarStatus("FINALIZADA");
            Text = "Ordem de Serviço Nº " + _idOrdem + " - FINALIZADA";
            MessageBox.Show("OS Nº " + _idOrdem + " finalizada com sucesso!");
        }

        private void btnCancelarOS_Click(object sender, EventArgs e)
        {
            if (_idOrdem == 0)
            {
                MessageBox.Show("Esta OS ainda não foi salva. Para descartar, use o botão Voltar.");
                return;
            }

            DialogResult resposta = MessageBox.Show(
                "Cancelar a OS Nº " + _idOrdem + "?\n\n" +
                "Ela ficará apenas para consulta e não poderá mais ser alterada.",
                "Cancelar OS",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (resposta != DialogResult.Yes)
            {
                return;
            }

            OrdemServicoService ordemServicoService = new OrdemServicoService();
            string mensagemErro;

            bool sucesso = ordemServicoService.CancelarOS(_idOrdem, out mensagemErro);
            if (!sucesso)
            {
                MessageBox.Show("Não foi possível cancelar a OS: " + mensagemErro);
                return;
            }

            AplicarStatus("CANCELADA");
            Text = "Ordem de Serviço Nº " + _idOrdem + " - CANCELADA";
            MessageBox.Show("OS Nº " + _idOrdem + " cancelada.");
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