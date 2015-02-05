using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouatelse.Models
{-)
    public class Product : BaseModel, IModel
    {
        public string Name { get; set; }
        public string Designation { get; set; }
        public float PurchasingPrice { get; set; }
        public float SellingPrice { get; set; }
        public float TVA { get; set; }
        public string EANCode { get; set; }

        public void Hydrate(object[] data)
        {
            ArrayCursor<object> cursor = new ArrayCursor<object>(data);
            this.Id = Int32.Parse(cursor.Read().ToString());
            this.Name = cursor.Read().ToString();
            this.Designation = cursor.Read().ToString();
            this.PurchasingPrice = Convert.ToSingle(cursor.Read().ToString());
            this.SellingPrice = Convert.ToSingle(cursor.Read().ToString());
            this.TVA = Convert.ToSingle(cursor.Read().ToString());
            this.EANCode = cursor.Read().ToString();
        }
    }
}
