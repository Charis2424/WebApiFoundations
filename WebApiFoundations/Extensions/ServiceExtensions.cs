using Database;
using RepoInterfaces;
using Repositories;
using Service.Interfaces;
using Services;

namespace WebApiFoundations.Extensions
{
    public static class ServiceExtensions
    {
        // DI Container of Services and Repositories
        public static void ConfigureServiceManager (this IServiceCollection services) 
        {
            services.AddScoped<IServiceManager,ServiceManager>();
        }

        public static void ConfigureRepositoryManager(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryManager, RepositoryManager>();
        }

        //public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) =>
        //   services.AddSqlServer<AppDbContext>(configuration.GetConnectionString("sqlConnection"));

        public static void ConfigureCORS(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                {
                    builder.AllowAnyOrigin(); // allow requests from any domain, so need to define specific url for security
                    builder.AllowAnyMethod(); // allows requests with any HTTP method (GET, POST, PUT, DELETE, etc.)
                    builder.AllowAnyHeader();
                });
            }
            );

        }
    }
}
