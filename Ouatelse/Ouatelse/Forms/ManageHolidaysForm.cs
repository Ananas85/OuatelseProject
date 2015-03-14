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
using Ouatelse.Managers;
using Ouatelse.Models;

namespace Ouatelse.Forms
{
    public partial class ManageHolidaysForm : Form
    {

        public enum AdminEventType { ACCEPT_HOLIDAYS, DISMISS_HOLIDAYS };

        #region Les attributs de la classe
        //L'année courante à la construction de la forme
        private int currentYear = DateTime.Now.Year;

        //Nombre de jour déjà posés
        private int alreadyPresent;

        private bool allEmployeesHolidays;

        private ToolTip tooltip;

        private Point oldCell;

        private string tooltipText;
        #endregion

        #region Constructeur de la forme
        public ManageHolidaysForm()
        {
            InitializeComponent();

            if (AuthManager.Instance.User.Role.Id == RoleManager.Instance.Find(1).Id)
            {
                this.admin.Visible = true;
                this.acceptButton.Visible = true;
                this.dismissButton.Visible = true;
            }
            else
            {
                this.admin.Visible = false;
                this.acceptButton.Visible = false;
                this.dismissButton.Visible = false;
            }



            this.allEmployeesHolidays = checkBox.Checked;

            designCalendar();

            FillCalendar();

            designForm();

            this.year.Text = currentYear.ToString();

            //On retire la sélection par défaut
            this.holidays.ClearSelection();

            this.tooltip = new ToolTip();

            oldCell = new Point(0, 0);

            tooltipText = "";

        }
        #endregion

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

        #region Méthode qui permet de remplir le calendrier au chargement
        public void FillCalendar()
        {

            //On test la possibilté d'aller voir le planing de l'année précédente
            preventPreviousYear();
         
            //Boucle pour gérer les mois
            for (int i = 1; i <= 12; ++i)
            {
                
                DataGridViewRow row = new DataGridViewRow();
                //On ajoute le mois courant
                this.holidays.Rows.Add(row);
                

                //On met en forme la colonne "légende"
                row.HeaderCell.Value = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i);

                //Boucle pour gérer les jours dans le mois courant.
                for (int j = 1; j <= 31; ++j)
                {
                    //On récupère la cellule courante.
                    DataGridViewCell cell = holidays.Rows[i - 1].Cells[j - 1];

                    //On vérifie que l'on ne dépasse pas le nombre de jour du mois en cours sinon on le grise
                    if (j <= DateTime.DaysInMonth(currentYear, i))
                    {
                        //On définit le style d'alignement de la cellule courante.
                        cell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                        //On Met le style de la cellule
                        cell.Style.Font = new Font("Arial", 8, FontStyle.Bold);

                        //On récupère la date liée à la cellule courante.
                        DateTime dateValue = new DateTime(currentYear, i, j);

                        //On récupère la première lettre du nom du jour
                        string day = dateValue.ToString("ddd", new CultureInfo("fr-FR")).Substring(0, 1);

                        //On met à jour le contenu de la cellule
                        cell.Value = day;
                        
                        //On vérifie si c'est un jour ouvrable, si ce n'en est pas un on le met en rouge
                        if (!ManageDate.Instance.isWorkingDate(dateValue, this.currentYear))
                        {
                            cell.Style.ForeColor = Color.Red;
                        }
                        if (dateValue < DateTime.Now)
                        {
                            cell.Style.BackColor = Color.Silver;
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

            //On cherche à afficher les jours déjà posés
            UpdateAlreadyPost();
        }
        #endregion

        #region Affichage des jours posés en tant que congés
        public void UpdateAlreadyPost()
        {
            //On remet à 0 les jours posés
            alreadyPresent = 0;
            
            //On récupère tous les congés déjà posés
            List<Holiday> putHolidays;
            if(allEmployeesHolidays)
                putHolidays = HolidayManager.Instance.Filter("WHERE " + currentYear + " = YEAR(date_debut)").ToList();
            else
                putHolidays = HolidayManager.Instance.Filter("WHERE salaries_id =" + AuthManager.Instance.User.Id + " AND " + currentYear + " = YEAR(date_debut)").ToList();

            //On place les congés déjà posés sur le calendrier
            foreach (Holiday holiday in putHolidays)
            {
                Color day = holiday.Accepted ? Color.LimeGreen : Color.Orange;
                DateTime current = holiday.StartingDate;
                for (int i = 0; i <= holiday.numberOfDays(); ++i)
                {
                    if (ManageDate.Instance.isWorkingDate(current, this.currentYear))
                        alreadyPresent++;
                    holidays.Rows[current.Month - 1].Cells[current.Day - 1].Style.BackColor = day;
                    current = current.AddDays(1);
                }
            }
            this.nbPut.Text = alreadyPresent.ToString();
            this.nbRest.Text = (30 - alreadyPresent).ToString();
        }
        #endregion

        #region Méthode utilisée lors de la modification du calendrier
        public void UpdateCalendar()
        {
            preventPreviousYear();
            preventNextYear();

            for (int i = 1; i <= 12; ++i)
            {
                for (int j = 1; j <= 31; ++j)
                {
                    //On récupère la cellule
                    DataGridViewCell cell = holidays.Rows[i-1].Cells[j-1];
                    //On met en forme la cellule
                    cell.Style.BackColor = Color.White;
                    cell.Style.ForeColor = Color.Black;
                    cell.Style.Font = new Font("Arial", 8, FontStyle.Bold);

                    //Si le jour courant est bien possible
                    if (j <= DateTime.DaysInMonth(currentYear, i))
                    {
                        DateTime dateValue = new DateTime(currentYear, i, j);
                        string day = dateValue.ToString("ddd", new CultureInfo("fr-FR")).Substring(0, 1);
                        cell.Value = day;
                        cell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                        if (!ManageDate.Instance.isWorkingDate(dateValue, this.currentYear))
                        {
                            cell.Style.ForeColor = Color.Red;
                        }
                        if (dateValue < DateTime.Now)
                        {
                            cell.Style.BackColor = Color.Silver;
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
            UpdateAlreadyPost();
            this.holidays.ClearSelection();
        }
        #endregion

        #region Sécurité passage entre les années et manipulation du datagridView
        #region On annule le tri des colonnes
        public void preventSortingColumns()
        {
            foreach (DataGridViewColumn c in holidays.Columns)
                c.SortMode = DataGridViewColumnSortMode.NotSortable;
        }
        #endregion

        #region On vérifie la possibilité de passer à une année antérieure
        private void preventPreviousYear()
        {
            this.previousYear.Enabled = currentYear != DateTime.Now.Year;
        }

        #endregion

        #region On vérifie la possibilité de passer à une année suivante
        private void preventNextYear()
        {
            if (currentYear > DateTime.Now.Year + 1)
            {
                this.nextYear.Enabled = false;
                return;
            }
            this.nextYear.Enabled = true;
        }
        #endregion

        #region Méthode pour gérer le clique sur l'année suivante
        private void nextYear_Click(object sender, EventArgs e)
        {
            currentYear++;
            UpdateCalendar();
            this.year.Text = currentYear.ToString();
        }
        #endregion

        #region Méthode pour gérer le clique sur l'année précédente
        private void previousYear_Click(object sender, EventArgs e)
        {
            if (currentYear > DateTime.Now.Year)
            {
                currentYear--;
                UpdateCalendar();
                this.year.Text = currentYear.ToString();
            }
        }
        #endregion
        #endregion

        #region Méthode pour gérer l'ajout de congés
        private void newholiday_Click(object sender, EventArgs e)
        {
            if (holidays.SelectedCells.Count == 0)
            {
                Utils.Error("Veuillez sélectionner au moins un jour pour créer un congé");
                return;
            }

            //On vérifie directemrnt le nombre de jour déjà posé
            if (alreadyPresent == 30)
            {
                Utils.Error("Vous avez déjà posé tous vos jours de congés");
                return;
            }
            
            //On regarde s'il y'a des jours non existants dans la selection
            if (holidays.SelectedCells.Cast<DataGridViewCell>()
                .Where(c => c.Style.BackColor == Color.Gray)
                .ToList()
                .Count > 0)
            {
                Utils.Error("Vous avez selectionné un ou plusieurs jours qui n'existent pas");
                return;
            }

            //On regarde s'il n'y a pas des congés déjà posé
            if (holidays.SelectedCells.Cast<DataGridViewCell>()
                    .Where(c => c.Style.BackColor == Color.Orange || c.Style.BackColor == Color.LimeGreen)
                    .ToList()
                    .Count > 0)
            {
                Utils.Error("Vous avez déjà posé des congés dans cette plage là");
                return;
            }

            //Si nous arrivons ici, la selection des jours est correctes
            List<DateTime> holidaysSelected = (from DataGridViewCell c in holidays.SelectedCells
                                               where c.Style.BackColor != Color.Gray 
                                               select new DateTime(currentYear, c.RowIndex + 1, c.ColumnIndex + 1)).ToList();

            
            //On récupère l'ordre croissant des dates posées pour les congés
            holidaysSelected = ManageDate.Instance.SortAscending(holidaysSelected);

            //On récupère le premier jour de la selection
            DateTime startingDate = holidaysSelected.First();

            //On récupère le dernier jour de la selection
            DateTime endingDate = holidaysSelected.Last();

            //On vérifie s'il n'y a pas d'intervalle vide entre les dates selectionnées
            if ((endingDate - startingDate).Days + 1 != holidaysSelected.Count)
            {
                Utils.Error("Vous devez choisir des jours consécutifs");
                return;
            }

            if (startingDate < DateTime.Now)
            {
                Utils.Error("Il n'est pas possible de poser des congés sur des jours passés");
                return;
            }


            int nbHollidays = holidaysSelected.Except(ManageDate.Instance.UnworkingDate).ToList().Count;

            if (nbHollidays + alreadyPresent > 30)
            {
                Utils.Error("Vous ne pouvez pas poser plus de congés que vous en avez le droit.");
                return;
            }

            Holiday holiday = new Holiday(startingDate, endingDate, AuthManager.Instance.User);
            

            if (new NewHolidaysForm(holiday, nbHollidays,alreadyPresent).ShowDialog() != DialogResult.OK) return;
            
            HolidayManager.Instance.Save(new Holiday(startingDate, endingDate, AuthManager.Instance.User));
            UpdateCalendar();
            Utils.Info("Votre demande de congé a bien été prise en compte");
        }
        #endregion

        #region Méthode pour gérer la sélection de jour pour suppression et modification
        private void SelectHolidays(bool modif)
        {
            if (holidays.SelectedCells.Count == 0)
            {
                Utils.Error("Veuillez sélectionner un jour");
                return;
            }

            if (this.holidays.SelectedCells.Count > 1)
            {
                Utils.Error("Sélectionnez uniquement une journée dans le congé concerné");
                return;
            }
            if (
                !ManageDate.Instance.IsExistingDay(this.holidays.SelectedCells[0].RowIndex + 1,
                    this.holidays.SelectedCells[0].ColumnIndex + 1))
            {
                Utils.Error("Ce jour n'existe pas");
                return;
            }

            DateTime date = new DateTime(currentYear, this.holidays.SelectedCells[0].RowIndex + 1, this.holidays.SelectedCells[0].ColumnIndex + 1);
            Holiday holiday = HolidayManager.Instance.FilterByDate(date);
            if (holiday == null)
            {
                Utils.Error("Ce jour n'est pas un congé");
                return;
            }

            if (holiday.Accepted)
            {
                Utils.Error(modif
                    ? "Vous ne pouvez modifier que les congés qui n'ont pas été validés"
                    : "Vous ne pouvez supprimer que les congés qui n'ont pas été validés");
                return;
            }

            if (!modif)
            {
                if (
                    Utils.Prompt("Voulez-vous vraiment supprimer votre demande de congé du " +
                                 holiday.StartingDate.ToShortDateString() +
                                 " au " + holiday.EndingDate.ToShortDateString() + " ? "))
                {
                    HolidayManager.Instance.Delete(holiday);
                    Utils.Notify("Suppression effectuée");
                }
            }
            else
            {
                int nbHollidays = holiday.ConcernedDays().Except(ManageDate.Instance.UnworkingDate).ToList().Count();
                NewHolidaysForm form = new NewHolidaysForm(holiday,nbHollidays,alreadyPresent);
                if (form.ShowDialog() != DialogResult.OK) return;
                HolidayManager.Instance.Save(form.CurrentHoliday);
                Utils.Notify("Modification enregistrée");
            }
            UpdateCalendar();

            
        }
        #endregion

        public void adminOperation(AdminEventType e)
        {
            if (this.holidays.SelectedCells.Count > 1)
            {
                Utils.Error("Sélectionnez uniquement une journée dans le congé concerné");
                return;
            }

            if (this.holidays.SelectedCells[0].Style.BackColor != Color.Orange)
            {
                Utils.Error("Le jour sélectionné n'est pas un dans un congé en attente d'approbation");
                return;
            }

            DateTime date = new DateTime(currentYear, this.holidays.SelectedCells[0].RowIndex + 1, this.holidays.SelectedCells[0].ColumnIndex + 1);
            List<Holiday> holidaysInstances = new List<Holiday>();
            holidaysInstances = HolidayManager.Instance.FilterAllByDate(date);

            Holiday holiday;
            if (holidaysInstances.Count > 1)
            {
                SelectHolidayForm selectForm = new SelectHolidayForm(holidaysInstances);
                if (selectForm.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                    return;

                holiday = selectForm.getHoliday();
            }
            else
                holiday = holidaysInstances[0];

            if (e == AdminEventType.DISMISS_HOLIDAYS)
            {
                if (
                    Utils.Prompt("Voulez-vous vraiment supprimer cette demande de congé du " +
                                 holiday.StartingDate.ToShortDateString() +
                                 " au " + holiday.EndingDate.ToShortDateString() + " ? "))
                {
                    HolidayManager.Instance.Delete(holiday);
                    Utils.Notify("Suppression effectuée");
                }
            }
            else if(e == AdminEventType.ACCEPT_HOLIDAYS)
            {
                holiday.Accepted = true;
                HolidayManager.Instance.Save(holiday);
                Utils.Notify("Congé validé");
            }
            UpdateCalendar();
        }


        #region Méthode pour gérer la modification
        private void modifyHoliday_Click(object sender, EventArgs e)
        {
            SelectHolidays(true);
        }
        #endregion

        #region Méthode pour gérer la suppression de congés
        private void deleteholiday_Click(object sender, EventArgs e)
        {
            SelectHolidays(false);
        }
        #endregion

        private void acceptButton_Click(object sender, EventArgs e)
        {
            adminOperation(AdminEventType.ACCEPT_HOLIDAYS);
        }

        private void dismissButton_Click(object sender, EventArgs e)
        {
            adminOperation(AdminEventType.DISMISS_HOLIDAYS);
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            this.allEmployeesHolidays = checkBox.Checked;
            UpdateCalendar();
            designForm();
        }

        public void designForm()
        {
            if (this.allEmployeesHolidays)
            {
                customEnabledStyle(acceptButton);
                customEnabledStyle(dismissButton);
                customDisabledStyle(newholiday);
                customDisabledStyle(modifyHoliday);
                customDisabledStyle(deleteholiday);

                holidayLabel.Visible = false;
                remainingHolidayLabel.Visible = false;
                nbPut.Visible = false;
                nbRest.Visible = false;
            }
            else
            {
                customDisabledStyle(acceptButton);
                customDisabledStyle(dismissButton);
                customEnabledStyle(newholiday);
                customEnabledStyle(modifyHoliday);
                customEnabledStyle(deleteholiday);

                holidayLabel.Visible = true;
                remainingHolidayLabel.Visible = true;
                nbPut.Visible = true;
                nbRest.Visible = true;
            }
        }

        public void customDisabledStyle(Button b)
        {
            b.Enabled = false;
            b.BackColor = Color.LightGray;
            b.ForeColor = Color.DarkGray;
        }

        public void customEnabledStyle(Button b)
        {
            b.Enabled = true;
            if (b.Tag == "ACCEPT" || b.Tag == "NEW")
                b.BackColor = Color.MediumSeaGreen;
            else if (b.Tag == "DISMISS" || b.Tag == "DELETE")
                b.BackColor = Color.IndianRed;
            else
                b.BackColor = Color.DarkOrange;
            b.ForeColor = SystemColors.ButtonFace;
        }

        private void holidays_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (allEmployeesHolidays)
            {
                if (oldCell != new Point(e.RowIndex, e.ColumnIndex))
                {
                    if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                    {
                        if (holidays.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == Color.Orange ||
                        holidays.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == Color.LimeGreen)
                        {
                            tooltipText = "";
                            DateTime date = new DateTime(currentYear, e.RowIndex + 1, e.ColumnIndex + 1);
                            List<Holiday> holidaysInCell = HolidayManager.Instance.FilterAllByDateToolTip(date);

                            // Set up the delays for the ToolTip.
                            tooltip.AutoPopDelay = 5000;
                            tooltip.InitialDelay = 1000;
                            tooltip.ReshowDelay = 500;

                            tooltip.ShowAlways = true;

                            if (holidaysInCell.Count > 1)
                            {
                                for (int i = 0; i < holidaysInCell.Count; i++)
                                {
                                    tooltipText += "- " + holidaysInCell[i].Employee.FirstName + " " + holidaysInCell[i].Employee.LastName
                                        + " (du " + holidaysInCell[i].StartingDate.ToShortDateString() + " au " + holidaysInCell[i].EndingDate.ToShortDateString() + ")";
                                    if (i != holidaysInCell.Count)
                                        tooltipText += Environment.NewLine;
                                }
                            }
                            else
                                tooltipText += "- " + holidaysInCell[0].Employee.FirstName + " " + holidaysInCell[0].Employee.LastName
                                    + " (du " + holidaysInCell[0].StartingDate.ToShortDateString() + " au " + holidaysInCell[0].EndingDate.ToShortDateString() + ")"; ;

                            // show and adjust tooltip
                            tooltip.Show(tooltipText, this, PointToClient(Cursor.Position).X + 25, PointToClient(Cursor.Position).Y+15);
                            oldCell = new Point(e.RowIndex,e.ColumnIndex);
                        }
                        else
                            tooltip.Hide(this);
                    }
                }
               }
        }

        private void holidays_MouseLeave(object sender, EventArgs e)
        {
            tooltip.Hide(this);
        }
    }
}

