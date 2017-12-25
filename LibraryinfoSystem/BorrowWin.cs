using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace LibraryinfoSystem
{
    public partial class BorrowWin : Form
    {
        private BorrowWinAS helper=new BorrowWinAS();
        public BorrowWin()
        {
            InitializeComponent();
        }

        private void 加载子窗体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.MdiParent = this;
            f2.Show();

            Form3 f3 = new Form3();
            f3.MdiParent = this;
            f3.Show();

            Form4 f4 = new Form4();
            f4.MdiParent = this;
            f4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String libraryCardID = textBox1.Text;
            

        }
    }
}
