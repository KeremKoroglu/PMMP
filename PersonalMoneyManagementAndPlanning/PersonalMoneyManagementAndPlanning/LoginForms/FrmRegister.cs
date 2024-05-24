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
                MessageBox.Show(Lang.GetText("ErrorMissingName"), Lang.GetText("ErrorMissingHeader"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(TxtSurname.Text))
            {
                MessageBox.Show(Lang.GetText("ErrorMissingSurname"), Lang.GetText("ErrorMissingHeader"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(TxtEmail.Text))
            {
                MessageBox.Show(Lang.GetText("ErrorMissingEmail"), Lang.GetText("ErrorMissingHeader"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(TxtPassword.Text))
            {
                MessageBox.Show(Lang.GetText("ErrorMissingPassword"), Lang.GetText("ErrorMissingHeader"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(TxtPasswordAgain.Text))
            {
                MessageBox.Show(Lang.GetText("ErrorMissingPasswordAgain"), Lang.GetText("ErrorMissingHeader"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(MtbPhoneNumber.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "")))
            {
                MessageBox.Show(Lang.GetText("ErrorMissingPhoneNumber"), Lang.GetText("ErrorMissingHeader"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TxtPassword.Text != TxtPasswordAgain.Text)
            {
                MessageBox.Show(Lang.GetText("ErrorMismatchedPassword"), Lang.GetText("ErrorMismatchedPasswordHeader"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string error = Database.Register(TxtName.Text, TxtSurname.Text, TxtEmail.Text, TxtPassword.Text, MtbPhoneNumber.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", ""), DtpDateOfBirth.Value.ToString("d"));

                if (error == "Success")
                {
                    MessageBox.Show(Lang.GetText("RegistrationSuccess"), Lang.GetText("Information"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
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
                    MessageBox.Show(Lang.GetText("ErrorEmailConflict"), Lang.GetText("MessageError"), MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            this.Text = Lang.GetText("Register");
            LblName.Text = Lang.GetText("Name");
            LblSurname.Text = Lang.GetText("Surname");
            LblEmail.Text = Lang.GetText("Email");
            LblPassword.Text = Lang.GetText("Password");
            LblPasswordAgain.Text = Lang.GetText("PasswordAgain");
            LblPhoneNumber.Text = Lang.GetText("PhoneNumber");
            LblDateOfBirth.Text = Lang.GetText("DateOfBirth");
            BtnCancel.Text = Lang.GetText("Cancel");
            BtnRegister.Text = Lang.GetText("Register");
        }
        #endregion
    }
}
