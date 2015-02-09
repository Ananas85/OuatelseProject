using Ouatelse.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouatelse.Models
{
    public class Store : BaseModel, IModel
    {
        public string Address { get; set; }
        public City City { get; set; }

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
            Dictionary<string, string> res = new Dictionary<string, string>();
            res.Add("adresse", Address);
            res.Add("villes_id", City.Id.ToString());
            return res;
        }
    }
}
