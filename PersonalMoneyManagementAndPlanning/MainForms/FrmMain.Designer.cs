namespace PersonalMoneyManagementAndPlanning.MainForms
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            this.MnsTopMenu = new System.Windows.Forms.MenuStrip();
            this.TsmMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmAddIncomeExpense = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmScenarios = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmCalendar = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmIncomes = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmExpenses = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmTotal = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmReport = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmLang = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmAccounts = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmIncomeAndExpenseList = new System.Windows.Forms.ToolStripMenuItem();
            this.PnlBottomMenu = new System.Windows.Forms.Panel();
            this.PnlRightMenu = new System.Windows.Forms.Panel();
            this.PnlLeftMenu = new System.Windows.Forms.Panel();
            this.Tlt = new System.Windows.Forms.ToolTip(this.components);
            this.PnlFill = new System.Windows.Forms.Panel();
            this.TsmScenarioList = new System.Windows.Forms.ToolStripMenuItem();
            this.MnsTopMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnsTopMenu
            // 
            this.MnsTopMenu.AutoSize = false;
            this.MnsTopMenu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.MnsTopMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmMainMenu,
            this.TsmAddIncomeExpense,
            this.TsmScenarios,
            this.TsmSettings,
            this.TsmCalendar,
            this.TsmIncomes,
            this.TsmExpenses,
            this.TsmTotal,
            this.TsmReport,
            this.TsmLang,
            this.TsmAccounts,
            this.TsmIncomeAndExpenseList,
            this.TsmScenarioList});
            this.MnsTopMenu.Location = new System.Drawing.Point(0, 0);
            this.MnsTopMenu.Name = "MnsTopMenu";
            this.MnsTopMenu.ShowItemToolTips = true;
            this.MnsTopMenu.Size = new System.Drawing.Size(1904, 100);
            this.MnsTopMenu.TabIndex = 1;
            this.MnsTopMenu.Text = "menuStrip1";
            // 
            // TsmMainMenu
            // 
            this.TsmMainMenu.Name = "TsmMainMenu";
            this.TsmMainMenu.Size = new System.Drawing.Size(74, 96);
            this.TsmMainMenu.Text = "Ana Menü";
            this.TsmMainMenu.Click += new System.EventHandler(this.TsmMainMenu_Click);
            // 
            // TsmAddIncomeExpense
            // 
            this.TsmAddIncomeExpense.Name = "TsmAddIncomeExpense";
            this.TsmAddIncomeExpense.Size = new System.Drawing.Size(98, 96);
            this.TsmAddIncomeExpense.Text = "Gelir Gider Ekle";
            this.TsmAddIncomeExpense.Click += new System.EventHandler(this.TsmAddIncomeExpense_Click);
            // 
            // TsmScenarios
            // 
            this.TsmScenarios.Name = "TsmScenarios";
            this.TsmScenarios.Size = new System.Drawing.Size(74, 96);
            this.TsmScenarios.Text = "Senaryolar";
            this.TsmScenarios.Click += new System.EventHandler(this.TsmScenarios_Click);
            // 
            // TsmSettings
            // 
            this.TsmSettings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TsmSettings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsmSettings.Name = "TsmSettings";
            this.TsmSettings.Size = new System.Drawing.Size(56, 96);
            this.TsmSettings.Text = "Ayarlar";
            this.TsmSettings.Click += new System.EventHandler(this.TsmSettings_Click);
            // 
            // TsmCalendar
            // 
            this.TsmCalendar.Name = "TsmCalendar";
            this.TsmCalendar.Size = new System.Drawing.Size(56, 96);
            this.TsmCalendar.Text = "Takvim";
            // 
            // TsmIncomes
            // 
            this.TsmIncomes.Name = "TsmIncomes";
            this.TsmIncomes.Size = new System.Drawing.Size(56, 96);
            this.TsmIncomes.Text = "Gelirler";
            // 
            // TsmExpenses
            // 
            this.TsmExpenses.Name = "TsmExpenses";
            this.TsmExpenses.Size = new System.Drawing.Size(60, 96);
            this.TsmExpenses.Text = "Giderler";
            // 
            // TsmTotal
            // 
            this.TsmTotal.Name = "TsmTotal";
            this.TsmTotal.Size = new System.Drawing.Size(58, 96);
            this.TsmTotal.Text = "Toplam";
            // 
            // TsmReport
            // 
            this.TsmReport.Name = "TsmReport";
            this.TsmReport.Size = new System.Drawing.Size(50, 96);
            this.TsmReport.Text = "Rapor";
            // 
            // TsmLang
            // 
            this.TsmLang.Name = "TsmLang";
            this.TsmLang.Size = new System.Drawing.Size(79, 96);
            this.TsmLang.Text = "Dili Değiştir";
            this.TsmLang.Click += new System.EventHandler(this.TsmLang_Click);
            // 
            // TsmAccounts
            // 
            this.TsmAccounts.Name = "TsmAccounts";
            this.TsmAccounts.Size = new System.Drawing.Size(65, 96);
            this.TsmAccounts.Text = "Hesaplar";
            this.TsmAccounts.Click += new System.EventHandler(this.TsmAccounts_Click);
            // 
            // TsmIncomeAndExpenseList
            // 
            this.TsmIncomeAndExpenseList.Name = "TsmIncomeAndExpenseList";
            this.TsmIncomeAndExpenseList.Size = new System.Drawing.Size(110, 96);
            this.TsmIncomeAndExpenseList.Text = "Gelir Gider Listele";
            this.TsmIncomeAndExpenseList.Click += new System.EventHandler(this.TsmIncomeAndExpenseList_Click);
            // 
            // PnlBottomMenu
            // 
            this.PnlBottomMenu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PnlBottomMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlBottomMenu.Location = new System.Drawing.Point(0, 941);
            this.PnlBottomMenu.Name = "PnlBottomMenu";
            this.PnlBottomMenu.Size = new System.Drawing.Size(1904, 100);
            this.PnlBottomMenu.TabIndex = 2;
            // 
            // PnlRightMenu
            // 
            this.PnlRightMenu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PnlRightMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnlRightMenu.Location = new System.Drawing.Point(1704, 100);
            this.PnlRightMenu.Name = "PnlRightMenu";
            this.PnlRightMenu.Size = new System.Drawing.Size(200, 841);
            this.PnlRightMenu.TabIndex = 3;
            // 
            // PnlLeftMenu
            // 
            this.PnlLeftMenu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PnlLeftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlLeftMenu.Location = new System.Drawing.Point(0, 100);
            this.PnlLeftMenu.Name = "PnlLeftMenu";
            this.PnlLeftMenu.Size = new System.Drawing.Size(200, 841);
            this.PnlLeftMenu.TabIndex = 4;
            // 
            // PnlFill
            // 
            this.PnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlFill.Location = new System.Drawing.Point(200, 100);
            this.PnlFill.Name = "PnlFill";
            this.PnlFill.Size = new System.Drawing.Size(1504, 841);
            this.PnlFill.TabIndex = 5;
            // 
            // TsmScenarioList
            // 
            this.TsmScenarioList.Name = "TsmScenarioList";
            this.TsmScenarioList.Size = new System.Drawing.Size(97, 96);
            this.TsmScenarioList.Text = "Senaryo Listele";
            this.TsmScenarioList.Click += new System.EventHandler(this.TsmScenarioList_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.PnlFill);
            this.Controls.Add(this.PnlLeftMenu);
            this.Controls.Add(this.PnlRightMenu);
            this.Controls.Add(this.MnsTopMenu);
            this.Controls.Add(this.PnlBottomMenu);
            this.MainMenuStrip = this.MnsTopMenu;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.MnsTopMenu.ResumeLayout(false);
            this.MnsTopMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MenuStrip MnsTopMenu;
        private System.Windows.Forms.ToolStripMenuItem TsmSettings;
        private System.Windows.Forms.Panel PnlBottomMenu;
        private System.Windows.Forms.Panel PnlRightMenu;
        private System.Windows.Forms.Panel PnlLeftMenu;
        private System.Windows.Forms.ToolTip Tlt;
        private System.Windows.Forms.ToolStripMenuItem TsmScenarios;
        private System.Windows.Forms.ToolStripMenuItem TsmAddIncomeExpense;
        private System.Windows.Forms.ToolStripMenuItem TsmCalendar;
        private System.Windows.Forms.ToolStripMenuItem TsmIncomes;
        private System.Windows.Forms.ToolStripMenuItem TsmExpenses;
        private System.Windows.Forms.ToolStripMenuItem TsmTotal;
        private System.Windows.Forms.ToolStripMenuItem TsmReport;
        private System.Windows.Forms.ToolStripMenuItem TsmLang;
        private System.Windows.Forms.Panel PnlFill;
        private System.Windows.Forms.ToolStripMenuItem TsmAccounts;
        private System.Windows.Forms.ToolStripMenuItem TsmMainMenu;
        private System.Windows.Forms.ToolStripMenuItem TsmIncomeAndExpenseList;
        private System.Windows.Forms.ToolStripMenuItem TsmScenarioList;
    }
}