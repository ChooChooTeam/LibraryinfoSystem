﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utility;
using BLL;
using Model;

namespace LibraryinfoSystem
{
    public partial class PayForm : Form
    {
        public PayForm()
        {
            InitializeComponent();
        }
        private DataTable dataTable;
        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataRow myRow in dataTable.Rows)
            {
               int damageIndex =int.Parse(myRow["damageIndex"].ToString());
                string sql = "update damageRecord set damageRtnTime=GETDATE() where damageIndex=@damageIndex";
                SqlParameter para = new SqlParameter("@damageIndex", damageIndex);
                SQLHelper.Update(sql, para);
            }
            dataTable.Clear();
            textBox2.Clear();
            button3.Enabled = false;
            MessageBox.Show("欠款已缴清");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {
                MainWin mainw = (MainWin)this.Owner;
                mainw.Show();
            }
            this.Close();
        }

        private void PayForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner != null)
            {
                MainWin mainw = (MainWin)this.Owner;
                mainw.Show();
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {

            String libraryCardID=textBox1.Text;
            LibraryCard card = AS.HaveLibraryCard(libraryCardID);
            if (null == card)
            {
                MessageBox.Show("用户ID错误！");
                return;
            }
            label6.Text = card._Name;
            string sql = "select damageRecord.damageIndex,damageReason.damageExplain,circuBookClass.bookName,damageRecord.damageTime,damageRecord.damageMoney "+
                    "from damageRecord join(circuBook join circuBookClass on circuBook.isbn = circuBookClass.isbn)on damageRecord.circuBookNo = circuBook.circuBookNo "+
                    "join damageReason on damageReason.damageReasonIndex = damageRecord.damageReasonIndex "+
                    "where damageRecord.damageRtnTIme is NULL and damageRecord.libraryCardID = @libraryCardID";
            SqlParameter para = new SqlParameter("@libraryCardID", libraryCardID);
            
            dataTable = SQLHelper.getDataTable(sql, para);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dataTable;
            //dataTable.
            decimal amount=0;
            if (dataTable.Rows.Count == 0) {
                MessageBox.Show("该用户无欠费记录");
                return;
            }
            for (int i = 0; i < dataTable.Rows.Count; i++) {
                amount = amount + decimal.Parse(dataTable.Rows[i]["damageMoney"].ToString());
            }
            textBox2.Text = amount.ToString();
            button3.Enabled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ////只能输入数字
            //if (e.KeyChar == 0x20) e.KeyChar = (char)0;  //禁止空格键  
            //if ((e.KeyChar == 0x2D) && (((TextBox)sender).Text.Length == 0)) return;   //处理负数  
            //if (e.KeyChar > 0x20)
            //{
            //    try
            //    {
            //        double.Parse(((TextBox)sender).Text + e.KeyChar.ToString());
            //    }
            //    catch
            //    {
            //        e.KeyChar = (char)0;   //处理非法字符  
            //    }
            //}
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label6.Text = "";
            button3.Enabled = false;
        }
    }
}
