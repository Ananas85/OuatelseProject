using Ouatelse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouatelse.Managers
{
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
            tableName = "villes";
        }
    }
}
