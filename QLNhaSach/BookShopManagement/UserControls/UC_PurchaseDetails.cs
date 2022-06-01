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
    public partial class UC_PurchaseDetails : UserControl
    {
        DAO_Books books = new DAO_Books();
        public UC_PurchaseDetails()
        {
            InitializeComponent();
        }

        private void btnAddNewBooks_Click(object sender, EventArgs e)
        {
            using (Form_AddNewBook abn = new Form_AddNewBook())
            {
                abn.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Form_AddAuthor ads = new Form_AddAuthor())
            {
                ads.ShowDialog();
            }
        }

        private void UC_PurchaseDetails_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = books.loadSach();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Form_AddCategory ads = new Form_AddCategory())
            {
                ads.ShowDialog();
            }
        }
    }
}
