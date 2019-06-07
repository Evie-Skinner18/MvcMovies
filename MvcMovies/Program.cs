using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MvcMovies.Models;

namespace MvcMovies
{
    public class Program
    {        
        public static void Main(string[] args)
        {
            var host = CreateWebHostBuilder(args).Build();

            // try to seed the DB before running the app
            using (var scope = host.Services.CreateScope())
            {
                // I think this is the dependency injection container
                var services = scope.ServiceProvider;

                try
                {
                    var context = services.GetRequiredService<MvcMoviesContext>();
                    context.Database.Migrate();
                    SeedData.Initialise(services);
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred seeding the DB.");
                }
            }

            host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
