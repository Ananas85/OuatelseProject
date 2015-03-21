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
            get { return _instance ?? (_instance = new CustomerManager()); }
        }

        #region Constructeur de la classe
        public CustomerManager()
        {
            this.TableName = "clients";
        }
        #endregion

        #region Permet de créer un nouveau Client
        public void Create(Customer cust)
        {
            //Enregistrement dans la base de données
            CustomerManager.Instance.Save(cust);

            //Message d'information
            Utils.Notify("Client enregistré avec succès");

            //Envoi du mail au nouveau client
            if (!String.IsNullOrWhiteSpace(cust.Email))
                MailSender.Instance.newCustomer(cust);
        }
        #endregion

        #region Permet de modifier un client
        public void Modify(Customer cust)
        {
            CustomerManager.Instance.Save(cust);
            Utils.Notify("Client modifié avec succès");
            if (cust.EmailOnUpdate)
            {
                MailSender.Instance.modifyCustomer(cust);
            }
        }
        #endregion

        public static string CreationQuery()
        {
            string query = " DROP TABLE IF EXISTS \"clients\"; " + Environment.NewLine;
            query += " CREATE TABLE \"clients\" ( " + Environment.NewLine;
            query += " \"id\" INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, " + Environment.NewLine;
            query += " \"nom\" TEXT(255,0) NOT NULL," + Environment.NewLine;
            query += " \"prenom\" TEXT(255,0) NOT NULL," + Environment.NewLine;
            query += " \"adresse1\" TEXT NOT NULL," + Environment.NewLine;
            query += " \"adresse2\" TEXT," + Environment.NewLine;
            query += " \"fixe\" TEXT(255,0)," + Environment.NewLine;
            query += " \"portable\" TEXT(255,0)," + Environment.NewLine;
            query += " \"mail\" TEXT(255,0)," + Environment.NewLine;
            query += " \"naissance\" TEXT NOT NULL," + Environment.NewLine;
            query += " \"notes\" TEXT," + Environment.NewLine;
            query += " \"villes_id\" INTEGER(11,0) NOT NULL," + Environment.NewLine;
            query += " \"civilite_id\" INTEGER(11,0) NOT NULL," + Environment.NewLine;
            query += " \"email_modification\" INTEGER(1,0) NOT NULL);";

            return query;
        }

        public static string CreationIndex()
        {
            string query = " CREATE UNIQUE INDEX \"fk_clients_villes1_idx\" ON clients (villes_id);" + Environment.NewLine;
            query += " CREATE UNIQUE INDEX \"fk_clients_civilite1_idx\" ON clients (civilite_id);";
            return query;
        }

        public static string Fixtures()
        {
            return "INSERT INTO clients  VALUES (1, \"Moreau\", \"Corentin\", \"10, rue du général Margueritte\", \"Appart 9i\", \"\", \"\", \"corentin.moreau2@gmail.com\", \"1995-07-10\",\"\", 1, 1, 1);"; 
        }
    }
}
