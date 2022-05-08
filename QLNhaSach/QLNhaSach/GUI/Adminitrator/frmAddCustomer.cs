﻿using System;
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
    public partial class frmAddCustomer : Form
    {
        Dao_Customer customer = new Dao_Customer();
        public frmAddCustomer()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                customer.addCustomer(txtCCode.Text,txtCName.Text,textBox3.Text,int.Parse(txtCPN.Text),txtCEmail.Text,txtCAddress.Text);
                MessageBox.Show("succesfull");
            }
            catch (Exception)
            {
                MessageBox.Show("Trùng khóa chính bro :V", "error");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
