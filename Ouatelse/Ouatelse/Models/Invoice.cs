using Ouatelse.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouatelse.Models
{
    public class Invoice : BaseModel, IModel
    {
        public DateTime Date { get; set; }
        public float DiscountPercent { get; set; }
        public Employee Employee { get; set; }
        public Customer Customer { get; set; }
        public Payment Payment { get; set; }

        public void Hydrate(object[] data)
        {
            ArrayCursor<object> cursor = new ArrayCursor<object>(data);
            this.Id = Int32.Parse(cursor.Read().ToString());
            this.Date = DateTime.Parse(cursor.Read().ToString());
            this.DiscountPercent = Convert.ToSingle(cursor.Read().ToString());
            this.Employee = EmployeeManager.Instance.Find(cursor.Read().ToString());
            this.Customer = CustomerManager.Instance.Find(cursor.Read().ToString());
            this.Payment = PaymentManager.Instance.Find(cursor.Read().ToString());
        }

        public Dictionary<string, string> Fetch()
        {
            Dictionary<string, string> res = new Dictionary<string, string>();
            res.Add("date", Date.ToString("yyyy-MM-dd"));
            res.Add("pourcentage_remise", DiscountPercent.ToString());
            res.Add("salaries_id", Employee.Id.ToString());
            res.Add("clients_id", Customer.Id.ToString());
            res.Add("moyen_de_paiements_id", Payment.Id.ToString());
            return res;
        }
    }
}
