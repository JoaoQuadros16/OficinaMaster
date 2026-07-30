using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleEstoqueWindowsForm.DAO;
using ControleEstoqueWindowsForm.Models;
using MySqlConnector;

namespace ControleEstoqueWindowsForm.Services
{
    public class ClienteService
    {
        private ClienteDAO clienteDAO = new ClienteDAO();

        public int CadastrarCliente(Cliente cliente)
        {
            return clienteDAO.CadastrarCliente(cliente);
        }
        public List<Cliente> ListarClientes()
        {
            return clienteDAO.ListarClientes();
        }
        public List<Cliente> PesquisarCliente(string pesquisa)
        {
            return clienteDAO.PesquisarCliente(pesquisa);
        }
        public void AlterarCliente(Cliente cliente)
        {
            clienteDAO.EditarCliente(cliente);
        }
        public Cliente BuscarIDCliente(int id)
        {
            return clienteDAO.BuscarClienteID(id);
        }

        public void DeletarCliente(int id)
        {
            clienteDAO.ExcluirCliente(id);
        }
    }
}
