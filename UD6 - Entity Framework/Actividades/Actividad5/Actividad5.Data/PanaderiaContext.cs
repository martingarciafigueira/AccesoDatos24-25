using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad5.Data
{
    public partial class PanaderiaContext : DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Panaderia> Panaderias { get; set; }
        public DbSet<PanaderiaProducto> PanaderiasProductos { get; set; }

        public PanaderiaContext(DbContextOptions<PanaderiaContext> options)
           : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuración de la tabla intermedia
            modelBuilder.Entity<PanaderiaProducto>()
                .HasKey(pp => new { pp.PanaderiaId, pp.ProductoId }); // Clave compuesta

            modelBuilder.Entity<PanaderiaProducto>()
                .HasOne(pp => pp.Panaderia)
                .WithMany(p => p.PanaderiasProductos)
                .HasForeignKey(pp => pp.PanaderiaId);

            modelBuilder.Entity<PanaderiaProducto>()
                .HasOne(pp => pp.Producto)
                .WithMany(p => p.PanaderiasProductos)
                .HasForeignKey(pp => pp.ProductoId);
        }

    }
}
