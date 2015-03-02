using Ouatelse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouatelse.Managers
{
    /// <summary>
    /// Singleton qui gère les Moyen de paiements
    /// </summary>
    public class PaymentManager : BaseManager<Payment>
    {
        private static PaymentManager _instance = null;

        public static PaymentManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PaymentManager();
                return _instance;
            }
        }

        private PaymentManager()
        {
            this.TableName = "moyen_de_paiements";
        }
    }
}
