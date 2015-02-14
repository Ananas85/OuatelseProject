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
    /// <summary>
    /// Classe static singleton qui permet l'envoie de mail
    /// </summary>
    public class MailSender
    {
        #region Les attributs de la classe
        /// <summary>
        /// l'instance qui pourra être utilisée pour utiliser la classe
        /// </summary>
        private static MailSender _instance = null;

        /// <summary>
        /// L'adresse d'envoi
        /// </summary>
        private static string SendersAddress = null;

        /// <summary>
        /// Le mot de passe de l'adresse
        /// </summary>
        private static string SendersPassword = null;
        #endregion

        #region Implémentation du pattern Singleton
        /// <summary>
        /// Implémentation du pattern singleton
        /// </summary>
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
        #endregion

        #region Gestion de l'envoi de mail
        /// <summary>
        /// La méthode qui permet d'envoyer des mail
        /// </summary>
        /// <param name="to">L'adresse destinataire</param>
        /// <param name="subject">Le sujet du mail</param>
        /// <param name="body">Le contenu du mail</param>
        public void sendMail(string to, string subject, string body)
        {
            MailMessage message = new MailMessage();
            SmtpClient smtpClient = new SmtpClient();
            try
            {
                MailAddress fromAddress = new MailAddress(SendersAddress);
                message.From = fromAddress;
                message.To.Add(new MailAddress(to));
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
        #endregion

        #region Mail en cas de perte de mot de passe
        /// <summary>
        /// Mail à envoyer en cas de perte de mot de passe
        /// </summary>
        /// <param name="emp">L'employé qui a perdu son mot de passe</param>
        public void lostPassword(Employee emp)
        {
            string htmlContent = Ouatelse.Properties.Resources.forgottenPassword;
            string body = htmlContent.Replace("USERNAME", emp.Username);
            body = body.Replace("PASSWORD", emp.Password);
            body = body.Replace("EMAIL", emp.Email);
            sendMail(emp.Email, "Ouatelse : Récupération de mot de passe", body);
        }
        #endregion

        #region Mail en cas de nouveau client
        /// <summary>
        /// Mail à envoyer au nouveau client
        /// </summary>
        /// <param name="cust">Le nouveau client</param>
        public void newCustomer(Customer cust)
        {
            string htmlContent = Ouatelse.Properties.Resources.newCustomer;
            string body = htmlContent.Replace("SURNAME", cust.LastName);
            body = body.Replace("NAME", cust.FirstName);
            sendMail(cust.Email, "Ouatelse : Bienvenue chez Ouatelse", body);
        }
        #endregion

        #region Mail en cas de modification de compte client
        /// <summary>
        /// Mail à envoyer en cas de modification de paramètres client
        /// </summary>
        /// <param name="cust">Le client qui a été modifié</param>
        public void modifyCustomer(Customer cust)
        {
            string htmlContent = Ouatelse.Properties.Resources.modifiedCustomer;
            string body = htmlContent.Replace("GENDER", cust.Gender.Name);
            body = body.Replace("LASTNAME",cust.LastName);
            body = body.Replace("FIRSTNAME",cust.FirstName);
            if (String.IsNullOrWhiteSpace(cust.Address2))
            {
                body = body.Replace("ADDRESS", cust.Address1 + "<br/>" + cust.Address2);
            }
            else
            {
                body = body.Replace("ADDRESS", cust.Address1);

            }
            body = body.Replace("CITY", cust.City.Name);
            body = body.Replace("ZIPCODE", cust.City.PostalCode);
            if (!String.IsNullOrWhiteSpace(cust.MobilePhoneNumber)){
                body = body.Replace("MOBILEPHONENUMBER", cust.MobilePhoneNumber);
            } 
            else {
                body = body.Replace("MOBILEPHONENUMBER", "Non Communiqué");
            }

            if (!String.IsNullOrWhiteSpace(cust.PhoneNumber))
            {
                body = body.Replace("PHONENUMBER", cust.PhoneNumber);

            }
            else
            {
                body = body.Replace("PHONENUMBER", "Non Communiqué");

            }
            body = body.Replace("DATEOFBIRTH", cust.DateOfBirth.ToShortDateString());
            sendMail(cust.Email, "Ouatelse : modification de paramètres client", body);
        }
        #endregion

        #region Mail en cas de suppression de compte client
        /// <summary>
        /// Mail à envoyé quand le client se désinscrit
        /// </summary>
        /// <param name="cust">Le client qui se désinscrit</param>
        public void deleteCustomer(Customer cust)
        {
            string htmlContent = Ouatelse.Properties.Resources.deleteCustomer;
            string body = htmlContent.Replace("SURNAME", cust.LastName);
            body = body.Replace("NAME", cust.FirstName);
            sendMail(cust.Email, "Ouatelse  : Suppression de compte client", body);
        }
        #endregion

        #region Mail en cas de création de compte utilisateur
        /// <summary>
        /// Mail à envoyé à l'inscription d'un nouvel utilisateur
        /// </summary>
        /// <param name="emp">Le nouvel utilisateur</param>
        public void newEmployee(Employee emp)
        {
            string htmlContent = Ouatelse.Properties.Resources.newEmployee;
            string body = htmlContent.Replace("LASTNAME", emp.LastName);
            body = body.Replace("FIRSTNAME", emp.FirstName);
            body = body.Replace("EMAIL", emp.Email);
            body = body.Replace("STORE", emp.Store.Address);
            body = body.Replace("USERNAME", emp.Username);
            body = body.Replace("PASSWORD", emp.Password);
            sendMail(emp.Email, "Ouatelse  : Création de compte utilisateur", body);
        }
        #endregion

        #region Mail en cas de modification d'un compte utilisateur
        /// <summary>
        /// Mail pour la modification d'un compte utilisateur
        /// </summary>
        /// <param name="emp">L'utilisateur à modifier</param>
        public void modifyEmployee(Employee emp)
        {
            string htmlContent = Ouatelse.Properties.Resources.modifiedCustomer;
            string body = htmlContent.Replace("GENDER", emp.Gender.Name);
            body = body.Replace("LASTNAME", emp.LastName);
            body = body.Replace("FIRSTNAME", emp.FirstName);
            if (String.IsNullOrWhiteSpace(emp.Address2))
            {
                body = body.Replace("ADDRESS", emp.Address1 + "<br/>" + emp.Address2);
            }
            else
            {
                body = body.Replace("ADDRESS", emp.Address1);

            }
            body = body.Replace("CITY", emp.City.Name);
            body = body.Replace("ZIPCODE", emp.City.PostalCode);
            if (!String.IsNullOrWhiteSpace(emp.MobilePhoneNumber))
            {
                body = body.Replace("MOBILEPHONENUMBER", emp.MobilePhoneNumber);
            }
            else
            {
                body = body.Replace("MOBILEPHONENUMBER", "Non Communiqué");
            }

            if (!String.IsNullOrWhiteSpace(emp.PhoneNumber))
            {
                body = body.Replace("PHONENUMBER", emp.PhoneNumber);

            }
            else
            {
                body = body.Replace("PHONENUMBER", "Non Communiqué");

            }
            body = body.Replace("DATEOFBIRTH", emp.DateOfBirth.ToShortDateString());
            body = body.Replace("STORE", emp.Store.Address);
            body = body.Replace("ROLE", emp.Role.Name);
            sendMail(emp.Email, "Ouatelse : modification de paramètres employé", body);
        }
        #endregion

        #region Mail en cas de suppresion d'un compte utilisateur
        /// <summary>
        /// Mail en cas de suppresion d'un compte utilisateur
        /// </summary>
        /// <param name="emp">L'utilisateur à supprimer</param>
        public void deleteEmployee(Employee emp)
        {
            string htmlContent = Ouatelse.Properties.Resources.deleteEmployee;
            string body = htmlContent.Replace("LASTNAME", emp.LastName);
            body = body.Replace("FIRSTNAME", emp.FirstName);
            sendMail(emp.Email, "Ouatelse  : Suppression de compte utilisateur", body);
        }
        #endregion

        #region Mail en cas de demande d'assistance
        /// <summary>
        /// Mail en cas de demande d'assistance
        /// </summary>
        /// <param name="emp">L'employé qui veut un support technique</param>
        public void supportRequest(Employee emp)
        {
            string htmlContent = Ouatelse.Properties.Resources.deleteEmployee;
            string body = htmlContent.Replace("LASTNAME", emp.LastName);
            sendMail(emp.Email, "Ouatelse  : Suppression de compte utilisateur", body);
        }
        #endregion
    }
}
