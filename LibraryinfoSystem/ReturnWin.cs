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
using DAL;
namespace LibraryinfoSystem
{
    public partial class ReturnWin : Form
    {
        static int damageReason = 0;
        static decimal brokenCost = 0;
        public ReturnWin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cost = 0;
            if(DAL.ReturnInfo.getOverDueDay(textBox1.Text)<0)
            {
                cost = -0.1 * DAL.ReturnInfo.getOverDueDay(textBox1.Text);
            }
            if (this.BrokenCheckBox.Checked)
            {
                
                if (brokenCost>0)
                {
                    try
                    {
                        DAL.ReturnInfo.InsertDamageRecord(damageReason, textBox1.Text, brokenCost);
                    }
                    catch(ArgumentOutOfRangeException)
                    {
                    }
                    cost += (double)brokenCost;
                    MessageBox.Show("还书成功，逾期和破损产生费用共计"+cost+"元！");
                }
                else
                {
                    try
                    {
                        DAL.ReturnInfo.InsertDamageRecord(damageReason, textBox1.Text, brokenCost);
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                    }
                    MessageBox.Show("还书成功，破损产生费用" + brokenCost + "元!");
                }
                
            }
            else
            {
                DAL.ReturnInfo.changeBorrowRecord(textBox1.Text);
                if(cost>0)
                {
                    MessageBox.Show("还书成功,逾期产生费用" + cost +"元！");
                }
                else
                {
                    MessageBox.Show("还书成功!" );
                }
            }
            textBox1.Text = null;
            BrokenCheckBox.Checked = false;
            DAL.ReturnInfo.changeBorrowRecord(textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Length == 10)
            {
                BrokenCheckBox.CheckState = CheckState.Unchecked;
                CircuBookClass cBookc = BLL.RetrunWinAS.montorTextBox1Changed(this.textBox1.Text);
                this.textBox2.Text = cBookc.BookName;
                this.textBox3.Text = cBookc.PublishingHouse;
                
            }
            if(this.textBox1.Text.Length!=10)
            {
                label2.Enabled = false;
                this.textBox2.Text = null;
                this.textBox3.Text = null;
                BrokenCheckBox.Enabled = false;
                comboBox1.Text = null;
                button1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {
                MainWin mainw = (MainWin)this.Owner;
                mainw.Show();
            }
            this.Dispose();
        }

        private void ReturnWin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner != null)
            {
                MainWin mainw = (MainWin)this.Owner;
                mainw.Show();
            }
        }

        private void BrokenCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            if (BrokenCheckBox.CheckState==CheckState.Checked)
            {
                label2.Enabled = true;
                button1.Enabled = false;
                comboBox1.Enabled = true;
                comboBox1.Text = null;
            }
            else
            {
                label2.Enabled = false;
                if (textBox2.Text!=null)
                {
                    button1.Enabled = true;
                }
                comboBox1.Text = null;
                comboBox1.Enabled = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<DamageReason> CBDamageReason = DAL.DamageInfo.getAllReason();
            if(comboBox1.Text!=null)
            {
                button1.Enabled = true;
            }
            if (CBDamageReason[0].DamageExplain==comboBox1.Text)
            {
                damageReason = 1;
                brokenCost += DAL.ReturnInfo.getPrice(textBox1.Text) * (decimal)0.1;
            }
            if (CBDamageReason[1].DamageExplain == comboBox1.Text)
            {
                damageReason = 2;
                brokenCost += DAL.ReturnInfo.getPrice(textBox1.Text) * (decimal)0.2;
            }
            if (CBDamageReason[2].DamageExplain == comboBox1.Text)
            {
                damageReason = 3;

                brokenCost += DAL.ReturnInfo.getPrice(textBox1.Text) * (decimal)0.5;
            }
            if (CBDamageReason[3].DamageExplain == comboBox1.Text)
            {
                damageReason = 4;
                brokenCost += DAL.ReturnInfo.getPrice(textBox1.Text);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ReturnWin_Load(object sender, EventArgs e)
        {
            label2.Enabled = false;
            brokenCost = 0;
            button1.Enabled = false;
            BrokenCheckBox.Enabled = false;
            comboBox1.Text = null;
            List<DamageReason> CBDamageReason = DAL.DamageInfo.getAllReason();
            for (int i = 0; i < CBDamageReason.Count(); i++)
            {
                comboBox1.Items.Add(CBDamageReason[i].DamageExplain);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == null)
            {
                
                button1.Enabled = false;
                BrokenCheckBox.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
                BrokenCheckBox.Enabled = true;
            }
        }
    }
}
