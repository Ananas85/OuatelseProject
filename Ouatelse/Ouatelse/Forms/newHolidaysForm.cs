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
        public NewHolidaysForm(Holiday holiday, int nbHolidays, int rest)
        {
            InitializeComponent();
            if (!holiday.Exists)
            {
                this.start.Visible = false;
                this.end.Visible = false;
                this.title.Text = "Nouveau congé";
                this.Name = "Demande de congé";
                this.startingDate.Text = holiday.StartingDate.ToLongDateString();
                this.endingDate.Text = holiday.EndingDate.ToLongDateString();
                this.nbDay.Text = nbHolidays.ToString();
                this.rest.Text = rest.ToString();
                this.amplitude.Text = (holiday.numberOfDays() + 1).ToString();
                return;
            }
            
        }

    }
}
