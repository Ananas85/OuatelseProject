using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.HtmlControls;
using System.Windows.Forms;
using Ouatelse.Managers;
using Ouatelse.Models;

namespace Ouatelse.Forms
{
    /// <summary>
    /// Classe pour créer ou modifier un congé
    /// </summary>
    public partial class NewHolidaysForm : Form
    {
        #region Les attributs
        //Le nombre de vacances déjà posées
        private int alreadyPresent;
        
        //Le congé en cours
        public Holiday CurrentHoliday { get; private set; }

        //L'année concernée par le congé
        private int currentYear;

        //Le nombre de jour de congé concernés
        private int nbHolidays;

        //Pour savoir si l'on est en train de charger la forme
        private bool init = true;
        #endregion

        #region Le constructeur
        /// <summary>
        /// Le constructeur
        /// </summary>
        /// <param name="holiday">Le congé concerné</param>
        /// <param name="nbHolidays">Le nombre de vacances</param>
        /// <param name="alreadyPresent">Le nombre de congé déjà posé</param>
        public NewHolidaysForm(Holiday holiday, int nbHolidays, int alreadyPresent)
        {
            InitializeComponent();
            
            //On associe tous les contrôles aux données

            this.currentYear = holiday.StartingDate.Year;
            this.alreadyPresent = alreadyPresent;
            this.CurrentHoliday = holiday;
            this.nbHolidays = nbHolidays;

            this.nbDay.Text = nbHolidays.ToString();
            this.amplitude.Text = (CurrentHoliday.numberOfDays() + 1).ToString();

            //Si le congé est pas persisté ça veut dire que l'on est en création
            if (!holiday.Exists)
            {
                this.start.Visible = false;
                this.end.Visible = false;
                this.title.Text = "Nouveau congé";
                this.Name = "Demande de congé";
                this.startingDate.Text = holiday.StartingDate.ToLongDateString();
                this.endingDate.Text = holiday.EndingDate.ToLongDateString();
                this.rest.Text = (30 - nbHolidays - alreadyPresent).ToString();

                return;
            }

            this.startingDate.Visible = false;
            this.endingDate.Visible = false;
            this.Name = "Modification de congé";
            this.title.Text = "Modification de congé";
            this.end.Value = holiday.EndingDate;
            this.start.Value = holiday.StartingDate;
            this.rest.Text = (30 - alreadyPresent).ToString();
            init = false;

        }
        #endregion

        #region Click sur le bouton valider
        private void validateButton_Click(object sender, EventArgs e)
        {
            //Si Le congés courant est déjà posé
            if (HolidayManager.Instance.FilterByDateAndNotCurrent(CurrentHoliday.Id, this.start.Value) != null)
            {
                Utils.Error("Vous avez déjà des congés posés pendant cette période");
                this.DialogResult = DialogResult.None;
                return;
            }

            //Si le nombre de congés est supérieur au nombre de congés autorisés
            if ((nbHolidays + alreadyPresent) > 30)
            {
                Utils.Error("Vous ne pouvez pas poser plus de congés que vous en avez le droit");
                this.DialogResult = DialogResult.None;

                return;
            }
        }
        #endregion

        #region Lorsque la date de départ est modifiée
        private void start_ValueChanged(object sender, EventArgs e)
        {
            if (!init)
            {
                UpdateData();
            }
        }
        #endregion

        #region Lorsque la date fin est modifié
        private void end_ValueChanged(object sender, EventArgs e)
        {
            if (!init)
            {
                UpdateData();
            }
        }
        #endregion

        #region Pour vérifier les données du congés
        private void UpdateData()
        {
            //Il faut que les dates soient cohérentes
            if (this.start.Value > this.end.Value)
            {
                Utils.Error("Il faut que la date de début des congés soit avant celle de fin");
                this.DialogResult = DialogResult.None;
                return;
            }
            List<DateTime> holidaysSelected = new List<DateTime>();

            //On vérifie le nombre de jour ouvrés concernés
            for (DateTime counter = this.start.Value; counter <= this.end.Value; counter = counter.AddDays(1))
            {
                if (ManageDate.Instance.isWorkingDate(counter, currentYear))
                    holidaysSelected.Add(counter);
            }

            CurrentHoliday.EndingDate = this.end.Value;
            CurrentHoliday.StartingDate = this.start.Value;
            this.nbHolidays = holidaysSelected.Count;
            Utils.Info(nbHolidays.ToString());
            this.nbDay.Text = nbHolidays.ToString();
            this.amplitude.Text = (CurrentHoliday.numberOfDays() + 1).ToString();
            this.rest.Text = (30 - nbHolidays - alreadyPresent).ToString();
        }
        #endregion

    }
}
