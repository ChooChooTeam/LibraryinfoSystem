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
using DAL;
using Model;
using Utility;

namespace LibraryinfoSystem
{
    public partial class BorrowWin : Form
    {
        private DateTime BorrowDuration;
        public BorrowWin()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            String libraryCardID = textBox1.Text;
            LibraryCard card;
            try
            {
                card = BorrowWinAS.GetLibraryCardIdInfo(libraryCardID);
              
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("借书证号不存在！");

                return;
            }

            textBox2.Text = card._Name;
            ReaderType readerType = BorrowWinAS.GetreaderTypeInfo(card.TypeID);
            textBox5.Text = readerType.TypeName;

            string sql = "select  borrowRecord.circuBookNo,circuBookClass.bookName,borrowRecord.borrowDuration,borrowRecord.dateToReturn,(case  when borrowRecord.dateToReturn>GETDATE() then datediff(DAY,borrowRecord.dateToReturn,GETDATE())else -datediff(DAY,borrowRecord.dateToReturn,GETDATE())end)  as remainDays,borrowRecord.renewNum " +
                "from borrowRecord join (circuBook join circuBookClass on circuBook.isbn = circuBookClass.isbn)on borrowRecord.circuBookNo = circuBook.circuBookNo "+
                "where borrowRecord.libraryCardID = @libraryCardID";
            SqlParameter para = new SqlParameter("@libraryCardID", libraryCardID);
            DataTable dataTable= SQLHelper.getDataTable(sql,para);
            dataGridView1.DataSource =dataTable;
            textBox3.Text = dataTable.Rows.Count.ToString();
            DataRow[] datarows=dataTable.Select("remainDays<0");
            int overTimeBookcount=datarows.Count();
            //textBox6.Text = overTimeBookcount.ToString();
            int canBorrowN = readerType.MaxBorrowNum- dataTable.Rows.Count;
            BorrowDuration = readerType.BorrowDuration;
            int borrowCardStatusInt = 0;
            String borrowCardStatusText="正常";
            if (overTimeBookcount > 0) {
                borrowCardStatusInt = 1;
                canBorrowN = 0;
                borrowCardStatusText="有书过期";
            }
            if (card.DueTime < DateTime.Now) {
                borrowCardStatusInt = 1;
                canBorrowN = 0;
                borrowCardStatusText = "借阅证过期";
            }
            //TODO:有未缴费项

            textBox8.Text = borrowCardStatusText;
            if (borrowCardStatusInt > 0)
            {
                textBox8.BackColor = Color.Red;

            }
            else {
                textBox8.BackColor = Color.Green;
            }
            textBox4.Text = canBorrowN.ToString();


        }
        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (float.Parse(item.Cells[4].Value.ToString()) < 0)
                {
                    item.DefaultCellStyle.BackColor = Color.Red;
                }
            }
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
        }

        private void BorrowWin_Load(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox9.Text.Length == 5)
            {
                label14.Text = "label数据";
            }
        }

        private void textBox9_TextChanged_1(object sender, EventArgs e)
        {
            
            String circuBookNo = textBox9.Text;
            if (circuBookNo.Length == 10)
            {

                CircuBookClass book = BookInfo.queryABookInfo(circuBookNo);
                textBox11.Text = book.BookName;
                textBox10.Text = book.PublishingHouse;
                
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //只能输入数字
            if (e.KeyChar == 0x20) e.KeyChar = (char)0;  //禁止空格键  
            if ((e.KeyChar == 0x2D) && (((TextBox)sender).Text.Length == 0)) return;   //处理负数  
            if (e.KeyChar > 0x20)
            {
                try
                {
                    double.Parse(((TextBox)sender).Text + e.KeyChar.ToString());
                }
                catch
                {
                    e.KeyChar = (char)0;   //处理非法字符  
                }
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            //只能输入数字
            if (e.KeyChar == 0x20) e.KeyChar = (char)0;  //禁止空格键  
            if ((e.KeyChar == 0x2D) && (((TextBox)sender).Text.Length == 0)) return;   //处理负数  
            if (e.KeyChar > 0x20)
            {
                try
                {
                    double.Parse(((TextBox)sender).Text + e.KeyChar.ToString());
                }
                catch
                {
                    e.KeyChar = (char)0;   //处理非法字符  
                }
            }
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
           
            
        }

        private void button3_Click_3(object sender, EventArgs e)
        {
            String sql = "INSERT INTO borrowRecord(libraryCardID, circuBookNo, borrowDuration, dateToReturn, renewNum) "
                + "VALUES(@libraryCardID,@circuBookNo,GETDATE(),GETDATE()+@BorrowDuration,0);";
            SqlParameter para = new SqlParameter("@libraryCardID", textBox1.Text);
            SqlParameter para1 = new SqlParameter("@circuBookNo", textBox9.Text);
            SqlParameter para2 = new SqlParameter("@borrowDuration", BorrowDuration.ToShortDateString());
            SQLHelper.Update(sql, para,para1,para2);

        }
    }
}
