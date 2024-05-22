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
            CmbCalendar.Items.Add(ClsLang.GetText("Day"));
            CmbCalendar.Items.Add(ClsLang.GetText("Week"));
            CmbCalendar.Items.Add(ClsLang.GetText("Month"));
            CmbCalendar.Items.Add(ClsLang.GetText("Year"));
            CmbCalendar.SelectedIndex = 2;
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
                            MessageBox.Show(ClsLang.GetText("ErrorYear0"), ClsLang.GetText("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            MessageBox.Show(ClsLang.GetText("ErrorYear0"), ClsLang.GetText("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        MessageBox.Show(ClsLang.GetText("ErrorYear0"), ClsLang.GetText("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show(ClsLang.GetText("ErrorYear0"), ClsLang.GetText("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            MessageBox.Show(ClsLang.GetText("ErrorYear10000"), ClsLang.GetText("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            MessageBox.Show(ClsLang.GetText("ErrorYear10000"), ClsLang.GetText("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        MessageBox.Show(ClsLang.GetText("ErrorYear10000"), ClsLang.GetText("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show(ClsLang.GetText("ErrorYear10000"), ClsLang.GetText("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        #endregion

        // FUNCTION
        #region
        void ReportCalculation(decimal incomes, decimal expenses)
        {
            decimal total = incomes - expenses;

            LblIncome.Text = ClsLang.GetText("Income") + " : " + incomes + "₺";
            LblExpense.Text = ClsLang.GetText("Expense") + " : " + expenses + "₺";
            LblTotal.Text = ClsLang.GetText("Total") + " : " + total + "₺";

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

            LblTotalIncomePercent.Text = $"{ClsLang.GetText("Earning")} % {Math.Round(earningPer, 2)}";
            LblTotalExpensePercent.Text = $"{ClsLang.GetText("Expense")} % {Math.Round(totalExpensePer, 2)}";

            CpbDistribution.Maximum = Convert.ToInt32(totalAmount);
            CpbDistribution.Value = Math.Max(0, Convert.ToInt32(incomes));

            LblDistributionIncomePercent.Text = $"{ClsLang.GetText("Income")} % {Math.Round(incomePer, 2)}";
            LblDistributionExpensePercent.Text = $"{ClsLang.GetText("Expense")} % {Math.Round(distributionExpensePer, 2)}";
        }

        public void GetValues()
        {
            this.Text = ClsLang.GetText("MainForm");
            LblMonth.Text = ClsLang.GetMonths()[month - 1];
            CpbTotal.Text = ClsLang.GetText("Total");
            CpbDistribution.Text = ClsLang.GetText("Distribution");

            if (CmbCalendar.SelectedIndex == 0)
            {
                LblMonth.Text = ClsLang.GetMonths()[month - 1] + " - " + day;
                ReportCalculation(ClsDatabase.TotalDailyIncomes(day, month, year), ClsDatabase.TotalDailyExpenses(day, month, year));
            }
            else if (CmbCalendar.SelectedIndex == 1)
            {
                DateTime date = new(year, month, day);
                LblMonth.Text = $"{ClsLang.GetMonths()[month - 1]} ({day} - {date.AddDays(7).Day})";
                ReportCalculation(ClsDatabase.TotalWeeklyIncomes(day, month, year), ClsDatabase.TotalWeeklyExpenses(day, month, year));
            }
            else if (CmbCalendar.SelectedIndex == 2)
            {
                LblMonth.Text = ClsLang.GetMonths()[month - 1];
                ReportCalculation(ClsDatabase.TotalMonthlyIncomes(month, year), ClsDatabase.TotalMonthlyExpenses(month, year));
            }
            else if (CmbCalendar.SelectedIndex == 3)
            {
                LblMonth.Text = "";
                ReportCalculation(ClsDatabase.TotalYearlyIncomes(year), ClsDatabase.TotalYearlyExpenses(year));
            }
            
            LblYear.Text = year.ToString();
        }
        #endregion
    }
}
