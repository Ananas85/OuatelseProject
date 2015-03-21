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

        public static string CreationQuery()
        {
            string query = " DROP TABLE IF EXISTS \"salaries\"; " + Environment.NewLine;
            query += " CREATE TABLE \"salaries\" ( " + Environment.NewLine;
            query += " \"id\" INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, " + Environment.NewLine;
            query += " \"nom\" TEXT(255,0) NOT NULL," + Environment.NewLine;
            query += " \"prenom\" TEXT(255,0) NOT NULL," + Environment.NewLine;
            query += " \"identifiant\" TEXT(45,0) NOT NULL," + Environment.NewLine;
            query += " \"mot_de_passe\" TEXT(45,0) NOT NULL," + Environment.NewLine;
            query += " \"adresse1\" TEXT NOT NULL," + Environment.NewLine;
            query += " \"adresse2\" TEXT," + Environment.NewLine;
            query += " \"fixe\" TEXT(255,0)," + Environment.NewLine;
            query += " \"portable\" TEXT(255,0)," + Environment.NewLine;
            query += " \"mail\" TEXT(255,0)," + Environment.NewLine;
            query += " \"naissance\" TEXT NOT NULL," + Environment.NewLine;
            query += " \"notes\" TEXT," + Environment.NewLine;
            query += " \"villes_id\" INTEGER(11,0) NOT NULL," + Environment.NewLine;
            query += " \"roles_id\" INTEGER(11,0) NOT NULL," + Environment.NewLine;
            query += " \"magasin_id\" INTEGER(11,0) NOT NULL," + Environment.NewLine;
            query += " \"civilite_id\" INTEGER(11,0) NOT NULL," + Environment.NewLine;
            query += " \"email_modification\" INTEGER(1,0) NOT NULL);";

            return query;
        }

        public static string CreationIndex()
        {
            string query = " CREATE UNIQUE INDEX \"fk_salaries_villes1_idx\" ON salaries (villes_id); " + Environment.NewLine;
            query += "  CREATE UNIQUE INDEX \"fk_salaries_roles1_idx\" ON salaries (roles_id); " + Environment.NewLine;
            query += " CREATE UNIQUE INDEX \"fk_salaries_magasin1_id\" ON salaries (magasin_id); " + Environment.NewLine;
            query += " CREATE INDEX \"fk_salaries_civilite1_idx\" ON salaries (civilite_id); ";
            return query;
        }

        public static string Fixtures()
        {
            return
                "INSERT INTO salaries VALUES (1, \"SALVADOR\", \"Jean-Jacques\", \"test\", \"test\", \"10, rue d'info-timde\", null, null, null, \"contact@ouatelse.fr\", \"1975-02-04\", null, 1, 1, 1, 1, 1);";
        }
    }
}
