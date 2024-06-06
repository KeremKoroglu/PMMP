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
    public partial class FrmScenarios : Form
    {
        // FORM 
        #region
        public FrmScenarios()
        {
            InitializeComponent();
        }

        private void FrmScenarios_Load(object sender, EventArgs e)
        {
            GetValues();
        }
        #endregion

        // BUTTON
        #region
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Database.AddScenario(TxtName.Text, TxtDescription.Text, CmbCategory.Text, TxtTarget.Text, TxtTargetValue.Text);
            MessageBox.Show(Lang.GetText("AddScenarioSuccesful"), Lang.GetText("Information"), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        // FUNCTION
        #region
        public void GetValues()
        {
            // LANG
            #region
            LblName.Text = Lang.GetText("Name") + " :";
            LblDescription.Text = Lang.GetText("Description") + " :";
            LblCategory.Text = Lang.GetText("Category") + " :";
            LblTarget.Text = Lang.GetText("Target") + " :";
            LblTargetValue.Text = Lang.GetText("TargetValue") + " :";
            #endregion

            // Category ComboBox
            #region
            foreach (var item in Database.ScenarioCategories())
            {
                CmbCategory.Items.Add(Lang.GetText(item));
            }
            CmbCategory.SelectedIndex = 0;
            CmbCategory.DropDownHeight = CmbCategory.ItemHeight * 10;
            #endregion
        }
        #endregion
    }
}
