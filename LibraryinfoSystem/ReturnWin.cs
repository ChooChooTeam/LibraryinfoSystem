using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryinfoSystem
{
    public partial class ReturnWin : Form
    {
        public ReturnWin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.BrokenCheckBox.Checked)
            {
                MessageBox.Show("还书成功，破损产生费用4元");
            }
            else
            {
                MessageBox.Show("还书成功");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Length == 5)
            {
                this.textBox2.Text = "数据库";
                this.textBox3.Text = "机械工业出版社";
            }
        }
    }
}
