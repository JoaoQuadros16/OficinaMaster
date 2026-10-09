using ControleEstoqueWindowsForm.DAO;
using ControleEstoqueWindowsForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleEstoqueWindowsForm.Validacoes;

namespace ControleEstoqueWindowsForm.Services
{
    public class VeiculoService
    {
        VeiculoDAO veiculoDAO = new VeiculoDAO();

        private static bool ValidarVeiculo(Veiculo veiculo, out string mensagemErro)
        {
            // salva a placa sempre no mesmo padrão: maiúscula e sem traço
            veiculo.Placa = Formatador.FormatarPlaca(veiculo.Placa);

            mensagemErro = string.Empty;

            if (veiculo.ClienteId <= 0)
            {
                mensagemErro = "Selecione um cliente.";
                return false;
            }
            if (!Validador.ValidarPlaca(veiculo.Placa, out mensagemErro))
            {
                return false;
            }
            if (!Validador.CampoObrigatorio(veiculo.Marca, "Marca", out mensagemErro))
            {
                return false;
            }
            if (!Validador.CampoObrigatorio(veiculo.Modelo, "Modelo", out mensagemErro))
            {
                return false;
            }

            int anoMaximo = DateTime.Now.Year + 1;
            if (veiculo.Ano < 1950 || veiculo.Ano > anoMaximo)
            {
                mensagemErro = "Ano inválido. Informe um ano entre 1950 e " + anoMaximo + ".";
                return false;
            }
            return true;
        }

        public bool CadastrarVeiculo(Veiculo veiculo, out string mensagemErro)
        {
            if (!ValidarVeiculo(veiculo, out mensagemErro))
            {
                return false;
            }
            bool sucesso = veiculoDAO.CadastrarVeiculo(veiculo, out mensagemErro);

            return sucesso;
        }
        public bool EditarVeiculo(Veiculo veiculo, out string mensagemErro)
        {
            if (!ValidarVeiculo(veiculo, out mensagemErro))
            {
                return false;
            }

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
        public List<Veiculo> PesquisarComponentesVeiculos(string pesquisa, out string mensagemErro)
        {
            return veiculoDAO.PesquisarComponentesVeiculos(pesquisa, out mensagemErro);
        }
    }
}
