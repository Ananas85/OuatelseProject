using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouatelse.Models
{
    public class Product : BaseModel, IModel
    {
        public string Name { get; set; }
        public string Designation { get; set; }
        public float PurchasePrice { get; set; }
        public float SellPrice { get; set; }
        public float TVA { get; set; }
        public string EANCode { get; set; }

        public void Hydrate(object[] data)
        {
            ArrayCursor<object> cursor = new ArrayCursor<object>(data);
            this.Id = Int32.Parse(cursor.Read().ToString());
            this.Name = cursor.Read().ToString();
            this.Designation = cursor.Read().ToString();
            this.PurchasePrice = Convert.ToSingle(cursor.Read().ToString());
            this.SellPrice = Convert.ToSingle(cursor.Read().ToString());
            this.TVA = Convert.ToSingle(cursor.Read().ToString());
            this.EANCode = cursor.Read().ToString();
        }

        public Dictionary<string, string> Fetch()
        {
            Dictionary<string, string> res = new Dictionary<string, string>();
            res.Add("nom", Name);
            res.Add("designation", Designation);
            res.Add("prix_achat", PurchasePrice.ToString());
            res.Add("prix_vente", SellPrice.ToString());
            res.Add("tva", TVA.ToString());
            res.Add("code_ean", EANCode.ToString());
            return res;
        }
    }
}
