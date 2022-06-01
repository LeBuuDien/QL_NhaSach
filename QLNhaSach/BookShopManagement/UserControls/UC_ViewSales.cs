using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookShopManagement.BLL;

namespace BookShopManagement.UserControls
{
    public partial class UC_ViewSales : UserControl
    {

        DAO_Bill bill = new DAO_Bill();

        public UC_ViewSales()
        {
            InitializeComponent();
        }

        private void UC_ViewSales_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bill.LoadHoaDon();
            lbDoanhThu.Text = TinhTien();
        }
        public string TinhTien()
        {
            int sc = dataGridView1.Rows.Count;
            float thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
                thanhtien += float.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
            return thanhtien.ToString();
        }
    }
}
