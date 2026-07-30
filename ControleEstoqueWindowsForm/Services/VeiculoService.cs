using ControleEstoqueWindowsForm.DAO;
using ControleEstoqueWindowsForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoqueWindowsForm.Services
{
    public class VeiculoService
    {
        VeiculoDAO veiculoDAO = new VeiculoDAO();

        public bool CadastrarVeiculo(Veiculo veiculo, out string mensagemErro)
        {
            mensagemErro = string.Empty;

            if (veiculo.ClienteId <= 0)
            {
                mensagemErro = "Selecione um cliente.";
                return false;
            }
            bool sucesso = veiculoDAO.CadastrarVeiculo(veiculo, out mensagemErro);

            return sucesso;
        }
        public bool EditarVeiculo(Veiculo veiculo, out string mensagemErro)
        {
            mensagemErro = string.Empty;

            bool sucesso = veiculoDAO.EditarVeiculo(veiculo,out mensagemErro);

            return sucesso;
        }
        public List<Veiculo> ListarVeiculo(out string mensagemErro)
        {
            return veiculoDAO.ListarVeiculo(out mensagemErro);
        }
        public Veiculo BuscarVeiculoID(int id, out string mensagemErro)
        {
            return veiculoDAO.BuscarVeiculoID(id, out mensagemErro);
        }
        public List<Veiculo> PesquisarNomeCliente(string NomeCliente, out string mensagemErro)
        {
            return veiculoDAO.PesquisarNomeCliente(NomeCliente, out mensagemErro);
        }
    }
}
