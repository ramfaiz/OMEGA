using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.AspNetCore.Http;
using System.Text;
using System.Threading.Tasks;
using static OMEGA.Core.Global.Functions;
using static OMEGA.Core.Global.Variables;

namespace OMEGA.Core.Global
{
    public static class Functions
    {
        public static void SetApplicationLog()
        {
            var repository = log4net.LogManager.GetRepository(Assembly.GetCallingAssembly());
            var sExecutablePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string sConfig = string.Format("{0}\\log4net.config", sExecutablePath);
            var fileInfo = new FileInfo(sConfig);
            log4net.Config.XmlConfigurator.Configure(repository, fileInfo);
        }

        public static void LogRequest(HttpRequest Request)
        {
            log.Info($"Processing {Request.Scheme}://{Request.Host}{Request.PathBase}{Request.Path}");

            if (Request.QueryString.HasValue == true)
            {
                log.Info($"Query String: {Request.QueryString.Value}");
            }
        }
    }
}
