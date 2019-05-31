using Infra.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repository
{
    public class ClienteRepository
    {
        private readonly Context.Context _context = new Context.Context();

        public async Task<IEnumerable<Cliente>> GetAllCliente()
        {
            return await _context.Cliente.ToListAsync();
        }

    }
}
