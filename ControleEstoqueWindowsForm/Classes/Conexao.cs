using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoqueWindowsForm
{
    public class Conexao
    {
        private string conexao = "Server=localhost;Database=OficinaMasterDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public SqlConnection ObterConexao()
        {
            return new SqlConnection(conexao);
        }
    }
}