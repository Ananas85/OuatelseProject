using Ouatelse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouatelse.Managers
{
    /// <summary>
    /// Singleton qui gère les civilités
    /// </summary>
    public class GenderManager : BaseManager<Gender>
    {
        private static GenderManager _instance = null;

        public static GenderManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new GenderManager();
                return _instance;
            }
        }

        private GenderManager()
        {
            this.TableName = "civilite";
        }

        public static string CreationQuery()
        {
            //Necessary to create table in test environment with SQLite syntax
            var query = "DROP TABLE IF EXISTS \"civilite\";" + Environment.NewLine;
            query += "CREATE TABLE \"civilite\" (" + Environment.NewLine;
            query += " \"id\" INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, " + Environment.NewLine;
            query += " \"nom\" TEXT(3,0) NOT NULL);";
            return query;
        }

        public static string Fixtures()
        {
            return "INSERT INTO civilite VALUES (1, 'M.'); ";
        }
    }
}
