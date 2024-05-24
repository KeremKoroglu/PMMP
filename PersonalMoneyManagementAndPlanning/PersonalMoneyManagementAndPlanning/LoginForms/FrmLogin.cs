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
            Lang.SetLang("TR");
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
            if (Database.Login(TxtEmail.Text, TxtPassword.Text))
            {
                WriteLoginState(true, TxtEmail.Text);

                TxtEmail.Clear();
                TxtPassword.Clear();

                Main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(Lang.GetText("ErrorLogin"), Lang.GetText("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);

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
            Lang.SetLang(CmbLang.Text);
            ChangeLang();
        }
        #endregion

        // FUNCTION
        #region
        void ChangeLang()
        {
            this.Text = Lang.GetText("LoginForm"); ;
            LblEmail.Text = Lang.GetText("Email");
            LblPassword.Text = Lang.GetText("Password");
            BtnLogin.Text = Lang.GetText("Login");
            BtnExit.Text = Lang.GetText("Exit");
            BtnRegister.Text = Lang.GetText("Register");
        }

        void WriteLoginState(bool isLoggedIn, string id)
        {
            string content = isLoggedIn ? "1" : "0";
            File.WriteAllText("state.txt", content);
            File.WriteAllText("identity.txt", id);
            File.WriteAllText("lang.txt", Lang.AppLang);
        }
        #endregion
    }
}
