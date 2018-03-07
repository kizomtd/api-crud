using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estudo.Models
{
    public class EstudoContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        public EstudoContext(DbContextOptions<EstudoContext> options):base(options) { }
    }
}
