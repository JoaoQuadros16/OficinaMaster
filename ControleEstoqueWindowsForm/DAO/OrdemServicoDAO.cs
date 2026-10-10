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
    }
}
