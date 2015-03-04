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
using Ouatelse.Models;

namespace Ouatelse.Forms
{
    public partial class NewHolidaysForm : Form
    {
        private int alreadyPresent;

        public NewHolidaysForm(Holiday holiday, int nbHolidays, int alreadyPresent)
        {
            InitializeComponent();
            this.alreadyPresent = alreadyPresent;

            this.nbDay.Text = nbHolidays.ToString();
            this.rest.Text = (30 - nbHolidays - alreadyPresent).ToString();
            this.amplitude.Text = (holiday.numberOfDays() + 1).ToString();

            if (!holiday.Exists)
            {
                this.start.Visible = false;
                this.end.Visible = false;
                this.title.Text = "Nouveau congé";
                this.Name = "Demande de congé";
                this.startingDate.Text = holiday.StartingDate.ToLongDateString();
                this.endingDate.Text = holiday.EndingDate.ToLongDateString();
                
                return;
            }
            this.startingDate.Visible = false;
            this.endingDate.Visible = false;
            this.Name = "Modification de congé";
            this.title.Text = "Modification de congé";
            this.start.Value = holiday.StartingDate;
            this.end.Value = holiday.EndingDate;

        }

        private void start_ValueChanged(object sender, EventArgs e)
        {
            if (this.start.Value < DateTime.Now)
            {
                Utils.Error("Il n'est pas possible de poser des congés sur des jours passés");
                return;
            }
            if (this.start.Value > this.end.Value)
            {
                Utils.Error("Il faut que la date de début des congés soit avant celle de fin");
                return;
            }
        }

        private void end_ValueChanged(object sender, EventArgs e)
        {
            if (this.start.Value > this.end.Value)
            {
                Utils.Error("Il faut que la date de début des congés soit avant celle de fin");
                return;
            }
        }

    }
}
