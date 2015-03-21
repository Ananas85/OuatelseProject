using Ouatelse.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouatelse.Models
{
    public class InvoiceProduct : BaseModel, IModel
    {
        public int Quantity { get; set; }
        public Invoice Invoice { get; set; }
        public Product Product { get; set; }

        public void Hydrate(object[] data)
        {
            ArrayCursor<object> cursor = new ArrayCursor<object>(data);
            this.Id = Int32.Parse(cursor.Read().ToString());
            this.Quantity = Int32.Parse(cursor.Read().ToString());
            this.Invoice = InvoiceManager.Instance.Find(cursor.Read().ToString());
            this.Product = ProductManager.Instance.Find(cursor.Read().ToString());
        }

        public Dictionary<string, string> Fetch()
        {
            Dictionary<string, string> res = new Dictionary<string, string>();
            res.Add("quantite", Quantity.ToString());
            res.Add("factures_id", Invoice.Id.ToString());
            res.Add("produits_id", Product.Id.ToString());
            return res;
        }

        public float Price
        {
            get { return Quantity*Product.SellPrice; }
        }
    }
}
