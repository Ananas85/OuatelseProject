using Ouatelse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouatelse.Managers
{
    /// <summary>
    /// Classe singleton qui permet de gérer les villes
    /// </summary>
    public class CityManager : BaseManager<City>
    {
        private static CityManager _instance = null;

        public static CityManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CityManager();
                return _instance;
            }
        }

        public CityManager()
        {
            this.TableName = "villes";
        }

        public static string CreationQuery()
        {
            string query = " DROP TABLE IF EXISTS \"villes\"; " + Environment.NewLine;
            query+= "CREATE TABLE \"villes\" ( " + Environment.NewLine;
            query += " \"id\" INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, " + Environment.NewLine;
            query += "\"libelle\" TEXT(255,0) NOT NULL," + Environment.NewLine;
            query+="\"code_postal\" TEXT(255,0) NOT NULL," + Environment.NewLine;
            query += "\"pays_id\" INTEGER(11,0) NOT NULL);";

            return query;
        }

        public static string CreationIndex()
        {
            string query = " CREATE INDEX \"fk_villes_pays1_idx\" ON villes (pays_id);" + Environment.NewLine;
            query += " CREATE INDEX \"code_postal_idx\" ON villes (code_postal);";
            return query;
        }

        public static string Fixtures()
        {
            return "INSERT INTO \"villes\" VALUES (1,'Marseille', 13001, 1);";
        }
    }
}
