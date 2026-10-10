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
        public bool CadastrarOS(OrdemServico ordemServico, out string mensagemErro)
        {
            OrdemServicoDAO ordemServicoDAO = new OrdemServicoDAO();
            return ordemServicoDAO.CadastrarOS(ordemServico, out mensagemErro);
        }
    }
}
