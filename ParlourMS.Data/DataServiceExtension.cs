using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParlourMS.Data
{
    public static class DataServiceExtension
    {
        public static IServiceCollection AddParlourMSDataServices(this IServiceCollection services )
        {

            return services;
        }
    }
}
