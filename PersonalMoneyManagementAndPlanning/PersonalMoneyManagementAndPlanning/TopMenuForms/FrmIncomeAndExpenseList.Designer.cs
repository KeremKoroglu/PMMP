namespace PersonalMoneyManagementAndPlanning.TopMenuForms
{
    partial class FrmIncomeAndExpenseList
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
            this.FlpIncomeAndExpenseList = new System.Windows.Forms.FlowLayoutPanel();
            this.Grp = new System.Windows.Forms.GroupBox();
            this.LblDescription = new System.Windows.Forms.Label();
            this.PnlTop = new System.Windows.Forms.Panel();
            this.PnlTopRight = new System.Windows.Forms.Panel();
            this.LblAccount = new System.Windows.Forms.Label();
            this.PnlTopLeft = new System.Windows.Forms.Panel();
            this.LblDate = new System.Windows.Forms.Label();
            this.PnlBottom = new System.Windows.Forms.Panel();
            this.PnlBottomRight = new System.Windows.Forms.Panel();
            this.LblAmount = new System.Windows.Forms.Label();
            this.PnlBottomLeft = new System.Windows.Forms.Panel();
            this.LblCategory = new System.Windows.Forms.Label();
            this.PnlTopA = new System.Windows.Forms.Panel();
            this.CmbAccount = new System.Windows.Forms.ComboBox();
            this.CmbSort = new System.Windows.Forms.ComboBox();
            this.LblIncomeAndExpenseList = new System.Windows.Forms.Label();
            this.FlpIncomeAndExpenseList.SuspendLayout();
            this.Grp.SuspendLayout();
            this.PnlTop.SuspendLayout();
            this.PnlTopRight.SuspendLayout();
            this.PnlTopLeft.SuspendLayout();
            this.PnlBottom.SuspendLayout();
            this.PnlBottomRight.SuspendLayout();
            this.PnlBottomLeft.SuspendLayout();
            this.PnlTopA.SuspendLayout();
            this.SuspendLayout();
            // 
            // FlpIncomeAndExpenseList
            // 
            this.FlpIncomeAndExpenseList.AutoScroll = true;
            this.FlpIncomeAndExpenseList.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FlpIncomeAndExpenseList.Controls.Add(this.Grp);
            this.FlpIncomeAndExpenseList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FlpIncomeAndExpenseList.Location = new System.Drawing.Point(0, 38);
            this.FlpIncomeAndExpenseList.Name = "FlpIncomeAndExpenseList";
            this.FlpIncomeAndExpenseList.Size = new System.Drawing.Size(1488, 764);
            this.FlpIncomeAndExpenseList.TabIndex = 0;
            // 
            // Grp
            // 
            this.Grp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Grp.Controls.Add(this.LblDescription);
            this.Grp.Controls.Add(this.PnlTop);
            this.Grp.Controls.Add(this.PnlBottom);
            this.Grp.Dock = System.Windows.Forms.DockStyle.Top;
            this.Grp.Location = new System.Drawing.Point(3, 3);
            this.Grp.Name = "Grp";
            this.Grp.Size = new System.Drawing.Size(1496, 250);
            this.Grp.TabIndex = 2;
            this.Grp.TabStop = false;
            // 
            // LblDescription
            // 
            this.LblDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblDescription.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDescription.Location = new System.Drawing.Point(3, 61);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(1490, 141);
            this.LblDescription.TabIndex = 6;
            this.LblDescription.Text = "Lahmacun Söyledim";
            this.LblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PnlTop
            // 
            this.PnlTop.BackColor = System.Drawing.Color.Transparent;
            this.PnlTop.Controls.Add(this.PnlTopRight);
            this.PnlTop.Controls.Add(this.PnlTopLeft);
            this.PnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTop.Location = new System.Drawing.Point(3, 16);
            this.PnlTop.Name = "PnlTop";
            this.PnlTop.Size = new System.Drawing.Size(1490, 45);
            this.PnlTop.TabIndex = 5;
            // 
            // PnlTopRight
            // 
            this.PnlTopRight.BackColor = System.Drawing.Color.Transparent;
            this.PnlTopRight.Controls.Add(this.LblAccount);
            this.PnlTopRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnlTopRight.Location = new System.Drawing.Point(757, 0);
            this.PnlTopRight.Name = "PnlTopRight";
            this.PnlTopRight.Size = new System.Drawing.Size(733, 45);
            this.PnlTopRight.TabIndex = 1;
            // 
            // LblAccount
            // 
            this.LblAccount.BackColor = System.Drawing.Color.Transparent;
            this.LblAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblAccount.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAccount.Location = new System.Drawing.Point(0, 0);
            this.LblAccount.Name = "LblAccount";
            this.LblAccount.Size = new System.Drawing.Size(733, 45);
            this.LblAccount.TabIndex = 2;
            this.LblAccount.Text = "Nakit";
            this.LblAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PnlTopLeft
            // 
            this.PnlTopLeft.BackColor = System.Drawing.Color.Transparent;
            this.PnlTopLeft.Controls.Add(this.LblDate);
            this.PnlTopLeft.Location = new System.Drawing.Point(0, 0);
            this.PnlTopLeft.Name = "PnlTopLeft";
            this.PnlTopLeft.Size = new System.Drawing.Size(733, 45);
            this.PnlTopLeft.TabIndex = 0;
            // 
            // LblDate
            // 
            this.LblDate.BackColor = System.Drawing.Color.Transparent;
            this.LblDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblDate.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDate.Location = new System.Drawing.Point(0, 0);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(733, 45);
            this.LblDate.TabIndex = 3;
            this.LblDate.Text = "2024.01.25";
            this.LblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PnlBottom
            // 
            this.PnlBottom.BackColor = System.Drawing.Color.Transparent;
            this.PnlBottom.Controls.Add(this.PnlBottomRight);
            this.PnlBottom.Controls.Add(this.PnlBottomLeft);
            this.PnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlBottom.Location = new System.Drawing.Point(3, 202);
            this.PnlBottom.Name = "PnlBottom";
            this.PnlBottom.Size = new System.Drawing.Size(1490, 45);
            this.PnlBottom.TabIndex = 3;
            // 
            // PnlBottomRight
            // 
            this.PnlBottomRight.BackColor = System.Drawing.Color.Transparent;
            this.PnlBottomRight.Controls.Add(this.LblAmount);
            this.PnlBottomRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnlBottomRight.Location = new System.Drawing.Point(757, 0);
            this.PnlBottomRight.Name = "PnlBottomRight";
            this.PnlBottomRight.Size = new System.Drawing.Size(733, 45);
            this.PnlBottomRight.TabIndex = 1;
            // 
            // LblAmount
            // 
            this.LblAmount.BackColor = System.Drawing.Color.Transparent;
            this.LblAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblAmount.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAmount.Location = new System.Drawing.Point(0, 0);
            this.LblAmount.Name = "LblAmount";
            this.LblAmount.Size = new System.Drawing.Size(733, 45);
            this.LblAmount.TabIndex = 1;
            this.LblAmount.Text = "1000₺";
            this.LblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PnlBottomLeft
            // 
            this.PnlBottomLeft.BackColor = System.Drawing.Color.Transparent;
            this.PnlBottomLeft.Controls.Add(this.LblCategory);
            this.PnlBottomLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlBottomLeft.Location = new System.Drawing.Point(0, 0);
            this.PnlBottomLeft.Name = "PnlBottomLeft";
            this.PnlBottomLeft.Size = new System.Drawing.Size(733, 45);
            this.PnlBottomLeft.TabIndex = 0;
            // 
            // LblCategory
            // 
            this.LblCategory.BackColor = System.Drawing.Color.Transparent;
            this.LblCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblCategory.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblCategory.Location = new System.Drawing.Point(0, 0);
            this.LblCategory.Name = "LblCategory";
            this.LblCategory.Size = new System.Drawing.Size(733, 45);
            this.LblCategory.TabIndex = 2;
            this.LblCategory.Text = "Yemek";
            this.LblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PnlTopA
            // 
            this.PnlTopA.Controls.Add(this.CmbAccount);
            this.PnlTopA.Controls.Add(this.CmbSort);
            this.PnlTopA.Controls.Add(this.LblIncomeAndExpenseList);
            this.PnlTopA.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTopA.Location = new System.Drawing.Point(0, 0);
            this.PnlTopA.Name = "PnlTopA";
            this.PnlTopA.Size = new System.Drawing.Size(1488, 50);
            this.PnlTopA.TabIndex = 4;
            // 
            // CmbAccount
            // 
            this.CmbAccount.Dock = System.Windows.Forms.DockStyle.Right;
            this.CmbAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbAccount.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbAccount.FormattingEnabled = true;
            this.CmbAccount.Location = new System.Drawing.Point(1048, 0);
            this.CmbAccount.Name = "CmbAccount";
            this.CmbAccount.Size = new System.Drawing.Size(220, 40);
            this.CmbAccount.TabIndex = 3;
            this.CmbAccount.SelectedIndexChanged += new System.EventHandler(this.CmbAccount_SelectedIndexChanged);
            // 
            // CmbSort
            // 
            this.CmbSort.Dock = System.Windows.Forms.DockStyle.Right;
            this.CmbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSort.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbSort.FormattingEnabled = true;
            this.CmbSort.Items.AddRange(new object[] {
            "Tarih"});
            this.CmbSort.Location = new System.Drawing.Point(1268, 0);
            this.CmbSort.Name = "CmbSort";
            this.CmbSort.Size = new System.Drawing.Size(220, 40);
            this.CmbSort.TabIndex = 2;
            this.CmbSort.SelectedIndexChanged += new System.EventHandler(this.CmbSort_SelectedIndexChanged);
            // 
            // LblIncomeAndExpenseList
            // 
            this.LblIncomeAndExpenseList.AutoSize = true;
            this.LblIncomeAndExpenseList.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblIncomeAndExpenseList.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblIncomeAndExpenseList.Location = new System.Drawing.Point(0, 0);
            this.LblIncomeAndExpenseList.Name = "LblIncomeAndExpenseList";
            this.LblIncomeAndExpenseList.Size = new System.Drawing.Size(308, 42);
            this.LblIncomeAndExpenseList.TabIndex = 1;
            this.LblIncomeAndExpenseList.Text = "Gelir Gider Listesi";
            this.LblIncomeAndExpenseList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmIncomeAndExpenseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1488, 802);
            this.Controls.Add(this.FlpIncomeAndExpenseList);
            this.Controls.Add(this.PnlTopA);
            this.Name = "FrmIncomeAndExpenseList";
            this.Text = "FrmIncomeAndExpenseList";
            this.Load += new System.EventHandler(this.FrmIncomeAndExpenseList_Load);
            this.FlpIncomeAndExpenseList.ResumeLayout(false);
            this.Grp.ResumeLayout(false);
            this.PnlTop.ResumeLayout(false);
            this.PnlTopRight.ResumeLayout(false);
            this.PnlTopLeft.ResumeLayout(false);
            this.PnlBottom.ResumeLayout(false);
            this.PnlBottomRight.ResumeLayout(false);
            this.PnlBottomLeft.ResumeLayout(false);
            this.PnlTopA.ResumeLayout(false);
            this.PnlTopA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlpIncomeAndExpenseList;
        private System.Windows.Forms.GroupBox Grp;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.Panel PnlTop;
        private System.Windows.Forms.Panel PnlTopRight;
        private System.Windows.Forms.Label LblAccount;
        private System.Windows.Forms.Panel PnlTopLeft;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Panel PnlBottom;
        private System.Windows.Forms.Panel PnlBottomRight;
        private System.Windows.Forms.Label LblAmount;
        private System.Windows.Forms.Panel PnlBottomLeft;
        private System.Windows.Forms.Label LblCategory;
        private System.Windows.Forms.Panel PnlTopA;
        private System.Windows.Forms.ComboBox CmbSort;
        private System.Windows.Forms.Label LblIncomeAndExpenseList;
        private System.Windows.Forms.ComboBox CmbAccount;
    }
}