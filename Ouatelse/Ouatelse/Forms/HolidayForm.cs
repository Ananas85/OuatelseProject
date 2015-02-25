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
        public HolidayForm()
        {
            InitializeComponent();

            this.holidays.RowHeadersWidth = 100;
            foreach (DataGridViewColumn col in this.holidays.Columns)
            {
                col.Width = 30;
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            for (int i = 1; i <= 12; ++i)
            {

                DataGridViewRow row = new DataGridViewRow();
                this.holidays.Rows.Add(row);
                row.HeaderCell.Value = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i);
                for (int j = 1; j <= 31; ++j)
                {
                    DataGridViewCell cell = holidays.Rows[i - 1].Cells[j - 1];
                    if (j <= DateTime.DaysInMonth(DateTime.Now.Year, i))
                    {
                        DateTime dateValue = new DateTime(DateTime.Now.Year, i, j);
                        string day = dateValue.ToString("ddd", new CultureInfo("fr-FR")).Substring(0, 1);
                        cell.Value = day;
                        cell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
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

        public void preventSortingColumns()
        {
            foreach (DataGridViewColumn c in holidays.Columns)
                c.SortMode = DataGridViewColumnSortMode.NotSortable;
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
                DateTime dateValue = new DateTime(DateTime.Now.Year, c.RowIndex+1, c.ColumnIndex+1);
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
    }
}

