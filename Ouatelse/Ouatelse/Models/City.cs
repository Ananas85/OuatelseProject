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
            Id = Int32.Parse(cursor.Read().ToString());
            Name = cursor.Read().ToString();
            PostalCode = cursor.Read().ToString();
            
        }
    }

}
