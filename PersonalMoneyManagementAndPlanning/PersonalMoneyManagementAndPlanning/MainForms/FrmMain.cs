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
