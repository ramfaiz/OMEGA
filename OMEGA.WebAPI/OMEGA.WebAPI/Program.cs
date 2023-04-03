using log4net;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static OMEGA.Core.Global.Functions;
using static OMEGA.Core.Global.Variables;
namespace OMEGA.WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SetApplicationLog();
            log.Info("");
            log.Info("Application starting");
            CreateHostBuilder(args).Build().Run();
            log.Info("Application exiting");
            log.Info("");
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
