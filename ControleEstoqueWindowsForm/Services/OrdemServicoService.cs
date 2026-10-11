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
        public bool CadastrarOS(OrdemServico ordemServico, out string mensagemErro)
        {
            
            return ordemServicoDAO.CadastrarOS(ordemServico, out mensagemErro);
        }
        public List<OrdemServico> ListarOrdensServico(out string mensagemErro) 
        {
            return ordemServicoDAO.ListarOrdensServico(out mensagemErro);
        }
    }
}
