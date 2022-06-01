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
        }
    }
}
