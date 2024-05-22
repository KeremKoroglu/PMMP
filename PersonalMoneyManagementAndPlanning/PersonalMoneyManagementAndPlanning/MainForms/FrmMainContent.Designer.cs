namespace PersonalMoneyManagementAndPlanning.MainForms
{
    partial class FrmMainContent
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
            this.PnlFill = new System.Windows.Forms.Panel();
            this.PnlTotal = new System.Windows.Forms.Panel();
            this.CpbTotal = new CircularProgressBar.CircularProgressBar();
            this.LblTotalIncomePercent = new System.Windows.Forms.Label();
            this.LblTotalExpensePercent = new System.Windows.Forms.Label();
            this.PnlDistribution = new System.Windows.Forms.Panel();
            this.CpbDistribution = new CircularProgressBar.CircularProgressBar();
            this.LblDistributionIncomePercent = new System.Windows.Forms.Label();
            this.LblDistributionExpensePercent = new System.Windows.Forms.Label();
            this.PnlCalculation = new System.Windows.Forms.Panel();
            this.CmbCalendar = new System.Windows.Forms.ComboBox();
            this.LblIncome = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.LblExpense = new System.Windows.Forms.Label();
            this.PnlCalendar = new System.Windows.Forms.Panel();
            this.LblYear = new System.Windows.Forms.Label();
            this.LblMonth = new System.Windows.Forms.Label();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.PnlFill.SuspendLayout();
            this.PnlTotal.SuspendLayout();
            this.PnlDistribution.SuspendLayout();
            this.PnlCalculation.SuspendLayout();
            this.PnlCalendar.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlFill
            // 
            this.PnlFill.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PnlFill.Controls.Add(this.PnlTotal);
            this.PnlFill.Controls.Add(this.PnlDistribution);
            this.PnlFill.Controls.Add(this.PnlCalculation);
            this.PnlFill.Controls.Add(this.PnlCalendar);
            this.PnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlFill.Location = new System.Drawing.Point(0, 0);
            this.PnlFill.Name = "PnlFill";
            this.PnlFill.Size = new System.Drawing.Size(1488, 802);
            this.PnlFill.TabIndex = 6;
            // 
            // PnlTotal
            // 
            this.PnlTotal.Controls.Add(this.CpbTotal);
            this.PnlTotal.Controls.Add(this.LblTotalIncomePercent);
            this.PnlTotal.Controls.Add(this.LblTotalExpensePercent);
            this.PnlTotal.Location = new System.Drawing.Point(1226, 455);
            this.PnlTotal.Name = "PnlTotal";
            this.PnlTotal.Size = new System.Drawing.Size(250, 322);
            this.PnlTotal.TabIndex = 13;
            // 
            // CpbTotal
            // 
            this.CpbTotal.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.CpbTotal.AnimationSpeed = 500;
            this.CpbTotal.BackColor = System.Drawing.Color.Transparent;
            this.CpbTotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.CpbTotal.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CpbTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CpbTotal.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CpbTotal.InnerMargin = 2;
            this.CpbTotal.InnerWidth = -1;
            this.CpbTotal.Location = new System.Drawing.Point(0, 0);
            this.CpbTotal.MarqueeAnimationSpeed = 2000;
            this.CpbTotal.Name = "CpbTotal";
            this.CpbTotal.OuterColor = System.Drawing.Color.Red;
            this.CpbTotal.OuterMargin = -25;
            this.CpbTotal.OuterWidth = 25;
            this.CpbTotal.ProgressColor = System.Drawing.Color.Green;
            this.CpbTotal.ProgressWidth = 25;
            this.CpbTotal.SecondaryFont = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CpbTotal.Size = new System.Drawing.Size(250, 250);
            this.CpbTotal.StartAngle = 270;
            this.CpbTotal.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CpbTotal.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.CpbTotal.SubscriptText = "";
            this.CpbTotal.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.CpbTotal.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.CpbTotal.SuperscriptText = "";
            this.CpbTotal.TabIndex = 1;
            this.CpbTotal.Text = "Toplam";
            this.CpbTotal.TextMargin = new System.Windows.Forms.Padding(0);
            this.CpbTotal.Value = 70;
            // 
            // LblTotalIncomePercent
            // 
            this.LblTotalIncomePercent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LblTotalIncomePercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTotalIncomePercent.Location = new System.Drawing.Point(0, 250);
            this.LblTotalIncomePercent.Name = "LblTotalIncomePercent";
            this.LblTotalIncomePercent.Size = new System.Drawing.Size(250, 36);
            this.LblTotalIncomePercent.TabIndex = 10;
            this.LblTotalIncomePercent.Text = "Gelir %78";
            this.LblTotalIncomePercent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LblTotalExpensePercent
            // 
            this.LblTotalExpensePercent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LblTotalExpensePercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTotalExpensePercent.Location = new System.Drawing.Point(0, 286);
            this.LblTotalExpensePercent.Name = "LblTotalExpensePercent";
            this.LblTotalExpensePercent.Size = new System.Drawing.Size(250, 36);
            this.LblTotalExpensePercent.TabIndex = 11;
            this.LblTotalExpensePercent.Text = "Gider %22";
            this.LblTotalExpensePercent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PnlDistribution
            // 
            this.PnlDistribution.Controls.Add(this.CpbDistribution);
            this.PnlDistribution.Controls.Add(this.LblDistributionIncomePercent);
            this.PnlDistribution.Controls.Add(this.LblDistributionExpensePercent);
            this.PnlDistribution.Location = new System.Drawing.Point(1226, 127);
            this.PnlDistribution.Name = "PnlDistribution";
            this.PnlDistribution.Size = new System.Drawing.Size(250, 322);
            this.PnlDistribution.TabIndex = 12;
            // 
            // CpbDistribution
            // 
            this.CpbDistribution.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.CpbDistribution.AnimationSpeed = 500;
            this.CpbDistribution.BackColor = System.Drawing.Color.Transparent;
            this.CpbDistribution.Dock = System.Windows.Forms.DockStyle.Top;
            this.CpbDistribution.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CpbDistribution.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CpbDistribution.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CpbDistribution.InnerMargin = 2;
            this.CpbDistribution.InnerWidth = -1;
            this.CpbDistribution.Location = new System.Drawing.Point(0, 0);
            this.CpbDistribution.MarqueeAnimationSpeed = 2000;
            this.CpbDistribution.Name = "CpbDistribution";
            this.CpbDistribution.OuterColor = System.Drawing.Color.Red;
            this.CpbDistribution.OuterMargin = -25;
            this.CpbDistribution.OuterWidth = 25;
            this.CpbDistribution.ProgressColor = System.Drawing.Color.Green;
            this.CpbDistribution.ProgressWidth = 25;
            this.CpbDistribution.SecondaryFont = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CpbDistribution.Size = new System.Drawing.Size(250, 250);
            this.CpbDistribution.StartAngle = 270;
            this.CpbDistribution.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CpbDistribution.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.CpbDistribution.SubscriptText = "";
            this.CpbDistribution.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.CpbDistribution.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.CpbDistribution.SuperscriptText = "";
            this.CpbDistribution.TabIndex = 7;
            this.CpbDistribution.Text = "Dağılım";
            this.CpbDistribution.TextMargin = new System.Windows.Forms.Padding(0);
            this.CpbDistribution.Value = 70;
            // 
            // LblDistributionIncomePercent
            // 
            this.LblDistributionIncomePercent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LblDistributionIncomePercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDistributionIncomePercent.Location = new System.Drawing.Point(0, 250);
            this.LblDistributionIncomePercent.Name = "LblDistributionIncomePercent";
            this.LblDistributionIncomePercent.Size = new System.Drawing.Size(250, 36);
            this.LblDistributionIncomePercent.TabIndex = 8;
            this.LblDistributionIncomePercent.Text = "Gelir %78";
            this.LblDistributionIncomePercent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LblDistributionExpensePercent
            // 
            this.LblDistributionExpensePercent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LblDistributionExpensePercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDistributionExpensePercent.Location = new System.Drawing.Point(0, 286);
            this.LblDistributionExpensePercent.Name = "LblDistributionExpensePercent";
            this.LblDistributionExpensePercent.Size = new System.Drawing.Size(250, 36);
            this.LblDistributionExpensePercent.TabIndex = 9;
            this.LblDistributionExpensePercent.Text = "Gider %22";
            this.LblDistributionExpensePercent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PnlCalculation
            // 
            this.PnlCalculation.BackColor = System.Drawing.SystemColors.Control;
            this.PnlCalculation.Controls.Add(this.CmbCalendar);
            this.PnlCalculation.Controls.Add(this.LblIncome);
            this.PnlCalculation.Controls.Add(this.LblTotal);
            this.PnlCalculation.Controls.Add(this.LblExpense);
            this.PnlCalculation.Location = new System.Drawing.Point(3, 109);
            this.PnlCalculation.Name = "PnlCalculation";
            this.PnlCalculation.Size = new System.Drawing.Size(757, 340);
            this.PnlCalculation.TabIndex = 6;
            // 
            // CmbCalendar
            // 
            this.CmbCalendar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCalendar.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbCalendar.FormattingEnabled = true;
            this.CmbCalendar.Location = new System.Drawing.Point(633, 3);
            this.CmbCalendar.Name = "CmbCalendar";
            this.CmbCalendar.Size = new System.Drawing.Size(121, 35);
            this.CmbCalendar.TabIndex = 6;
            this.CmbCalendar.SelectedIndexChanged += new System.EventHandler(this.CmbCalendar_SelectedIndexChanged);
            // 
            // LblIncome
            // 
            this.LblIncome.AutoSize = true;
            this.LblIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblIncome.Location = new System.Drawing.Point(3, 45);
            this.LblIncome.Name = "LblIncome";
            this.LblIncome.Size = new System.Drawing.Size(298, 55);
            this.LblIncome.TabIndex = 3;
            this.LblIncome.Text = "Gelir : 25000";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTotal.Location = new System.Drawing.Point(3, 238);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(331, 55);
            this.LblTotal.TabIndex = 5;
            this.LblTotal.Text = "Toplam : 5000";
            // 
            // LblExpense
            // 
            this.LblExpense.AutoSize = true;
            this.LblExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblExpense.Location = new System.Drawing.Point(3, 141);
            this.LblExpense.Name = "LblExpense";
            this.LblExpense.Size = new System.Drawing.Size(315, 55);
            this.LblExpense.TabIndex = 4;
            this.LblExpense.Text = "Gider : 20000";
            // 
            // PnlCalendar
            // 
            this.PnlCalendar.BackColor = System.Drawing.SystemColors.Control;
            this.PnlCalendar.Controls.Add(this.LblYear);
            this.PnlCalendar.Controls.Add(this.LblMonth);
            this.PnlCalendar.Controls.Add(this.BtnNext);
            this.PnlCalendar.Controls.Add(this.BtnBack);
            this.PnlCalendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlCalendar.Location = new System.Drawing.Point(0, 0);
            this.PnlCalendar.Name = "PnlCalendar";
            this.PnlCalendar.Size = new System.Drawing.Size(1488, 100);
            this.PnlCalendar.TabIndex = 0;
            // 
            // LblYear
            // 
            this.LblYear.Dock = System.Windows.Forms.DockStyle.Right;
            this.LblYear.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblYear.Location = new System.Drawing.Point(1282, 0);
            this.LblYear.Name = "LblYear";
            this.LblYear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblYear.Size = new System.Drawing.Size(131, 100);
            this.LblYear.TabIndex = 3;
            this.LblYear.Text = "2024";
            this.LblYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblMonth
            // 
            this.LblMonth.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblMonth.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblMonth.Location = new System.Drawing.Point(75, 0);
            this.LblMonth.Name = "LblMonth";
            this.LblMonth.Size = new System.Drawing.Size(685, 100);
            this.LblMonth.TabIndex = 2;
            this.LblMonth.Text = "Mayıs";
            this.LblMonth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnNext
            // 
            this.BtnNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnNext.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnNext.Location = new System.Drawing.Point(1413, 0);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(75, 100);
            this.BtnNext.TabIndex = 1;
            this.BtnNext.Text = ">";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnBack.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnBack.Location = new System.Drawing.Point(0, 0);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 100);
            this.BtnBack.TabIndex = 0;
            this.BtnBack.Text = "<";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // FrmMainContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1488, 802);
            this.Controls.Add(this.PnlFill);
            this.Name = "FrmMainContent";
            this.Text = "FrmMainContent";
            this.Load += new System.EventHandler(this.FrmMainContent_Load);
            this.PnlFill.ResumeLayout(false);
            this.PnlTotal.ResumeLayout(false);
            this.PnlDistribution.ResumeLayout(false);
            this.PnlCalculation.ResumeLayout(false);
            this.PnlCalculation.PerformLayout();
            this.PnlCalendar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlFill;
        private CircularProgressBar.CircularProgressBar CpbTotal;
        private System.Windows.Forms.Panel PnlCalculation;
        private System.Windows.Forms.Label LblIncome;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label LblExpense;
        private System.Windows.Forms.Panel PnlCalendar;
        private System.Windows.Forms.Label LblYear;
        private System.Windows.Forms.Label LblMonth;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnBack;
        private CircularProgressBar.CircularProgressBar CpbDistribution;
        private System.Windows.Forms.Label LblDistributionIncomePercent;
        private System.Windows.Forms.Panel PnlTotal;
        private System.Windows.Forms.Label LblTotalIncomePercent;
        private System.Windows.Forms.Label LblTotalExpensePercent;
        private System.Windows.Forms.Panel PnlDistribution;
        private System.Windows.Forms.Label LblDistributionExpensePercent;
        private System.Windows.Forms.ComboBox CmbCalendar;
    }
}