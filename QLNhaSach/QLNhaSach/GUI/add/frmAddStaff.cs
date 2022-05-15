using QLNhaSach.BLL;
using System;
using System.Windows.Forms;

namespace QLNhaSach.GUI.Adminitrator
{
    public partial class frmAddStaff : Form
    {
        DAO_STAFF STAFF = new DAO_STAFF();
        public frmAddStaff()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //STAFF.addStaff(txtSCode.Text, txtSName.Text, txtSSex.Text, int.Parse(txtID.Text), txtSAddress.Text, txtPosition.Text);
                MessageBox.Show("successfull");
            }
            catch (Exception)
            {

                MessageBox.Show("trùng khóa");
            }
        }
    }
}
