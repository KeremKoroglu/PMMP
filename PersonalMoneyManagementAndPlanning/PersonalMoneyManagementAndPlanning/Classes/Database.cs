using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using SqlLibrary;
using System.Drawing;
using System.Security.Principal;
using System.Data;
using System.Data.SqlClient;
using Dapper.Contrib.Extensions;
using Dapper;
using static PersonalMoneyManagementAndPlanning.Classes.Database;

namespace PersonalMoneyManagementAndPlanning.Classes
{
    public static class Database
    {
        private static readonly SqlConnection Con = new(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        public static readonly DatabaseManager Manager = new(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        private static readonly Authentication Auth = new(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        public static string Id;
        private static readonly string tbUsers = "Users", tbIncomes = "Incomes", tbExpenses = "Expenses",
            tbAccounts = "Accounts", tbIEC = "IncomeAndExpenseCategories", tbAC = "AccountCategories",
            tbCC = "CurrencyCategories";
        private static readonly int Year = DateTime.Now.Year, Month = DateTime.Now.Month, Day = DateTime.Now.Day;

        // PRIVATE
        #region
        private static string TranslateAccountText(string text)
        {
            return text switch
            {
                "Tümü" => "All",
                "Nakit" => "Cash",
                "Banka Hesabı" => "BankAccount",
                "Kredi Kartı" => "CreditCard",
                "Banka Kartı" => "BankCard",
                "Tasarruf" => "Saving",
                "Yatırım" => "Investmen",
                "Kredi" => "Credit",
                "Diğer" => "Other",
                _ => text,
            };
        }

        private static string TranslateIECText(string text)
        {
            return text switch
            {
                "Tümü" => "All",
                "Yemek" => "Food",
                "Eğlence" => "Entertainment",
                "Ulaşım" => "Transport",
                "Hobi" => "Hobby",
                "Giyim" => "Clothing",
                "Sağlık" => "Health",
                "Eğitim" => "Education",
                "Fatura" => "Bill",
                "Elektrik Faturası" => "ElectricityBill",
                "Isınma Faturası" => "HeatingBill",
                "Su Faturası" => "WaterBill",
                "İnternet Faturası" => "InternetBill",
                "Televizyon Faturası" => "TelevisionBill",
                "Telefon Faturası" => "PhoneBill",
                "Bağış" => "Charity",
                "Kredi Kartı" => "CreditCard",
                "Ev" => "Home",
                "Çocuk" => "Kid",
                "Kişisel Bakım" => "PersonalCare",
                "Evcil Hayvan" => "Pet",
                "Kira" => "Rent",
                "Maaş" => "Salary",
                "Satış" => "Sale",
                "Abonelik" => "Subscription",
                "Seyahat" => "Travel",
                "Diğer" => "Other",
                _ => text,
            };
        }
        #endregion

        // PUBLIC
        #region

        public static void SetId(string email)
        {
            Id = Manager.GetColumn(tbUsers, "Id", ("Email", "=", email, null))[0];
        }

        public static string Register(string name, string surname, string email, string password, string phoneNumber, string dateOfBirth)
        {
            string[] emails = Manager.GetColumn(tbUsers, "Email", null);

            if (emails.Contains(email))
            {
                return "EmailConflict";
            }

            Manager.Insert(tbUsers, ("Name", name), ("Surname", surname), ("Email", email), ("Password", password), ("PhoneNumber", phoneNumber), ("DateOfBirth", dateOfBirth), ("Registration", DateTime.Now.ToString()));
            return "Success";
        }

        public static bool Login(string email, string password)
        {
            return Auth.Login(tbUsers, "Email", email, "Password", password);
        }

        // Get
        #region
        public static List<IncomeAndExpense> IncomeAndExpenseList(string account, string sort)
        {
            var iae = new List<IncomeAndExpense>();
            if (Manager.IsThere(tbIncomes, "Account", ("Account", "=", account, null)) && Manager.IsThere(tbExpenses, "Account", ("Account", "=", account, null)))
            {
                var incomes = Con.Query<IncomeAndExpense>($"SELECT Id, UserId, Description, Amount, Category, Account, Scenario, Date, 'Income' AS TableName FROM {tbIncomes} WHERE UserId = {Id} AND Account = '{account}'").ToList();
                var expenses = Con.Query<IncomeAndExpense>($"SELECT Id, UserId, Description, Amount, Category, Account, Scenario, Date, 'Expense' AS TableName FROM {tbExpenses} WHERE UserId = {Id} AND Account = '{account}'").ToList();
                iae = incomes.Concat(expenses).ToList();
            }
            else if (Manager.IsThere(tbExpenses, "Account", ("Account", "=", account, null)) && !Manager.IsThere(tbExpenses, "Account", ("Account", "=", account, null)))
            {
                var incomes = Con.Query<IncomeAndExpense>($"SELECT Id, UserId, Description, Amount, Category, Account, Scenario, Date, 'Income' AS TableName FROM {tbIncomes} WHERE UserId = {Id} AND Account = '{account}'").ToList();
                iae = incomes.ToList();
            }
            else if (!Manager.IsThere(tbExpenses, "Account", ("Account", "=", account, null)) && Manager.IsThere(tbExpenses, "Account", ("Account", "=", account, null)))
            {
                var expenses = Con.Query<IncomeAndExpense>($"SELECT Id, UserId, Description, Amount, Category, Account, Scenario, Date, 'Expense' AS TableName FROM {tbExpenses} WHERE UserId = {Id} AND Account = '{account}'").ToList();
                iae = expenses.ToList();
            }
            else
            {
                return null;
            }

            return sort switch
            {
                "Tarih" or "Date" => iae.OrderBy(t => t.Date).ToList(),
                "Tutar" or "Amount" => iae.OrderBy(t => t.Amount).ToList(),
                "Kategori" or "Category" => iae.OrderBy(t => t.Category).ToList(),
                "Hesap" or "Account" => iae.OrderBy(t => t.Account).ToList(),
                _ => iae.ToList(),
            };
        }

        public static string CurrencySymbol(string account) // Tümü Seçildiğinde Ana Birim Cinsinden Hesapla
        {
            string currency = Manager.GetColumn(tbAccounts, "Currency", ("Name", "=", account, null))[0];
            return Manager.GetColumn(tbCC, "Symbol", ("Name", "=", currency, null))[0];
        }
        #endregion

        // Additions
        #region
        public static void AddIncome(string description, string amount, string category, string account, string date)
        {
            category = TranslateIECText(category);
            account = TranslateAccountText(account);
            Manager.Insert(tbIncomes, ("UserId", Id), ("Description", description), ("Amount", amount), ("Category", category), ("Account", account), ("Date", date));
        }

        public static void AddExpense(string description, string amount, string category, string account, string date)
        {
            category = TranslateIECText(category);
            account = TranslateAccountText(account);
            Manager.Insert(tbExpenses, ("UserId", Id), ("Description", description), ("Amount", amount), ("Category", category), ("Account", account), ("Date", date));
        }
        
        public static void AddAccount(string no, string name, string description, string category, string currency, string createdDate)
        {
            category = TranslateAccountText(category);
            Manager.Insert(tbAccounts, ("UserId", Id), ("No", no), ("Name", name), ("Description", description), ("Category", category), ("Currency", currency), ("CreatedDate", createdDate));
        }
        #endregion

        // Lists
        #region
        public static string[] IncomeAndExpenseCategories()
        {
            return Manager.GetColumn(tbIEC, "Name", null);
        }

        public static string[] AccountCategories()
        {
            return Manager.GetColumn(tbAC, "Name", null);
        }

        public static string[] CurrencyCategories()
        {
            return Manager.GetColumn(tbCC, "Name", null);
        }

        public static string[] Accounts()
        {
            return Manager.GetColumn(tbAccounts, "Name", ("UserId", "=", Id, null));
        }
        #endregion

        // Calculations
        #region
        public static decimal TotalDailyIncomes(int day = 0, int month = 0, int year = 0, string account = "All")
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
            account = TranslateAccountText(account);

            if (account == "All")
            {
                foreach (var item in Manager.GetColumn(tbIncomes, "Amount", ("UserId", "=", Id, "AND"), ("Date", "=", date.ToString("yyyy-MM-dd"), null)))
                {
                    total += Convert.ToDecimal(item);
                }

                return total;
            }

            foreach (var item in Manager.GetColumn(tbIncomes, "Amount", ("UserId", "=", Id, "AND"), ("Account", "=", account, "AND"), ("Date", "=", date.ToString("yyyy-MM-dd"), null)))
            {
                total += Convert.ToDecimal(item);
            }

            return total;
        }

        public static decimal TotalDailyExpenses(int day = 0, int month = 0, int year = 0, string account = "All")
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
            account = TranslateAccountText(account);

            if (account == "All")
            {
                foreach (var item in Manager.GetColumn(tbExpenses, "Amount", ("UserId", "=", Id, "AND"), ("Date", "=", date.ToString("yyyy-MM-dd"), null)))
                {
                    total += Convert.ToDecimal(item);
                }

                return total;
            }

            foreach (var item in Manager.GetColumn(tbExpenses, "Amount", ("UserId", "=", Id, "AND"), ("Account", "=", account, "AND"), ("Date", "=", date.ToString("yyyy-MM-dd"), null)))
            {
                total += Convert.ToDecimal(item);
            }

            return total;
        }

        public static decimal TotalWeeklyIncomes(int day = 0, int month = 0, int year = 0, string account = "All")
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
            account = TranslateAccountText(account);

            if (account == "All")
            {
                foreach (var item in Manager.GetColumn(tbIncomes, "Amount", ("UserId", "=", Id, "AND"), ("Date", "BETWEEN", startWeek.ToString("yyyy-MM-dd"), "AND"), ("", "", endWeek.ToString("yyyy-MM-dd"), null)))
                {
                    total += Convert.ToDecimal(item);
                }

                return total;
            }

            foreach (var item in Manager.GetColumn(tbIncomes, "Amount", ("UserId", "=", Id, "AND"), ("Account", "=", account, "AND"), ("Date", "BETWEEN", startWeek.ToString("yyyy-MM-dd"), "AND"), ("", "", endWeek.ToString("yyyy-MM-dd"), null)))
            {
                total += Convert.ToDecimal(item);
            }

            return total;
        }

        public static decimal TotalWeeklyExpenses(int day = 0, int month = 0, int year = 0, string account = "All")
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
            account = TranslateAccountText(account);

            if (account == "All")
            {
                foreach (var item in Manager.GetColumn(tbExpenses, "Amount", ("UserId", "=", Id, "AND"), ("Date", "BETWEEN", startWeek.ToString("yyyy-MM-dd"), "AND"), ("", "", endWeek.ToString("yyyy-MM-dd"), null)))
                {
                    total += Convert.ToDecimal(item);
                }

                return total;
            }

            foreach (var item in Manager.GetColumn(tbExpenses, "Amount", ("UserId", "=", Id, "AND"), ("Account", "=", account, "AND"), ("Date", "BETWEEN", startWeek.ToString("yyyy-MM-dd"), "AND"), ("", "", endWeek.ToString("yyyy-MM-dd"), null)))
            {
                total += Convert.ToDecimal(item);
            }

            return total;
        }

        public static decimal TotalMonthlyIncomes(int month = 0, int year = 0, string account = "All")
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
            account = TranslateAccountText(account);

            if (account == "All")
            {
                foreach (var item in Manager.GetColumn(tbIncomes, "Amount", ("UserId", "=", Id, "AND"), ("Date", "BETWEEN", startMonth.ToString("yyyy-MM-dd"), "AND"), ("", "", endMonth.ToString("yyyy-MM-dd"), null)))
                {
                    total += Convert.ToDecimal(item);
                }

                return total;
            }

            foreach (var item in Manager.GetColumn(tbIncomes, "Amount", ("UserId", "=", Id, "AND"), ("Account", "=", account, "AND"), ("Date", "BETWEEN", startMonth.ToString("yyyy-MM-dd"), "AND"), ("", "", endMonth.ToString("yyyy-MM-dd"), null)))
            {
                total += Convert.ToDecimal(item);
            }

            return total;
        }

        public static decimal TotalMonthlyExpenses(int month = 0, int year = 0, string account = "All")
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
            account = TranslateAccountText(account);

            if (account == "All")
            {
                foreach (var item in Manager.GetColumn(tbExpenses, "Amount", ("UserId", "=", Id, "AND"), ("Date", "BETWEEN", startMonth.ToString("yyyy-MM-dd"), "AND"), (null, null, endMonth.ToString("yyyy-MM-dd"), null)))
                {
                    total += Convert.ToDecimal(item);
                }

                return total;
            }

            foreach (var item in Manager.GetColumn(tbExpenses, "Amount", ("UserId", "=", Id, "AND"), ("Account", "=", account, "AND"), ("Date", "BETWEEN", startMonth.ToString("yyyy-MM-dd"), "AND"), (null, null, endMonth.ToString("yyyy-MM-dd"), null)))
            {
                total += Convert.ToDecimal(item);
            }

            return total;
        }

        public static decimal TotalYearlyIncomes(int year = 0, string account = "All")
        {
            if (year == 0)
            {
                year = Year;
            }

            int lastDay = DateTime.DaysInMonth(year, 12);
            DateTime startYear = new(year, 1, 1);
            DateTime endYear = new(year, 12, lastDay);
            decimal total = 0;
            account = TranslateAccountText(account);

            if (account == "All")
            {
                foreach (var item in Manager.GetColumn(tbIncomes, "Amount", ("UserId", "=", Id, "AND"), ("Date", "BETWEEN", startYear.ToString("yyyy-MM-dd"), "AND"), (null, null, endYear.ToString("yyyy-MM-dd"), null)))
                {
                    total += Convert.ToDecimal(item);
                }

                return total;
            }

            foreach (var item in Manager.GetColumn(tbIncomes, "Amount", ("UserId", "=", Id, "AND"), ("Account", "=", account, "AND"), ("Date", "BETWEEN", startYear.ToString("yyyy-MM-dd"), "AND"), (null, null, endYear.ToString("yyyy-MM-dd"), null)))
            {
                total += Convert.ToDecimal(item);
            }

            return total;
        }

        public static decimal TotalYearlyExpenses(int year = 0, string account = "All")
        {
            if (year == 0)
            {
                year = Year;
            }

            int lastDay = DateTime.DaysInMonth(year, 12);
            DateTime startYear = new(year, 1, 1);
            DateTime endYear = new(year, 12, lastDay);
            decimal total = 0;
            account = TranslateAccountText(account);

            if (account == "All")
            {
                foreach (var item in Manager.GetColumn(tbExpenses, "Amount", ("UserId", "=", Id, "AND"), ("Date", "BETWEEN", startYear.ToString("yyyy-MM-dd"), "AND"), (null, null, endYear.ToString("yyyy-MM-dd"), null)))
                {
                    total += Convert.ToDecimal(item);
                }

                return total;
            }

            foreach (var item in Manager.GetColumn(tbExpenses, "Amount", ("UserId", "=", Id, "AND"), ("Account", "=", account, "AND"), ("Date", "BETWEEN", startYear.ToString("yyyy-MM-dd"), "AND"), (null, null, endYear.ToString("yyyy-MM-dd"), null)))
            {
                total += Convert.ToDecimal(item);
            }

            return total;
        }

        public static decimal TotalIncomes(string account = "All")
        {
            decimal total = 0;
            account = TranslateAccountText(account);

            if (account == "All")
            {
                foreach (var item in Manager.GetColumn(tbIncomes, "Amount", null))
                {
                    total += Convert.ToDecimal(item);
                }

                return total;
            }

            foreach (var item in Manager.GetColumn(tbIncomes, "Amount", ("Account", "=", account, null)))
            {
                total += Convert.ToDecimal(item);
            }

            return total;
        }

        public static decimal TotalExpenses(string account = "All")
        {
            decimal total = 0;
            account = TranslateAccountText(account);

            if (account == "All")
            {
                foreach (var item in Manager.GetColumn(tbExpenses, "Amount", null))
                {
                    total += Convert.ToDecimal(item);
                }

                return total;
            }

            foreach (var item in Manager.GetColumn(tbExpenses, "Amount", ("Account", "=", account, null)))
            {
                total += Convert.ToDecimal(item);
            }

            return total;
        }
        #endregion

        #endregion

        // TABLES
        #region
        public class Income
        {
            [Key]
            public int Id { get; set; }
            public int UserId { get; set; }
            public string Description { get; set; }
            public decimal Amount { get; set; }
            public string Category { get; set; }
            public string Account { get; set; }
            public string Scenario { get; set; }
            public DateTime Date { get; set; }
        }

        public class Expense
        {
            [Key]
            public int Id { get; set; }
            public int UserId { get; set; }
            public string Description { get; set; }
            public decimal Amount { get; set; }
            public string Category { get; set; }
            public string Account { get; set; }
            public string Scenario { get; set; }
            public DateTime Date { get; set; }
        }

        public class IncomeAndExpense
        {
            [Key]
            public int Id { get; set; }
            public int UserId { get; set; }
            public string Description { get; set; }
            public decimal Amount { get; set; }
            public string Category { get; set; }
            public string Account { get; set; }
            public string Scenario { get; set; }
            public DateTime Date { get; set; }
            public string TableName { get; set; }
        }
        #endregion
    }
}
