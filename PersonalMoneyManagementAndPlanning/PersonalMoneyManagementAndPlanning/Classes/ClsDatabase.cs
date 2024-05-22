using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using SqlLibrary;
using System.Drawing;

namespace PersonalMoneyManagementAndPlanning.Classes // DÖVİZ CİNSİ HESAPLAMALARI
{
    public static class ClsDatabase
    {
        private static readonly DatabaseManager Manager = new(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        private static readonly Authentication Auth = new(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        public static string Id;
        private static readonly string tbLogin = "Login", tbIncomes = "Incomes", tbExpenses = "Expenses";
        private static readonly int Year = DateTime.Now.Year, Month = DateTime.Now.Month, Day = DateTime.Now.Day;

        public static string Register(string name, string surname, string email, string password, string phoneNumber, string dateOfBirth)
        {
            string[] emails = Manager.GetColumn(tbLogin, "Email", null);

            if (emails.Contains(email))
            {
                return "EmailConflict";
            }

            Manager.Insert(tbLogin, ("Name", name), ("Surname", surname), ("Email", email), ("Password", password), ("PhoneNumber", phoneNumber), ("DateOfBirth", dateOfBirth), ("Registration", DateTime.Now.ToString()));
            return "Success";
        }

        public static bool Login(string email, string password)
        {
            return Auth.Login(tbLogin, "Email", email, "Password", password);
        }

        public static decimal TotalDailyIncomes(int day = 0, int month = 0, int year = 0)
        {
            if (day == 0)
            {
                day = Day;
            }
            if (month == 0)
            {
                month = Month;
            }
            if (year == 0)
            {
                year = Year;
            }

            DateTime date = new(year, month, day);
            decimal total = 0;
            foreach (var item in Manager.GetColumn(tbIncomes, "Amount", ("Date", "=", date.ToString("yyyy-MM-dd"), "")))
            {
                total += Convert.ToDecimal(item);
            }

            return total;
        }

        public static decimal TotalDailyExpenses(int day = 0, int month = 0, int year = 0)
        {
            if (day == 0)
            {
                day = Day;
            }
            if (month == 0)
            {
                month = Month;
            }
            if (year == 0)
            {
                year = Year;
            }

            DateTime date = new(year, month, day);
            decimal total = 0;
            foreach (var item in Manager.GetColumn(tbExpenses, "Amount", ("Date", "=", date.ToString("yyyy-MM-dd"), "")))
            {
                total += Convert.ToDecimal(item);
            }

            return total;
        }

        public static decimal TotalWeeklyIncomes(int day = 0, int month = 0, int year = 0)
        {
            if (day == 0)
            {
                day = Day;
            }
            if (month == 0)
            {
                month = Month;
            }
            if (year == 0)
            {
                year = Year;
            }

            DateTime startWeek = new(year, month, day);
            DateTime endWeek = startWeek.AddDays(7);
            decimal total = 0;
            foreach (var item in Manager.GetColumn(tbIncomes, "Amount", ("Date", "BETWEEN", startWeek.ToString("yyyy-MM-dd"), "AND"), ("", "", endWeek.ToString("yyyy-MM-dd"), "")))
            {
                total += Convert.ToDecimal(item);
            }

            return total;
        }

        public static decimal TotalWeeklyExpenses(int day = 0, int month = 0, int year = 0)
        {
            if (day == 0)
            {
                day = Day;
            }
            if (month == 0)
            {
                month = Month;
            }
            if (year == 0)
            {
                year = Year;
            }

            DateTime startWeek = new(year, month, day);
            DateTime endWeek = startWeek.AddDays(7);
            decimal total = 0;
            foreach (var item in Manager.GetColumn(tbExpenses, "Amount", ("Date", "BETWEEN", startWeek.ToString("yyyy-MM-dd"), "AND"), ("", "", endWeek.ToString("yyyy-MM-dd"), "")))
            {
                total += Convert.ToDecimal(item);
            }

            return total;
        }

        public static decimal TotalMonthlyIncomes(int month = 0, int year = 0)
        {
            if (month == 0)
            {
                month = Month;
            }
            if (year == 0)
            {
                year = Year;
            }

            int lastDay = DateTime.DaysInMonth(year, month);
            DateTime startMonth = new(year, month, 1);          
            DateTime endMonth = new(year, month, lastDay);
            decimal total = 0;
            foreach (var item in Manager.GetColumn(tbIncomes, "Amount", ("Date", "BETWEEN", startMonth.ToString("yyyy-MM-dd"), "AND"), ("", "", endMonth.ToString("yyyy-MM-dd"), "")))
            {
                total += Convert.ToDecimal(item);
            }

            return total;
        }

        public static decimal TotalMonthlyExpenses(int month = 0, int year = 0)
        {
            if (month == 0)
            {
                month = Month;
            }
            if (year == 0)
            {
                year = Year;
            }

            int lastDay = DateTime.DaysInMonth(year, month);
            DateTime startMonth = new(year, month, 1);
            DateTime endMonth = new(year, month, lastDay);
            decimal total = 0;
            foreach (var item in Manager.GetColumn(tbExpenses, "Amount", ("Date", "BETWEEN", startMonth.ToString("yyyy-MM-dd"), "AND"), ("", "", endMonth.ToString("yyyy-MM-dd"), "")))
            {
                total += Convert.ToDecimal(item);
            }

            return total;
        }

        public static decimal TotalYearlyIncomes(int year = 0)
        {
            if (year == 0)
            {
                year = Year;
            }

            int lastDay = DateTime.DaysInMonth(year, 12);
            DateTime startYear = new(year, 1, 1);
            DateTime endYear = new(year, 12, lastDay);
            decimal total = 0;
            foreach (var item in Manager.GetColumn(tbIncomes, "Amount", ("Date", "BETWEEN", startYear.ToString("yyyy-MM-dd"), "AND"), ("", "", endYear.ToString("yyyy-MM-dd"), "")))
            {
                total += Convert.ToDecimal(item);
            }

            return total;
        }

        public static decimal TotalYearlyExpenses(int year = 0)
        {
            if (year == 0)
            {
                year = Year;
            }

            int lastDay = DateTime.DaysInMonth(year, 12);
            DateTime startYear = new(year, 1, 1);
            DateTime endYear = new(year, 12, lastDay);
            decimal total = 0;
            foreach (var item in Manager.GetColumn(tbExpenses, "Amount", ("Date", "BETWEEN", startYear.ToString("yyyy-MM-dd"), "AND"), ("", "", endYear.ToString("yyyy-MM-dd"), "")))
            {
                total += Convert.ToDecimal(item);
            }

            return total;
        }

        public static decimal TotalIncomes()
        {
            decimal total = 0;
            foreach (var item in Manager.GetColumn(tbIncomes, "Amount", null))
            {
                total += Convert.ToDecimal(item);
            }

            return total;
        }

        public static decimal TotalExpenses()
        {
            decimal total = 0;
            foreach (var item in Manager.GetColumn(tbExpenses, "Amount", null))
            {
                total += Convert.ToDecimal(item);
            }

            return total;
        }
    }
}
