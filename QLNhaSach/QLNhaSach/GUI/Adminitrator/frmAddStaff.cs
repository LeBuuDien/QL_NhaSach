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
                STAFF.addStaff(txtSCode.Text, txtSName.Text, txtSSex.Text, int.Parse(txtID.Text), txtSAddress.Text, txtPosition.Text);
                MessageBox.Show("successfull");
            }
            catch (Exception)
            {

                MessageBox.Show("trùng khóa");
            }
        }
    }
}
