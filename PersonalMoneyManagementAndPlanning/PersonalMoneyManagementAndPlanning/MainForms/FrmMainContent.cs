using PersonalMoneyManagementAndPlanning.Classes;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace PersonalMoneyManagementAndPlanning.MainForms
{
    public partial class FrmMainContent : Form
    {
        // VALUE
        #region
        int day = DateTime.Now.Day;
        int month = DateTime.Now.Month;
        int year = DateTime.Now.Year;
        #endregion

        // FORM 
        #region
        public FrmMainContent()
        {
            InitializeComponent();
        }

        private void FrmMainContent_Load(object sender, EventArgs e)
        {
            GetValues();

            // Calendar ComboBox
            #region
            CmbCalendar.Items.Clear();
            CmbCalendar.Items.Add(Lang.GetText("Day"));
            CmbCalendar.Items.Add(Lang.GetText("Week"));
            CmbCalendar.Items.Add(Lang.GetText("Month"));
            CmbCalendar.Items.Add(Lang.GetText("Year"));
            CmbCalendar.SelectedIndex = 2;
            #endregion

            // Accounts ComboBox
            #region
            foreach (var item in Database.AccountList())
            {
                CmbAccounts.Items.Add(item.Name);
            }
            CmbAccounts.Items.Add(Lang.GetText("All"));
            CmbAccounts.SelectedIndex = 0;
            #endregion
        }
        #endregion

        // BUTTON
        #region
        private void BtnBack_Click(object sender, EventArgs e)
        {
            // Day
            #region
            if (CmbCalendar.SelectedIndex == 0)
            {
                day--;
                if (day == 0)
                {
                    month--;
                    if (month == 0)
                    {
                        month = 12;

                        year--;
                        if (year == 0)
                        {
                            year = 1;                            
                            MessageBox.Show(Lang.GetText("ErrorYear0"), Lang.GetText("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    day = DateTime.DaysInMonth(year, month);
                }
            }
            #endregion

            // Week
            #region
            if (CmbCalendar.SelectedIndex == 1)
            {
                day -= 7;
                if (day <= 0)
                {
                    month--;
                    if (month == 0)
                    {
                        month = 12;

                        year--;
                        if (year == 0)
                        {
                            year = 1;
                            MessageBox.Show(Lang.GetText("ErrorYear0"), Lang.GetText("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    day = DateTime.DaysInMonth(year, month) + day;
                }
            }
            #endregion

            // Month
            #region
            if (CmbCalendar.SelectedIndex == 2)
            {
                month--;
                if (month == 0)
                {
                    month = 12;

                    year--;
                    if (year == 0)
                    {
                        year = 1;                    
                        MessageBox.Show(Lang.GetText("ErrorYear0"), Lang.GetText("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            #endregion

            // Year
            #region
            if (CmbCalendar.SelectedIndex == 3)
            {
                year--;
                if (year == 0)
                {
                    year = 1;
                    MessageBox.Show(Lang.GetText("ErrorYear0"), Lang.GetText("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            #endregion

            GetValues();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            // Day
            #region
            if (CmbCalendar.SelectedIndex == 0)
            {
                day++;
                if (day > DateTime.DaysInMonth(year, month))
                {
                    month++;
                    if (month == 13)
                    {
                        month = 1;

                        year++;
                        if (year == 10000)
                        {
                            year = 9999;
                            MessageBox.Show(Lang.GetText("ErrorYear10000"), Lang.GetText("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    day = 1;
                }
            }
            #endregion

            // Week
            #region
            if (CmbCalendar.SelectedIndex == 1)
            {
                day += 7;
                if (day > DateTime.DaysInMonth(year, month))
                {
                    month++;
                    if (month == 13)
                    {
                        month = 1;

                        year++;
                        if (year == 10000)
                        {
                            year = 9999;
                            MessageBox.Show(Lang.GetText("ErrorYear10000"), Lang.GetText("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    
                    if (month - 1 == 0)
                    {
                        day -= DateTime.DaysInMonth(year - 1, 12);
                    }
                    else
                    {
                        day -= DateTime.DaysInMonth(year, month - 1);
                    }
                }
            }
            #endregion

            // Month
            #region
            if (CmbCalendar.SelectedIndex == 2)
            {
                month++;
                if (month == 13)
                {
                    month = 1;

                    year++;
                    if (year == 10000)
                    {
                        year = 9999;
                        MessageBox.Show(Lang.GetText("ErrorYear10000"), Lang.GetText("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            #endregion

            // Year
            #region
            if (CmbCalendar.SelectedIndex == 3)
            {
                year++;
                if (year == 10000)
                {
                    year = 9999;
                    MessageBox.Show(Lang.GetText("ErrorYear10000"), Lang.GetText("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            #endregion

            GetValues();
        }
        #endregion

        // COMBOBOX
        #region
        private void CmbCalendar_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetValues();
        }

        private void CmbAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetValues();
        }
        #endregion

        // FUNCTION
        #region
        void ReportCalculation(decimal incomes, decimal expenses)
        {
            string symbol = Database.CurrencySymbol(CmbAccounts.Text);
            decimal total = incomes - expenses;

            LblIncome.Text = Lang.GetText("Income") + " : " + incomes + symbol;
            LblExpense.Text = Lang.GetText("Expense") + " : " + expenses + symbol;
            LblTotal.Text = Lang.GetText("Total") + " : " + total + symbol;

            CpbTotal.Maximum = Convert.ToInt32(incomes + expenses);
            CpbTotal.Value = Math.Max(0, Convert.ToInt32(total));

            decimal totalAmount = incomes + expenses;
            decimal earningPer = 0, totalExpensePer = 0, incomePer = 0, distributionExpensePer = 0;

            if (totalAmount != 0)
            {
                if (total == 0)
                {
                    earningPer = 0;
                    totalExpensePer = 100;
                    incomePer = 50;
                    distributionExpensePer = 50;
                }
                else
                {
                    earningPer = total / totalAmount * 100;
                    totalExpensePer = (totalAmount - total) / totalAmount * 100;
                    incomePer = incomes / totalAmount * 100;
                    distributionExpensePer = expenses / totalAmount * 100;
                }
            }

            LblTotalIncomePercent.Text = $"{Lang.GetText("Earning")} % {Math.Round(earningPer, 2)}";
            LblTotalExpensePercent.Text = $"{Lang.GetText("Expense")} % {Math.Round(totalExpensePer, 2)}";

            CpbDistribution.Maximum = Convert.ToInt32(totalAmount);
            CpbDistribution.Value = Math.Max(0, Convert.ToInt32(incomes));

            LblDistributionIncomePercent.Text = $"{Lang.GetText("Income")} % {Math.Round(incomePer, 2)}";
            LblDistributionExpensePercent.Text = $"{Lang.GetText("Expense")} % {Math.Round(distributionExpensePer, 2)}";
        }

        public void GetValues()
        {
            this.Text = Lang.GetText("MainForm");
            LblMonth.Text = Lang.GetMonths()[month - 1];
            CpbTotal.Text = Lang.GetText("Total");
            CpbDistribution.Text = Lang.GetText("Distribution");

            if (CmbCalendar.SelectedIndex == 0)
            {
                LblMonth.Text = Lang.GetMonths()[month - 1] + " - " + day;
                ReportCalculation(Database.TotalDailyIncomes(day, month, year, CmbAccounts.Text), Database.TotalDailyExpenses(day, month, year, CmbAccounts.Text));
            }
            else if (CmbCalendar.SelectedIndex == 1)
            {
                DateTime date = new(year, month, day);
                LblMonth.Text = $"{Lang.GetMonths()[month - 1]} ({day} - {date.AddDays(7).Day})";
                ReportCalculation(Database.TotalWeeklyIncomes(day, month, year, CmbAccounts.Text), Database.TotalWeeklyExpenses(day, month, year, CmbAccounts.Text));
            }
            else if (CmbCalendar.SelectedIndex == 2)
            {
                LblMonth.Text = Lang.GetMonths()[month - 1];
                ReportCalculation(Database.TotalMonthlyIncomes(month, year, CmbAccounts.Text), Database.TotalMonthlyExpenses(month, year, CmbAccounts.Text));
            }
            else if (CmbCalendar.SelectedIndex == 3)
            {
                LblMonth.Text = "";
                ReportCalculation(Database.TotalYearlyIncomes(year, CmbAccounts.Text), Database.TotalYearlyExpenses(year, CmbAccounts.Text));
            }
            
            LblYear.Text = year.ToString();
        }
        #endregion
    }
}
