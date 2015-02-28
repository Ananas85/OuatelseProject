using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ouatelse.Forms
{
    public partial class NewHolidaysForm : Form
    {
        public NewHolidaysForm(DateTime start, DateTime end, int nbHolidays, int amplitude)
        {
            InitializeComponent();
            this.startingDate.Text = start.ToLongDateString();
            this.endingDate.Text = end.ToLongDateString();
            this.nbDay.Text = nbHolidays.ToString();
            this.amplitude.Text = amplitude.ToString();
        }

    }
}
