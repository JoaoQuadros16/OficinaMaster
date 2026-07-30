using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleEstoqueWindowsForm.Models;
using System.Security.Cryptography;

namespace ControleEstoqueWindowsForm.DAO
{
    public class ClienteDAO
    {
        private Conexao conexao = new Conexao();

        public int CadastrarCliente(Cliente cliente)
        {
            using (SqlConnection conn = conexao.ObterConexao())
            {
                conn.Open();
                string sql = @"INSERT INTO clientes
                           (nome, cpf, telefone, email)
                           VALUES
                           (@nome, @cpf, @telefone, @email);
                            SELECT CAST(SCOPE_IDENTITY() AS INT);";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@nome", cliente.Nome);
                cmd.Parameters.AddWithValue("@cpf", cliente.Cpf);
                cmd.Parameters.AddWithValue("@telefone", cliente.Telefone);
                cmd.Parameters.AddWithValue("@email", cliente.Email);

                int novoId = Convert.ToInt32(cmd.ExecuteScalar());
                return novoId;
            }
        }

        public List<Cliente> ListarClientes()
        {
            List<Cliente> cliente = new List<Cliente>();

            using (SqlConnection conn = conexao.ObterConexao())
            {
                conn.Open();

                string sql = @"SELECT c.id, c.nome, c.cpf, c.telefone, c.email,
                      STRING_AGG(v.modelo + ' (' + CAST(v.ano AS VARCHAR(4)) + ')', ', ') AS VeiculosResumo
                      FROM clientes c
                      LEFT JOIN Veiculos v ON v.ClienteId = c.id
                      GROUP BY c.id, c.nome, c.cpf, c.telefone, c.email";

                SqlCommand cmd = new SqlCommand(sql, conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Cliente cliente1 = new Cliente();
                        cliente1.Id = Convert.ToInt32(reader["id"]);
                        cliente1.Nome = reader["nome"].ToString();
                        cliente1.Cpf = reader["cpf"].ToString();
                        cliente1.Telefone = reader["telefone"].ToString();
                        cliente1.Email = reader["email"].ToString();
                        cliente1.VeiculosResumo = reader["VeiculosResumo"] == DBNull.Value
                            ? ""
                            : reader["VeiculosResumo"].ToString();

                        cliente.Add(cliente1);
                    }
                }
            }
            return cliente;
        }

        public List<Cliente> PesquisarCliente(string pesquisa)
        {
            List<Cliente> cliente = new List<Cliente>();

            using (SqlConnection conn = conexao.ObterConexao())
            {
                conn.Open();

                // CAST necessário: SQL Server não permite LIKE direto em coluna INT (diferente do MySQL, que converte automaticamente)
                string sql = @"SELECT * FROM clientes 
                              WHERE CAST(id AS NVARCHAR(20)) LIKE @pesquisa
                              OR nome LIKE @pesquisa
                              OR cpf LIKE @pesquisa";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@pesquisa", "%" + pesquisa + "%");

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Cliente cliente1 = new Cliente
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Nome = reader["nome"].ToString(),
                            Cpf = reader["cpf"].ToString(),
                            Telefone = reader["telefone"].ToString(),
                            Email = reader["email"].ToString(),
                        };
                        cliente.Add(cliente1);
                    }
                }
            }
            return cliente;
        }

        public Cliente BuscarClienteID(int id)
        {
            Cliente cliente = null;

            using (SqlConnection conn = conexao.ObterConexao())
            {
                conn.Open();

                string sql = @"SELECT * FROM clientes 
                        WHERE id = @id";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        cliente = new Cliente
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Nome = reader["nome"].ToString(),
                            Cpf = reader["cpf"].ToString(),
                            Telefone = reader["telefone"].ToString(),
                            Email = reader["email"].ToString(),
                        };
                    }
                }
            }
            return cliente;
        }

        public List<Cliente> BuscarClienteVeiculos(out string mensagemErro)
        {
            List<Cliente> cliente = new List<Cliente>();
            mensagemErro = string.Empty;

            try
            {
                using (SqlConnection conn = conexao.ObterConexao())
                {
                    conn.Open();

                    string sql = @"SELECT id,nome,cpf FROM clientes ";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Cliente cliente1 = new Cliente();

                            cliente1.Id = Convert.ToInt32(reader["id"]);
                            cliente1.Nome = reader["nome"].ToString();
                            cliente1.Cpf = reader["cpf"].ToString();

                            cliente.Add(cliente1);
                        }
                    }
                }
                return cliente;
            }
            catch (Exception ex)
            {
                mensagemErro = ex.Message;
                return cliente;
            }
        }

        public void EditarCliente(Cliente cliente)
        {
            using (SqlConnection conn = conexao.ObterConexao())
            {
                conn.Open();

                string sql = @"UPDATE clientes 
                        SET nome = @nome,
                        cpf = @cpf,
                        email = @email,
                        telefone = @telefone,
                        WHERE id = @id";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nome", cliente.Nome);
                cmd.Parameters.AddWithValue("@cpf", cliente.Cpf);
                cmd.Parameters.AddWithValue("@email", cliente.Email);
                cmd.Parameters.AddWithValue("@telefone", cliente.Telefone);
                cmd.Parameters.AddWithValue("@id", cliente.Id);

                cmd.ExecuteNonQuery();
            }
        }

        public void ExcluirCliente(int id)
        {
            using (SqlConnection conn = conexao.ObterConexao())
            {
                conn.Open();
                string sql = "DELETE FROM clientes WHERE id = @id";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
        }
    }
}