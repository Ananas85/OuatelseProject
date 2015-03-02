using Ouatelse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouatelse.Managers
{
    /// <summary>
    /// Classe singleton qui permet de gérer les factures
    /// </summary>
    public class InvoiceManager : BaseManager<Invoice>
    {
        private static InvoiceManager _instance = null;

        public static InvoiceManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new InvoiceManager();
                return _instance;
            }
        }

        public InvoiceManager()
        {
            this.TableName = "factures";
        }
    }
}
