using Ouatelse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouatelse.Managers
{
    /// <summary>
    /// Singleton qui gère les congés
    /// </summary>
    public class HolidayManager : BaseManager<Holiday>
    {
        private static HolidayManager _instance = null;

        public static HolidayManager Instance
        {
            get { return _instance ?? (_instance = new HolidayManager()); }
        }

        private HolidayManager()
        {
            this.TableName = "conge";
        }

        public Holiday FilterByDate(DateTime date)
        {
            return HolidayManager.Instance.First("WHERE salaries_id = " + AuthManager.Instance.User.Id + " AND '" +
                                          String.Format("{0:yyyy-MM-dd}", date) + "' BETWEEN date_debut AND date_fin");
        }

        public Holiday FilterByDateAndNotCurrent(int id, DateTime date)
        {
            return HolidayManager.Instance.First("WHERE salaries_id = " + AuthManager.Instance.User.Id + " AND conge.id <> " + id +" AND '" +
                                          String.Format("{0:yyyy-MM-dd}", date) + "' BETWEEN date_debut AND date_fin");
        }
    }
}
