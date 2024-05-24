namespace PersonalMoneyManagementAndPlanning.TopMenuForms
{
    partial class FrmScenarios
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
            this.Flp = new System.Windows.Forms.FlowLayoutPanel();
            this.PnlAddIncomeAndExpense = new System.Windows.Forms.Panel();
            this.LblType = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.RdbIncome = new System.Windows.Forms.RadioButton();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.RdbExpense = new System.Windows.Forms.RadioButton();
            this.LblDescription = new System.Windows.Forms.Label();
            this.LblAmount = new System.Windows.Forms.Label();
            this.DtpDate = new System.Windows.Forms.DateTimePicker();
            this.TxtAmount = new System.Windows.Forms.TextBox();
            this.LblDate = new System.Windows.Forms.Label();
            this.LblCategory = new System.Windows.Forms.Label();
            this.CmbAccount = new System.Windows.Forms.ComboBox();
            this.CmbCategory = new System.Windows.Forms.ComboBox();
            this.LblAccount = new System.Windows.Forms.Label();
            this.PnlAddIncomeAndExpense.SuspendLayout();
            this.SuspendLayout();
            // 
            // Flp
            // 
            this.Flp.BackColor = System.Drawing.SystemColors.Control;
            this.Flp.Location = new System.Drawing.Point(12, 12);
            this.Flp.Name = "Flp";
            this.Flp.Size = new System.Drawing.Size(925, 778);
            this.Flp.TabIndex = 0;
            // 
            // PnlAddIncomeAndExpense
            // 
            this.PnlAddIncomeAndExpense.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PnlAddIncomeAndExpense.Controls.Add(this.LblType);
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
            this.PnlAddIncomeAndExpense.Location = new System.Drawing.Point(943, 12);
            this.PnlAddIncomeAndExpense.Name = "PnlAddIncomeAndExpense";
            this.PnlAddIncomeAndExpense.Size = new System.Drawing.Size(533, 778);
            this.PnlAddIncomeAndExpense.TabIndex = 16;
            // 
            // LblType
            // 
            this.LblType.AutoSize = true;
            this.LblType.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblType.Location = new System.Drawing.Point(19, 119);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(77, 36);
            this.LblType.TabIndex = 0;
            this.LblType.Text = "Tür :";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAdd.Location = new System.Drawing.Point(229, 627);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(89, 50);
            this.BtnAdd.TabIndex = 14;
            this.BtnAdd.Text = "Ekle";
            this.BtnAdd.UseVisualStyleBackColor = true;
            // 
            // RdbIncome
            // 
            this.RdbIncome.AutoSize = true;
            this.RdbIncome.Checked = true;
            this.RdbIncome.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RdbIncome.Location = new System.Drawing.Point(229, 117);
            this.RdbIncome.Name = "RdbIncome";
            this.RdbIncome.Size = new System.Drawing.Size(99, 40);
            this.RdbIncome.TabIndex = 1;
            this.RdbIncome.TabStop = true;
            this.RdbIncome.Text = "Gelir";
            this.RdbIncome.UseVisualStyleBackColor = true;
            // 
            // TxtDescription
            // 
            this.TxtDescription.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtDescription.Location = new System.Drawing.Point(229, 191);
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(268, 44);
            this.TxtDescription.TabIndex = 12;
            // 
            // RdbExpense
            // 
            this.RdbExpense.AutoSize = true;
            this.RdbExpense.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RdbExpense.Location = new System.Drawing.Point(391, 120);
            this.RdbExpense.Name = "RdbExpense";
            this.RdbExpense.Size = new System.Drawing.Size(106, 40);
            this.RdbExpense.TabIndex = 2;
            this.RdbExpense.Text = "Gider";
            this.RdbExpense.UseVisualStyleBackColor = true;
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDescription.Location = new System.Drawing.Point(19, 194);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(153, 36);
            this.LblDescription.TabIndex = 11;
            this.LblDescription.Text = "Açıklama :";
            // 
            // LblAmount
            // 
            this.LblAmount.AutoSize = true;
            this.LblAmount.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAmount.Location = new System.Drawing.Point(19, 268);
            this.LblAmount.Name = "LblAmount";
            this.LblAmount.Size = new System.Drawing.Size(99, 36);
            this.LblAmount.TabIndex = 3;
            this.LblAmount.Text = "Tutar :";
            // 
            // DtpDate
            // 
            this.DtpDate.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtpDate.Location = new System.Drawing.Point(229, 522);
            this.DtpDate.Name = "DtpDate";
            this.DtpDate.Size = new System.Drawing.Size(268, 44);
            this.DtpDate.TabIndex = 10;
            // 
            // TxtAmount
            // 
            this.TxtAmount.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAmount.Location = new System.Drawing.Point(229, 265);
            this.TxtAmount.Name = "TxtAmount";
            this.TxtAmount.Size = new System.Drawing.Size(268, 44);
            this.TxtAmount.TabIndex = 4;
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDate.Location = new System.Drawing.Point(19, 528);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(98, 36);
            this.LblDate.TabIndex = 9;
            this.LblDate.Text = "Tarih :";
            // 
            // LblCategory
            // 
            this.LblCategory.AutoSize = true;
            this.LblCategory.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblCategory.Location = new System.Drawing.Point(19, 353);
            this.LblCategory.Name = "LblCategory";
            this.LblCategory.Size = new System.Drawing.Size(142, 36);
            this.LblCategory.TabIndex = 5;
            this.LblCategory.Text = "Kategori :";
            // 
            // CmbAccount
            // 
            this.CmbAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbAccount.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbAccount.FormattingEnabled = true;
            this.CmbAccount.IntegralHeight = false;
            this.CmbAccount.Location = new System.Drawing.Point(229, 438);
            this.CmbAccount.Name = "CmbAccount";
            this.CmbAccount.Size = new System.Drawing.Size(268, 44);
            this.CmbAccount.TabIndex = 8;
            // 
            // CmbCategory
            // 
            this.CmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCategory.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbCategory.FormattingEnabled = true;
            this.CmbCategory.IntegralHeight = false;
            this.CmbCategory.Location = new System.Drawing.Point(229, 350);
            this.CmbCategory.Name = "CmbCategory";
            this.CmbCategory.Size = new System.Drawing.Size(268, 44);
            this.CmbCategory.TabIndex = 6;
            // 
            // LblAccount
            // 
            this.LblAccount.AutoSize = true;
            this.LblAccount.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAccount.Location = new System.Drawing.Point(19, 441);
            this.LblAccount.Name = "LblAccount";
            this.LblAccount.Size = new System.Drawing.Size(110, 36);
            this.LblAccount.TabIndex = 7;
            this.LblAccount.Text = "Hesap :";
            // 
            // FrmScenarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1488, 802);
            this.Controls.Add(this.PnlAddIncomeAndExpense);
            this.Controls.Add(this.Flp);
            this.Name = "FrmScenarios";
            this.Text = "FrmScenarios";
            this.PnlAddIncomeAndExpense.ResumeLayout(false);
            this.PnlAddIncomeAndExpense.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Flp;
        private System.Windows.Forms.Panel PnlAddIncomeAndExpense;
        private System.Windows.Forms.Label LblType;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.RadioButton RdbIncome;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.RadioButton RdbExpense;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.Label LblAmount;
        private System.Windows.Forms.DateTimePicker DtpDate;
        private System.Windows.Forms.TextBox TxtAmount;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label LblCategory;
        private System.Windows.Forms.ComboBox CmbAccount;
        private System.Windows.Forms.ComboBox CmbCategory;
        private System.Windows.Forms.Label LblAccount;
    }
}