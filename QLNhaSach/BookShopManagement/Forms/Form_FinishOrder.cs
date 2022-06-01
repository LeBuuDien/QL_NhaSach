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
using BookShopManagement.DTO;

namespace BookShopManagement.Forms
{
    public partial class Form_FinishOrder : Form
    {
        DAO_Bill bill = new DAO_Bill();
        QLNSDataContext QLNS = new QLNSDataContext();
        public Form_FinishOrder()
        {
            InitializeComponent();
        }
        public Form_FinishOrder(string a,string maHD)
        {
            InitializeComponent();
            txtTongTien.Text = a;
            HOADON h = QLNS.HOADONs.Where(t => t.MaKH == maHD).FirstOrDefault();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            this.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            QLNS.SubmitChanges();
            this.Dispose();
        }

        private void Form_FinishOrder_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
