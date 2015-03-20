using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouatelse
{
    public class ManageDate
    {
        private static ManageDate _instance = null;

        public static ManageDate Instance
        {
            get { return _instance ?? (_instance = new ManageDate()); }
        }

        public List<DateTime> UnworkingDate
        {
            get { return unworkingDate; }
            set { unworkingDate = value; }
        }

        private static int currentYear = DateTime.Now.Year;

        //Liste des jours fériés de l'année courante
        private static List<DateTime> permanentUnworkingDate;

        //Liste des jours où l'on ne travaille pas cette années
        private static List<DateTime> unworkingDate = new List<DateTime>();

        public ManageDate()
        {
            FillPermanentUnworkingDate();
        }

        #region Méthode pour savoir si un jour existe
        public bool IsExistingDay(int month, int day)
        {
            return day < DateTime.DaysInMonth(currentYear, month);
        }
        #endregion

        #region Méthode qui permet d'enregistrer tous les jours fériés de l'année courante
        private void FillPermanentUnworkingDate()
        {
            permanentUnworkingDate = new List<DateTime>
            {
                //1er Janvier
                new DateTime(currentYear, 1, 1),
                //1er Mai
                new DateTime(currentYear, 5, 1),
                //8 Mai
                new DateTime(currentYear, 5, 8),
                //Fête Nationale
                new DateTime(currentYear, 7, 14),
                //L'assomption
                new DateTime(currentYear, 8, 15),
                //La toussaint
                new DateTime(currentYear, 11, 1),
                //L'armistice
                new DateTime(currentYear, 11, 11),
                //Noël
                new DateTime(currentYear, 12, 25)
            };

            //Calcul des jours non fixes ( algorithme de oudin ) 
            //Calcul du nombre d'or - 1
            int goldNumber = (int)(currentYear % 19);
            //Année diviser par 100
            int yearPerHundred = (int)(currentYear / 100);
            // Calcul de l'epacte
            int epacte = (int)((yearPerHundred - yearPerHundred / 4 - (8 * yearPerHundred + 13) / 25 + (19 * goldNumber) + 15) % 30);
            //Le nombre de jours à partir du 21 mars pour atteindre la pleine lune Pascale
            int daysEquinoxeToMoonFull = (int)(epacte - (epacte / 28) * (1 - (epacte / 28) * (29 / (epacte + 1)) * ((21 - goldNumber) / 11)));
            //Jour de la semaine pour la pleine lune Pascale (0=dimanche)
            int weekDayMoonFull = (int)((currentYear + currentYear / 4 + daysEquinoxeToMoonFull + 2 - yearPerHundred + yearPerHundred / 4) % 7);
            // Nombre de jours du 21 mars jusqu'au dimanche de ou 
            // avant la pleine lune Pascale (un nombre entre -6 et 28)
            int daysEquinoxeBeforeFullMoon = daysEquinoxeToMoonFull - weekDayMoonFull;
            // mois de pâques
            int monthPaques = (int)(3 + (daysEquinoxeBeforeFullMoon + 40) / 44);
            // jour de pâques
            int dayPaques = (int)(daysEquinoxeBeforeFullMoon + 28 - 31 * (monthPaques / 4));
            // lundi de pâques
            DateTime mondayPaques = new DateTime(currentYear, monthPaques, dayPaques + 1);
            permanentUnworkingDate.Add(mondayPaques);
            // Ascension
            permanentUnworkingDate.Add(mondayPaques.AddDays(38));
            //Pentecote
            permanentUnworkingDate.Add(mondayPaques.AddDays(49));
        }
        #endregion

        #region Méthode qui dit si le jour testé est un jour ouvrable
        public bool isWorkingDate(DateTime date, int current)
        {
            if (current != currentYear)
            {
                FillPermanentUnworkingDate();
            }
            //S'il est dans la liste des jours fériés permanents ou des dimanches.
            if (permanentUnworkingDate.Contains(date) || date.DayOfWeek == DayOfWeek.Sunday)
            {
                unworkingDate.Add(date);
                return false;
            }
            return true;
        }
        #endregion

        #region Méthode pour trier une liste de date
        public List<DateTime> SortAscending(List<DateTime> list)
        {
            list.Sort((a, b) => a.CompareTo(b));
            return list;
        }
        #endregion
    }
}
