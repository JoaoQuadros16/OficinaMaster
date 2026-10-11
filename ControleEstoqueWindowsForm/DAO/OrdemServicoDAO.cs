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

        public bool CadastrarOS(OrdemServico ordemServico, out string mensagemErro)
        {
            mensagemErro = string.Empty;
            try
            {
                using(SqlConnection conn = Conexao.ObterConexao())
                {
                    conn.Open();
                    string sql = @"INSERT INTO OrdensServico
                                   (ClienteId, VeiculoId, DataAbertura, DataFinalizacao, Descricao, Status)
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
    }
}
