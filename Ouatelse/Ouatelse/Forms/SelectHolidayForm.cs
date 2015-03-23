using Ouatelse.Managers;
using Ouatelse.Models;
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
    public partial class SelectHolidayForm : Form
    {
        private Holiday holiday;
        private List<Holiday> holidays;
        private List<KeyValuePair<int, string>> employees;
        public SelectHolidayForm(List<Holiday> h)
        {
            InitializeComponent();
            this.holidays = h;
            this.employees = new List<KeyValuePair<int, string>>();
            populatingData();
        }

        public void populatingData()
        {
            for(int i  = 0 ; i < holidays.Count ; i++){
                DataGridViewRow row = new DataGridViewRow();
                this.holidaysListView.Rows.Add(row);
                this.employees.Add(new KeyValuePair<int, string>(holidays[i].Employee.Id, holidays[i].Employee.FirstName + " " + holidays[i].Employee.LastName));

                this.holidaysListView.Rows[i].Cells[0].Value = this.employees[i].Value;
                this.holidaysListView.Rows[i].Cells[1].Value = holidays[i].StartingDate.ToShortDateString();
                this.holidaysListView.Rows[i].Cells[2].Value = holidays[i].EndingDate.ToShortDateString();
            }
        }
        public Holiday getHoliday(){
            return holiday;
        }

        private void validateButton_Click(object sender, EventArgs e)
        {
            if (holidaysListView.SelectedRows.Count == 0)
            {
                Utils.Error("Veuillez sélectionner un congé");
                return;
            }
            else
            {
                int indexRow = holidaysListView.SelectedRows[0].Index;
                DateTime startingDateTime = DateTime.ParseExact(holidaysListView.SelectedRows[0].Cells[1].Value.ToString(), "dd/MM/yyyy", null);
                DateTime endingDateTime = DateTime.ParseExact(holidaysListView.SelectedRows[0].Cells[2].Value.ToString(), "dd/MM/yyyy", null);
                Employee emp = EmployeeManager.Instance.Find(employees[indexRow].Key);

                holiday = HolidayManager.Instance.First("WHERE date_debut = '" 
                    + String.Format("{0:yyyy-MM-dd}", startingDateTime) 
                    + "' AND date_fin = '" + String.Format("{0:yyyy-MM-dd}", endingDateTime) 
                    + "' AND salaries_id = '" + emp.Id + "'");
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
