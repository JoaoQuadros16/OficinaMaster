using ControleEstoqueWindowsForm.Classes;
using ControleEstoqueWindowsForm.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoqueWindowsForm
{
    public class UsuarioService
    {
        UsuarioDAO usuariodao = new UsuarioDAO();

        public void CadastrarUsuario(Usuario usuario)
        {
            usuariodao.CadastrarUsuario(usuario);
        }
        public void BuscarUsuario(string login)
        {
            usuariodao.BuscarPorLogin(login);
        }
    }
}
