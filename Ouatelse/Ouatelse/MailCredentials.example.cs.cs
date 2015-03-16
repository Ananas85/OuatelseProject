using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouatelse
{
    class MailCredentials
    {
        public static string SMTPServer { get { return "mail.ouatelse.fr"; } }
        public static string Username { get { return "contact@ouatelse.fr"; } }
        public static string Password { get { return ""; } }
        public static Int32 Port { get { return 587; } }
    }
}
