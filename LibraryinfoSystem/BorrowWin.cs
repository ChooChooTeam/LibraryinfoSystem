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
using Model;
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
    }
}
