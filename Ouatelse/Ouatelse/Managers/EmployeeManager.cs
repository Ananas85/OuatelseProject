using Ouatelse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouatelse.Managers
{
    /// <summary>
    /// Singleton qui gère les employés
    /// </summary>
    public class EmployeeManager : BaseManager<Employee>
    {
        private static EmployeeManager _instance = null;
        private bool userChanged;
        private bool mailChanged;

        public bool MailChanged
        {
            get { return mailChanged; }
            set { mailChanged = value; }
        }

        public bool UserChanged
        {
            get { return userChanged; }
            set { userChanged = value; }
        }

        public static EmployeeManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EmployeeManager();
                return _instance;
            }
        }

        private EmployeeManager()
        {
            this.TableName = "salaries";
            this.userChanged = false;
            this.mailChanged = false;
        }

        #region Création d'un employé
        public void Create(Employee emp)
        {
            //Enregistrement dans la base de données
            EmployeeManager.Instance.Save(emp);

            //Message d'information
            //Utils.Info("Salarié enregistré avec succès");

            //Envoi du mail au nouveau salarié
            if (!String.IsNullOrWhiteSpace(emp.Email))
                MailSender.Instance.newEmployee(emp);
        }
        #endregion

        #region Permet de modifier un client
        public void Modify(Employee emp)
        {
            EmployeeManager.Instance.Save(emp);
            Utils.Notify("Salarié modifié avec succès");
            if (emp.EmailOnUpdate)
            {
                MailSender.Instance.modifyEmployee(emp);
            }
        }
        #endregion

        public List<Employee> FilterByEmployeesWithHolidays(int currentYear)
        {
            return EmployeeManager.Instance.Filter("INNER JOIN conge ON salaries.id = conge.salaries_id INNER JOIN magasin ON salaries.magasin_id = magasin.id WHERE salaries_id <>" + AuthManager.Instance.User.Id + " AND magasin.id =" + AuthManager.Instance.User.Store.Id + " AND " + currentYear + " = YEAR(conge.date_debut) GROUP BY salaries.id").ToList();
        }

        public Employee FindByName(string name)
        {
            return EmployeeManager.Instance.First("WHERE \"" + name + "\" = CONCAT(prenom,' ',nom)");
        }
    }
}
