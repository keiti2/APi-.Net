using Infra.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Mappings
{
    class MedicoMap: EntityTypeConfiguration<Medico>
    {
        public MedicoMap()
        {
            HasKey(x => x.idMedico);
            Property(x => x.nome).HasMaxLength(100).IsRequired();
            Property(x => x.telefone).HasMaxLength(100);
            Property(x => x.especialidade).HasMaxLength(100).IsRequired();
            HasMany(x => x.Agendamento);
        }
    }
}
