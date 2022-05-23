using System.Windows.Forms;
using QLNhaSach.BLL;
using QLNhaSach.GUI.Staff;
using QLNhaSach.GUI.Customer;

namespace QLNhaSach.GUI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            //frmCustomerManager frmCustomerManager = new frmCustomerManager();
            //frmCustomerManager.Show();
            //this.Hide();
            login lg = new login();
            if (lg.funtionLogin(txtUsename.Text, txtPassword.Text) == true)
            {
                string q = lg.phanQuyen(txtUsename.Text);
                if (q == "1")
                {
                    frmCustomerManager frmCustomerManager = new frmCustomerManager();
                    frmCustomerManager.Show();
                    this.Hide();
                }
                else
                if (q=="2")
                {
                    frmThanhToan frmThanhToan = new frmThanhToan();
                    frmThanhToan.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("");
                }
            }
        }
    }
}
