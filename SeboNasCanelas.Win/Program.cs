using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using SeboNasCanelas.Win.Forms;
using SeboNasCanelas.Win.Forms.Games;
using SeboNasCanelas.Win.Forms.Magazines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SeboNasCanelas.Win.Repositories;
using SeboNasCanelas.Win.Forms.Books;
using SeboNasCanelas.Win.Repositories.Handlers;

namespace SeboNasCanelas.Win
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new HostBuilder()
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddSingleton<frmMain>();

                    services.AddDbContext<SeboNasCanelasContext>();

                    services.AddScoped<IBooksRepository, BooksRepository>();
                });

            var host = builder.Build();

            using (var serviceScope = host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;
                
                var main = services.GetRequiredService<frmMain>();
                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.EnableVisualStyles();
                //Application.SetCompatibleTextRenderingDefault(false);
                //Application.Run(new frmMain());
                Application.Run(main);
            }
        }
    }
}
