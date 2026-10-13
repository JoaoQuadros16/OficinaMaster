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

        public List<OrdemServico> ListarOrdensServico(out string mensagemErro)
        {
            return ordemServicoDAO.ListarOrdensServico(out mensagemErro);
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