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
using BLL;
using Model;
using Utility;

namespace LibraryinfoSystem
{
    public partial class BorrowWin : Form
    {
        public BorrowWin()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            String libraryCardID = textBox1.Text;
            LibraryCard card = BorrowWinAS.GetLibraryCardIdInfo(libraryCardID);
            textBox2.Text = card._Name;
            
            ReaderType readerType = BorrowWinAS.GetreaderTypeInfo(card.TypeID);
            textBox5.Text = readerType.TypeName;

            string sql = "select  borrowRecord.circuBookNo,circuBookClass.bookName,borrowRecord.borrowDuration,borrowRecord.dateToReturn,(case  when borrowRecord.dateToReturn>GETDATE() then datediff(DAY,borrowRecord.dateToReturn,GETDATE())else -datediff(DAY,borrowRecord.dateToReturn,GETDATE())end)  as remainDays,borrowRecord.renewNum " +
                "from borrowRecord join (circuBook join circuBookClass on circuBook.isbn = circuBookClass.isbn)on borrowRecord.circuBookNo = circuBook.circuBookNo "+
                "where borrowRecord.libraryCardID = 1";
            //SqlParameter para = new SqlParameter("@libraryCardID", libraryCardID);
            DataTable dataTable= SQLHelper.getDataTable(sql);
            dataGridView1.DataSource =dataTable;
            //string sql = "SELECT * FROM circuBookClass WHERE isbn = @isbn";
            //SqlParameter para = new SqlParameter("@isbn", ISBN);
            //SQLHelper.CoverToObject cto = new SQLHelper.CoverToObject(ReaderToCircuBookClass);
            //var list = SQLHelper.Query(sql, cto, para);
            textBox3.Text = dataTable.Rows.Count.ToString();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {
                MainWin mainw = (MainWin)this.Owner;
                mainw.Show();
            }
            this.Close();
        }

        private void BorrowWin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner != null)
            {
                MainWin mainw = (MainWin)this.Owner;
                mainw.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BorrowingWin biw = new BorrowingWin();
            biw.Show(this);
        }
    }
}
