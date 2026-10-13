using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleEstoqueWindowsForm.DAO;
using ControleEstoqueWindowsForm.Models;
using ControleEstoqueWindowsForm.Validacoes;

namespace ControleEstoqueWindowsForm.Services
{
    public class OrdemServicoService
    {
        OrdemServicoDAO ordemServicoDAO = new OrdemServicoDAO();

        public int CadastrarOS(OrdemServico ordemServico, out string mensagemErro)
        {
            return ordemServicoDAO.CadastrarOS(ordemServico, out mensagemErro);
        }

        public List<OrdemServico> ListarOrdensServico(string pesquisa, DateTime inicio, DateTime fim, out string mensagemErro)
        {
            if (inicio.Date > fim.Date)
            {
                mensagemErro = "A data inicial não pode ser maior que a data final.";
                return new List<OrdemServico>();
            }

            return ordemServicoDAO.ListarOrdensServico(pesquisa.Trim(), inicio, fim, out mensagemErro);
        }

        public OrdemServico ObterObterPorId(int id, out string mensagemErro)
        {
            return ordemServicoDAO.ObterPorId(id, out mensagemErro);
        }

        public bool AtualizarOS(OrdemServico ordem, List<OrdemServicoItemServico> servicos,
                                List<OrdemServicoPecas> pecas, out string mensagemErro)
        {
            return ordemServicoDAO.AtualizarOS(ordem, servicos, pecas, out mensagemErro);
        }

        public bool IniciarOS(int idOrdem, out string mensagemErro)
        {
            return ordemServicoDAO.AlterarStatus(idOrdem, "EM ANDAMENTO", out mensagemErro);
        }

        // Cancelar não mexe no estoque: a baixa só acontece no Finalizar
        public bool CancelarOS(int idOrdem, out string mensagemErro)
        {
            return ordemServicoDAO.AlterarStatus(idOrdem, "CANCELADA", out mensagemErro);
        }

        // Regra: só finaliza OS que tenha pelo menos um serviço ou uma peça
        public bool FinalizarOS(int idOrdem, List<OrdemServicoItemServico> servicos,
                                List<OrdemServicoPecas> pecas, out string mensagemErro)
        {
            if (servicos.Count == 0 && pecas.Count == 0)
            {
                mensagemErro = "Adicione pelo menos um serviço ou uma peça antes de finalizar.";
                return false;
            }

            return ordemServicoDAO.FinalizarOS(idOrdem, out mensagemErro);
        }

        public List<OrdemServicoItemServico> ListarServicosDaOS(int idOrdem, out string mensagemErro)
        {
            return ordemServicoDAO.ListarServicosDaOS(idOrdem, out mensagemErro);
        }

        public List<OrdemServicoPecas> ListarPecasOS(int idOrdem, out string mensagemErro)
        {
            return ordemServicoDAO.ListarPecasOS(idOrdem, out mensagemErro);
        }
    }
}