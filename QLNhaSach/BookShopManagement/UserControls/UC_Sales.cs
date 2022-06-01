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
using BookShopManagement.DTO;


namespace BookShopManagement.UserControls
{
    public partial class UC_Sales : UserControl
    {
        double tongTien;
        DAO_Bill bill = new DAO_Bill();
        Dao_KhachHang khachHang;
        DAO_NhanVien nhanVien;
        DAO_Books books;
        public UC_Sales()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void UC_Sales_Load(object sender, EventArgs e)
        {
            nhanVien = new DAO_NhanVien();
            khachHang = new Dao_KhachHang();
            
            dataGridView1.DataSource = bill.LoadCTHD(lbMaHD.Text);
            cbbKH.DataSource =  khachHang.loadKhachHang();
            cbbKH.DisplayMember = "TenKH";
            cbbKH.ValueMember = "MaKH";

            cbbNV.DataSource = nhanVien.loadNhanVien();
            cbbNV.DisplayMember = "TenNV";
            cbbNV.ValueMember = "MaNV";

        }


        private void txtMaSach_TextChanged_1(object sender, EventArgs e)
        {
            books = new DAO_Books();
            if (books.check(txtMaSach.Text))
            {
                txtDonGia.Text= books.loadGiaSP(txtMaSach.Text);
            }else
            {
                
            }
        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {
            if (txtSL.Text == String.Empty)
            {

            }
            else
            {
            int sl = int.Parse(txtSL.Text);
            double dg = double.Parse(txtDonGia.Text);
            txtThanhTien.Text = (sl * dg).ToString();
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            HOADON hd = new HOADON();
            hd.MaHD = txtMaHD.Text;
            hd.ngayLap = dateTimePicker1.Value;
            hd.MaNV = cbbNV.SelectedValue.ToString();
            hd.MaKH = cbbKH.SelectedValue.ToString();
            hd.gia = 0;
            if (bill.addBill(hd) == true)
            {
                txtMaSach.Enabled = txtSL.Enabled = true;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CHITIETHOADON cthd = new CHITIETHOADON();
            cthd.MaHD = txtMaHD.Text;
            cthd.MaSach = txtMaSach.Text;
            cthd.SoLuong = int.Parse(txtSL.Text);
            cthd.DonGia = double.Parse(txtDonGia.Text);
            cthd.ThanhTien = double.Parse(txtThanhTien.Text);

            if (bill.addBillInformation(cthd))
            {
                dataGridView1.DataSource = bill.LoadCTHD(txtMaHD.Text);
                MessageBox.Show("SUCCESFULL");
                tongTien+= double.Parse(txtThanhTien.Text);
                lbTongTien.Text = tongTien.ToString();
            }
            else
                MessageBox.Show("TRY AGAIN");
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            txtMaHD.Text = "HD" + random.Next(1000);
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            using (Form_FinishOrder f = new Form_FinishOrder())
            {
                f.ShowDialog();
            }
                
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click_2(object sender, EventArgs e)
        {
            using(Form_FinishOrder f = new Form_FinishOrder(lbTongTien.Text,txtMaHD.Text)) {
                f.ShowDialog();
            }
        }
    }
}
