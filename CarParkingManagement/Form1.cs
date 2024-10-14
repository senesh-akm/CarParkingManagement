using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarParkingManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbl_system_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Hname_Click(object sender, EventArgs e)
        {

        }

        // going to login page
        private void btn_enter_Click(object sender, EventArgs e)
        {
            Frm_Login login = new Frm_Login();
            this.Hide();
            login.Show();
        }
    }
}
