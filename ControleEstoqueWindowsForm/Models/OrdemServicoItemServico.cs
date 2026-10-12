using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoqueWindowsForm.Models
{
    public class OrdemServicoItemServico
    {
        public int Id { get; set; }
        public int OrdemServicoId { get; set; }
        public int ServicoId { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
    }
}
