using Ouatelse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouatelse.Managers
{
    /// <summary>
    /// Singleton qui gère les factures_produits
    /// </summary>
    public class InvoiceProductManager : BaseManager<InvoiceProduct>
    {
        private static InvoiceProductManager _instance = null;

        public static InvoiceProductManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new InvoiceProductManager();
                return _instance;
            }
        }

        private InvoiceProductManager()
        {
            this.TableName = "factures_produits";
        }

        public static string CreationQuery()
        {
            string query = " DROP TABLE IF EXISTS \"factures_produits\"; " + Environment.NewLine;
            query += " CREATE TABLE \"factures_produits\" ( " + Environment.NewLine;
            query += " \"id\" INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, " + Environment.NewLine;
            query += " \"quantite\" INTEGER(11,0) NOT NULL," + Environment.NewLine;
            query += " \"factures_id\" INTEGER(11,0) NOT NULL," + Environment.NewLine;
            query += " \"produits_id\" INTEGER(11,0) NOT NULL);";

            return query;
        }

        public static string CreationIndex()
        {
            string query = " CREATE UNIQUE INDEX \"fk_factures_produits_factures1_idx\" ON factures_produits (factures_id);" + Environment.NewLine;
            query += " CREATE UNIQUE INDEX \"fk_factures_produits_produits1_idx\" ON factures_produits (produits_id);" + Environment.NewLine;
            return query;
        }

        public static string Fixtures()
        {
            return "INSERT INTO factures_produits  VALUES (1, 4, 3, 1);";
        }
    }
}
