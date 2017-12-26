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
        
        private void button1_Click(object sender, EventArgs e)
        {
            String libraryCardID = textBox1.Text;
            

        }
    }
}
