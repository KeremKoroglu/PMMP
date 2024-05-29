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
            GetValues();

            // Lang
            #region
            LblType.Text = Lang.GetText("Type") + " :";
            RdbIncome.Text = Lang.GetText("Income");
            RdbExpense.Text = Lang.GetText("Expense");
            LblAmount.Text = Lang.GetText("Amount") + " :";
            LblCategory.Text = Lang.GetText("Category") + " :";
            LblAccount.Text = Lang.GetText("Account") + " :";
            LblDate.Text = Lang.GetText("Date") + " :";
            LblDescription.Text = Lang.GetText("Description") + " :";
            BtnAdd.Text = Lang.GetText("Add");
            #endregion
        }
        #endregion

        // BUTTON
        #region
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string account = CmbAccount.Text == "NoAccount" || CmbAccount.Text == "Hesap Yok" ? "NoAccount" : CmbAccount.Text;
            if (RdbIncome.Checked)
            {
                Database.AddIncome(TxtDescription.Text, TxtAmount.Text, CmbCategory.Text, account, DtpDate.Value.ToString("s"));
            }
            else
            {
                Database.AddExpense(TxtDescription.Text, TxtAmount.Text, CmbCategory.Text, account, DtpDate.Value.ToString("s"));              
            }
            MessageBox.Show(Lang.GetText("AddIncomeSuccesful"), Lang.GetText("Information"), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        // FUNCTION
        #region
        void GetValues()
        {
            // Category ComboBox
            #region
            foreach (var item in Database.IncomeAndExpenseCategories())
            {
                CmbCategory.Items.Add(Lang.GetText(item));
            }
            CmbCategory.SelectedIndex = 0;
            CmbCategory.DropDownHeight = CmbCategory.ItemHeight * 10;
            #endregion

            // Account ComboBox
            #region
            foreach (var item in Database.Accounts())
            {
                CmbAccount.Items.Add(item);
            }
            CmbAccount.SelectedIndex = 0;
            CmbAccount.DropDownHeight = CmbAccount.ItemHeight * 10;
            #endregion
        }
        #endregion
    }
}
