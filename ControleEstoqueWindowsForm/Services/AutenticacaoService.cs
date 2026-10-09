using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;
using ControleEstoqueWindowsForm.Classes;
using ControleEstoqueWindowsForm.DAO;


namespace ControleEstoqueWindowsForm.Services
{
    public class AutenticacaoService
    {
        UsuarioDAO usuarioDAO = new UsuarioDAO();

        public string GerarHash(string senha)
        {
            return BCrypt.Net.BCrypt.HashPassword(senha);
        }
        public Usuario ValidarLogin(string login, string senha, out string mensagemErro)
        {
            Usuario usuario = usuarioDAO.BuscarPorLogin(login, out mensagemErro);

            if (usuario == null || !usuario.Ativo)
                return null;

            if(! BCrypt.Net.BCrypt.Verify(senha, usuario.SenhaHash))
                return null;

            return usuario;
        }
    }
}
