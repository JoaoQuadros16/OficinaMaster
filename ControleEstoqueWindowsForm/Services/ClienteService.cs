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
    public class ClienteService
    {
        private ClienteDAO clienteDAO = new ClienteDAO();

        private static bool ValidarCliente(Cliente cliente, out string mensagemErro)
        {
            // salva só os números no banco; a tela formata ao exibir
            cliente.Cpf = Formatador.SomenteNumeros(cliente.Cpf);
            cliente.Telefone = Formatador.SomenteNumeros(cliente.Telefone);

            if (!Validador.CampoObrigatorio(cliente.Nome, "Nome", out mensagemErro))
            {
                return false;
            }
            if (!Validador.ValidarNome(cliente.Nome, out mensagemErro))
            {
                return false;
            }
            if (!Validador.ValidarCPF(cliente.Cpf, out mensagemErro))
            {
                return false;
            }
            if (!Validador.CampoObrigatorio(cliente.Telefone, "Telefone", out mensagemErro))
            {
                return false;
            }
            if (!Validador.ValidarTelefone(cliente.Telefone, out mensagemErro))
            {
                return false;
            }
            // e-mail é opcional: só valida se foi preenchido
            if (!string.IsNullOrWhiteSpace(cliente.Email))
            {
                if (!Validador.ValidarEmail(cliente.Email, out mensagemErro))
                {
                    return false;
                }
            }
            return true;
        }

        public int CadastrarCliente(Cliente cliente, out string mensagemErro)
        {
            if(!ValidarCliente(cliente, out mensagemErro))
            {
                return 0;
            }
            return clienteDAO.CadastrarCliente(cliente, out mensagemErro);
        }
        public List<Cliente> ListarClientes(out string mensagemErro)
        {
            return clienteDAO.ListarClientes(out mensagemErro);
        }
        public List<Cliente> PesquisarCliente(string pesquisa, out string mensagemErro)
        {
            return clienteDAO.PesquisarCliente(pesquisa, out mensagemErro);
        }
        public bool AlterarCliente(Cliente cliente, out string mensagemErro)
        {
            if (!ValidarCliente(cliente, out mensagemErro))
            {
                return false;
            }

            bool sucesso = clienteDAO.EditarCliente(cliente, out mensagemErro);

            return sucesso;
        }
        public Cliente BuscarIDCliente(int id, out string mensagemErro)
        {
            return clienteDAO.BuscarClienteID(id, out mensagemErro);
        }

        public bool DeletarCliente(int id, out string mensagemErro)
        {
            mensagemErro = string.Empty;

            bool sucesso = clienteDAO.ExcluirCliente(id, out mensagemErro);

            return sucesso;
        }
        public List<Cliente> BuscarClienteVeiculos( out string mensagemErro)
        {
            return  clienteDAO.BuscarClienteVeiculos(out mensagemErro);
        }
    }
}
