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

        public static string CreationQuery()
        {
            string query = " DROP TABLE IF EXISTS \"factures_produits\"; " + Environment.NewLine;
            query += " CREATE TABLE \"factures_produits\" ( " + Environment.NewLine;
            query += " \"id\" INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, " + Environment.NewLine;
            query += " \"quantite\" INTEGER(11,0) NOT NULL," + Environment.NewLine;
            query += " \"factures_id\" INTEGER(11,0) NOT NULL," + Environment.NewLine;
            query += " \"produits_id\" INTEGER(11,0) NOT NULL);";

            return query;
        }

        public static string CreationIndex()
        {
            string query = " CREATE UNIQUE INDEX \"fk_factures_produits_factures1_idx\" ON factures_produits (factures_id);" + Environment.NewLine;
            query += " CREATE UNIQUE INDEX \"fk_factures_produits_produits1_idx\" ON factures_produits (produits_id);" + Environment.NewLine;
            return query;
        }
    }
}
