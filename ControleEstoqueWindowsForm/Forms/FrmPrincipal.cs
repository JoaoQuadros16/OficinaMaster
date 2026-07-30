using System;
using System.Windows.Forms;

namespace ControleEstoqueWindowsForm
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: carregar dados do usuário logado, permissões, etc.
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            // TODO: lógica de logout / retorno à tela de login
            this.Close();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            // TODO: exibir dashboard em pnlConteudo
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            // TODO: exibir tela de Clientes em pnlConteudo
            FrmCliente tela = new FrmCliente();
            tela.ShowDialog();
        }

        private void btnVeiculos_Click(object sender, EventArgs e)
        {
            // TODO: exibir tela de Veículos em pnlConteudo
            FrmVeiculo tela = new FrmVeiculo();
            tela.ShowDialog();
        }

        private void btnOrdensServico_Click(object sender, EventArgs e)
        {
            // TODO: exibir tela de Ordens de Serviço em pnlConteudo
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            // TODO: exibir tela de Estoque / Peças em pnlConteudo
            FrmProduto tela = new FrmProduto();
            tela.ShowDialog();
        }

        private void btnServicos_Click(object sender, EventArgs e)
        {
            // TODO: exibir tela de Serviços em pnlConteudo
        }

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            // TODO: exibir tela de Financeiro em pnlConteudo
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            // TODO: exibir tela de Usuários em pnlConteudo
            FrmCadastroUsuario tela = new FrmCadastroUsuario();
            tela.ShowDialog();
        }

        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {
            // TODO: exibir tela de Configurações em pnlConteudo
        }

        private void lblUsuarioLogado_Click(object sender, EventArgs e)
        {

        }
    }
}