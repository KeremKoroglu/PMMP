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
            this.LblType = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // LblType
            // 
            this.LblType.AutoSize = true;
            this.LblType.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblType.Location = new System.Drawing.Point(37, 57);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(51, 23);
            this.LblType.TabIndex = 0;
            this.LblType.Text = "Tür :";
            // 
            // RdbIncome
            // 
            this.RdbIncome.AutoSize = true;
            this.RdbIncome.Checked = true;
            this.RdbIncome.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RdbIncome.Location = new System.Drawing.Point(120, 57);
            this.RdbIncome.Name = "RdbIncome";
            this.RdbIncome.Size = new System.Drawing.Size(71, 27);
            this.RdbIncome.TabIndex = 1;
            this.RdbIncome.TabStop = true;
            this.RdbIncome.Text = "Gelir";
            this.RdbIncome.UseVisualStyleBackColor = true;
            // 
            // RdbExpense
            // 
            this.RdbExpense.AutoSize = true;
            this.RdbExpense.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RdbExpense.Location = new System.Drawing.Point(235, 57);
            this.RdbExpense.Name = "RdbExpense";
            this.RdbExpense.Size = new System.Drawing.Size(75, 27);
            this.RdbExpense.TabIndex = 2;
            this.RdbExpense.Text = "Gider";
            this.RdbExpense.UseVisualStyleBackColor = true;
            // 
            // LblAmount
            // 
            this.LblAmount.AutoSize = true;
            this.LblAmount.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAmount.Location = new System.Drawing.Point(66, 175);
            this.LblAmount.Name = "LblAmount";
            this.LblAmount.Size = new System.Drawing.Size(65, 23);
            this.LblAmount.TabIndex = 3;
            this.LblAmount.Text = "Tutar :";
            // 
            // TxtAmount
            // 
            this.TxtAmount.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAmount.Location = new System.Drawing.Point(137, 172);
            this.TxtAmount.Name = "TxtAmount";
            this.TxtAmount.Size = new System.Drawing.Size(100, 32);
            this.TxtAmount.TabIndex = 4;
            // 
            // LblCategory
            // 
            this.LblCategory.AutoSize = true;
            this.LblCategory.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblCategory.Location = new System.Drawing.Point(37, 229);
            this.LblCategory.Name = "LblCategory";
            this.LblCategory.Size = new System.Drawing.Size(94, 23);
            this.LblCategory.TabIndex = 5;
            this.LblCategory.Text = "Kategori :";
            // 
            // CmbCategory
            // 
            this.CmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCategory.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbCategory.FormattingEnabled = true;
            this.CmbCategory.IntegralHeight = false;
            this.CmbCategory.Location = new System.Drawing.Point(137, 226);
            this.CmbCategory.Name = "CmbCategory";
            this.CmbCategory.Size = new System.Drawing.Size(121, 31);
            this.CmbCategory.TabIndex = 6;
            // 
            // CmbAccount
            // 
            this.CmbAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbAccount.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbAccount.FormattingEnabled = true;
            this.CmbAccount.IntegralHeight = false;
            this.CmbAccount.Location = new System.Drawing.Point(137, 311);
            this.CmbAccount.Name = "CmbAccount";
            this.CmbAccount.Size = new System.Drawing.Size(121, 31);
            this.CmbAccount.TabIndex = 8;
            // 
            // LblAccount
            // 
            this.LblAccount.AutoSize = true;
            this.LblAccount.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAccount.Location = new System.Drawing.Point(37, 314);
            this.LblAccount.Name = "LblAccount";
            this.LblAccount.Size = new System.Drawing.Size(72, 23);
            this.LblAccount.TabIndex = 7;
            this.LblAccount.Text = "Hesap :";
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDate.Location = new System.Drawing.Point(37, 384);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(64, 23);
            this.LblDate.TabIndex = 9;
            this.LblDate.Text = "Tarih :";
            // 
            // DtpDate
            // 
            this.DtpDate.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtpDate.Location = new System.Drawing.Point(110, 377);
            this.DtpDate.Name = "DtpDate";
            this.DtpDate.Size = new System.Drawing.Size(200, 32);
            this.DtpDate.TabIndex = 10;
            // 
            // TxtDescription
            // 
            this.TxtDescription.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtDescription.Location = new System.Drawing.Point(155, 110);
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(100, 32);
            this.TxtDescription.TabIndex = 12;
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDescription.Location = new System.Drawing.Point(49, 113);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(100, 23);
            this.LblDescription.TabIndex = 11;
            this.LblDescription.Text = "Açıklama :";
            // 
            // FrmIncomeAndExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1488, 802);
            this.Controls.Add(this.TxtDescription);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.DtpDate);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.CmbAccount);
            this.Controls.Add(this.LblAccount);
            this.Controls.Add(this.CmbCategory);
            this.Controls.Add(this.LblCategory);
            this.Controls.Add(this.TxtAmount);
            this.Controls.Add(this.LblAmount);
            this.Controls.Add(this.RdbExpense);
            this.Controls.Add(this.RdbIncome);
            this.Controls.Add(this.LblType);
            this.Name = "FrmIncomeAndExpense";
            this.Text = "FrmIncomeAndExpense";
            this.Load += new System.EventHandler(this.FrmIncomeAndExpense_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblType;
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
    }
}