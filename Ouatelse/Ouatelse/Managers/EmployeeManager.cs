using Ouatelse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouatelse.Managers
{
    /// <summary>
    /// Singleton qui gère les employés
    /// </summary>
    public class EmployeeManager : BaseManager<Employee>
    {
        private static EmployeeManager _instance = null;

        public static EmployeeManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EmployeeManager();
                return _instance;
            }
        }

        private EmployeeManager()
        {
            this.TableName = "salaries";
        }
    }
}
