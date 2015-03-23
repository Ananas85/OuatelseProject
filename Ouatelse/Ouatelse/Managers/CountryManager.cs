using Ouatelse.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Ouatelse.Managers
{
    /// <summary>
    /// Classe singleton qui permet de gérer les pays
    /// </summary>
    public class CountryManager : BaseManager<Country>
    {
        private static CountryManager _instance = null;

        public static CountryManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CountryManager();
                return _instance;
            }
        }

        public CountryManager()
        {
            this.TableName = "pays";
        }

        public static string CreationQuery()
        {
            string query = " DROP TABLE IF EXISTS \"pays\"; " + Environment.NewLine;
            query += "CREATE TABLE \"pays\" ( " + Environment.NewLine;
            query += " \"id\" INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, " + Environment.NewLine;
            query += "\"libelle\" TEXT(255,0) NOT NULL);";
            return query;
        }

        public static string Fixtures()
        {
            return "INSERT INTO pays VALUES (1,'France');";
        }


    }
}
