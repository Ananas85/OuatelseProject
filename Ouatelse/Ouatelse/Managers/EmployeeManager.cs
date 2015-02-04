using Ouatelse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouatelse.Managers
{
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
            tableName = "salaries";
        }
    }
}
