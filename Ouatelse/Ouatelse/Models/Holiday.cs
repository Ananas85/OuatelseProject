using Ouatelse.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouatelse.Models
{
    public class Holiday : BaseModel, IModel
    {
        public DateTime StartingDate { get; set; }
        public DateTime EndingDate { get; set; }
        public Employee Employee { get; set; }
        public Boolean Accepted { get; set; }

        public Holiday()
        {
            StartingDate = DateTime.Now;
            EndingDate = DateTime.Now.AddDays(1);
            Employee = null;
            Accepted = false;
        }

        public Holiday(DateTime sd, DateTime ed, Employee e)
        {
            this.StartingDate = sd;
            this.EndingDate = ed;
            this.Employee = e;
            Accepted = false;
        }

        /// <summary>
        /// Permet d'hydrater l'objet
        /// </summary>
        /// <param name="data"></param>
        public void Hydrate(object[] data)
        {
            ArrayCursor<object> cursor = new ArrayCursor<object>(data);
            this.Id = Int32.Parse(cursor.Read().ToString());
            this.StartingDate = DateTime.Parse(cursor.Read().ToString());
            this.EndingDate = DateTime.Parse(cursor.Read().ToString());
            this.Employee = EmployeeManager.Instance.Find(cursor.Read().ToString());
            this.Accepted = bool.Parse(cursor.Read().ToString());
        }

        public Dictionary<string, string> Fetch()
        {
            Dictionary<string, string> res = new Dictionary<string, string>();
            res.Add("date_debut", StartingDate.ToString("yyyy-MM-dd"));
            res.Add("date_fin", EndingDate.ToString("yyyy-MM-dd"));
            res.Add("salaries_id", Employee.Id.ToString());
            res.Add("accepte", Convert.ToInt16(Accepted).ToString());
            return res;
        }
    }
}
