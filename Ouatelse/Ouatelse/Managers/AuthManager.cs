using Ouatelse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouatelse.Managers
{
    /// <summary>
    /// Classe singleton qui permet de gérér l'authentification
    /// </summary>
    public class AuthManager : BaseManager<Employee>
    {
        private static AuthManager _instance = null;

        public static Employee User { get; set; }

        public static AuthManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AuthManager();
                return _instance;
            }
        }

        public bool Login(string username, string password)
        {
            Employee employee = EmployeeManager.Instance.First("WHERE identifiant='" + username + "' AND mot_de_passe='" + password + "'");
            if (employee != null)
            {
                User = employee;
                return true;
            }
            return false;
        }
    }
}
