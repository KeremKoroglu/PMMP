namespace PersonalMoneyManagementAndPlanning.TopMenuForms
{
    partial class FrmAccounts
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
            this.PnlAddIncomeAndExpense = new System.Windows.Forms.Panel();
            this.TxtNo = new System.Windows.Forms.TextBox();
            this.LblNo = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.LblDescription = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblCategory = new System.Windows.Forms.Label();
            this.CmbCurrency = new System.Windows.Forms.ComboBox();
            this.CmbCategory = new System.Windows.Forms.ComboBox();
            this.LblCurrency = new System.Windows.Forms.Label();
            this.PnlAddIncomeAndExpense.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlAddIncomeAndExpense
            // 
            this.PnlAddIncomeAndExpense.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PnlAddIncomeAndExpense.Controls.Add(this.TxtNo);
            this.PnlAddIncomeAndExpense.Controls.Add(this.LblNo);
            this.PnlAddIncomeAndExpense.Controls.Add(this.BtnAdd);
            this.PnlAddIncomeAndExpense.Controls.Add(this.TxtDescription);
            this.PnlAddIncomeAndExpense.Controls.Add(this.LblDescription);
            this.PnlAddIncomeAndExpense.Controls.Add(this.LblName);
            this.PnlAddIncomeAndExpense.Controls.Add(this.TxtName);
            this.PnlAddIncomeAndExpense.Controls.Add(this.LblCategory);
            this.PnlAddIncomeAndExpense.Controls.Add(this.CmbCurrency);
            this.PnlAddIncomeAndExpense.Controls.Add(this.CmbCategory);
            this.PnlAddIncomeAndExpense.Controls.Add(this.LblCurrency);
            this.PnlAddIncomeAndExpense.Location = new System.Drawing.Point(478, 12);
            this.PnlAddIncomeAndExpense.Name = "PnlAddIncomeAndExpense";
            this.PnlAddIncomeAndExpense.Size = new System.Drawing.Size(533, 778);
            this.PnlAddIncomeAndExpense.TabIndex = 16;
            // 
            // TxtNo
            // 
            this.TxtNo.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtNo.Location = new System.Drawing.Point(229, 116);
            this.TxtNo.Name = "TxtNo";
            this.TxtNo.Size = new System.Drawing.Size(268, 44);
            this.TxtNo.TabIndex = 15;
            // 
            // LblNo
            // 
            this.LblNo.AutoSize = true;
            this.LblNo.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblNo.Location = new System.Drawing.Point(19, 119);
            this.LblNo.Name = "LblNo";
            this.LblNo.Size = new System.Drawing.Size(71, 36);
            this.LblNo.TabIndex = 0;
            this.LblNo.Text = "No :";
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
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TxtDescription
            // 
            this.TxtDescription.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtDescription.Location = new System.Drawing.Point(229, 275);
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(268, 44);
            this.TxtDescription.TabIndex = 12;
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDescription.Location = new System.Drawing.Point(19, 278);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(153, 36);
            this.LblDescription.TabIndex = 11;
            this.LblDescription.Text = "Açıklama :";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblName.Location = new System.Drawing.Point(19, 197);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(70, 36);
            this.LblName.TabIndex = 3;
            this.LblName.Text = "Ad :";
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtName.Location = new System.Drawing.Point(229, 194);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(268, 44);
            this.TxtName.TabIndex = 4;
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
            // CmbCurrency
            // 
            this.CmbCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCurrency.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbCurrency.FormattingEnabled = true;
            this.CmbCurrency.IntegralHeight = false;
            this.CmbCurrency.Location = new System.Drawing.Point(229, 438);
            this.CmbCurrency.Name = "CmbCurrency";
            this.CmbCurrency.Size = new System.Drawing.Size(268, 44);
            this.CmbCurrency.TabIndex = 8;
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
            // LblCurrency
            // 
            this.LblCurrency.AutoSize = true;
            this.LblCurrency.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblCurrency.Location = new System.Drawing.Point(19, 441);
            this.LblCurrency.Name = "LblCurrency";
            this.LblCurrency.Size = new System.Drawing.Size(105, 36);
            this.LblCurrency.TabIndex = 7;
            this.LblCurrency.Text = "Birim :";
            // 
            // FrmAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1488, 802);
            this.Controls.Add(this.PnlAddIncomeAndExpense);
            this.Name = "FrmAccounts";
            this.Text = "FrmAccounts";
            this.Load += new System.EventHandler(this.FrmAccounts_Load);
            this.PnlAddIncomeAndExpense.ResumeLayout(false);
            this.PnlAddIncomeAndExpense.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlAddIncomeAndExpense;
        private System.Windows.Forms.Label LblNo;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.Label LblCategory;
        private System.Windows.Forms.ComboBox CmbCurrency;
        private System.Windows.Forms.ComboBox CmbCategory;
        private System.Windows.Forms.Label LblCurrency;
        private System.Windows.Forms.TextBox TxtNo;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TxtName;
    }
}