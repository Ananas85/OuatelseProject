using Ouatelse.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ouatelse.Models
{
    public class City : BaseModel, IModel
    {
        public string Name { get; set; }
        public string PostalCode { get; set; }
        public Country Country { get; set; }

        public void Hydrate(object[] data)
        {
            ArrayCursor<object> cursor = new ArrayCursor<object>(data);
            this.Id = Int32.Parse(cursor.Read().ToString());
            this.Name = cursor.Read().ToString();
            this.PostalCode = cursor.Read().ToString();
            this.Country = CountryManager.Instance.Find(cursor.Read().ToString());            
        }

        public Dictionary<string, string> Fetch()
        {
            Dictionary<string, string> res = new Dictionary<string, string>
            {
                {"libelle", Name},
                {"code_postal", PostalCode},
                {"pays_id", Country.Id.ToString()}
            };
            return res;
        }

        public static string CreationQuery()
        {
            string query = " DROP TABLE IF EXISTS \"villes\"; " + Environment.NewLine;
            query+= "CREATE TABLE \"villes\" ( " + Environment.NewLine;
            query+="\"id\" INTEGER(11,0) NOT NULL," + Environment.NewLine;
	        query+="\"libelle\" TEXT(255,0) NOT NULL," + Environment.NewLine;
	        query+="\"code_postal\" TEXT(255,0) NOT NULL," + Environment.NewLine;
	        query+="\"pays_id\" INTEGER(11,0) NOT NULL," + Environment.NewLine;
	        query+= "PRIMARY KEY(\"id\",\"pays_id\"))";

            return query;
        }
    }

}
