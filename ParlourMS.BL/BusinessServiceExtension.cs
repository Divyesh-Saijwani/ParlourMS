using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParlourMS.BL
{
    public static class BusinessServiceExtension
    {
        public static IServiceCollection AddParlourMSBusinessServices ( this IServiceCollection services )
        {

            return services;
        }
    }
}
