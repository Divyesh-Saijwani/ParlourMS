using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParlourMS.BL.Extensions.Configurations
{
    public class SmtpConfigurations
    {
        public string Server { get; set; }

        public int Port { get; set; }

        public bool EnableSsl { get; set; }

        public bool UseDefaultCredentials { get; set; }
        public string FromDisplayName { get; set; }

        public string FromAddress { get; set; }

        public string Password { get; set; }

        public string Domain { get; set; }
    }
}
