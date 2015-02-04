using Ouatelse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouatelse.Managers
{
    public class AuthManager : BaseManager<Employee>
    {

        private static AuthManager _instance = null;

        public static AuthManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AuthManager();
                return _instance;
            }
        }
    }
}
