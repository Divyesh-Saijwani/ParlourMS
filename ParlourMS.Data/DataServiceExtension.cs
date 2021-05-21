using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ParlourMS.Data
{
    public static class DataServiceExtension
    {
        public static IServiceCollection AddParlourMSDataServices(this IServiceCollection services, string connectionString="")
        {
            services.AddDbContext<ApplicationDbContext> ( options =>
                  options.UseSqlServer ( connectionString ) );
            services.AddDatabaseDeveloperPageExceptionFilter ();
            return services;
        }
    }
}
