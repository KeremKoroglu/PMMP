using PersonalMoneyManagementAndPlanning.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using GroupBox = System.Windows.Forms.GroupBox;
using Label = System.Windows.Forms.Label;

namespace PersonalMoneyManagementAndPlanning.TopMenuForms
{
    public partial class FrmIncomeAndExpenseList : Form
    {
        // VALUE
        #region
        private readonly int grbWidth = 1496, grbHeight = 250;
        private readonly int pnlWidth = 1467, pnlHeight = 60;
        private readonly int pnlLowerWidth = 744, pnlLowerHeight = 45;
        private readonly int fontSize = 24, fontSizeDescription = 18, fontSizeAmount = 36;
        #endregion

        // FORM 
        #region
        public FrmIncomeAndExpenseList()
        {
            InitializeComponent();
        }

        private void FrmIncomeAndExpenseList_Load(object sender, EventArgs e)
        {
            // LANG
            #region
            CmbAccount.Items.Clear();
            foreach (var item in Database.AccountList())
            {
                CmbAccount.Items.Add(item.Name);
            }
            CmbAccount.SelectedIndex = 0;
            CmbAccount.DropDownHeight = CmbAccount.ItemHeight * 10;
            CmbSort.Items.Clear();
            CmbSort.Items.Add(Lang.GetText("Date"));
            CmbSort.Items.Add(Lang.GetText("Amount"));
            CmbSort.Items.Add(Lang.GetText("Category"));
            CmbSort.SelectedIndex = 0;
            CmbSort.DropDownHeight = CmbAccount.ItemHeight * 10;
            #endregion

            GetValues();
        }
        #endregion

        // COMBOBOX
        #region
        private void CmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetValues();
        }

        private void CmbAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetValues();
        }
        #endregion

        // FUNCTION
        #region
        public void GetValues()
        {
            FlpIncomeAndExpenseList.Controls.Clear();
            if (Database.IncomeAndExpenseList(CmbAccount.Text, CmbSort.Text) == null)
            {
                Label lblInformation = new()
                {
                    Font = new System.Drawing.Font("Times New Roman", fontSize),
                    TextAlign = ContentAlignment.MiddleCenter,
                    AutoSize = true,
                    Text = Lang.GetText("NoIncomeOrExpense")
                };
                FlpIncomeAndExpenseList.Controls.Add(lblInformation);
            }
            else
            {
                foreach (var item in Database.IncomeAndExpenseList(CmbAccount.Text, CmbSort.Text))
                {
                    string date = $"{item.Date.Day} {Lang.GetMonths()[item.Date.Month]}";
                    string account = item.Account;
                    string desciription = item.Description;
                    string category = Lang.GetText(item.Category);
                    string amount = item.Amount + Database.CurrencySymbol(account);

                    // GroupBoxs
                    #region
                    GroupBox grb = new()
                    {
                        Size = new System.Drawing.Size(grbWidth, grbHeight),
                        BackColor = item.TableName == "Income" ? Color.LightGreen : Color.FromArgb(255, 128, 128)
                    };
                    FlpIncomeAndExpenseList.Controls.Add(grb);
                    #endregion
                    // Panels
                    #region
                    Panel pnlTop = new()
                    {
                        Size = new System.Drawing.Size(pnlWidth, pnlHeight),
                        Dock = DockStyle.Top,
                    };
                    grb.Controls.Add(pnlTop);

                    Panel pnlTopLeft = new()
                    {
                        Size = new System.Drawing.Size(pnlLowerWidth, pnlLowerHeight),
                        Dock = DockStyle.Left,
                    };
                    pnlTop.Controls.Add(pnlTopLeft);

                    Panel pnlTopRight = new()
                    {
                        Size = new System.Drawing.Size(pnlLowerWidth, pnlLowerHeight),
                        Dock = DockStyle.Right
                    };
                    pnlTop.Controls.Add(pnlTopRight);

                    Panel pnlBottom = new()
                    {
                        Size = new System.Drawing.Size(pnlWidth, pnlHeight),
                        Dock = DockStyle.Bottom
                    };
                    grb.Controls.Add(pnlBottom);

                    Panel pnlBottomLeft = new()
                    {
                        Size = new System.Drawing.Size(pnlLowerWidth, pnlLowerHeight),
                        Dock = DockStyle.Left
                    };
                    pnlBottom.Controls.Add(pnlBottomLeft);

                    Panel pnlBottomRight = new()
                    {
                        Size = new System.Drawing.Size(pnlLowerWidth, pnlLowerHeight),
                        Dock = DockStyle.Right
                    };
                    pnlBottom.Controls.Add(pnlBottomRight);
                    #endregion
                    // Labels
                    #region
                    Label lblDate = new()
                    {
                        Dock = DockStyle.Fill,
                        TextAlign = ContentAlignment.MiddleLeft,
                        Font = new System.Drawing.Font("Times New Roman", fontSize),
                        Text = date
                    };
                    pnlTopLeft.Controls.Add(lblDate);

                    Label lblAccount = new()
                    {
                        Dock = DockStyle.Fill,
                        TextAlign = ContentAlignment.MiddleRight,
                        Font = new System.Drawing.Font("Times New Roman", fontSize),
                        Text = account
                    };
                    pnlTopRight.Controls.Add(lblAccount);

                    Label lblDescription = new()
                    {
                        Dock = DockStyle.Fill,
                        TextAlign = ContentAlignment.MiddleLeft,
                        Font = new System.Drawing.Font("Times New Roman", fontSizeDescription, FontStyle.Italic),
                        Text = desciription
                    };
                    grb.Controls.Add(lblDescription);

                    Label lblCategory = new()
                    {
                        Dock = DockStyle.Fill,
                        TextAlign = ContentAlignment.MiddleLeft,
                        Font = new System.Drawing.Font("Times New Roman", fontSize),
                        Text = category
                    };
                    pnlBottomLeft.Controls.Add(lblCategory);

                    Label lblAmount = new()
                    {
                        Dock = DockStyle.Fill,
                        TextAlign = ContentAlignment.MiddleRight,
                        Font = new System.Drawing.Font("Times New Roman", fontSizeAmount, FontStyle.Bold),
                        Text = amount
                    };
                    pnlBottomRight.Controls.Add(lblAmount);
                    #endregion
                }
            }          
        }
        #endregion
    }
}
