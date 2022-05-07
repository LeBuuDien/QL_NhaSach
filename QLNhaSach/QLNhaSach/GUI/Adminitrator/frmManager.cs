using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNhaSach.BLL;

namespace QLNhaSach.GUI
{
    public partial class frmCustomerManager : Form
    {
        Dao_Customer customer = new Dao_Customer();
        DAO_STAFF staff = new DAO_STAFF();
        public frmCustomerManager()
        {
            InitializeComponent();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = customer.loadCustomer();
        }
    }
}
