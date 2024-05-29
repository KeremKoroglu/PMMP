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
    public partial class FrmIncomeAndExpenseList : Form
    {
        // FORM 
        #region
        public FrmIncomeAndExpenseList()
        {
            InitializeComponent();
        }

        private void FrmIncomeAndExpenseList_Load(object sender, EventArgs e)
        {
            GetValues();
        }
        #endregion

        // FUNCTION
        #region
        void GetValues()
        {
            dataGridView1.DataSource = Database.IncomeAndExpense();
            foreach (DataGridViewRow row in dataGridView1.Rows)
                if (Convert.ToInt32(row.Cells[7].Value) < Convert.ToInt32(row.Cells[10].Value))
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
        }
        #endregion
    }
}
