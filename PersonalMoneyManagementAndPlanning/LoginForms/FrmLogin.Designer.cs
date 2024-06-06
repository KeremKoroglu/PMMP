namespace PersonalMoneyManagementAndPlanning
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.CmbLang = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnExit.Location = new System.Drawing.Point(12, 309);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(90, 40);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.Text = "Çıkış";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnLogin.Location = new System.Drawing.Point(482, 309);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(90, 40);
            this.BtnLogin.TabIndex = 3;
            this.BtnLogin.Text = "Giriş Yap";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // CmbLang
            // 
            this.CmbLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbLang.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbLang.FormattingEnabled = true;
            this.CmbLang.Items.AddRange(new object[] {
            "TR",
            "EN"});
            this.CmbLang.Location = new System.Drawing.Point(519, 12);
            this.CmbLang.Name = "CmbLang";
            this.CmbLang.Size = new System.Drawing.Size(53, 29);
            this.CmbLang.TabIndex = 5;
            this.CmbLang.SelectedIndexChanged += new System.EventHandler(this.CmbLang_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnRegister);
            this.panel1.Controls.Add(this.TxtEmail);
            this.panel1.Controls.Add(this.TxtPassword);
            this.panel1.Controls.Add(this.LblPassword);
            this.panel1.Controls.Add(this.LblEmail);
            this.panel1.Location = new System.Drawing.Point(94, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 147);
            this.panel1.TabIndex = 8;
            // 
            // BtnRegister
            // 
            this.BtnRegister.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnRegister.Location = new System.Drawing.Point(163, 110);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(70, 30);
            this.BtnRegister.TabIndex = 16;
            this.BtnRegister.Text = "Kayıt Ol";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtEmail.Location = new System.Drawing.Point(113, 12);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(182, 29);
            this.TxtEmail.TabIndex = 1;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPassword.Location = new System.Drawing.Point(113, 75);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(182, 29);
            this.TxtPassword.TabIndex = 2;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // LblPassword
            // 
            this.LblPassword.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblPassword.Location = new System.Drawing.Point(5, 78);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblPassword.Size = new System.Drawing.Size(102, 21);
            this.LblPassword.TabIndex = 7;
            this.LblPassword.Text = "Şifre :";
            this.LblPassword.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LblEmail
            // 
            this.LblEmail.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblEmail.Location = new System.Drawing.Point(28, 15);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(79, 21);
            this.LblEmail.TabIndex = 6;
            this.LblEmail.Text = "Eposta :";
            this.LblEmail.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CmbLang);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.BtnExit);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Yap";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.ComboBox CmbLang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Button BtnRegister;
    }
}

