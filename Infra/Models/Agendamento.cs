using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Models
{
    public class Agendamento
    {
        public int idConsulta { get; set; }
        public DateTime dataConsulta { get; set; }
        public string situacao { get; set; }
        public string descricao { get; set; }

    }
}
