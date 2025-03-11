using Actividad4.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace Actividad4
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

            // Ejecutar la aplicación con inyección de dependencias
            ApplicationConfiguration.Initialize();
            var mainForm = serviceProvider.GetRequiredService<Form1>();
            Application.Run(mainForm); 

        }

        private static IServiceCollection ConfigureServices()
        {
            var services = new ServiceCollection();

            // Cargar la configuración desde appsettings.json
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()) // Establece la ruta del archivo
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true) // Carga el archivo
                .Build();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            // Registrar el DbContext
            services.AddDbContext<PanaderiaContext>(options =>
                options.UseSqlServer(connectionString));

            // Registrar formularios
            services.AddTransient<Form1>();

            return services;
        }
    }
}