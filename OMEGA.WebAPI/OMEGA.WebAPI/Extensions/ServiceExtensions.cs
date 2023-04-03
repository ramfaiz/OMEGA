using OMEGA.Core.Repositories;
using OMEGA.Core.Services;
using OMEGA.Repository;
using OMEGA.Services;
using OMEGA.Core.Models;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Text;

namespace OMEGA.WebAPI.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureServicesAndRepositories(this IServiceCollection services)
        {
            services.AddScoped<IJwtAuthService, JwtAuthService>();

            services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();

            services.AddScoped<ILoginService, LoginService>();
            services.AddScoped<ILoginRepository, LoginRepository>();

            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IOrderRepository, OrderRepository>();

            //services.AddScoped<IQuestionRepository, QuestionRepository>();
            //services.AddScoped<IQuestionService, QuestionService>();

            //services.AddScoped<IVisitorLogRepository, VisitorLogRepository>();
            //services.AddScoped<IVisitorLogService, VisitorLogService>();
        }
        public static void ConfigureJWT(this IServiceCollection services, IConfiguration config)
        {
            var jwtConfiguration = config.GetSection("JwtConfiguration").Get<JwtConfiguration>();

            services.AddSingleton(jwtConfiguration);

            services.AddAuthentication(opt =>
            {

                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;

                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

            })
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidIssuer = jwtConfiguration.Issuer,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(jwtConfiguration.Secret)),
                    ValidAudience = jwtConfiguration.Audience,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.FromMinutes(1)
                };
            });
        }



        public static void ConfigureSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(swagger =>
            {
                swagger.SwaggerDoc("v1", new OpenApiInfo { Title = "OMEGA.WebAPI", Version = "v1" });

                swagger.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Description = "Enter 'Bearer' [space] and then your valid Token in the text input below.\r\n\r\nExample: \"Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9\"",
                });


                swagger.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                        }
                    },
                    new string[] {}
                    }
                });
            });
        }
    }
}
