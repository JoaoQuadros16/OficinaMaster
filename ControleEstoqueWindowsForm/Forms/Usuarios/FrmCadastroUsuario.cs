using ControleEstoqueWindowsForm.Classes;
using ControleEstoqueWindowsForm.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleEstoqueWindowsForm.Validacoes;

namespace ControleEstoqueWindowsForm
{
    public partial class FrmCadastroUsuario : Form
    {
        public FrmCadastroUsuario()
        {
            InitializeComponent();
        }

        private void FrmCadastroUsuario_Load(object sender, EventArgs e)
        {
        }
        public static class Perfis
        {
            public const string Administrador = "Administrador";
            public const string Funcionario = "Funcionário";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtLogin.Text) ||
                string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtSenha.Text != txtConfirmarSenha.Text)
            {
                MessageBox.Show("As senhas não coincidem.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // fica aqui (e não no Service) porque o Service só recebe a senha já criptografada
            if (txtSenha.Text.Length < 6)
            {
                MessageBox.Show("A senha deve ter pelo menos 6 caracteres.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Usuario usuario = new Usuario();
            string nome = txtNome.Text;
            string login = txtLogin.Text;
            string senha = txtSenha.Text;
            string hash = BCrypt.Net.BCrypt.HashPassword(senha);

            usuario.Ativo = chkAtivo.Checked;
            usuario.SenhaHash = hash;
            usuario.Nome = nome;
            usuario.Login = login;

            if (rbAdministrador.Checked)
            {
                usuario.Nivel_acesso = Perfis.Administrador;
            }
            else
            {
                usuario.Nivel_acesso = Perfis.Funcionario;
            }

            UsuarioService service = new UsuarioService();
            string mensagemErro;
            bool sucesso = service.CadastrarUsuario(usuario, out mensagemErro);

            if (sucesso)
            {
                MessageBox.Show("Usuario Cadastrado !");
                this.Close();
            }
            else
            {
                MessageBox.Show(mensagemErro);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtLogin.Clear();
            txtSenha.Clear();
            txtConfirmarSenha.Clear();
            rbAdministrador.Checked = true;
            chkAtivo.Checked = true;
            txtNome.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            Formatador.Aplicar(txtNome, Formatador.FormatarNome);
        }
    }
}
