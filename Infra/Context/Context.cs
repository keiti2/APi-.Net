using Infra.Mappings;
using Infra.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Context
{
    public class Context : DbContext
    {
        public Context() : base(@"Data Source=spac.database.windows.net;Initial Catalog=Spac;User ID=spac;Password=pacoquinh@123;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {

        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Agendamento> Agendamento { get; set; }
        public DbSet<Medico> Medico { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ClienteMap());
            modelBuilder.Configurations.Add(new AgendamentoMap());
            modelBuilder.Configurations.Add(new MedicoMap());
        }

    }
}
