using Ouatelse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouatelse.Managers
{
    /// <summary>
    /// Classe singleton qui permet de gérer les roles
    /// </summary>
    public class RoleManager : BaseManager<Role>
    {
        private static RoleManager _instance = null;

        public static RoleManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new RoleManager();
                return _instance;
            }
        }

        public RoleManager()
        {
            this.TableName = "roles";
        }
    }
}
