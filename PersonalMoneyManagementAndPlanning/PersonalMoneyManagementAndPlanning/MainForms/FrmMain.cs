using PersonalMoneyManagementAndPlanning.Classes;
using PersonalMoneyManagementAndPlanning.TopMenuForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalMoneyManagementAndPlanning.MainForms
{
    public partial class FrmMain : Form
    {
        // VALUE
        #region
        readonly FrmMainContent MainContent = new();
        readonly FrmIncomeAndExpense IncomeAndExpense = new();
        readonly FrmScenarios Scenarios = new();
        #endregion

        // FORM 
        #region
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            ChangeLang();
            LoadMainContent();
        }
        #endregion

        // TOOLSTRIPMENU
        #region
        private void TsmAddIncomeExpense_Click(object sender, EventArgs e)
        {
            LoadIncomeAndExpense();
        }

        private void TsmMainMenu_Click(object sender, EventArgs e)
        {
            LoadMainContent();
        }

        private void TsmScenarios_Click(object sender, EventArgs e)
        {
            LoadScenarios();
        }
        #endregion

        // FUNCTION
        #region
        void ChangeLang()
        {
            this.Text = ClsLang.GetText("MainForm");
            TsmSettings.ToolTipText = ClsLang.GetText("Settings");
            TsmScenarios.ToolTipText = ClsLang.GetText("Scenarios");
            MainContent.GetValues();
        }

        void LoadMainContent()
        {
            PnlFill.Controls.Clear();
            MainContent.TopLevel = false;
            PnlFill.Controls.Add(MainContent);
            MainContent.FormBorderStyle = FormBorderStyle.None;
            MainContent.Dock = DockStyle.Fill;
            MainContent.Show();
        }

        void LoadIncomeAndExpense()
        {
            PnlFill.Controls.Clear();
            IncomeAndExpense.TopLevel = false;
            PnlFill.Controls.Add(IncomeAndExpense);
            IncomeAndExpense.FormBorderStyle = FormBorderStyle.None;
            IncomeAndExpense.Dock = DockStyle.Fill;
            IncomeAndExpense.Show();
        }

        void LoadScenarios()
        {
            PnlFill.Controls.Clear();
            Scenarios.TopLevel = false;
            PnlFill.Controls.Add(Scenarios);
            Scenarios.FormBorderStyle = FormBorderStyle.None;
            Scenarios.Dock = DockStyle.Fill;
            Scenarios.Show();
        }
        #endregion



        // DENEYSEL
        private void TsmLang_Click(object sender, EventArgs e)
        {
            if (ClsLang.GetLang() == "TR")
            {
                ClsLang.SetLang("EN");
                ChangeLang();
            }
            else
            {
                ClsLang.SetLang("TR");
                ChangeLang();
            }
        }
    }
}
