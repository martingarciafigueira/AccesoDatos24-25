using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad5.Data
{
    public class PanaderiaContextFactory : IDesignTimeDbContextFactory<PanaderiaContext>
    {
        public PanaderiaContext CreateDbContext(string[] args)
        {
            // Construir la configuración manualmente para tiempo de diseño
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()) // Ubicación del appsettings.json
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            // Obtener la cadena de conexión
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            // Configurar DbContextOptions con SQL Server
            var optionsBuilder = new DbContextOptionsBuilder<PanaderiaContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new PanaderiaContext(optionsBuilder.Options);
        }
    }
}
