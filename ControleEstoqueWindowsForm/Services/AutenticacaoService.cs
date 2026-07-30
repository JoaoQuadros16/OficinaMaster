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
        public bool ValidarLogin(string login, string senha)
        {
            Usuario usuario = usuarioDAO.BuscarPorLogin(login);

            if (usuario == null)
                return false;

            if (!usuario.Ativo)
                return false;

            return BCrypt.Net.BCrypt.Verify(senha, usuario.SenhaHash);
        }
    }
}
