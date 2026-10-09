using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ControleEstoqueWindowsForm.Models;
using ControleEstoqueWindowsForm.Validacoes;

namespace ControleEstoqueWindowsForm.DAO
{
    public class ServicoDAO
    {
        private Conexao conexao = new Conexao();

        public bool CadastrarServico(Servico servico, out string mensagemErro)
        {
            mensagemErro = string.Empty;

            try
            {
                using (SqlConnection conn = conexao.ObterConexao())
                {
                    conn.Open();
                    string sql = @"INSERT INTO servicos
                               (descricao, valor, ativo)
                               VALUES
                               (@descricao, @valor, @ativo);
                                SELECT CAST(SCOPE_IDENTITY() AS INT);";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@descricao", servico.Descricao);
                    cmd.Parameters.AddWithValue("@valor", servico.Valor);
                    cmd.Parameters.AddWithValue("@ativo", servico.Ativo);

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
        public List<Servico> ListarServicos(out string mensagemErro)
        {
            mensagemErro = string.Empty;

            List<Servico> servicos = new List<Servico>();
            try
            {
                using (SqlConnection conn = conexao.ObterConexao())
                {
                    conn.Open();
                    string sql = @"SELECT * FROM servicos WHERE Ativo = 1";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Servico servico1 = new Servico();
                        servico1.Id = Convert.ToInt32(reader["id"]);
                        servico1.Descricao = reader["descricao"].ToString();
                        servico1.Valor = Convert.ToDouble(reader["valor"]);
                        servico1.Ativo = Convert.ToBoolean(reader["Ativo"]);
                        servicos.Add(servico1);
                    }
                }
                return servicos;
            }
            catch (Exception ex)
            {
                mensagemErro = ex.Message;
                return servicos;
            }
        }

        public List<Servico> ListarServicosAtivoseInativos(out string mensagemErro)
        {
            mensagemErro = string.Empty;

            List<Servico> servicos = new List<Servico>();
            try
            {
                using (SqlConnection conn = conexao.ObterConexao())
                {
                    conn.Open();
                    string sql = @"SELECT * FROM servicos";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Servico servico1 = new Servico();
                        servico1.Id = Convert.ToInt32(reader["id"]);
                        servico1.Descricao = reader["descricao"].ToString();
                        servico1.Valor = Convert.ToDouble(reader["valor"]);
                        servico1.Ativo = Convert.ToBoolean(reader["Ativo"]);
                        servicos.Add(servico1);
                    }
                }
                return servicos;
            }
            catch (Exception ex)
            {
                mensagemErro = ex.Message;
                return servicos;
            }
        }
        public List<Servico> PesquisarServicos(string pesquisa, bool mostrarInativos, out string mensagemErro)
        {
            mensagemErro = string.Empty;

            List<Servico> servicos = new List<Servico>();
            try
            {
                using (SqlConnection conn = conexao.ObterConexao())
                {
                    conn.Open();
                    string sql = @"SELECT Id, Descricao, Valor, Ativo
                           FROM Servicos
                           WHERE (CAST(Id AS NVARCHAR(20)) LIKE @pesquisa
                                  OR Descricao LIKE @pesquisa)
                             AND (@mostrarInativos = 1 OR Ativo = 1)";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@pesquisa", "%" + pesquisa + "%");
                    cmd.Parameters.AddWithValue("@mostrarInativos", mostrarInativos);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Servico servico1 = new Servico()
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Descricao = reader["Descricao"].ToString(),
                                Valor = Convert.ToDouble(reader["Valor"]),
                                Ativo = Convert.ToBoolean(reader["Ativo"]),
                            };
                            servicos.Add(servico1);
                        }
                    }
                }
                return servicos;
            }
            catch (Exception ex)
            {
                mensagemErro = ex.Message;
                return servicos;
            }
        }
        public bool EditarServico(Servico servico, out string mensagemErro)
        {
            mensagemErro = string.Empty;
            try
            {
                using (SqlConnection conn = conexao.ObterConexao())
                {
                    conn.Open();
                    string sql = @"UPDATE Servicos
                                   SET Descricao = @descricao,
                                       Valor = @valor,
                                       Ativo = @ativo
                                   WHERE Id = @id";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@descricao", servico.Descricao);
                    cmd.Parameters.AddWithValue("@valor", servico.Valor);
                    cmd.Parameters.AddWithValue("@ativo", servico.Ativo);
                    cmd.Parameters.AddWithValue("@id", servico.Id);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        mensagemErro = "Nenhum serviço encontrado com o ID fornecido.";
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
    }
}
