using Microsoft.AspNetCore.Identity.UI.Services;
using ParlourMS.BL.Extensions.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ParlourMS.BL.CoreServices
{
    public class EmailSender : IEmailSender
    {
        private readonly SmtpConfigurations _smtpConfiguration;
        public EmailSender ( SmtpConfigurations smtpConfiguration )
        {
            _smtpConfiguration = smtpConfiguration;
        }

        public Task SendEmailAsync ( string email, string subject, string htmlMessage )
        {
            var mail = new MailMessage()
            {
                To = { email },
                Subject = subject,
                Body = htmlMessage,
                IsBodyHtml = true
            };

            if ( mail.From == null || string.IsNullOrEmpty ( mail.From.Address ) )
            {
                mail.From = new MailAddress (
                    _smtpConfiguration.FromAddress,
                    _smtpConfiguration.FromDisplayName,
                    Encoding.UTF8
                );
            }

            using ( var smtpClient = GetSmtpClient() )
            {
                try
                {
                    return smtpClient.SendMailAsync ( mail );
                }
                catch(Exception e)
                {
                    return Task.FromResult(true);
                }
            }
        }

        private SmtpClient GetSmtpClient ()
        {
            var smtpClient = new SmtpClient(_smtpConfiguration.Server, _smtpConfiguration.Port);

            try
            {
                if ( _smtpConfiguration.EnableSsl )
                {
                    smtpClient.EnableSsl = true;
                }

                if ( _smtpConfiguration.UseDefaultCredentials )
                {
                    smtpClient.UseDefaultCredentials = true;
                }
                else
                {
                    smtpClient.UseDefaultCredentials = false;

                    var userName = _smtpConfiguration.FromAddress;
                    if ( !string.IsNullOrEmpty ( userName ) )
                    {
                        var password = _smtpConfiguration.Password;
                        var domain = _smtpConfiguration.Domain;
                        smtpClient.Credentials = !string.IsNullOrEmpty ( domain )
                            ? new NetworkCredential ( userName, password, domain )
                            : new NetworkCredential ( userName, password );
                    }
                }

                return smtpClient;
            }
            catch
            {
                smtpClient.Dispose ();
                throw;
            }
        }
    }
}
