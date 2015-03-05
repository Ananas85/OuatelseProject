using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Ouatelse.Models
{
    public class Gender : BaseModel, IModel
    {
        public string Name { get; set; }

        public void Hydrate(object[] data)
        {
            ArrayCursor<object> cursor = new ArrayCursor<object>(data);
            this.Id = Int32.Parse(cursor.Read().ToString());
            this.Name = cursor.Read().ToString();
        }

        public Dictionary<string, string> Fetch()
        {
            Dictionary<string, string> res = new Dictionary<string, string> {{"nom", Name}};
            return res;
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

    }
}
