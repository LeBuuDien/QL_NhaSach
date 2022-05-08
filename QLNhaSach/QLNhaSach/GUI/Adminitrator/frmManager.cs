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
using QLNhaSach.GUI.Adminitrator;

namespace QLNhaSach.GUI
{
    public partial class frmCustomerManager : Form
    {
        Dao_Customer customer = new Dao_Customer();
        DAO_STAFF staff = new DAO_STAFF();

        public frmCustomerManager()
        {
            InitializeComponent();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Customer")
            {
                var frmAdd = new frmAddCustomer();
                frmAdd.Show();
            }
            else
            {
                var addStaff = new frmAddStaff();
                addStaff.Show();
            }    
        }

        private void frmCustomerManager_Load(object sender, EventArgs e)
        {
            string [] lst = { "Customer", "Staff" };
            comboBox1.DataSource = lst;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Contains("Staff"))
            {
                dataGridView1.DataSource = staff.loadStaff();
            }
            else
                dataGridView1.DataSource = customer.loadCustomer();
        }
    }
}
