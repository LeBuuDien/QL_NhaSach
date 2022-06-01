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
    public partial class Form_AddCategory : Form
    {
        public Form_AddCategory()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            THELOAI tl = new THELOAI();
            tl.MaTheLoai = txtMaTL.Text;
            tl.TenTheLoai = txtTenTheLoai.Text;
            Dao_TheLoai theLoai = new Dao_TheLoai();
            theLoai.addTL(tl);
        }
    }
}
