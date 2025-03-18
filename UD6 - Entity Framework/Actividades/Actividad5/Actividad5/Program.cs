using Actividad5.Data;
using Actividad5.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Actividad5
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Configurar servicios
            var services = ConfigureServices();

            // Crear un proveedor de servicios
            var serviceProvider = services.BuildServiceProvider();

            // Ejecutar la aplicaci�n con inyecci�n de dependencias
            ApplicationConfiguration.Initialize();
            var mainForm = serviceProvider.GetRequiredService<Form1>();
            Application.Run(mainForm); 

        }

        private static IServiceCollection ConfigureServices()
        {
            var services = new ServiceCollection();

            // Cargar la configuraci�n desde appsettings.json
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()) // Establece la ruta del archivo
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true) // Carga el archivo
                .Build();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            // Registrar el DbContext
            services.AddDbContext<PanaderiaContext>(options =>
                options.UseSqlServer(connectionString));

            // Inyecci�n de dependencias
            services.AddScoped<IProductoService, ProductoService>();
            services.AddScoped<IPanaderiaService, PanaderiaService>();
            services.AddScoped<IPanaderiaProductoService, PanaderiaProductoService>();



            // Registrar formularios
            services.AddScoped<Form1>();

            return services;
        }
    }
}