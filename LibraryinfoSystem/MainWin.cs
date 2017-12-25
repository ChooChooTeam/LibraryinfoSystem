﻿using System;
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
    public partial class MainWin : Form
    {
        public MainWin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BorrowWin bw = new BorrowWin();
            bw.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //var book = DAL.BookInfo.queryBookInfo("9780387202488");
            //MessageBox.Show(book.BookName);
            //string sql = "SELECT * FROM circuBookClass";
            //var table = Utility.SQLHelper.getDataTable(sql);
            LzTest form = new LzTest();
            form.Show();

            var book = DAL.BookInfo.queryABookInfo("2");
            MessageBox.Show(book[0].ToString()+book[1].ToString());

        }

        private void bthExample_Click(object sender, EventArgs e)
        {
            MessageBox.Show("欢迎欢迎");
        }
    }
}
