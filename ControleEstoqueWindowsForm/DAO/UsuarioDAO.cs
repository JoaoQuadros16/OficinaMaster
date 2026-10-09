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

        public bool CadastrarUsuario(Usuario usuario, out string mensagemErro)
        {
            mensagemErro = string.Empty;

            try
            {
                using (SqlConnection conn = conexao.ObterConexao())
                {
                    conn.Open();

                    string sql = "INSERT INTO usuario " +
                                 "(nome, login, senha_hash, ativo, nivel_acesso)" +
                                 "VALUES" +
                                 "(@nome, @login, @senha_hash, @ativo, @nivel_acesso)";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@nome", usuario.Nome);
                    cmd.Parameters.AddWithValue("@login", usuario.Login);
                    cmd.Parameters.AddWithValue("@senha_hash", usuario.SenhaHash);
                    cmd.Parameters.AddWithValue("@ativo", usuario.Ativo);
                    cmd.Parameters.AddWithValue("@nivel_acesso", usuario.Nivel_acesso);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                mensagemErro = ex.Message;
                return false;
            }
        }

        public Usuario BuscarPorLogin(string login, out string mensagemErro)
        {
            mensagemErro = string.Empty;
            Usuario usuario = null;

            try
            {
                using (SqlConnection conn = conexao.ObterConexao())
                {
                    conn.Open();

                    string sql = @"SELECT id, nome, login, senha_hash, ativo, nivel_acesso
                                   FROM usuario
                                   WHERE login = @login";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@login", login);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuario = new Usuario
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                Nome = reader["nome"].ToString(),
                                Login = reader["login"].ToString(),
                                SenhaHash = reader["senha_hash"].ToString(),
                                Ativo = Convert.ToBoolean(reader["ativo"]),
                                Nivel_acesso = reader["nivel_acesso"].ToString()
                            };
                        }
                    }
                }
                return usuario;
            }
            catch (Exception ex)
            {
                mensagemErro = ex.Message;
                return usuario;
            }
        }
        public List<Usuario> ListarUsuariosAtivos(out string mensagemErro)
        {
            mensagemErro = string.Empty;
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                using (SqlConnection conn = conexao.ObterConexao())
                {
                    conn.Open();
                    string sql = @"SELECT id, nome, login, ativo, nivel_acesso
                                   FROM usuario
                                   WHERE ativo = 1";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Usuario usuario = new Usuario
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                Nome = reader["nome"].ToString(),
                                Login = reader["login"].ToString(),
                                Ativo = Convert.ToBoolean(reader["ativo"]),
                                Nivel_acesso = reader["nivel_acesso"].ToString()
                            };
                            usuarios.Add(usuario);
                        }
                    }
                }
                return usuarios;
            }
            catch (Exception ex)
            {
                mensagemErro = ex.Message;
                return usuarios;
            }
        }
        public Usuario BuscarPorId(int  id, out string mensagemErro)
        {
            mensagemErro = string.Empty;
            Usuario usuario = null;

            try
            {
                using (SqlConnection conn = conexao.ObterConexao())
                {
                    conn.Open();

                    string sql = @"SELECT id, nome, login, senha_hash, ativo, nivel_acesso
                                   FROM usuario
                                   WHERE id = @id";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuario = new Usuario
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                Nome = reader["nome"].ToString(),
                                Login = reader["login"].ToString(),
                                SenhaHash = reader["senha_hash"].ToString(),
                                Ativo = Convert.ToBoolean(reader["ativo"]),
                                Nivel_acesso = reader["nivel_acesso"].ToString()
                            };
                        }
                    }
                }
                return usuario;
            }
            catch (Exception ex)
            {
                mensagemErro = ex.Message;
                return usuario;
            }
        }

        public bool EditarUsuario(Usuario usuario, out string mensagemErro)
        {
            mensagemErro = string.Empty;
            try
            {
                using (SqlConnection conn = conexao.ObterConexao())
                {
                    conn.Open();
                    string sql = @"UPDATE usuario
                                   SET nome = @nome, login = @login, senha_hash = @senha_hash, ativo = @ativo, nivel_acesso = @nivel_acesso
                                   WHERE id = @id";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", usuario.Id);
                    cmd.Parameters.AddWithValue("@nome", usuario.Nome);
                    cmd.Parameters.AddWithValue("@login", usuario.Login);
                    cmd.Parameters.AddWithValue("@senha_hash", usuario.SenhaHash);
                    cmd.Parameters.AddWithValue("@ativo", usuario.Ativo);
                    cmd.Parameters.AddWithValue("@nivel_acesso", usuario.Nivel_acesso);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        mensagemErro = "Nenhum usuário foi atualizado. Verifique se o ID está correto.";
                        return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                mensagemErro = ex.Message;
                return false;
            }
        }

        public List<Usuario> ListarUsuariosAtivosInativos(string pesquisa, bool inativo, out string mensagemErro)
        {
            mensagemErro = string.Empty;
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                using (SqlConnection conn = conexao.ObterConexao())
                {
                    conn.Open();
                    string sql = @"SELECT id, nome, login, ativo, nivel_acesso
                                   FROM usuario
                                    WHERE (CAST(Id AS NVARCHAR(20)) LIKE @pesquisa
                                  OR nome LIKE @pesquisa)
                             AND (@mostrarInativos = 1 OR Ativo = 1)";
                    SqlCommand cmd = new SqlCommand(sql, conn);


                    cmd.Parameters.AddWithValue("@pesquisa", "%" + pesquisa + "%");
                    cmd.Parameters.AddWithValue("@mostrarInativos", inativo);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Usuario usuario = new Usuario
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                Nome = reader["nome"].ToString(),
                                Login = reader["login"].ToString(),
                                Ativo = Convert.ToBoolean(reader["ativo"]),
                                Nivel_acesso = reader["nivel_acesso"].ToString()
                            };
                            usuarios.Add(usuario);
                        }
                    }
                }
                return usuarios;
            }
            catch (Exception ex)
            {
                mensagemErro = ex.Message;
                return usuarios;
            }
        }
    }
}
