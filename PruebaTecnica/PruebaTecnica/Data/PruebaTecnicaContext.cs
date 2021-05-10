using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PruebaTecnica.Models;

namespace PruebaTecnica.Data
{
    public class PruebaTecnicaContext : DbContext
    {
        public PruebaTecnicaContext (DbContextOptions<PruebaTecnicaContext> options)
            : base(options)
        {
        }

        public DbSet<PruebaTecnica.Models.Cliente> Cliente { get; set; }

        public DbSet<PruebaTecnica.Models.Producto> Producto { get; set; }

        public DbSet<PruebaTecnica.Models.Compra> Compra { get; set; }

        public DbSet<PruebaTecnica.Models.Factura> Factura { get; set; }
    }
}
