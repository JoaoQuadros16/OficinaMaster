using ControleEstoqueWindowsForm.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEstoqueWindowsForm.DAO
{
    public class UsuarioDAO
    {
        Conexao conexao = new Conexao();

        public void CadastrarUsuario(Usuario usuario)
        {
            using (SqlConnection conn = conexao.ObterConexao())
            {
                conn.Open();

                string sql = "INSERT INTO usuario " +
                             "(nome, login, senha_hash, ativo)" +
                             "VALUES" +
                             "(@nome, @login, @senha_hash, @ativo)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nome", usuario.Nome);
                cmd.Parameters.AddWithValue("@login", usuario.Login);
                cmd.Parameters.AddWithValue("@senha_hash", usuario.SenhaHash);
                cmd.Parameters.AddWithValue("@ativo", usuario.Ativo);
                cmd.ExecuteNonQuery();
            }
        }

        public Usuario BuscarPorLogin(string login)
        {
            using (SqlConnection conn = conexao.ObterConexao())
            {
                conn.Open();

                string sql = @"SELECT id, nome, login, senha_hash, ativo
                               FROM usuario
                               WHERE login = @login";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@login", login);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Usuario
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Nome = reader["nome"].ToString(),
                            Login = reader["login"].ToString(),
                            SenhaHash = reader["senha_hash"].ToString(),
                            Ativo = Convert.ToBoolean(reader["ativo"])
                        };
                    }
                }
            }
            return null;
        }
    }
}