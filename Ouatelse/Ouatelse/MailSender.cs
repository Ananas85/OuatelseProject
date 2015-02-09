using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace Ouatelse
{
    public class MailSender
    {
        private static MailSender _instance = null;
        private static string SendersAddress = null;
        private static string SendersPassword = null;

        public static MailSender Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MailSender();
                    SendersAddress = "outelse.contact@gmail.com";
                    SendersPassword = "ouatelse";
                }
                return _instance;
            }
        }

        public void sendMail(string to, string subject, string body)
        {
            try
            {

                string ReceiversAddress = to;
                //we will use Smtp client which allows us to send email using SMTP Protocol
                //i have specified the properties of SmtpClient smtp within{}
                //gmails smtp server name is smtp.gmail.com and port number is 587
                SmtpClient smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = new NetworkCredential(SendersAddress,SendersPassword),
                    Timeout = 3000
                };

                //MailMessage represents a mail message
                //it is 4 parameters(From,TO,subject,body)

                MailMessage message = new MailMessage(SendersAddress, ReceiversAddress, subject, body);
                /*WE use smtp sever we specified above to send the message(MailMessage message)*/

                smtp.Send(message);
                Utils.Info("Message correctement envoyé");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Utils.Warning(ex.Message);
                Console.ReadKey();
            }
        }
    }
}
