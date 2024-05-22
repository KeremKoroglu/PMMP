using PersonalMoneyManagementAndPlanning.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PersonalMoneyManagementAndPlanning.MainForms
{
    public partial class FrmIncomeAndExpense : Form
    {
        // FORM
        #region
        public FrmIncomeAndExpense()
        {
            InitializeComponent();
        }

        private void FrmIncomeAndExpense_Load(object sender, EventArgs e)
        {
            ChangeLang();
            GetValues();
        }
        #endregion

        // FUNCTION
        #region
        void ChangeLang()
        {
            LblType.Text = ClsLang.GetText("Type") + " :";
            RdbIncome.Text = ClsLang.GetText("Income");
            RdbExpense.Text = ClsLang.GetText("Expense");
            LblAmount.Text = ClsLang.GetText("Amount") + " :";
            LblCategory.Text = ClsLang.GetText("Category") + " :";
            LblAccount.Text = ClsLang.GetText("Account") + " :";
            LblDate.Text = ClsLang.GetText("Date") + " :";
            LblDescription.Text = ClsLang.GetText("Description") + " :";
        }

        void GetValues()
        {
            // Category ComboBox
            #region
            CmbCategory.Items.Add(ClsLang.GetText("Food"));
            CmbCategory.Items.Add(ClsLang.GetText("Entertainment"));
            CmbCategory.Items.Add(ClsLang.GetText("Transport"));
            CmbCategory.Items.Add(ClsLang.GetText("Hobby"));
            CmbCategory.Items.Add(ClsLang.GetText("Clothing"));
            CmbCategory.Items.Add(ClsLang.GetText("Health"));
            CmbCategory.Items.Add(ClsLang.GetText("Education"));
            CmbCategory.Items.Add(ClsLang.GetText("Bill"));
            CmbCategory.Items.Add(ClsLang.GetText("ElectricityBill"));
            CmbCategory.Items.Add(ClsLang.GetText("HeatingBill"));
            CmbCategory.Items.Add(ClsLang.GetText("WaterBill"));
            CmbCategory.Items.Add(ClsLang.GetText("InternetBill"));
            CmbCategory.Items.Add(ClsLang.GetText("TelevisionBill"));
            CmbCategory.Items.Add(ClsLang.GetText("PhoneBill"));
            CmbCategory.Items.Add(ClsLang.GetText("Charity"));
            CmbCategory.Items.Add(ClsLang.GetText("CreditCard"));
            CmbCategory.Items.Add(ClsLang.GetText("Home"));
            CmbCategory.Items.Add(ClsLang.GetText("Kid"));
            CmbCategory.Items.Add(ClsLang.GetText("PersonalCare"));
            CmbCategory.Items.Add(ClsLang.GetText("Pet"));
            CmbCategory.Items.Add(ClsLang.GetText("Rent"));
            CmbCategory.Items.Add(ClsLang.GetText("Salary"));
            CmbCategory.Items.Add(ClsLang.GetText("Sale"));
            CmbCategory.Items.Add(ClsLang.GetText("Subscription"));
            CmbCategory.Items.Add(ClsLang.GetText("Travel"));
            CmbCategory.Items.Add(ClsLang.GetText("Other"));
            CmbCategory.SelectedIndex = 0;
            CmbCategory.DropDownHeight = CmbCategory.ItemHeight * 10;
            #endregion

            // Account ComboBox
            #region
            // Databaseden Çekmek Gerek
            int accountCount = 0;
            if (accountCount == 0)
            {
                CmbAccount.Items.Add(ClsLang.GetText("NoAccount"));
                CmbAccount.SelectedIndex = 0;
            }
            #endregion

        }
        #endregion
    }
}
