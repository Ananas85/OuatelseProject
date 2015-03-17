using Ouatelse.Managers;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouatelse.Models
{
    public class Role : BaseModel, IModel
    {
        public string Name { get; set; }
        public Role ParentRole { get; set; }


        public void Hydrate(object[] data)
        {
            ArrayCursor<object> cursor = new ArrayCursor<object>(data);
            this.Id = Int32.Parse(cursor.Read().ToString());
            this.Name = cursor.Read().ToString();
            string parent = cursor.Read().ToString();
            if (!String.IsNullOrEmpty(parent))
                this.ParentRole = RoleManager.Instance.Find(parent);            
        }

        public Dictionary<string, string> Fetch()
        {
            Dictionary<string, string> res = new Dictionary<string, string>
            {
                {"libelle_role", Name},
                {"parent_role_id", ParentRole.Id.ToString()}
            };
            return res;
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
