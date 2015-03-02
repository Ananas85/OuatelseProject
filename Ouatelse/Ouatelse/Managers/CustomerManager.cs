using Ouatelse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouatelse.Managers
{
    /// <summary>
    /// Classe singleton qui permet de gérer les clients
    /// </summary>
    public class CustomerManager : BaseManager<Customer>
    {
        private static CustomerManager _instance = null;

        public static CustomerManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CustomerManager();
                return _instance;
            }
        }

        #region Constructeur de la classe
        public CustomerManager()
        {
            this.tableName = "clients";
        }
        #endregion

        #region Permet de créer un nouveau Client
        public void Create(Customer cust)
        {
            //Enregistrement dans la base de données
            CustomerManager.Instance.Save(cust);

            //Message d'information
            //Utils.Info("Client enregistré avec succès");

            //Envoi du mail au nouveau client
            if (!String.IsNullOrWhiteSpace(cust.Email))
                MailSender.Instance.newCustomer(cust);
        }
        #endregion

        #region Permet de modifier un client
        public void Modify(Customer cust)
        {
            CustomerManager.Instance.Save(cust);
            //Utils.Info("Client modifié avec succès");
            if (cust.EmailOnUpdate)
            {
                MailSender.Instance.modifyCustomer(cust);
            }
        }
        #endregion
    }
}
