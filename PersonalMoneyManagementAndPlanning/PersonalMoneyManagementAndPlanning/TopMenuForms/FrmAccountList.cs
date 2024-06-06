using PersonalMoneyManagementAndPlanning.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalMoneyManagementAndPlanning.TopMenuForms
{
    public partial class FrmAccountList : Form
    {
        // VALUE
        #region
        private readonly int grbWidth = 1496, grbHeight = 250;
        private readonly int pnlWidth = 1467, pnlHeight = 60;
        private readonly int pnlLowerWidth = 744, pnlLowerHeight = 45;
        private readonly int fontSize = 24, fontSizeDescription = 18, fontSizeTotal = 32;
        private int zebraDesignCount = 0;
        #endregion

        // FORM
        #region
        public FrmAccountList()
        {
            InitializeComponent();
        }

        private void FrmAccountList_Load(object sender, EventArgs e)
        {
            GetValues();
        }
        #endregion

        // FUNCTION
        #region
        public void GetValues()
        {
            FlpScenarioList.Controls.Clear();
            if (Database.AccountList() == null)
            {
                Label lblInformation = new()
                {
                    Font = new System.Drawing.Font("Times New Roman", fontSize),
                    TextAlign = ContentAlignment.MiddleCenter,
                    AutoSize = true,
                };
                FlpScenarioList.Controls.Add(lblInformation);
            }
            else
            {
                foreach (var item in Database.AccountList())
                {
                    string name = item.Name;
                    string no = "No : " + item.No;
                    string desciription = item.Description;
                    string category = Lang.GetText(item.Category);
                    string currency = Database.TotalByAccount(item.Name) + " - " + item.Currency;

                    // GroupBoxs
                    #region
                    GroupBox grb = new()
                    {
                        Size = new System.Drawing.Size(grbWidth, grbHeight),
                        BackColor = zebraDesignCount % 2 == 0 ? Color.Turquoise : Color.Pink
                    };
                    zebraDesignCount++;
                    FlpScenarioList.Controls.Add(grb);
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
                    Label lblName = new()
                    {
                        Dock = DockStyle.Fill,
                        TextAlign = ContentAlignment.MiddleLeft,
                        Font = new System.Drawing.Font("Times New Roman", fontSize),
                        Text = name
                    };
                    pnlTopLeft.Controls.Add(lblName);

                    Label lblNo = new()
                    {
                        Dock = DockStyle.Fill,
                        TextAlign = ContentAlignment.MiddleRight,
                        Font = new System.Drawing.Font("Times New Roman", fontSize),
                        Text = no
                    };
                    pnlTopRight.Controls.Add(lblNo);

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

                    Label lblCurrency = new()
                    {
                        Dock = DockStyle.Fill,
                        TextAlign = ContentAlignment.MiddleRight,
                        Font = new System.Drawing.Font("Times New Roman", fontSizeTotal, FontStyle.Bold),
                        Text = currency
                    };
                    pnlBottomRight.Controls.Add(lblCurrency);
                    #endregion
                }
            }
        }
        #endregion
    }
}
