using Ouatelse.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ouatelse.Models
{
    public class Store : BaseModel, IModel
    {
        public string Address { get; set; }
        public City City { get; set; }

        public string Name
        {
            get { return string.Format("{0}, {1} {2}", Address, City.PostalCode, City.Name); }
        }

        public string NameTwoLines
        {
            get { return string.Format("{0} {3} {1} {2}", Address, City.PostalCode, City.Name, Environment.NewLine); }
        }

        /// <summary>
        /// Permet d'hydrater l'objet
        /// </summary>
        /// <param name="data"></param>
        public void Hydrate(object[] data)
        {
            ArrayCursor<object> cursor = new ArrayCursor<object>(data);
            this.Id = Int32.Parse(cursor.Read().ToString());
            this.Address = cursor.Read().ToString();
            this.City = CityManager.Instance.Find(cursor.Read().ToString());
        }

        public Dictionary<string, string> Fetch()
        {
            Dictionary<string, string> res = new Dictionary<string, string>
            {
                {"adresse", Address},
                {"villes_id", City.Id.ToString()}
            };
            return res;
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
