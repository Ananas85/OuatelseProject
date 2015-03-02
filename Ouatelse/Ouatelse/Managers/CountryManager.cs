using Ouatelse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouatelse.Managers
{
    /// <summary>
    /// Classe singleton qui permet de gérer les pays
    /// </summary>
    public class CountryManager : BaseManager<Country>
    {
        private static CountryManager _instance = null;

        public static CountryManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CountryManager();
                return _instance;
            }
        }

        public CountryManager()
        {
            this.TableName = "pays";
        }
    }
}
