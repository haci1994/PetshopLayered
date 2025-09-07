using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Petshop.DAL.DataContext;

namespace Petshop.DAL
{
    public static class DALServiceRegistration
    {
        public static IServiceCollection AddDALServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("Default"), options =>
                {
                    options.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName);
                }));

            services.AddScoped<DataInitializer>();

            return services;
        }
    }
}
