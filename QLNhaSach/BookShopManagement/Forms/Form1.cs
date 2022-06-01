using BookShopManagement.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookShopManagement.BLL;

namespace BookShopManagement
{
    public partial class Form1 : Form
    {
        login lg = new login();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lg.funtionLogin(textBox1.Text, textBox2.Text))
            {
                if (lg.phanQuyen(textBox1.Text).Contains("1"))
                {
                    using (Form_Dashboard fd = new Form_Dashboard())
                    {
                        fd.ShowDialog();
                    }
                }
                else
                {
                    using (Form_Dashboard fd = new Form_Dashboard(textBox1.Text))
                    {
                        fd.ShowDialog();
                    }
                }

            }
        }
    }
}
