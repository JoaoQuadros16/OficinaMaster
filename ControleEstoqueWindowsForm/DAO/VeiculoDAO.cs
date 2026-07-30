using ControleEstoqueWindowsForm.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEstoqueWindowsForm.DAO
{
    public class VeiculoDAO
    {
        Conexao conexao = new Conexao();

        public bool CadastrarVeiculo(Veiculo veiculo, out string mensagemErro)
        {
            mensagemErro = string.Empty;

            try
            {
                using (SqlConnection conn = conexao.ObterConexao())
                {
                    conn.Open();

                    string sql = @"INSERT INTO Veiculos (ClienteId, placa, marca, modelo, ano, cor)
                             VALUES 
                             (@ClienteId, @placa, @marca, @modelo, @ano, @cor)";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@id", veiculo.Id);
                    cmd.Parameters.AddWithValue("@ClienteId", veiculo.ClienteId);
                    cmd.Parameters.AddWithValue("@placa", veiculo.Placa);
                    cmd.Parameters.AddWithValue("@marca", veiculo.Marca);
                    cmd.Parameters.AddWithValue("@modelo", veiculo.Modelo);
                    cmd.Parameters.AddWithValue("@ano", veiculo.Ano);
                    cmd.Parameters.AddWithValue("@cor", veiculo.Cor);

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

        public bool EditarVeiculo(Veiculo veiculo, out string mensagemErro)
        {
            mensagemErro = string.Empty;

            try
            {
                using (SqlConnection conn = conexao.ObterConexao())
                {
                    conn.Open();

                    string sql = @"UPDATE veiculos 
                                  SET 
                                  marca = @marca,
                                  placa = @placa,
                                  ano = @ano,
                                  cor = @cor,
                                  modelo = @modelo 
                                  WHERE id = @id";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@marca", veiculo.Marca);
                    cmd.Parameters.AddWithValue("@modelo", veiculo.Modelo);
                    cmd.Parameters.AddWithValue("@placa", veiculo.Placa);
                    cmd.Parameters.AddWithValue("@ano", veiculo.Ano);
                    cmd.Parameters.AddWithValue("@id", veiculo.Id);
                    cmd.Parameters.AddWithValue("@cor", (object)veiculo.Cor ?? DBNull.Value);

                    cmd.ExecuteNonQuery();
                }
                return true;
            }catch(Exception ex)
            {
                mensagemErro = ex.Message;
                return false;
            }
        }

        public List<Veiculo> ListarVeiculo(out string mensagemErro)
        {
            mensagemErro = string.Empty;

            List<Veiculo> veiculo = new List<Veiculo>();

            try
            {
                using (SqlConnection conn = conexao.ObterConexao())
                {
                    conn.Open();

                    string sql = @"SELECT 
                               v.Id,
                               v.ClienteId,
                               c.Nome AS NomeCliente,
                               v.Modelo,
                               v.Marca,
                               v.Ano,
                               v.Placa,
                               v.Cor
                           FROM Veiculos v
                           LEFT JOIN Clientes c ON v.ClienteId = c.Id";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Veiculo veiculo1 = new Veiculo();
                            veiculo1.Id = Convert.ToInt32(reader["id"]);
                            veiculo1.ClienteId = Convert.ToInt32(reader["ClienteId"]);
                            veiculo1.NomeCliente = reader["NomeCliente"] != DBNull.Value ? reader["NomeCliente"].ToString() : "Cliente não encontrado";
                            veiculo1.Modelo = reader["Modelo"].ToString();
                            veiculo1.Marca = reader["Marca"].ToString();
                            veiculo1.Placa = reader["Placa"].ToString();
                            veiculo1.Ano = Convert.ToInt32(reader["Ano"]);
                            veiculo1.Cor = reader["Cor"].ToString();

                            veiculo.Add(veiculo1);
                        }
                    }
                }
                return veiculo;

            }
            catch (Exception ex)
            {
                mensagemErro = ex.Message;
                return veiculo;
            }
        }
        public Veiculo BuscarVeiculoID(int id, out string mensagemErro)
        {
            Veiculo veiculo = null;
            mensagemErro = string.Empty;

            try
            {
                using(SqlConnection conn = conexao.ObterConexao())
                {
                    conn.Open();

                    string sql = @"SELECT * FROM Veiculos WHERE id = @id";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", id);


                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            veiculo = new Veiculo
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                ClienteId = Convert.ToInt32(reader["clienteID"]),
                                Modelo = reader["modelo"].ToString(),
                                Marca = reader["marca"].ToString(),
                                Placa = reader["placa"].ToString(),
                                Ano = Convert.ToInt32(reader["ano"]),
                                Cor = reader["cor"].ToString(),
                            };
                        }
                    }
                }
                return veiculo;
            }catch(Exception ex)
            {
                mensagemErro = ex.Message;
                return veiculo;
            }
        }
    }
}
