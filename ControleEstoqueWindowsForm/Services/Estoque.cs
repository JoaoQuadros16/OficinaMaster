using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEstoqueWindowsForm
{
    public class Estoque
    {
        ProdutoDAO dao = new ProdutoDAO();
        public void CadastrarProduto(Produto produto)
        {
            dao.CadastrarProduto(produto);
        }
        public List<Produto> ListarProdutos()
        {
            return dao.ListarProdutos();
        }

        public List<Produto> BuscarProduto(string pesquisa)
        {
           return dao.BuscarProduto(pesquisa);
        }
        public void AlterarEstoque(Produto produto)
        {
            dao.AlterarEstoque(produto);
        }
        public void AlterarNomeProduto(Produto produto)
        {
            dao.AlterarNomeProduto(produto);
        }

        public void DeletarProduto(int id)
        {
            dao.DeletarProduto(id);
        }
    }               
}
