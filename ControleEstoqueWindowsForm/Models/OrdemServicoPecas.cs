using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoqueWindowsForm.Models
{
    public class OrdemServicoPecas
    {
        public int Id { get; set; }
        public int OrdemServicoId { get; set; }
        public int ProdutoId { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorTotal
        {
            get { return Quantidade * ValorUnitario; }
        }
    }
}
