using Ouatelse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouatelse.Managers
{
    /// <summary>
    /// Classe singleton qui permet de gérer les clients
    /// </summary>
    public class CustomerManager : BaseManager<Customer>
    {
        private static CustomerManager _instance = null;

        public static CustomerManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CustomerManager();
                return _instance;
            }
        }

        public CustomerManager()
        {
            this.tableName = "clients";
        }
    }
}
