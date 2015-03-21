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

        public static string CreationQuery()
        {
            string query = " DROP TABLE IF EXISTS \"moyen_de_paiements\";" + Environment.NewLine;
            query += " CREATE TABLE \"moyen_de_paiements\" (" + Environment.NewLine;
            query += " \"id\" INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, " + Environment.NewLine;
            query += " \"type\" TEXT(45,0) NOT NULL);";
            return query;
        }

        public static string Fixtures()
        {
            return "INSERT INTO moyen_de_paiements VALUES (1,'CB');";
        }
    }
}
