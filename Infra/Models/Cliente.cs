using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Models
{
    public class Cliente
    {
        public int idCliente { get; set; }
        public string nome { get; set; }
        public string telefone { get; set; }
        public string convenioMedico { get; set; }
        public ICollection<Agendamento> Agendamento { get; set; }

    }
}
