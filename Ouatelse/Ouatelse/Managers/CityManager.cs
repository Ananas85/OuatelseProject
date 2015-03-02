using Ouatelse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouatelse.Managers
{
    /// <summary>
    /// Classe singleton qui permet de gérer les villes
    /// </summary>
    public class CityManager : BaseManager<City>
    {
        private static CityManager _instance = null;

        public static CityManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CityManager();
                return _instance;
            }
        }

        public CityManager()
        {
            this.TableName = "villes";
        }
    }
}
