using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using BLL;
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
            if (this.textBox1.Text.Length == 10)
            {
                CircuBookClass cBookc = BLL.RetrunWinAS.montorTextBox1Changed(this.textBox1.Text);
                this.textBox2.Text = cBookc.BookName;
                this.textBox3.Text = cBookc.PublishingHouse;
                
            }
            if(this.textBox1.Text.Length!=10)
            {
                this.textBox2.Text = null;
                this.textBox3.Text = null;
            }
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

        private void ReturnWin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner != null)
            {
                MainWin mainw = (MainWin)this.Owner;
                mainw.Show();
            }
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
    }
}
