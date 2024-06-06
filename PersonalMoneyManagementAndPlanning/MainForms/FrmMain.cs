using PersonalMoneyManagementAndPlanning.Classes;
using PersonalMoneyManagementAndPlanning.TopMenuForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace PersonalMoneyManagementAndPlanning.MainForms
{
    public partial class FrmMain : Form
    {
        // VALUE
        #region
        private readonly FrmMainContent MainContent = new();
        private readonly FrmIncomeAndExpense IncomeAndExpense = new();
        private readonly FrmScenarios Scenarios = new();
        private readonly FrmAccounts Accounts = new();
        private readonly FrmIncomeAndExpenseList IncomeAndExpenseList = new();
        private readonly FrmScenarioList ScenarioList = new();
        public FrmLogin Login;
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

        private void TsmAccounts_Click(object sender, EventArgs e)
        {
            LoadAccounts();
        }

        private void TsmIncomeAndExpenseList_Click(object sender, EventArgs e)
        {
            LoadIncomeAndExpenseList();
        }

        private void TsmScenarioList_Click(object sender, EventArgs e)
        {
            LoadScenarioList();
        }
        #endregion

        // FUNCTION
        #region
        void ChangeLang()
        {
            this.Text = Lang.GetText("MainForm");
            TsmSettings.ToolTipText = Lang.GetText("Settings");
            TsmScenarios.ToolTipText = Lang.GetText("Scenarios");
            MainContent.GetValues();
        }

        void WriteLoginState(bool isLoggedIn)
        {
            string content = isLoggedIn ? "1" : "0";
            File.WriteAllText("state.txt", content);
        }

        void LoadMainContent()
        {
            PnlFill.Controls.Clear();
            MainContent.TopLevel = false;
            PnlFill.Controls.Add(MainContent);
            MainContent.FormBorderStyle = FormBorderStyle.None;
            MainContent.Dock = DockStyle.Fill;
            MainContent.Show();
            MainContent.GetValues();
        }

        void LoadIncomeAndExpense()
        {
            PnlFill.Controls.Clear();
            IncomeAndExpense.TopLevel = false;
            PnlFill.Controls.Add(IncomeAndExpense);
            IncomeAndExpense.FormBorderStyle = FormBorderStyle.None;
            IncomeAndExpense.Dock = DockStyle.Fill;
            IncomeAndExpense.Show();
            IncomeAndExpense.GetValues();
        }

        void LoadScenarios()
        {
            PnlFill.Controls.Clear();
            Scenarios.TopLevel = false;
            PnlFill.Controls.Add(Scenarios);
            Scenarios.FormBorderStyle = FormBorderStyle.None;
            Scenarios.Dock = DockStyle.Fill;
            Scenarios.Show();
            Scenarios.GetValues();
        }

        void LoadAccounts()
        {
            PnlFill.Controls.Clear();
            Accounts.TopLevel = false;
            PnlFill.Controls.Add(Accounts);
            Accounts.FormBorderStyle = FormBorderStyle.None;
            Accounts.Dock = DockStyle.Fill;
            Accounts.Show();
            Accounts.GetValues();
        }

        void LoadIncomeAndExpenseList()
        {
            PnlFill.Controls.Clear();
            IncomeAndExpenseList.TopLevel = false;
            PnlFill.Controls.Add(IncomeAndExpenseList);
            IncomeAndExpenseList.FormBorderStyle = FormBorderStyle.None;
            IncomeAndExpenseList.Dock = DockStyle.Fill;
            IncomeAndExpenseList.Show();
            IncomeAndExpenseList.GetValues();
        }

        void LoadScenarioList()
        {
            PnlFill.Controls.Clear();
            ScenarioList.TopLevel = false;
            PnlFill.Controls.Add(ScenarioList);
            ScenarioList.FormBorderStyle = FormBorderStyle.None;
            ScenarioList.Dock = DockStyle.Fill;
            ScenarioList.Show();
            ScenarioList.GetValues();
        }
        #endregion



        // DENEYSEL
        private void TsmLang_Click(object sender, EventArgs e)
        {
            if (Lang.GetLang() == "TR")
            {
                Lang.SetLang("EN");
                ChangeLang();
            }
            else
            {
                Lang.SetLang("TR");
                ChangeLang();
            }
        }

        private void TsmSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login = new FrmLogin();
            Login.ShowDialog();
            WriteLoginState(false);
        }
    }
}
