using System;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Projetos.Models;
using Projetos.database;
using Projetos.Data;

namespace Projetos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            
            if(CreateDbIfnotExists(host)){
                Console.WriteLine("conexão realizada");
            }else{
                Console.WriteLine("Erro");
            }

            host.Run();
            
        }

        private static Boolean CreateDbIfnotExists(IHost host) {
            using (var scope = host.Services.CreateScope()) {
                var services = scope.ServiceProvider;

                try {
                    var context = services.GetRequiredService<DbProvider>();
                    PopulaBd  bd = new PopulaBd();
                    bd.inserir(context);
                    return true;
                }catch (Exception e){
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(e, "Erro ao criar Base de dados ");
                    return false;
                }
            }
        }


        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
