using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookShopManagement.Forms;
using BookShopManagement.BLL;

namespace BookShopManagement.UserControls
{
    public partial class UC_khtt : UserControl
    {
        Dao_KhachHang khachHang = new Dao_KhachHang();
        public UC_khtt()
        {
            InitializeComponent();
        }

        private void btnAddNewBooks_Click(object sender, EventArgs e)
        {
            using (Form_AddCustomer ae = new Form_AddCustomer())
            {
                ae.ShowDialog();
            }
        }

        private void UC_khtt_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = khachHang.loadKhachHang();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
