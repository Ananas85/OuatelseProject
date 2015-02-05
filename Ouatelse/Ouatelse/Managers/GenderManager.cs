using Ouatelse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouatelse.Managers
{
    /// <summary>
    /// Singleton qui gère les civilités
    /// </summary>
    public class GenderManager : BaseManager<Gender>
    {
        private static GenderManager _instance = null;

        public static GenderManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new GenderManager();
                return _instance;
            }
        }

        private GenderManager()
        {
            this.tableName = "civilite";
        }
    }
}
