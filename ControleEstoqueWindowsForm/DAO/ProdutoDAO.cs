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

        public void CadastrarProduto(Produto produto)
        {
            using (SqlConnection conn = conexao.ObterConexao())
            {
                conn.Open();

                string sql = "INSERT INTO produto (nome, quantidade) VALUES (@nome, @quantidade)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@nome", produto.Nome);
                cmd.Parameters.AddWithValue("@quantidade", produto.Quantidade);

                cmd.ExecuteNonQuery();
            }
        }

        public List<Produto> ListarProdutos()
        {
            List<Produto> produtos = new List<Produto>();

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

                        produtos.Add(produto);
                    }
                }
            }

            return produtos;
        }

        public List<Produto> BuscarProduto(string pesquisa)
        {
            List<Produto> objetoProduto = new List<Produto>();

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
                        };
                        objetoProduto.Add(produto);
                    }
                }
            }

            return objetoProduto;
        }

        public void AlterarEstoque(Produto produto)
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
        }

        public void AlterarNomeProduto(Produto produto)
        {
            using (SqlConnection conn = conexao.ObterConexao())
            {
                conn.Open();

                string sql = "UPDATE produto " +
                             "SET nome = @nome " +
                             "WHERE id = @id";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@nome", produto.Nome);
                cmd.Parameters.AddWithValue("@id", produto.Id);

                cmd.ExecuteNonQuery();
            }
        }

        public void DeletarProduto(int id)
        {
            using (SqlConnection conn = conexao.ObterConexao())
            {
                conn.Open();

                string sql = "DELETE FROM produto WHERE id = @id";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
        }
    }
}