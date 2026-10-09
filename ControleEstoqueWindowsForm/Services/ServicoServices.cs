using ControleEstoqueWindowsForm.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleEstoqueWindowsForm.Models;
using ControleEstoqueWindowsForm.Validacoes;
using System.Data.SqlClient;

namespace ControleEstoqueWindowsForm.Services
{
    public class ServicoServices
    {
        ServicoDAO servicoDAO = new ServicoDAO();

        private static bool ValidarServico(Servico servico, out string mensagemErro)
        {
            mensagemErro = string.Empty;

            if (!Validador.CampoObrigatorio(servico.Descricao, "Descrição", out mensagemErro))
            {
                return false;
            }
            return true;
        }

        public bool CadastrarServico(Servico servico, out string mensagemErro)
        {
            mensagemErro = string.Empty;

            if(!ValidarServico(servico, out mensagemErro))
            {
                return false;
            }
            bool sucesso =  servicoDAO.CadastrarServico(servico, out mensagemErro);

            return sucesso;
        }
        public List<Servico> ListarServicos(out string mensagemErro)
        {
            mensagemErro = string.Empty;
            return servicoDAO.ListarServicos(out mensagemErro);
        }

        public List<Servico> ListarServicosAtivoseInativos(out string mensagemErro)
        {
            mensagemErro = string.Empty;
            return servicoDAO.ListarServicosAtivoseInativos(out mensagemErro);
        }
        public List<Servico> PesuqisarServicos(string pesquisar,bool mostrarInativo, out string mensagemErro)
        {
            return servicoDAO.PesquisarServicos(pesquisar,mostrarInativo, out mensagemErro);
        }

        public bool EditarServico(Servico servico, out string mensagemErro)
        {
            mensagemErro = string.Empty;
            if (!ValidarServico(servico, out mensagemErro))
            {
                return false;
            }
            bool sucesso = servicoDAO.EditarServico(servico, out mensagemErro);
            return sucesso;
        }
    }
}
