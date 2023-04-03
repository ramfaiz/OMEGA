using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OMEGA.DAL.DBContext;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;


namespace OMEGA.DAL.MigrationExtension
{
   public static class MigrationManager
	{
		public static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

		public static IApplicationBuilder MigrateDatabase(this IApplicationBuilder application)
		{
			using (var scope = application.ApplicationServices.CreateScope())
			{
				using (var context = scope.ServiceProvider.GetRequiredService<OMEGADBContext>())
				{
					try
					{
						log.Info("Database migration started");

						context.Database.Migrate();

						Console.WriteLine("Migrated Succesfully");

						log.Info("Database migration completed");
					}
					catch (Exception ex)
					{
						log.Error($"Exception caught. Exception: {ex.Message}");

						if (ex.InnerException != null)
						{
							log.Error($"Details: {ex.InnerException.Message}");
						}
					}

				}
			}

			return application;
		}
	}
}
