using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ouatelse.Forms
{
    public partial class HolidayForm : Form
    {
        private int currentYear = DateTime.Now.Year;

        public HolidayForm()
        {
            InitializeComponent();

            designCalendar();

            fillCalendar();

            this.year.Text = currentYear.ToString();
        }

        #region Méthode pour mettre en forme le calendrier
        public void designCalendar()
        {
            //On fixe la largeur de la colonne des noms des mois
            this.holidays.RowHeadersWidth = 100;

            //On fixe le design de l'entête du tableau
            foreach (DataGridViewColumn col in this.holidays.Columns)
            {
                col.Width = 30;
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
        #endregion

        public void fillCalendar()
        {
            preventPreviousYear();
            for (int i = 1; i <= 12; ++i)
            {

                DataGridViewRow row = new DataGridViewRow();
                this.holidays.Rows.Add(row);
                row.HeaderCell.Value = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i);
                for (int j = 1; j <= 31; ++j)
                {
                    DataGridViewCell cell = holidays.Rows[i - 1].Cells[j - 1];
                    if (j <= DateTime.DaysInMonth(currentYear, i))
                    {
                        DateTime dateValue = new DateTime(currentYear, i, j);
                        string day = dateValue.ToString("ddd", new CultureInfo("fr-FR")).Substring(0, 1);
                        cell.Value = day;
                        cell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        if (day.Equals("s") || day.Equals("d"))
                        {
                            cell.Style.ForeColor = Color.Red;
                        }
                        else
                        {
                            cell.Style.Font = new Font("Arial", 8, FontStyle.Bold);
                        }
                    }
                    else
                    {
                        cell.ReadOnly = true;
                        cell.Style.BackColor = Color.Gray;
                    }
                }
            }
            preventSortingColumns();
        }

        public void updateCalendar()
        {
            preventPreviousYear();
            for (int i = 1; i <= 12; ++i)
            {
                for (int j = 1; j <= 31; ++j)
                {
                    DataGridViewCell cell = holidays.Rows[i-1].Cells[j-1];
                    cell.Style.BackColor = Color.White;
                    cell.Style.ForeColor = Color.Black;
                    if (j <= DateTime.DaysInMonth(currentYear, i))
                    {
                        DateTime dateValue = new DateTime(currentYear, i, j);
                        string day = dateValue.ToString("ddd", new CultureInfo("fr-FR")).Substring(0, 1);
                        cell.Value = day;
                        cell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        if (day.Equals("s") || day.Equals("d"))
                        {
                            cell.Style.ForeColor = Color.Red;
                        }
                        else
                        {
                            cell.Style.Font = new Font("Arial", 8, FontStyle.Bold);
                        }
                    }
                    else
                    {
                        cell.Value = "";
                        cell.ReadOnly = true;
                        cell.Style.BackColor = Color.Gray;
                    }
                }
            }
        }

        public void preventSortingColumns()
        {
            foreach (DataGridViewColumn c in holidays.Columns)
                c.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        public void preventPreviousYear()
        {
            if (currentYear == DateTime.Now.Year)
                this.previousYear.Enabled = false;
            else
                this.previousYear.Enabled = true;
        }

        static List<DateTime> SortAscending(List<DateTime> list)
        {
            list.Sort((a, b) => a.CompareTo(b));
            return list;
        }

        private void newholiday_Click(object sender, EventArgs e)
        {
            String data = "";
            List<DateTime> holidaysSelected = new List<DateTime>();
            List<DateTime> holidaysSorted = new List<DateTime>();
            foreach(DataGridViewCell c in holidays.SelectedCells)
            {
                DateTime dateValue = new DateTime(currentYear, c.RowIndex+1, c.ColumnIndex+1);
                holidaysSelected.Add(dateValue);
            }

            holidaysSorted = SortAscending(holidaysSelected);

            foreach (DateTime dt in holidaysSorted)
            {
                data += String.Format("{0:D}",dt);
                data += "\n";
            }
            Utils.Info(data);
        }

        private void previousYear_Click(object sender, EventArgs e)
        {
            if (currentYear > DateTime.Now.Year)
            {
                currentYear--;
                updateCalendar();
                this.year.Text = currentYear.ToString();
            }
        }

        private void nextYear_Click(object sender, EventArgs e)
        {
            currentYear++;
            updateCalendar();
            this.year.Text = currentYear.ToString();
        }
    }
}

