using Entities.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RepositoryEFCore.DataContext;
using RepositoryEFCore.Repositories;

namespace RepositoryEFCore
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services, 
            IConfiguration configuration)
        {
            services.AddDbContext<Context>(options
                => options.UseSqlServer(configuration.GetConnectionString("sqlConection")));

            services.AddScoped<IProductRepository, ProductRepository>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;

        }
    }
}
