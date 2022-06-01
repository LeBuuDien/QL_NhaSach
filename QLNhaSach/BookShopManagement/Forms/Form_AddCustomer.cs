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
    public partial class Form_AddCustomer : Form
    {
        public Form_AddCustomer()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            KhachHang khach = new KhachHang();
            khach.MaKH = "KH0" + rd.Next(1000);
            khach.TenKH = txtName.Text;
            khach.SDT = txtPhone.Text;
            khach.EMAIL = txtEmail.Text;
            khach.Address = txtAddress.Text;

            Dao_KhachHang khachHang = new Dao_KhachHang();
            khachHang.addKhachHang(khach);
        }
    }
}
