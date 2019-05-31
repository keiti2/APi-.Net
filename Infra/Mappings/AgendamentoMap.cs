using Infra.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Mappings
{
    public class AgendamentoMap : EntityTypeConfiguration<Agendamento>
    {
        public AgendamentoMap()
        {
            HasKey(x => x.idConsulta);
            Property(x => x.dataConsulta).IsRequired();
            Property(x => x.situacao).HasMaxLength(20);
            Property(x => x.descricao).HasMaxLength(20);
        }
    }
}
