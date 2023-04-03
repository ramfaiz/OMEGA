using static OMEGA.Core.Global.Variables;
using OMEGA.DAL.DBContext;
using OMEGA.DAL.MigrationExtension;
using OMEGA.Core.Extensions;
using OMEGA.Repository.Mapping;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OMEGA.WebAPI.Extensions;
using log4net;

namespace OMEGA.WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            log.Info("Configuring JWT");

            services.ConfigureJWT(Configuration);

            log.Info("Configuring Swagger");

            services.ConfigureSwagger();

            log.Info("Adding controllers");

            services.AddControllers();

            log.Info("Setting automapper");

            services.AddAutoMapper(typeof(ModelToDTOMappingProfile));

            log.Info("Adding database context");

            string connectionString = Configuration.GetConnectionString("OMEGAConnectionString");

            log.Info($"Connection string = '{connectionString}'");

            services.AddDbContext<OMEGADBContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });

            log.Info("Configuring services and repositories");

            services.ConfigureServicesAndRepositories();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment() || env.IsProduction())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "OMEGA.WebAPI v1"));
            }

            log.Info("Configuring exception handler");

            app.ConfigureExceptionHandler();

            log.Info("Executing databse migration");

            app.MigrateDatabase();

            log.Info("Configuring routing");

            app.UseRouting();

            log.Info("Configuring authentication");

            app.UseAuthentication();

            log.Info("Configuring autherization");

            app.UseAuthorization();

            log.Info("Configuring URL end points");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}