using ControleEstoqueWindowsForm.Models;
using ControleEstoqueWindowsForm.Services;
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

            if (Sessao.UsuarioLogado == null)
            {
                MessageBox.Show("Nenhum usuário logado.");
                Application.Exit();
                return;
            }
            lblUsuarioLogado.Text = "Bem-vindo(a), " + Sessao.UsuarioLogado.Nome;

            if (Sessao.UsuarioLogado.Nivel_acesso != "Administrador")
            {
                btnUsuarios.Visible = false;
                btnConfiguracoes.Visible = false;
            }
            else
            {
                btnUsuarios.Visible = true;
                btnConfiguracoes.Visible = true;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Restart();
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
            FrmOrdensServico tela = new FrmOrdensServico();
            tela.ShowDialog();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            // TODO: exibir tela de Estoque / Peças em pnlConteudo
            FrmEstoque tela = new FrmEstoque();
            tela.ShowDialog();
        }

        private void btnServicos_Click(object sender, EventArgs e)
        {
            // TODO: exibir tela de Serviços em pnlConteudo
            FrmServicos tela = new FrmServicos();
            tela.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            // TODO: exibir tela de Usuários em pnlConteudo
            FrmUsuarios tela = new FrmUsuarios();
            tela.ShowDialog();
        }

        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {
            // TODO: exibir tela de Configurações em pnlConteudo
        }

        private void pnlConteudo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}