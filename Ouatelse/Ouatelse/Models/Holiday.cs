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

        public List<DateTime> ConcernedDays()
        {
            List<DateTime> concerned = new List<DateTime>();
            for (DateTime i = StartingDate.Date; i.Date <= EndingDate.Date; i.AddDays(1))
            {
                concerned.Add(i);
            }
            return concerned;
        }

        public int numberOfDays()
        {
            return (EndingDate - StartingDate).Days;
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
            Dictionary<string, string> res = new Dictionary<string, string>
            {
                {"date_debut", StartingDate.ToString("yyyy-MM-dd")},
                {"date_fin", EndingDate.ToString("yyyy-MM-dd")},
                {"salaries_id", Employee.Id.ToString()},
                {"accepte", Convert.ToInt16(Accepted).ToString()}
            };
            return res;
        }

        public static string CreationQuery()
        {
            string query = "DROP TABLE IF EXISTS \"conge\";" + Environment.NewLine;
            query += " CREATE TABLE \"conge\" ( " + Environment.NewLine;
            query += " \"id\" INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, " + Environment.NewLine;
            query += " \"date_debut\" TEXT NOT NULL, " + Environment.NewLine;
            query += "\"date_fin\" TEXT NOT NULL, " + Environment.NewLine;
            query += " \"salaries_id\" INTEGER(11,0) NOT NULL, " + Environment.NewLine;
            query += " \"accepte\" INTEGER(1,0) NOT NULL);";
            return query;
        }

        public static string CreationIndex()
        {
            return " CREATE INDEX \"fk_conge_salaries1_idx\" ON conge (salaries_id);";
        }
    }
}
