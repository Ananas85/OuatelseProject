using Ouatelse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouatelse.Managers
{
    /// <summary>
    /// Classe singleton qui permet de gérer les produits
    /// </summary>
    public class ProductManager : BaseManager<Product>
    {
        private static ProductManager _instance = null;

        public static ProductManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ProductManager();
                return _instance;
            }
        }

        public ProductManager()
        {
            this.TableName = "produits";
        }

        public static string CreationQuery()
        {
            string query = " DROP TABLE IF EXISTS \"produits\";" + Environment.NewLine;
            query += " CREATE TABLE \"produits\" (" + Environment.NewLine;
            query += " \"id\" INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, " + Environment.NewLine;
            query += " \"nom\" TEXT(255,0) NOT NULL," + Environment.NewLine;
            query += " \"designation\" TEXT NOT NULL," + Environment.NewLine;
            query += " \"prix_achat\" REAL NOT NULL," + Environment.NewLine;
            query += " \"prix_vente\" REAL NOT NULL," + Environment.NewLine;
            query += " \"tva\" REAL NOT NULL," + Environment.NewLine;
            query += " \"code_ean\" TEXT(255,0));";

            return query;
        }

        public static string Fixtures()
        {
            return "INSERT INTO produits VALUES (1, \"Volluto\", \"Volluto\", 2, 5, 19, \"123\");";
        }
    }
}
