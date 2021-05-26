using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ParlourMS.Data.Repositories;
using ParlourMS.Data.Repositories.Interfaces;

namespace ParlourMS.Data
{
    public static class DataServiceExtension
    {
        public static IServiceCollection AddParlourMSDataServices(this IServiceCollection services, string connectionString="")
        {
            services.AddDbContext<ApplicationDbContext> ( options =>
                  options.UseSqlServer ( connectionString ) );
            services.AddDatabaseDeveloperPageExceptionFilter ();

            services.AddTransient<IUserRepository, UserRepository> ();

            return services;
        }
    }
}
