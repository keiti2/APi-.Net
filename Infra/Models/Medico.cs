using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Models
{
    public class Medico
    {
        public int idMedico { get; set; }
        public string nome { get; set; }
        public string telefone { get; set; }
        public string especialidade { get; set; }
        public ICollection<Agendamento> Agendamento { get; set; }
    }
}
