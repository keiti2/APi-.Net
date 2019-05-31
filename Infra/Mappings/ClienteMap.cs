using Infra.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Mappings
{
    public class ClienteMap : EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            HasKey(x => x.idCliente);
            Property(x => x.nome).HasMaxLength(100).IsRequired();
            Property(x => x.telefone).HasMaxLength(100);
            Property(x => x.convenioMedico).HasMaxLength(100);
            HasMany(x => x.Agendamento);
        }
    }
}
