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

            Reader reader = BorrowWinAS.GetreaderInfo(libraryCardID);
            ReaderType readerType = BorrowWinAS.GetreaderTypeInfo(reader.TypeID);
            textBox5.Text = readerType.TypeName;

            string sql = "select  borrowRecord.circuBookNo,circuBookClass.bookName,borrowRecord.borrowDuration,borrowRecord.dateToReturn,(case  when borrowRecord.dateToReturn>GETDATE() then datediff(DAY,borrowRecord.dateToReturn,GETDATE())else -datediff(DAY,borrowRecord.dateToReturn,GETDATE())end)  as remainDays,borrowRecord.renewNum " +
                "from borrowRecord join (circuBook join circuBookClass on circuBook.isbn = circuBookClass.isbn)on borrowRecord.circuBookNo = circuBook.circuBookNo "+
                "where borrowRecord.libraryCardID = 1";
            //SqlParameter para = new SqlParameter("@libraryCardID", libraryCardID);
            dataGridView1.DataSource = SQLHelper.getDataTable(sql);
            //string sql = "SELECT * FROM circuBookClass WHERE isbn = @isbn";
            //SqlParameter para = new SqlParameter("@isbn", ISBN);
            //SQLHelper.CoverToObject cto = new SQLHelper.CoverToObject(ReaderToCircuBookClass);
            //var list = SQLHelper.Query(sql, cto, para);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
