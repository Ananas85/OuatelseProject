using Ouatelse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouatelse.Managers
{
    /// <summary>
    /// Singleton qui gère les mouvement_stock
    /// </summary>
    public class StockManager : BaseManager<Stock>
    {
        private static StockManager _instance = null;

        public static StockManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new StockManager();
                return _instance;
            }
        }

        private StockManager()
        {
            this.TableName = "mouvement_stock";
        }
    }
}
