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
        private int borrowLen=0;
        private int reBorrowNum=0;
        private bool userBorrowAble = false,bookBorrowAble=false;
        public BorrowWin()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            String libraryCardID = textBox1.Text;
            button4.Enabled = false;
            label16.Text = "";
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
            textBox5.Text = readerType.TypeName.Replace(" ","");

            string sql = "select  borrowRecord.circuBookNo,circuBookClass.bookName,borrowRecord.borrowDuration,borrowRecord.dateToReturn,datediff(DAY,GETDATE(),borrowRecord.dateToReturn) as remainDays,borrowRecord.renewNum " +
                "from borrowRecord join (circuBook join circuBookClass on circuBook.isbn = circuBookClass.isbn)on borrowRecord.circuBookNo = circuBook.circuBookNo "+
                "where returnTime is null and borrowRecord.libraryCardID = @libraryCardID";
            SqlParameter para = new SqlParameter("@libraryCardID", libraryCardID);
            DataTable dataTable= SQLHelper.getDataTable(sql,para);
            dataGridView1.DataSource =dataTable;
            textBox3.Text = dataTable.Rows.Count.ToString();
            DataRow[] datarows=dataTable.Select("remainDays<0");
            int overTimeBookcount=datarows.Count();
            //textBox6.Text = overTimeBookcount.ToString();
            int canBorrowN = readerType.MaxBorrowNum- dataTable.Rows.Count;
            borrowLen = readerType.BorrowDuration;
            reBorrowNum = readerType.ReBorrowNum;
            int borrowCardStatusInt = 0;
            String borrowCardStatusText="正常";

            if (canBorrowN == 0)
            {
                borrowCardStatusInt = 2;
                canBorrowN = 0;
                borrowCardStatusText = "可借数达上限";
            }
            if (overTimeBookcount > 0) {
                borrowCardStatusInt = 1;
                canBorrowN = 0;
                borrowCardStatusText="有书过期";
            }
            if (BorrowWinAS.GetUserHaveMoneyToPay(libraryCardID))
            {
                borrowCardStatusInt = 1;
                canBorrowN = 0;
                borrowCardStatusText = "欠费未缴清";
            }
           
            if (card.DueTime < DateTime.Now) {
                borrowCardStatusInt = 1;
                canBorrowN = 0;
                borrowCardStatusText = "借阅证过期";
            }
            //TODO:有未缴费项

            textBox8.Text = borrowCardStatusText;
            if (borrowCardStatusInt == 1)
            {
                textBox8.BackColor = Color.Red;
                textBox8.ForeColor = Color.Black;
            }
            else if(borrowCardStatusInt==2){
                textBox8.BackColor = Color.Yellow;
                textBox8.ForeColor = Color.Black;
            }
            else {
                textBox8.BackColor = Color.Green;
                textBox8.ForeColor = Color.White;
                userBorrowAble = true;
                checkBorrowAble();
            }
            textBox4.Text = canBorrowN.ToString();
            dataGridView1.ClearSelection();

        }
        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (float.Parse(item.Cells[4].Value.ToString()) < 0)
                {
                    
                    item.Cells[4].Style.BackColor = Color.Red;
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
            textBox11.Text = "";
            textBox10.Text = "";
            label7.Text = "";
            label7.ForeColor = Color.Red;
            bookBorrowAble = false;
            checkBorrowAble();
            if (circuBookNo.Length == 10)
            {
                try
                {
                    CircuBookClass book = BookInfo.queryABookInfo(circuBookNo);
                    textBox11.Text = book.BookName;
                    textBox10.Text = book.PublishingHouse;
                }
                catch (System.ArgumentOutOfRangeException)
                {
                    label7.Text = "图书标识号有误！";
                    return;
                }
                if (!AS.BookBorrowAble(textBox9.Text))
                {
                    label7.Text = "书籍已被借出！";

                }
                else {
                    label7.ForeColor = Color.Green;
                    label7.Text = "该书籍可借阅";
                    bookBorrowAble = true;
                    checkBorrowAble();
                }

            }
           
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //只能输入数字
            if (e.KeyChar == 0x20) e.KeyChar = (char)0;  //禁止空格键  
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1.PerformClick();
                       
            }
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
            label16.Text = "";
            String sql = "INSERT INTO borrowRecord(libraryCardID, circuBookNo, borrowDuration, dateToReturn, renewNum) "
                + "VALUES(@libraryCardID,@circuBookNo,GETDATE(),DATEADD(day,@borrowLen,GETDATE()),0);";
            SqlParameter para = new SqlParameter("@libraryCardID", textBox1.Text);
            SqlParameter para1 = new SqlParameter("@circuBookNo", textBox9.Text);
            SqlParameter para2 = new SqlParameter("@borrowLen",borrowLen);
            SQLHelper.Update(sql, para,para1,para2);
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            bookBorrowAble = false;
            button1.PerformClick();
            checkBorrowAble();
            textBox9.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            userBorrowAble = false;
            checkBorrowAble();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1) {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                float remainDays =float.Parse(row.Cells[4].Value.ToString());
                int reBorrowNum = int.Parse(row.Cells[5].Value.ToString());
                if (remainDays >= 0 && reBorrowNum < this.reBorrowNum)
                {
                    label16.Text = "";
                    button4.Enabled = true;
                }
                else {
                    if (remainDays < 0)
                    {
                        label16.Text = "该书已过期！请先还书！";
                    }
                    else
                    {

                        label16.Text = "该书续借次数已达上限！";
                    }

                    button4.Enabled = false;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label16.Text = "";
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            string circuBookNo = row.Cells[0].Value.ToString();
            string sql = "update borrowRecord set renewNum = renewNum + 1, dateToReturn = DATEADD(day, @borrowLen, dateToReturn) "
             + "where circuBookNo = @circuBookNo and returnTime is null;";
            SqlParameter para1 = new SqlParameter("@borrowLen", borrowLen);
            SqlParameter para2 = new SqlParameter("@circuBookNo", circuBookNo);
            SQLHelper.Update(sql,para1, para2);
            button1.PerformClick();

        }
        private void checkBorrowAble() {
            if (userBorrowAble && bookBorrowAble)
            {
                button3.Enabled = true;
            }
            else {
                button3.Enabled = false;
            }
        }
    }
}
