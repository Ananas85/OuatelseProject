using Ouatelse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouatelse.Managers
{
    /// <summary>
    /// Classe singleton qui permet de gérer les magasin
    /// </summary>
    public class StoreManager : BaseManager<Store>
    {
        private static StoreManager _instance = null;

        public static StoreManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new StoreManager();
                return _instance;
            }
        }

        public StoreManager()
        {
            this.tableName = "magasin";
        }
    }
}
