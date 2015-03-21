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

        /// <summary>
        /// Permet de récupérer le stock d'un produit dans le magasin fourni en paramètre
        /// </summary>
        /// <param name="product"></param>
        /// <param name="store"></param>
        /// <returns>Le stock courant du produit product dans le magasin store</returns>
        public static int getCurrentStock(Product product, Store store){
            int res = new int();
            List<Stock> stockList = new List<Stock>(StockManager.Instance.Filter("WHERE produits_id = " + product.Id + " AND magasin_id = " + store.Id + ";"));
            foreach (Stock stock in stockList)
            {
                res += stock.Quantity;
            }
            return res;
        }
    }
}
