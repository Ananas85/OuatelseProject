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
    public partial class NewHolidaysForm : Form
    {
        private int alreadyPresent;
        public Holiday CurrentHoliday { get; private set; }
        private int currentYear;
        private int nbHolidays;
        private bool init = true;

        public NewHolidaysForm(Holiday holiday, int nbHolidays, int alreadyPresent)
        {
            InitializeComponent();
            this.currentYear = holiday.StartingDate.Year;
            this.alreadyPresent = alreadyPresent;
            this.CurrentHoliday = holiday;
            this.nbHolidays = nbHolidays;

            this.nbDay.Text = nbHolidays.ToString();
            this.amplitude.Text = (CurrentHoliday.numberOfDays() + 1).ToString();

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

        private void validateButton_Click(object sender, EventArgs e)
        {
            
            if (HolidayManager.Instance.FilterByDateAndNotCurrent(CurrentHoliday.Id, this.start.Value) != null)
            {
                Utils.Error("Vous avez déjà des congés posés pendant cette période");
                this.DialogResult = DialogResult.None;
                return;
            }

            if ((nbHolidays + alreadyPresent) > 30)
            {
                Utils.Error("Vous ne pouvez pas poser plus de congés que vous en avez le droit");
                this.DialogResult = DialogResult.None;

                return;
            }
        }

        private void start_ValueChanged(object sender, EventArgs e)
        {
            if (!init)
            {
                UpdateData();
            }
        }

        private void end_ValueChanged(object sender, EventArgs e)
        {
            if (!init)
            {
                UpdateData();
            }
        }

        private void UpdateData()
        {
            if (this.start.Value > this.end.Value)
            {
                Utils.Error("Il faut que la date de début des congés soit avant celle de fin");
                this.DialogResult = DialogResult.None;
                return;
            }
            List<DateTime> holidaysSelected = new List<DateTime>();

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

    }
}
