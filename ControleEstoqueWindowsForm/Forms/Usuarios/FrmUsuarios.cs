using ControleEstoqueWindowsForm.Classes;
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
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void CarregarUsuarios()
        {
            UsuarioService usuarioService = new UsuarioService();
            List<Usuario> usuarios = usuarioService.ListarUsuariosAtivosInativos(txtPesquisa.Text,chkMostrarInativos.Checked, out string mensagemErro);

            if (!string.IsNullOrEmpty(mensagemErro))
            {
                MessageBox.Show("Erro ao carregar produtos: " + mensagemErro);
            }

            dgvUsuarios.DataSource = usuarios;
            AjustarGrade();

        }

        private void AjustarGrade()
        {
            // a senha (mesmo criptografada) nunca aparece na tela
            if (dgvUsuarios.Columns.Contains("SenhaHash"))
            {
                dgvUsuarios.Columns["SenhaHash"].Visible = false;
            }

            if (dgvUsuarios.Columns.Contains("Id"))
            {
                dgvUsuarios.Columns["Id"].HeaderText = "Código";
                dgvUsuarios.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dgvUsuarios.Columns["Id"].Width = 80;
            }

            if (dgvUsuarios.Columns.Contains("Ativo"))
            {
                dgvUsuarios.Columns["Ativo"].Visible = chkMostrarInativos.Checked;

                foreach (DataGridViewRow linha in dgvUsuarios.Rows)
                {
                    bool ativo = Convert.ToBoolean(linha.Cells["Ativo"].Value);
                    if (!ativo)
                    {
                        linha.DefaultCellStyle.ForeColor = Color.Gray;
                    }
                }
            }
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            CarregarUsuarios();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            CarregarUsuarios();
        }

        private void chkMostrarInativos_CheckedChanged(object sender, EventArgs e)
        {
            CarregarUsuarios();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarUsuarios();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmCadastroUsuario tela = new FrmCadastroUsuario();
            tela.ShowDialog();

            CarregarUsuarios();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Selecione um usuário para editar.");
                return;
            }

            int idUsuario = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["Id"].Value);

            FrmEditarUsuario tela = new FrmEditarUsuario(idUsuario);
            tela.ShowDialog();
        }

        // dois cliques na linha também editam
        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                EditarSelecionado();
            }
        }

        private void EditarSelecionado()
        {
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Selecione um usuário na lista.");
                return;
            }

            int id = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["Id"].Value);

            // TODO: abrir o cadastro em modo edição, passando o id do usuário:
            //
            // FrmCadastroUsuario tela = new FrmCadastroUsuario(id);
            // tela.ShowDialog();
            // CarregarUsuarios();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
