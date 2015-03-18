using Ouatelse.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouatelse.Models
{
    public class Stock : BaseModel, IModel
    {
        public int Quantity { get; set; }
        public Product Product { get; set; }
        public Store Store { get; set; }


        public void Hydrate(object[] data)
        {
            ArrayCursor<object> cursor = new ArrayCursor<object>(data);
            this.Id = Int32.Parse(cursor.Read().ToString());
            this.Quantity = Int32.Parse(cursor.Read().ToString());
            this.Product = ProductManager.Instance.Find(cursor.Read().ToString());
            this.Store = StoreManager.Instance.Find(cursor.Read().ToString());
        }

        public Dictionary<string, string> Fetch()
        {
            Dictionary<string, string> res = new Dictionary<string, string>
            {
                {"quantite", Quantity.ToString()},
                {"produits_id", Product.Id.ToString()},
                {"magasin_id", Store.Id.ToString()}
            };
            return res;
        }

        public static string CreationQuery()
        {
            string query = " DROP TABLE IF EXISTS \"mouvement_stock\";" + Environment.NewLine;
            query += " CREATE TABLE \"mouvement_stock\" (" + Environment.NewLine;
            query += " \"id\" INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, " + Environment.NewLine;
            query += " \"quantite\" INTEGER(11,0) NOT NULL," + Environment.NewLine;
            query += " \"produits_id\" INTEGER(11,0) NOT NULL," + Environment.NewLine;
            query += " \"magasin_id\" INTEGER(11,0) NOT NULL);";

            return query;
        }

        public static string CreationIndex()
        {
            string query = " CREATE UNIQUE INDEX \"fk_mouvement_stock_produits1_idx\" ON mouvement_stock (produits_id);" + Environment.NewLine;
            query += " CREATE INDEX \"fk_mouvement_stock_magasin1_idx\" ON mouvement_stock (magasin_id);";

            return query;
        }

    }
}
