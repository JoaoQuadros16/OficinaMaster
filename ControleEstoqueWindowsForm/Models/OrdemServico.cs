using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoqueWindowsForm.Models
{
    public class OrdemServico
    {
        public int Id { get; set; }

        public int ClienteId { get; set; }

        public int VeiculoId { get; set; }

        public string ClienteNome { get; set; }
        public string VeiculoDescricao { get; set; }

        public string DescricaoProblema { get; set; }

        public DateTime DataAbertura { get; set; }

        public DateTime? DataFinalizacao { get; set; }
        public string Status { get; set; }

        // soma dos serviços + peças, preenchido pela listagem
        public decimal ValorTotal { get; set; }
    }
}