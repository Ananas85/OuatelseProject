using Ouatelse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouatelse.Managers
{
    /// <summary>
    /// Classe singleton qui permet de gérer les roles
    /// </summary>
    public class RoleManager : BaseManager<Role>
    {
        private static RoleManager _instance = null;

        public static RoleManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new RoleManager();
                return _instance;
            }
        }

        public RoleManager()
        {
            this.TableName = "roles";
        }

        public static string CreationQuery()
        {
            string query = " DROP TABLE IF EXISTS \"roles\";" + Environment.NewLine;
            query += " CREATE TABLE \"roles\" (" + Environment.NewLine;
            query += " \"id\" INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, " + Environment.NewLine;
            query += " \"libelle_role\" TEXT(255,0) NOT NULL," + Environment.NewLine;
            query += " \"parent_role_id\" INTEGER(11,0));";

            return query;
        }

        public static string CreationIndex()
        {
            return " CREATE INDEX \"fk_roles_roles1_idx\" ON roles (parent_role_id);";
        }

        public static string Fixtures()
        {
            return "INSERT INTO \"roles\" VALUES (1,'Administrateur', null);";
        }
    }
}
