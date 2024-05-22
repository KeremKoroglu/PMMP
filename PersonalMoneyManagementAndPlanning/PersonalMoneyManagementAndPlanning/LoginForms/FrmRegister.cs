using PersonalMoneyManagementAndPlanning.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalMoneyManagementAndPlanning.LoginForms
{
    public partial class FrmRegister : Form
    {
        // FORM
        #region
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            ChangeLang();
        }
        #endregion

        // BUTTON
        #region
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            // CONTROLS
            #region
            if (string.IsNullOrEmpty(TxtName.Text))
            {
                MessageBox.Show(ClsLang.GetText("ErrorMissingName"), ClsLang.GetText("ErrorMissingHeader"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(TxtSurname.Text))
            {
                MessageBox.Show(ClsLang.GetText("ErrorMissingSurname"), ClsLang.GetText("ErrorMissingHeader"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(TxtEmail.Text))
            {
                MessageBox.Show(ClsLang.GetText("ErrorMissingEmail"), ClsLang.GetText("ErrorMissingHeader"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(TxtPassword.Text))
            {
                MessageBox.Show(ClsLang.GetText("ErrorMissingPassword"), ClsLang.GetText("ErrorMissingHeader"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(TxtPasswordAgain.Text))
            {
                MessageBox.Show(ClsLang.GetText("ErrorMissingPasswordAgain"), ClsLang.GetText("ErrorMissingHeader"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(MtbPhoneNumber.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "")))
            {
                MessageBox.Show(ClsLang.GetText("ErrorMissingPhoneNumber"), ClsLang.GetText("ErrorMissingHeader"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TxtPassword.Text != TxtPasswordAgain.Text)
            {
                MessageBox.Show(ClsLang.GetText("ErrorMismatchedPassword"), ClsLang.GetText("ErrorMismatchedPasswordHeader"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string error = ClsDatabase.Register(TxtName.Text, TxtSurname.Text, TxtEmail.Text, TxtPassword.Text, MtbPhoneNumber.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", ""), DtpDateOfBirth.Value.ToString("d"));

                if (error == "Success")
                {
                    MessageBox.Show(ClsLang.GetText("RegistrationSuccess"), ClsLang.GetText("MessageInformation"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    TxtName.Clear();
                    TxtSurname.Clear();
                    TxtEmail.Clear();
                    TxtPassword.Clear();
                    TxtPasswordAgain.Clear();
                    MtbPhoneNumber.Clear();
                    DtpDateOfBirth.Value = DateTime.Now;

                    this.Close();
                }
                else if (error == "EmailConflict")
                {
                    MessageBox.Show(ClsLang.GetText("ErrorEmailConflict"), ClsLang.GetText("MessageError"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            #endregion
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        // CHECKBOX
        #region
        private void ChbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ChbShowPassword.Checked)
            {
                TxtPassword.UseSystemPasswordChar = false;
                TxtPasswordAgain.UseSystemPasswordChar = false;
            }
            else
            {
                TxtPassword.UseSystemPasswordChar = true;
                TxtPasswordAgain.UseSystemPasswordChar = true;
            }
        }
        #endregion

        // FUNCTION
        #region
        void ChangeLang()
        {
            this.Text = ClsLang.GetText("Register");
            LblName.Text = ClsLang.GetText("Name");
            LblSurname.Text = ClsLang.GetText("Surname");
            LblEmail.Text = ClsLang.GetText("Email");
            LblPassword.Text = ClsLang.GetText("Password");
            LblPasswordAgain.Text = ClsLang.GetText("PasswordAgain");
            LblPhoneNumber.Text = ClsLang.GetText("PhoneNumber");
            LblDateOfBirth.Text = ClsLang.GetText("DateOfBirth");
            BtnCancel.Text = ClsLang.GetText("Cancel");
            BtnRegister.Text = ClsLang.GetText("Register");
        }
        #endregion
    }
}
