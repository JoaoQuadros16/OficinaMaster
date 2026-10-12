using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoqueWindowsForm
{
    public class ProdutoDAO
    {
        Conexao conexao = new Conexao();

        public bool CadastrarProduto(Produto produto, out string mensagemErro)
        {
            mensagemErro = string.Empty;

            try
            {
                using (SqlConnection conn = conexao.ObterConexao())
                {
                    conn.Open();

                    string sql = "INSERT INTO produto (nome, quantidade,valor) " +
                        "VALUES (@nome, @quantidade,@valor)";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@nome", produto.Nome);
                    cmd.Parameters.AddWithValue("@quantidade", produto.Quantidade);
                    cmd.Parameters.AddWithValue("@valor", produto.Valor);

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

        public List<Produto> ListarProdutos(out string mensagemErro)
        {
            mensagemErro = string.Empty;
            List<Produto> produtos = new List<Produto>();

            try
            {
                using (SqlConnection conn = conexao.ObterConexao())
                {
                    conn.Open();

                    string sql = "SELECT * FROM produto";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Produto produto = new Produto();

                            produto.Id = Convert.ToInt32(reader["id"]);
                            produto.Nome = reader["nome"].ToString();
                            produto.Quantidade = Convert.ToInt32(reader["quantidade"]);
                            produto.Valor = Convert.ToDecimal(reader["valor"]);

                            produtos.Add(produto);
                        }
                    }
                }
                return produtos;
            }
            catch (Exception ex)
            {
                mensagemErro = ex.Message;
                return produtos;
            }
        }

        public List<Produto> BuscarProduto(string pesquisa, out string mensagemErro)
        {
            mensagemErro = string.Empty;
            List<Produto> objetoProduto = new List<Produto>();

            try
            {
                using (SqlConnection conn = conexao.ObterConexao())
                {
                    conn.Open();

                    // CAST necessário: SQL Server não permite LIKE direto em coluna INT (diferente do MySQL, que converte automaticamente)
                    string sql = "SELECT * FROM produto " +
                                 "WHERE CAST(id AS NVARCHAR(20)) LIKE @pesquisa " +
                                 "OR nome LIKE @pesquisa";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@pesquisa", "%" + pesquisa + "%");

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Produto produto = new Produto
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                Nome = reader["nome"].ToString(),
                                Quantidade = Convert.ToInt32(reader["quantidade"]),
                                Valor = Convert.ToDecimal(reader["valor"])
                            };
                            objetoProduto.Add(produto);
                        }
                    }
                }
                return objetoProduto;
            }
            catch (Exception ex)
            {
                mensagemErro = ex.Message;
                return objetoProduto;
            }
        }

        public bool AlterarEstoque(Produto produto, out string mensagemErro)
        {
            mensagemErro = string.Empty;

            try
            {
                using (SqlConnection conn = conexao.ObterConexao())
                {
                    conn.Open();

                    string sql = "UPDATE produto " +
                                 "SET quantidade = @quantidade " +
                                 "WHERE id = @id";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@quantidade", produto.Quantidade);
                    cmd.Parameters.AddWithValue("@id", produto.Id);

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

        public bool AlterarProduto(Produto produto, out string mensagemErro)
        {
            mensagemErro = string.Empty;

            try
            {
                using (SqlConnection conn = conexao.ObterConexao())
                {
                    conn.Open();

                    string sql = "UPDATE produto " +
                                 "SET nome = @nome, " +
                                 "    valor = @valor " +
                                 "WHERE id = @id";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@nome", produto.Nome);
                    cmd.Parameters.AddWithValue("@id", produto.Id);
                    cmd.Parameters.AddWithValue("@valor", produto.Valor);

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

        public bool DeletarProduto(int id, out string mensagemErro)
        {
            mensagemErro = string.Empty;

            try
            {
                using (SqlConnection conn = conexao.ObterConexao())
                {
                    conn.Open();

                    string sql = "DELETE FROM produto WHERE id = @id";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@id", id);

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
