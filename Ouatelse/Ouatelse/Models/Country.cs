using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouatelse.Models
{
    public class Country : BaseModel, IModel
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
            Dictionary<string, string> res = new Dictionary<string, string> {{"libelle", Name}};
            return res;
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
            return "INSERT INTO \"pays\" VALUES ('France');";
        }
    }
}
