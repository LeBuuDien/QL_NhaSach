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
    public partial class Form_AddAuthor : Form
    {
        
        public Form_AddAuthor()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TACGIA tg = new TACGIA();
            tg.MaTacGia = textBox1.Text;
            tg.TenTacGia = textBox2.Text;
            Dao_TacGia tacGia = new Dao_TacGia();
            tacGia.addTG(tg);

        }
    }
}
