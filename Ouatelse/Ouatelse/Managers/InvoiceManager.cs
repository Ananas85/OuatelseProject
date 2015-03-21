using Ouatelse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouatelse.Managers
{
    /// <summary>
    /// Classe singleton qui permet de gérer les factures
    /// </summary>
    public class InvoiceManager : BaseManager<Invoice>
    {
        private static InvoiceManager _instance = null;

        public static InvoiceManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new InvoiceManager();
                return _instance;
            }
        }

        public InvoiceManager()
        {
            this.TableName = "factures";
        }

        public static string CreationQuery()
        {
            string query = " DROP TABLE IF EXISTS \"factures\"; " + Environment.NewLine;
            query += " CREATE TABLE \"factures\" ( " + Environment.NewLine;
            query += " \"id\" INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, " + Environment.NewLine;
            query += " \"date\" TEXT NOT NULL, " + Environment.NewLine;
            query += " \"pourcentage_remise\" REAL NOT NULL," + Environment.NewLine;
            query += " \"salaries_id\" INTEGER(11,0) NOT NULL," + Environment.NewLine;
            query += " \"clients_id\" INTEGER(11,0) NOT NULL," + Environment.NewLine;
            query += " \"moyen_de_paiements_id\" INTEGER(11,0) NOT NULL, " + Environment.NewLine;
            query += " \"estPaye\" INTEGER(1,0) NOT NULL," + Environment.NewLine;
            query += " \"montantPaye\" REAL);";
            return query;
        }

        public static string CreationIndex()
        {
            string query = "CREATE UNIQUE INDEX \"fk_factures_salaries1_idx\" ON factures (salaries_id); " + Environment.NewLine;
            query += " CREATE UNIQUE INDEX \"fk_factures_clients1_idx\" ON factures (clients_id);" + Environment.NewLine;
            query += "CREATE UNIQUE INDEX \"fk_factures_moyen_de_paiements1_idx\" ON factures (moyen_de_paiements_id); " + Environment.NewLine;

            return query;
        }

        public static string Fixtures()
        {
            return "INSERT INTO factures VALUES (1, \"2015-03-09\", 0, 1, 41, 1, 0, 0);";
        }
    }
}
