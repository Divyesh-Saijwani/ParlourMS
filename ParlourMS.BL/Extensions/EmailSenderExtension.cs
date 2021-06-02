using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.DependencyInjection;
using ParlourMS.BL.CoreServices;
using ParlourMS.BL.Extensions.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParlourMS.BL.Extensions
{
    /// <summary>
    /// Extension methods for adding services to an IServiceCollection
    /// </summary>
    public static class EmailSenderExtension
    {
        /// <summary>
        /// Adds services to the IServiceCollection
        /// </summary>
        /// <param name="service">IServiceCollection to add the service</param>
        private static void AddSmtpEmailService ( this IServiceCollection service )
        {
            service.AddTransient<IEmailSender , EmailSender> ();
        }

        /// <summary>
        /// Adds a singleton service to the IServiceCollection
        /// </summary>
        /// <param name="serviceCollection">IServiceCollection to add the service</param>
        /// <param name="configuration">Configuration instance</param>
        public static void AddSmtpConfig ( this IServiceCollection serviceCollection,
            Action<SmtpConfigurations> configuration )
        {
            var config = new SmtpConfigurations();
            configuration.Invoke ( config );
            serviceCollection.AddSingleton ( config );
            serviceCollection.AddSmtpEmailService ();
        }
    }
}
