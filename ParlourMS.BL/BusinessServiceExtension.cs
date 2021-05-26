using Microsoft.Extensions.DependencyInjection;
using ParlourMS.BL.Services;
using ParlourMS.BL.Services.Interfaces;

namespace ParlourMS.BL
{
    public static class BusinessServiceExtension
    {
        public static IServiceCollection AddParlourMSBusinessServices ( this IServiceCollection services )
        {
            services.AddTransient<IUserService, UserService> ();


            return services;
        }
    }
}
