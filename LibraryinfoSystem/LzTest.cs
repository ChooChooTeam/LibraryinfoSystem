using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utility;
namespace LibraryinfoSystem
{
    public partial class LzTest : Form
    {
        public LzTest()
        {
            InitializeComponent();
        }

        private void LzTest_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 由于所有的数据都会显示在最后的表格中
            // 所以查询语句必须谨慎的需要的行
            string sql = "SELECT isbn,bookName FROM circuBookClass";
            dgvBook.DataSource = SQLHelper.getDataTable(sql);

        }

        private void dgvBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
