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

namespace PersonalMoneyManagementAndPlanning.TopMenuForms
{
    public partial class FrmAccounts : Form
    {
        // FORM
        #region
        public FrmAccounts()
        {
            InitializeComponent();
        }

        private void FrmAccounts_Load(object sender, EventArgs e)
        {
            GetValues();

            // Lang
            #region
            LblNo.Text = Lang.GetText("No") + " :";
            LblName.Text = Lang.GetText("Name") + " :";
            LblDescription.Text = Lang.GetText("Description") + " :";
            LblCategory.Text = Lang.GetText("Category") + " :";          
            LblCurrency.Text = Lang.GetText("Currency") + " :";  
            BtnAdd.Text = Lang.GetText("Add");
            #endregion
        }
        #endregion

        // BUTTON
        #region
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Database.AddAccount(TxtNo.Text, TxtName.Text, TxtDescription.Text, CmbCategory.Text, CmbCurrency.Text, DateTime.Now.ToString("s"));
            MessageBox.Show(Lang.GetText("AddAccountSuccesful"), Lang.GetText("Information"), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        // FUNCTION
        #region
        void GetValues()
        {
            // Category ComboBox
            #region
            foreach (var item in Database.AccountCategories())
            {
                CmbCategory.Items.Add(Lang.GetText(item));
            }
            CmbCategory.SelectedIndex = 0;
            CmbCategory.DropDownHeight = CmbCategory.ItemHeight * 10;
            #endregion

            // Currency ComboBox
            #region
            foreach (var item in Database.CurrencyCategories())
            {
                CmbCurrency.Items.Add(item);
            }
            CmbCurrency.SelectedIndex = 0;
            CmbCurrency.DropDownHeight = CmbCurrency.ItemHeight * 10;
            #endregion
        }
        #endregion
    }
}
