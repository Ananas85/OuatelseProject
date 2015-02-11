using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.IO;
using Ouatelse.Models;

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
                    SendersAddress = "ouatelse.contact@gmail.com";
                    SendersPassword = "ouatelse";
                }
                return _instance;
            }
        }

        public void sendMail(string toList, string subject, string body)
        {
            MailMessage message = new MailMessage();
            SmtpClient smtpClient = new SmtpClient();
            try
            {
                MailAddress fromAddress = new MailAddress(SendersAddress);
                message.From = fromAddress;
                message.To.Add(new MailAddress(toList));
                message.To.Add(new MailAddress(SendersAddress));
                message.Subject = subject;
                message.IsBodyHtml = true;
                message.Body = body;
                // We use gmail as our smtp client
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.EnableSsl = true;
                smtpClient.Host = "smtp.gmail.com";
                smtpClient.Port = 587;
                smtpClient.Credentials = new System.Net.NetworkCredential(SendersAddress, SendersPassword);
                smtpClient.Send(message);
                Utils.Info("Mail envoyé avec succès");
            }
            catch (Exception ex)
            {
                Utils.Error("Mail non envoyé" + ex.Message);
            }
        }

        public void lostPassword(Employee emp)
        {
            string htmlContent = Ouatelse.Properties.Resources.forgottenPassword;
            string body = htmlContent.Replace("USERNAME", emp.Username);
            body = body.Replace("PASSWORD", emp.Password);
            body = body.Replace("EMAIL", emp.Email);
            sendMail(emp.Email, "Récupération de mot de passe", body);
        }

        public void newCustomer(Customer cust)
        {
            string htmlContent = Ouatelse.Properties.Resources.newCustomer;
            string body = htmlContent.Replace("NAME", cust.FirstName);
            body = body.Replace("SURNAME", cust.LastName);
            sendMail(cust.Email, "Bienvenue chez Ouatelse", body);
        }

        public void newEmployee(Employee emp)
        {
            string htmlContent = Ouatelse.Properties.Resources.newCustomer;
            string body = htmlContent.Replace("LASTNAME", emp.LastName);
            body = body.Replace("FIRSTNAME", emp.FirstName);
            body = body.Replace("EMAIL", emp.Email);
            body = body.Replace("STORE", emp.Store.Address);
            body = body.Replace("USERNAME", emp.Username);
            body = body.Replace("PASSWORD", emp.Password);
            sendMail(emp.Email, "Création de comte utilisateur", body);
        }

    }
}
