using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleEstoqueWindowsForm.Validacoes;

namespace ControleEstoqueWindowsForm
{
    public class Estoque
    {
        ProdutoDAO dao = new ProdutoDAO();
        public bool CadastrarProduto(Produto produto, out string mensagemErro)
        {
            if (!Validador.CampoObrigatorio(produto.Nome, "Nome", out mensagemErro))
            {
                return false;
            }
            if (produto.Quantidade < 0)
            {
                mensagemErro = "A quantidade não pode ser negativa.";
                return false;
            }

            bool sucesso = dao.CadastrarProduto(produto, out mensagemErro);

            return sucesso;
        }
        public List<Produto> ListarProdutos(out string mensagemErro)
        {
            return dao.ListarProdutos(out mensagemErro);
        }

        public List<Produto> BuscarProduto(string pesquisa, out string mensagemErro)
        {
           return dao.BuscarProduto(pesquisa, out mensagemErro);
        }
        public bool AlterarEstoque(Produto produto, out string mensagemErro)
        {
            mensagemErro = string.Empty;

            // a tela envia o saldo já calculado; negativo = saída maior que o saldo
            if (produto.Quantidade < 0)
            {
                mensagemErro = "A saída não pode ser maior que o saldo em estoque.";
                return false;
            }

            bool sucesso = dao.AlterarEstoque(produto, out mensagemErro);

            return sucesso;
        }
        public bool AlterarProduto(Produto produto, out string mensagemErro)
        {
            if (!Validador.CampoObrigatorio(produto.Nome, "Nome", out mensagemErro))
            {
                return false;
            }

            bool sucesso = dao.AlterarProduto(produto, out mensagemErro);

            return sucesso;
        }

        public bool DeletarProduto(int id, out string mensagemErro)
        {
            mensagemErro = string.Empty;

            bool sucesso = dao.DeletarProduto(id, out mensagemErro);

            return sucesso;
        }
    }               
}
