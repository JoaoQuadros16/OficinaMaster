using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoqueWindowsForm
{
    public class Veiculo
    {
        public int Id { get; set; }

        public int ClienteId { get; set; }
        public string NomeCliente { get; set; }
        public string Modelo { get; set; }

        public string Marca { get; set; }

        public int Ano { get; set; }

        public string Placa { get; set; }

        public string Cor { get; set; }
    }
}
