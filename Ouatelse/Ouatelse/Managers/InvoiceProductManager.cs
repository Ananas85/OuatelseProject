using Ouatelse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouatelse.Managers
{
    /// <summary>
    /// Singleton qui gère les factures_produits
    /// </summary>
    public class InvoiceProductManager : BaseManager<InvoiceProduct>
    {
        private static InvoiceProductManager _instance = null;

        public static InvoiceProductManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new InvoiceProductManager();
                return _instance;
            }
        }

        private InvoiceProductManager()
        {
            this.tableName = "factures_produits";
        }
    }
}
