using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utility;
using BLL;

namespace LibraryinfoSystem
{
    public partial class PayForm : Form
    {
        public PayForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
               int damageIndex =int.Parse(item.Cells["damageIndex"].Value.ToString());
                string sql = "update damageRecord set damageRtnTime=GETDATE() where damageIndex=@damageIndex";
                SqlParameter para = new SqlParameter("@damageIndex", damageIndex);
                dataTable = SQLHelper.getDataTable(sql, para);
            }
            MessageBox.Show("欠款已缴清");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {
                MainWin mainw = (MainWin)this.Owner;
                mainw.Show();
            }
            this.Close();
        }

        private void PayForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner != null)
            {
                MainWin mainw = (MainWin)this.Owner;
                mainw.Show();
            }
        }
        private DataTable dataTable;
        private void button2_Click(object sender, EventArgs e)
        {

            String libraryCardID=textBox1.Text;
            if (!AS.HaveLibraryCard(libraryCardID)) {
                MessageBox.Show("用户ID错误！");
                return;
            }

            string sql = "select damageRecord.damageIndex,damageReason.damageExplain,circuBookClass.bookName,damageRecord.damageTime,damageRecord.damageMoney "+
                    "from damageRecord join(circuBook join circuBookClass on circuBook.isbn = circuBookClass.isbn)on damageRecord.circuBookNo = circuBook.circuBookNo "+
                    "join damageReason on damageReason.damageReasonIndex = damageRecord.damageReasonIndex "+
                    "where damageRecord.damageRtnTIme is NULL and damageRecord.libraryCardID = @libraryCardID";
            SqlParameter para = new SqlParameter("@libraryCardID", libraryCardID);
            
            dataTable = SQLHelper.getDataTable(sql, para);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dataTable;
            //dataTable.
            decimal amount=0;
            if (dataTable.Rows.Count == 0) {
                MessageBox.Show("该用户无欠费记录");
                return;
            }
            for (int i = 0; i < dataTable.Rows.Count; i++) {
                amount = amount + decimal.Parse(dataTable.Rows[i]["damageMoney"].ToString());
            }
            textBox2.Text = amount.ToString();
        }
     

    }
}
