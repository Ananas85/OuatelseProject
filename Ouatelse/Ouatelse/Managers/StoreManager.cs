using Ouatelse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouatelse.Managers
{
    /// <summary>
    /// Classe singleton qui permet de gérer les magasin
    /// </summary>
    public class StoreManager : BaseManager<Store>
    {
        private static StoreManager _instance = null;

        public static StoreManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new StoreManager();
                return _instance;
            }
        }

        public StoreManager()
        {
            this.TableName = "magasin";
        }

        public static string CreationQuery()
        {
            string query = " DROP TABLE IF EXISTS \"magasin\";" + Environment.NewLine;
            query += " CREATE TABLE \"magasin\" ( " + Environment.NewLine;
            query += " \"id\" INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, " + Environment.NewLine;
            query += " \"adresse\" TEXT NOT NULL," + Environment.NewLine;
            query += " \"villes_id\" INTEGER(11,0) NOT NULL);";

            return query;
        }

        public static string CreationIndex()
        {
            return " CREATE INDEX \"fk_magasin_villes1_idx\" ON magasin (villes_id);" + Environment.NewLine;
        }

        public static string Fixtures()
        {
            return "INSERT INTO magasin VALUES (1,\"Rue du Magasin de Test\", 1);";
        }
    }
}
