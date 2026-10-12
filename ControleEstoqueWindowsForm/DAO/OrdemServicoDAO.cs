using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleEstoqueWindowsForm.Models;

namespace ControleEstoqueWindowsForm.DAO
{
    public class OrdemServicoDAO
    {
        private Conexao Conexao = new Conexao();

        public int CadastrarOS(OrdemServico ordemServico, out string mensagemErro)
        {
            mensagemErro = string.Empty;
            try
            {
                using(SqlConnection conn = Conexao.ObterConexao())
                {
                    conn.Open();
                    string sql = @"INSERT INTO OrdensServico
                               (ClienteId, VeiculoId, DataAbertura, DataFinalizacao, Descricao, Status)
                               OUTPUT INSERTED.Id
                               VALUES
                               (@ClienteId, @VeiculoId, @DataAbertura, @DataFinalizacao, @Descricao, @Status)";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@ClienteId", ordemServico.ClienteId);
                    cmd.Parameters.AddWithValue("@VeiculoId", ordemServico.VeiculoId);
                    cmd.Parameters.AddWithValue("@DataAbertura", ordemServico.DataAbertura);
                    if (ordemServico.DataFinalizacao == null)
                    {
                        cmd.Parameters.AddWithValue("@DataFinalizacao", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@DataFinalizacao", ordemServico.DataFinalizacao.Value);
                    }
                    cmd.Parameters.AddWithValue("@Descricao", ordemServico.DescricaoProblema);
                    cmd.Parameters.AddWithValue("@Status", ordemServico.Status);

                    int novoId = Convert.ToInt32(cmd.ExecuteScalar());
                    return novoId;
                }
            }
            catch (Exception ex)
            {
                mensagemErro = ex.Message;
                return 0;
            }
        }
        public List<OrdemServico> ListarOrdensServico(out string mensagemErro)
        {
            mensagemErro = string.Empty;
            List<OrdemServico> ordensServico = new List<OrdemServico>();
            try
            {
                using (SqlConnection conn = Conexao.ObterConexao())
                {
                    conn.Open();
                    string sql = @"SELECT os.Id,
                                  os.ClienteId,
                                  os.VeiculoId,
                                  c.Nome AS Cliente,
                                  v.Modelo + ' - ' + v.Placa AS Veiculo,
                                  os.DataAbertura,
                                  os.DataFinalizacao,
                                  os.Descricao,
                                  os.Status
                           FROM OrdensServico os
                           INNER JOIN Clientes c ON c.Id = os.ClienteId
                           INNER JOIN Veiculos v ON v.Id = os.VeiculoId";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            OrdemServico ordemServico = new OrdemServico
                            {
                                Id = reader.GetInt32(0),
                                ClienteId = reader.GetInt32(1),
                                VeiculoId = reader.GetInt32(2),
                                ClienteNome = reader.GetString(3),
                                VeiculoDescricao = reader.GetString(4),
                                DataAbertura = reader.GetDateTime(5),
                                DataFinalizacao = reader.IsDBNull(6) ? (DateTime?)null : reader.GetDateTime(6),
                                DescricaoProblema = reader.GetString(7),
                                Status = reader.GetString(8)
                            };
                            ordensServico.Add(ordemServico);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                mensagemErro = ex.Message;
            }
            return ordensServico;
        }
        public OrdemServico ObterPorId(int id, out string mensagemErro)
        {
            mensagemErro = string.Empty;
            OrdemServico ordem = null;
            try
            {
                using (SqlConnection conn = Conexao.ObterConexao())
                {
                    conn.Open();
                    string sql = @"SELECT Id, ClienteId, VeiculoId, DataAbertura, DataFinalizacao, Descricao, Status
                           FROM OrdensServico
                           WHERE Id = @Id";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Id", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ordem = new OrdemServico
                            {
                                Id = reader.GetInt32(0),
                                ClienteId = reader.GetInt32(1),
                                VeiculoId = reader.GetInt32(2),
                                DataAbertura = reader.GetDateTime(3),
                                DataFinalizacao = reader.IsDBNull(4) ? (DateTime?)null : reader.GetDateTime(4),
                                DescricaoProblema = reader.GetString(5),
                                Status = reader.GetString(6)
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                mensagemErro = ex.Message;
            }
            return ordem;
        }
        public bool AtualizarOS(OrdemServico ordem, List<OrdemServicoItemServico> servicos, out string mensagemErro)
        {
            mensagemErro = string.Empty;

            using (SqlConnection conn = Conexao.ObterConexao())
            {
                conn.Open();
                SqlTransaction transacao = conn.BeginTransaction();

                try
                {
                    // 1. atualiza a OS
                    string sqlOS = @"UPDATE OrdensServico
                             SET Descricao = @Descricao
                             WHERE Id = @Id";
                    SqlCommand cmdOS = new SqlCommand(sqlOS, conn, transacao);
                    cmdOS.Parameters.AddWithValue("@Descricao", ordem.DescricaoProblema);
                    cmdOS.Parameters.AddWithValue("@Id", ordem.Id);
                    cmdOS.ExecuteNonQuery();

                    // 2. apaga os serviços antigos
                    string sqlDelete = "DELETE FROM OrdemServicoServicos WHERE OrdemServicoId = @Id";
                    SqlCommand cmdDelete = new SqlCommand(sqlDelete, conn, transacao);
                    cmdDelete.Parameters.AddWithValue("@Id", ordem.Id);
                    cmdDelete.ExecuteNonQuery();

                    // 3. grava os serviços da lista
                    string sqlInsert = @"INSERT INTO OrdemServicoServicos (OrdemServicoId, ServicoId, Valor)
                                 VALUES (@OrdemServicoId, @ServicoId, @Valor)";
                    foreach (OrdemServicoItemServico item in servicos)
                    {
                        SqlCommand cmdItem = new SqlCommand(sqlInsert, conn, transacao);
                        cmdItem.Parameters.AddWithValue("@OrdemServicoId", ordem.Id);
                        cmdItem.Parameters.AddWithValue("@ServicoId", item.ServicoId);
                        cmdItem.Parameters.AddWithValue("@Valor", item.Valor);
                        cmdItem.ExecuteNonQuery();
                    }

                    transacao.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transacao.Rollback();
                    mensagemErro = ex.Message;
                    return false;
                }
            }
        }
        public bool CadastrarServicoOrdem(OrdemServicoItemServico item, out string mensagemErro)
        {
            mensagemErro = string.Empty;
            try
            {
                using (SqlConnection conn = Conexao.ObterConexao())
                {
                    conn.Open();
                    string sql = @"INSERT INTO OrdemServicoServicos (OrdemServicoId, ServicoId, Valor)
                                   VALUES (@OrdemServicoId, @ServicoId, @Valor);
                                   SELECT SCOPE_IDENTITY();";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@OrdemServicoId", item.OrdemServicoId);
                    cmd.Parameters.AddWithValue("@ServicoId", item.ServicoId);
                    cmd.Parameters.AddWithValue("@Valor", item.Valor);

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
        public List<OrdemServicoItemServico> ListarServicosDaOS(int idOrdem, out string mensagemErro)
        {
            mensagemErro = string.Empty;
            List<OrdemServicoItemServico> itens = new List<OrdemServicoItemServico>();
            try
            {
                using (SqlConnection conn = Conexao.ObterConexao())
                {
                    conn.Open();
                    string sql = @"SELECT oss.Id,
                                  oss.OrdemServicoId,
                                  oss.ServicoId,
                                  s.Descricao,
                                  oss.Valor
                           FROM OrdemServicoServicos oss
                           INNER JOIN servicos s ON s.Id = oss.ServicoId
                           WHERE oss.OrdemServicoId = @IdOrdem";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@IdOrdem", idOrdem);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            OrdemServicoItemServico item = new OrdemServicoItemServico();
                            item.Id = reader.GetInt32(0);
                            item.OrdemServicoId = reader.GetInt32(1);
                            item.ServicoId = reader.GetInt32(2);
                            item.Descricao = reader.GetString(3);
                            item.Valor = reader.GetDecimal(4);
                            itens.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                mensagemErro = ex.Message;
            }
            return itens;
        }
    }
}
