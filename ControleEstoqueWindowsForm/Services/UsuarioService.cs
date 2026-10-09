using ControleEstoqueWindowsForm.Classes;
using ControleEstoqueWindowsForm.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleEstoqueWindowsForm.Validacoes;

namespace ControleEstoqueWindowsForm
{
    public class UsuarioService
    {
        UsuarioDAO usuariodao = new UsuarioDAO();

        private static bool ValidarUsuario(Usuario usuario, out string mensagemErro)
        {
            if (!Validador.CampoObrigatorio(usuario.Nome, "Nome", out mensagemErro))
            {
                return false;
            }
            if (!Validador.ValidarNome(usuario.Nome, out mensagemErro))
            {
                return false;
            }
            if (!Validador.CampoObrigatorio(usuario.Login, "Login", out mensagemErro))
            {
                return false;
            }
            return true;
        }

        public bool CadastrarUsuario(Usuario usuario, out string mensagemErro)
        {
            if (!ValidarUsuario(usuario, out mensagemErro))
            {
                return false;
            }

            bool sucesso = usuariodao.CadastrarUsuario(usuario, out mensagemErro);

            return sucesso;
        }
        public Usuario BuscarUsuario(string login, out string mensagemErro)
        {
            return usuariodao.BuscarPorLogin(login, out mensagemErro);
        }
        public List<Usuario> ListarUsuariosAtivos(out string mensagemErro)
        {
            return usuariodao.ListarUsuariosAtivos(out mensagemErro);
        }
        public List<Usuario> ListarUsuariosAtivosInativos(string pesquisa, bool inativo, out string mensagemErro)
        {
            return usuariodao.ListarUsuariosAtivosInativos(pesquisa, inativo, out mensagemErro);
        }
        public Usuario BuscarPorId(int id, out string mensagemErro)
        {
            return usuariodao.BuscarPorId(id, out mensagemErro);
        }
        public bool EditarUsuario(Usuario usuario, out string mensagemErro)
        {
            if (!ValidarUsuario(usuario, out mensagemErro))
            {
                return false;
            }
            bool sucesso = usuariodao.EditarUsuario(usuario, out mensagemErro);
            return sucesso;
        }
    }
}
