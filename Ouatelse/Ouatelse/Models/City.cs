using Ouatelse.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }

}
