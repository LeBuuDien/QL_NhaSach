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
    public partial class Form_AddNewBook : Form
    {
        DAO_Books books;
        Dao_TacGia tacGia;
        Dao_TheLoai theLoai;
        public Form_AddNewBook()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Form_AddCategory ac = new Form_AddCategory())
            {
                ac.ShowDialog();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            books = new DAO_Books();
            Sach s = new Sach();
            s.MaSach = txtMaSach.Text;
            s.TenSach = txtTenSach.Text;
            s.MaTheLoai = cbbTheLoai.SelectedValue.ToString();
            s.TacGia = cbbTacGia.SelectedValue.ToString();
            s.NXB = txtNXB.Text;
            s.gia = double.Parse(txtGiaBan.Text);

            if (books.addSach(s))
            {
                MessageBox.Show("Thêm Thành công");
            }
            else
                MessageBox.Show("xin thử lại");
        }

        private void Form_AddNewBook_Load(object sender, EventArgs e)
        {
            theLoai = new Dao_TheLoai();
            tacGia = new Dao_TacGia();
            cbbTacGia.DataSource = tacGia.loadTG();
            cbbTacGia.DisplayMember = "TenTacGia";
            cbbTacGia.ValueMember = "MaTacGia";


            cbbTheLoai.DataSource = theLoai.loadTL();
            cbbTheLoai.DisplayMember = "TenTheLoai";
            cbbTheLoai.ValueMember = "MaTheLoai";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtMaSach.Text = txtTenSach.Text = txtGiaBan.Text = txtNXB.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            txtMaSach.Text = "B0" + random.Next(1000);

        }
    }
}
