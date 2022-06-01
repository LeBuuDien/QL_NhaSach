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
using BookShopManagement.DTO;

namespace BookShopManagement.UserControls
{
    public partial class UC_ManageUser : UserControl
    {
        DAO_NhanVien nhanVien = new DAO_NhanVien();
        DAO_PhanQuyen phanQuyen = new DAO_PhanQuyen();
        DAO_ACCOUNT _ACCOUNT = new DAO_ACCOUNT();
        public UC_ManageUser()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            NHANVIEN a = new NHANVIEN();
            a.MaNV = txtMaNV.Text;
            a.SDT = txtPhone.Text;
            a.TenNV = txtTenNV.Text;
            a.Email = txtEmail.Text;
            a.address = txtDC.Text;
            a.username = txtUsername.Text;

            ACCOUNT TK = new ACCOUNT();
            TK.USERNAME = txtUsername.Text;
            TK.PASSWORD = txtPassword.Text;
            TK.MaPQ = int.Parse(cbbRole.SelectedValue.ToString());

            _ACCOUNT.addAccount(TK);
            nhanVien.addNhanVien(a);
            dataGridView1.DataSource = nhanVien.loadNhanVien();
        }

        private void UC_ManageUser_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = nhanVien.loadNhanVien();
            cbbRole.DataSource = phanQuyen.loadPQ();
            cbbRole.DisplayMember = "ChucVu";
            cbbRole.ValueMember = "MaPQ";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = txtTenNV.Text = txtPhone.Text = txtEmail.Text = txtDC.Text = txtPassword.Text = txtUsername.Text = String.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nhanVien.delNhanVien(txtMaNV.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTenNV.Text=dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtPhone.Text=dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text=dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtDC.Text=dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtUsername.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NHANVIEN a = new NHANVIEN();
            a.MaNV = txtMaNV.Text;
            a.SDT = txtPhone.Text;
            a.TenNV = txtTenNV.Text;
            a.Email = txtEmail.Text;
            a.address = txtDC.Text;
            a.username = txtUsername.Text;

            nhanVien.updateNhanVien(a);
        }
    }
}
