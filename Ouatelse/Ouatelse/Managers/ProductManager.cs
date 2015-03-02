using Ouatelse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouatelse.Managers
{
    /// <summary>
    /// Classe singleton qui permet de gérer les produits
    /// </summary>
    public class ProductManager : BaseManager<Product>
    {
        private static ProductManager _instance = null;

        public static ProductManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ProductManager();
                return _instance;
            }
        }

        public ProductManager()
        {
            this.TableName = "produits";
        }
    }
}
