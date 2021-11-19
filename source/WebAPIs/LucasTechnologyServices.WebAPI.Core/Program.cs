using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

<<<<<<< HEAD:LTS.Solution/Adapters/Driving/Crm/LTS.Services.Crm.API/Program.cs
namespace LTS.Services.Crm.API
=======
namespace LucasTechnologyServices.WebAPI.Core
>>>>>>> origin/dev:source/WebAPIs/LucasTechnologyServices.WebAPI.Core/Program.cs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
