using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Resources;
using System.Threading;
using System.Reflection;
using PersonalMoneyManagementAndPlanning.LoginForms;
using PersonalMoneyManagementAndPlanning.Classes;
using System.Configuration;
using SqlLibrary;
using System.IO;
using PersonalMoneyManagementAndPlanning.MainForms;

namespace PersonalMoneyManagementAndPlanning
{
    public partial class FrmLogin : Form
    {
        // VALUE
        #region
        private readonly FrmRegister Register = new();
        private readonly FrmMain Main = new();
        #endregion

        // FORM 
        #region
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            CmbLang.SelectedIndex = 0;

            // LANG
            #region
            ClsLang.SetLang("TR");
            ChangeLang();
            #endregion
        }
        #endregion

        // BUTTON
        #region
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            Register.ShowDialog();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (ClsDatabase.Login(TxtEmail.Text, TxtPassword.Text))
            {
                TxtEmail.Clear();
                TxtPassword.Clear();

                WriteLoginState(true, TxtEmail.Text);

                Main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(ClsLang.GetText("ErrorLogin"), ClsLang.GetText("MessageError"), MessageBoxButtons.OK, MessageBoxIcon.Error);

                TxtPassword.Clear();
                TxtPassword.Focus();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        // COMBOBOX
        #region
        private void CmbLang_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClsLang.SetLang(CmbLang.Text);
            ChangeLang();
        }
        #endregion

        // FUNCTION
        #region
        void ChangeLang()
        {
            this.Text = ClsLang.GetText("LoginForm"); ;
            LblEmail.Text = ClsLang.GetText("Email");
            LblPassword.Text = ClsLang.GetText("Password");
            BtnLogin.Text = ClsLang.GetText("Login");
            BtnExit.Text = ClsLang.GetText("Exit");
            BtnRegister.Text = ClsLang.GetText("Register");
        }

        void WriteLoginState(bool isLoggedIn, string id = "")
        {
            string content = isLoggedIn ? "1" : "0";
            File.WriteAllText("state.txt", content);
            File.WriteAllText("identity.txt", id);
            File.WriteAllText("lang.txt", ClsLang.Lang);
        }
        #endregion
    }
}
