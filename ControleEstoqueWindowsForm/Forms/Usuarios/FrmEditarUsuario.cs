using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleEstoqueWindowsForm.DAO;
using ControleEstoqueWindowsForm.Models;
using ControleEstoqueWindowsForm.Services;
using ControleEstoqueWindowsForm.Classes;

namespace ControleEstoqueWindowsForm
{
    public partial class FrmEditarUsuario : Form
    {
        private int _idUsuario;
        private Usuario usuarioAtual; 
        private UsuarioService usuarioService = new UsuarioService();

        public FrmEditarUsuario(int idUsuario)
        {
            InitializeComponent();
            _idUsuario = idUsuario;
        }

        private void FrmEditarUsuario_Load(object sender, EventArgs e)
        {
            string mensagemErro;
            try
            {
                usuarioAtual = usuarioService.BuscarPorId(_idUsuario, out mensagemErro);

                if(usuarioAtual == null)
                {
                    MessageBox.Show("Usuário não encontrado. Erro: " + mensagemErro + " | ID buscado: " + _idUsuario);
                    this.Close();
                    return;
                }

                txtNome.Text = usuarioAtual.Nome.ToString();
                txtLogin.Text = usuarioAtual.Login.ToString();
                if (usuarioAtual.Nivel_acesso == "Administrador")
                {
                    rbAdministrador.Checked = true;
                }
                else
                {
                    rbFuncionario.Checked = true;
                }
                if(usuarioAtual.Ativo == true)
                {
                    chkAtivo.Checked = true;
                }
                else
                {
                    chkAtivo.Checked = false;
                }
            }
            catch (Exception ex)
            { 
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string mensagemErro;
            try
            {
                usuarioAtual.Nome = txtNome.Text;
                usuarioAtual.Login = txtLogin.Text;
                bool alterarSenha = !string.IsNullOrEmpty(txtSenha.Text);

                if (alterarSenha)
                {
                    if (txtSenha.Text != txtConfirmarSenha.Text)
                    {
                        MessageBox.Show("As senhas não coincidem.");
                        return;
                    }

                    if (txtSenha.Text.Length < 6)
                    {
                        MessageBox.Show("A senha deve ter pelo menos 6 caracteres.");
                        return;
                    }

                    usuarioAtual.SenhaHash = BCrypt.Net.BCrypt.HashPassword(txtSenha.Text);
                }

                if (rbAdministrador.Checked)
                {
                    usuarioAtual.Nivel_acesso = "Administrador";
                }
                else
                {
                    usuarioAtual.Nivel_acesso = "Funcionário";
                }
                usuarioAtual.Ativo = chkAtivo.Checked;
                bool sucesso = usuarioService.EditarUsuario(usuarioAtual, out mensagemErro);
                if (sucesso)
                {
                    MessageBox.Show("Usuário atualizado com sucesso!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar usuário: " + mensagemErro);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar usuário: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
        }
    }
}
