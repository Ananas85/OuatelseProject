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
            string query = " DROP TABLE IF EXISTS \"factures\"; " + Environment.NewLine;
            query += " CREATE TABLE \"factures\" ( " + Environment.NewLine;
            query += " \"id\" INTEGER(11,0) NOT NULL," + Environment.NewLine;
            query += " \"date\" TEXT NOT NULL," + Environment.NewLine;
            query += " \"pourcentage_remise\" REAL NOT NULL," + Environment.NewLine;
            query += " \"salaries_id\" INTEGER(11,0) NOT NULL," + Environment.NewLine;
            query += " \"clients_id\" INTEGER(11,0) NOT NULL," + Environment.NewLine;
            query += " \"moyen_de_paiements_id\" INTEGER(11,0) NOT NULL," + Environment.NewLine;
            query += " \"estPaye\" INTEGER(1,0) NOT NULL," + Environment.NewLine;
            query += " \"montantPaye\" REAL," + Environment.NewLine;
            query += " PRIMARY KEY(\"id\",\"salaries_id\",\"clients_id\",\"moyen_de_paiements_id\"));";

            return query;
        }

        public static string CreationIndex()
        {
            string query = " CREATE INDEX \"fk_factures_salaries1_idx\" ON factures (salaries_id);" + Environment.NewLine;
            query += " CREATE INDEX \"fk_factures_clients1_idx\" ON factures (clients_id);" + Environment.NewLine;
            query += " CREATE INDEX \"fk_factures_moyen_de_paiements1_idx\" ON factures (moyen_de_paiements_id);";
            return query;
        }
    }
}
