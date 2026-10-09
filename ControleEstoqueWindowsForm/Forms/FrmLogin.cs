using ControleEstoqueWindowsForm.Classes;
using ControleEstoqueWindowsForm.Models;
using ControleEstoqueWindowsForm.Services;
using System;
using System.Windows.Forms;

namespace ControleEstoqueWindowsForm
{
    public partial class FrmLogin : Form
    {
        private AutenticacaoService autenticacao = new AutenticacaoService();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Preencha usuário e senha.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string mensagemErro;
            Usuario usuario = autenticacao.ValidarLogin(txtUsuario.Text, txtSenha.Text, out mensagemErro);

            if (!string.IsNullOrEmpty(mensagemErro))
            {
                MessageBox.Show("Erro ao conectar com o banco: " + mensagemErro, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (usuario != null)
            {
                Sessao.UsuarioLogado = usuario;
                MessageBox.Show("Usuário logado com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                FrmPrincipal tela = new FrmPrincipal();
                tela.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Clear();
                txtSenha.Focus();
            }
        }
    }
}
