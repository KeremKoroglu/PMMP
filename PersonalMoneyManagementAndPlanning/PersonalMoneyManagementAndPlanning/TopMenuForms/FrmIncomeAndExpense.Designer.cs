namespace PersonalMoneyManagementAndPlanning.MainForms
{
    partial class FrmIncomeAndExpense
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
            this.RdbIncome = new System.Windows.Forms.RadioButton();
            this.RdbExpense = new System.Windows.Forms.RadioButton();
            this.LblAmount = new System.Windows.Forms.Label();
            this.TxtAmount = new System.Windows.Forms.TextBox();
            this.LblCategory = new System.Windows.Forms.Label();
            this.CmbCategory = new System.Windows.Forms.ComboBox();
            this.CmbAccount = new System.Windows.Forms.ComboBox();
            this.LblAccount = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.DtpDate = new System.Windows.Forms.DateTimePicker();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.LblDescription = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.PnlAddIncomeAndExpense = new System.Windows.Forms.Panel();
            this.LblType = new System.Windows.Forms.Label();
            this.RdbAccount = new System.Windows.Forms.RadioButton();
            this.RdbScenario = new System.Windows.Forms.RadioButton();
            this.PnlAddIncomeAndExpense.SuspendLayout();
            this.SuspendLayout();
            // 
            // RdbIncome
            // 
            this.RdbIncome.AutoSize = true;
            this.RdbIncome.Checked = true;
            this.RdbIncome.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RdbIncome.Location = new System.Drawing.Point(136, 56);
            this.RdbIncome.Name = "RdbIncome";
            this.RdbIncome.Size = new System.Drawing.Size(99, 40);
            this.RdbIncome.TabIndex = 1;
            this.RdbIncome.TabStop = true;
            this.RdbIncome.Text = "Gelir";
            this.RdbIncome.UseVisualStyleBackColor = true;
            // 
            // RdbExpense
            // 
            this.RdbExpense.AutoSize = true;
            this.RdbExpense.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RdbExpense.Location = new System.Drawing.Point(298, 59);
            this.RdbExpense.Name = "RdbExpense";
            this.RdbExpense.Size = new System.Drawing.Size(106, 40);
            this.RdbExpense.TabIndex = 2;
            this.RdbExpense.Text = "Gider";
            this.RdbExpense.UseVisualStyleBackColor = true;
            // 
            // LblAmount
            // 
            this.LblAmount.AutoSize = true;
            this.LblAmount.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAmount.Location = new System.Drawing.Point(22, 298);
            this.LblAmount.Name = "LblAmount";
            this.LblAmount.Size = new System.Drawing.Size(99, 36);
            this.LblAmount.TabIndex = 3;
            this.LblAmount.Text = "Tutar :";
            // 
            // TxtAmount
            // 
            this.TxtAmount.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAmount.Location = new System.Drawing.Point(220, 295);
            this.TxtAmount.Name = "TxtAmount";
            this.TxtAmount.Size = new System.Drawing.Size(268, 44);
            this.TxtAmount.TabIndex = 4;
            // 
            // LblCategory
            // 
            this.LblCategory.AutoSize = true;
            this.LblCategory.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblCategory.Location = new System.Drawing.Point(22, 373);
            this.LblCategory.Name = "LblCategory";
            this.LblCategory.Size = new System.Drawing.Size(142, 36);
            this.LblCategory.TabIndex = 5;
            this.LblCategory.Text = "Kategori :";
            // 
            // CmbCategory
            // 
            this.CmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCategory.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbCategory.FormattingEnabled = true;
            this.CmbCategory.IntegralHeight = false;
            this.CmbCategory.Location = new System.Drawing.Point(220, 370);
            this.CmbCategory.Name = "CmbCategory";
            this.CmbCategory.Size = new System.Drawing.Size(268, 44);
            this.CmbCategory.TabIndex = 6;
            // 
            // CmbAccount
            // 
            this.CmbAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbAccount.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbAccount.FormattingEnabled = true;
            this.CmbAccount.IntegralHeight = false;
            this.CmbAccount.Location = new System.Drawing.Point(220, 441);
            this.CmbAccount.Name = "CmbAccount";
            this.CmbAccount.Size = new System.Drawing.Size(268, 44);
            this.CmbAccount.TabIndex = 8;
            // 
            // LblAccount
            // 
            this.LblAccount.AutoSize = true;
            this.LblAccount.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAccount.Location = new System.Drawing.Point(22, 444);
            this.LblAccount.Name = "LblAccount";
            this.LblAccount.Size = new System.Drawing.Size(110, 36);
            this.LblAccount.TabIndex = 7;
            this.LblAccount.Text = "Hesap :";
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDate.Location = new System.Drawing.Point(22, 520);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(98, 36);
            this.LblDate.TabIndex = 9;
            this.LblDate.Text = "Tarih :";
            // 
            // DtpDate
            // 
            this.DtpDate.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtpDate.Location = new System.Drawing.Point(220, 514);
            this.DtpDate.Name = "DtpDate";
            this.DtpDate.Size = new System.Drawing.Size(268, 44);
            this.DtpDate.TabIndex = 10;
            // 
            // TxtDescription
            // 
            this.TxtDescription.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtDescription.Location = new System.Drawing.Point(220, 221);
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(268, 44);
            this.TxtDescription.TabIndex = 12;
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDescription.Location = new System.Drawing.Point(22, 224);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(153, 36);
            this.LblDescription.TabIndex = 11;
            this.LblDescription.Text = "Açıklama :";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAdd.Location = new System.Drawing.Point(220, 641);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(89, 50);
            this.BtnAdd.TabIndex = 14;
            this.BtnAdd.Text = "Ekle";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // PnlAddIncomeAndExpense
            // 
            this.PnlAddIncomeAndExpense.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PnlAddIncomeAndExpense.Controls.Add(this.LblType);
            this.PnlAddIncomeAndExpense.Controls.Add(this.RdbAccount);
            this.PnlAddIncomeAndExpense.Controls.Add(this.RdbScenario);
            this.PnlAddIncomeAndExpense.Controls.Add(this.BtnAdd);
            this.PnlAddIncomeAndExpense.Controls.Add(this.RdbIncome);
            this.PnlAddIncomeAndExpense.Controls.Add(this.TxtDescription);
            this.PnlAddIncomeAndExpense.Controls.Add(this.RdbExpense);
            this.PnlAddIncomeAndExpense.Controls.Add(this.LblDescription);
            this.PnlAddIncomeAndExpense.Controls.Add(this.LblAmount);
            this.PnlAddIncomeAndExpense.Controls.Add(this.DtpDate);
            this.PnlAddIncomeAndExpense.Controls.Add(this.TxtAmount);
            this.PnlAddIncomeAndExpense.Controls.Add(this.LblDate);
            this.PnlAddIncomeAndExpense.Controls.Add(this.LblCategory);
            this.PnlAddIncomeAndExpense.Controls.Add(this.CmbAccount);
            this.PnlAddIncomeAndExpense.Controls.Add(this.CmbCategory);
            this.PnlAddIncomeAndExpense.Controls.Add(this.LblAccount);
            this.PnlAddIncomeAndExpense.Location = new System.Drawing.Point(500, 12);
            this.PnlAddIncomeAndExpense.Name = "PnlAddIncomeAndExpense";
            this.PnlAddIncomeAndExpense.Size = new System.Drawing.Size(533, 778);
            this.PnlAddIncomeAndExpense.TabIndex = 15;
            // 
            // LblType
            // 
            this.LblType.AutoSize = true;
            this.LblType.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblType.Location = new System.Drawing.Point(22, 142);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(77, 36);
            this.LblType.TabIndex = 15;
            this.LblType.Text = "Tür :";
            // 
            // RdbAccount
            // 
            this.RdbAccount.AutoSize = true;
            this.RdbAccount.Checked = true;
            this.RdbAccount.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RdbAccount.Location = new System.Drawing.Point(220, 137);
            this.RdbAccount.Name = "RdbAccount";
            this.RdbAccount.Size = new System.Drawing.Size(111, 40);
            this.RdbAccount.TabIndex = 16;
            this.RdbAccount.TabStop = true;
            this.RdbAccount.Text = "Hesap";
            this.RdbAccount.UseVisualStyleBackColor = true;
            // 
            // RdbScenario
            // 
            this.RdbScenario.AutoSize = true;
            this.RdbScenario.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RdbScenario.Location = new System.Drawing.Point(371, 140);
            this.RdbScenario.Name = "RdbScenario";
            this.RdbScenario.Size = new System.Drawing.Size(136, 40);
            this.RdbScenario.TabIndex = 17;
            this.RdbScenario.Text = "Senaryo";
            this.RdbScenario.UseVisualStyleBackColor = true;
            // 
            // FrmIncomeAndExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1488, 802);
            this.Controls.Add(this.PnlAddIncomeAndExpense);
            this.Name = "FrmIncomeAndExpense";
            this.Text = "FrmIncomeAndExpense";
            this.Load += new System.EventHandler(this.FrmIncomeAndExpense_Load);
            this.PnlAddIncomeAndExpense.ResumeLayout(false);
            this.PnlAddIncomeAndExpense.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton RdbIncome;
        private System.Windows.Forms.RadioButton RdbExpense;
        private System.Windows.Forms.Label LblAmount;
        private System.Windows.Forms.TextBox TxtAmount;
        private System.Windows.Forms.Label LblCategory;
        private System.Windows.Forms.ComboBox CmbCategory;
        private System.Windows.Forms.ComboBox CmbAccount;
        private System.Windows.Forms.Label LblAccount;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.DateTimePicker DtpDate;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Panel PnlAddIncomeAndExpense;
        private System.Windows.Forms.Label LblType;
        private System.Windows.Forms.RadioButton RdbAccount;
        private System.Windows.Forms.RadioButton RdbScenario;
    }
}