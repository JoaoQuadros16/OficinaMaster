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

            Usuario usuario = new Usuario();
            string nome = txtNome.Text;
            string login = txtLogin.Text;
            string senha = txtSenha.Text;
            string hash = BCrypt.Net.BCrypt.HashPassword(senha);

            usuario.Ativo = chkAtivo.Checked;
            usuario.SenhaHash = hash;
            usuario.Nome = nome;
            usuario.Login = login;
            // usuario.Perfil = rbAdministrador.Checked ? "Administrador" : "Funcionário"; // se sua classe Usuario tiver essa propriedade

            UsuarioService service = new UsuarioService();
            service.CadastrarUsuario(usuario);

            MessageBox.Show("Usuario Cadastrado !");
            this.Close();
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
    }
}