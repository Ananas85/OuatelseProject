using Ouatelse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouatelse.Managers
{
    /// <summary>
    /// Singleton qui gère les mouvement_stock
    /// </summary>
    public class StockManager : BaseManager<Stock>
    {
        private static StockManager _instance = null;

        public static StockManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new StockManager();
                return _instance;
            }
        }

        private StockManager()
        {
            this.TableName = "mouvement_stock";
        }

        public static string CreationQuery()
        {
            string query = " DROP TABLE IF EXISTS \"mouvement_stock\";" + Environment.NewLine;
            query += " CREATE TABLE \"mouvement_stock\" (" + Environment.NewLine;
            query += " \"id\" INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, " + Environment.NewLine;
            query += " \"quantite\" INTEGER(11,0) NOT NULL," + Environment.NewLine;
            query += " \"produits_id\" INTEGER(11,0) NOT NULL," + Environment.NewLine;
            query += " \"magasin_id\" INTEGER(11,0) NOT NULL);";

            return query;
        }

        public static string CreationIndex()
        {
            string query = " CREATE UNIQUE INDEX \"fk_mouvement_stock_produits1_idx\" ON mouvement_stock (produits_id);" + Environment.NewLine;
            query += " CREATE INDEX \"fk_mouvement_stock_magasin1_idx\" ON mouvement_stock (magasin_id);";

            return query;
        }
    }
}
