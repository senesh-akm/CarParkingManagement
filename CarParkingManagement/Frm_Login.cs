using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CarParkingManagement
{
    public partial class Frm_Login : Form
    {
        // mysql database connection
        MySqlConnection myConn = new MySqlConnection("server=localhost; userid=root; password=; database=car_parking_management");

        public Frm_Login()
        {
            InitializeComponent();
        }

        private String type;
        private String fname;
        private String lname;

        private void getTheName(String username)
        {
            // mysql database connection
            MySqlConnection myConn = new MySqlConnection("server=localhost; userid=root; password=; database=car_parking_management");

            string querystring = "SELECT user_type AS c, first_name AS a, last_name AS b FROM users WHERE user_name=@username";

            try
            {
                myConn.Open();
                MySqlCommand mycomm = new MySqlCommand(querystring, myConn);
                mycomm.Parameters.AddWithValue("@username", username);
                mycomm.ExecuteScalar();
                MySqlDataReader rdr = mycomm.ExecuteReader();
                if (rdr.Read())
                {
                    type = rdr["c"].ToString();
                    fname = rdr["a"].ToString();
                    lname = rdr["b"].ToString();
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                myConn.Close();
            }
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }

        // going to user registration
        private void btn_user_Click(object sender, EventArgs e)
        {
            Frm_User user = new Frm_User();
            this.Hide();
            user.Show();
        }

        // application exit
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            // click the exit button and display the message box
            if (MessageBox.Show("Do you want to exit?", "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // login the user
        private void btn_logIn_Click(object sender, EventArgs e)
        {
            string userType = cb_userType.Text;
            string username = txt_userName.Text;
            string password = txt_passWord.Text;

            try
            {
                myConn.Open(); // database connection open

                // Selecting data for the login
                string query = "SELECT * FROM `users` WHERE `user_name`=@username AND `password`=@password";
                MySqlCommand myComm = new MySqlCommand(query, myConn);
                myComm.Parameters.AddWithValue("@username", username);
                myComm.Parameters.AddWithValue("@password", password);

                MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
                DataSet ds = new DataSet();
                myAdp.Fill(ds);

                int count = ds.Tables[0].Rows.Count;

                if (count == 1)
                {
                    string storedUserType = ds.Tables[0].Rows[0]["user_type"].ToString().Trim();

                    if (userType == "Administrator" && storedUserType == "Administrator")
                    {
                        // Redirect to admin panel
                        this.getTheName(txt_userName.Text);
                        this.Hide();
                        Frm_Admin adminPanelForm = new Frm_Admin();
                        adminPanelForm.Type = type.Trim();
                        adminPanelForm.Fname = fname.Trim();
                        adminPanelForm.Lname = lname.Trim();
                        adminPanelForm.Show();
                    }
                    else if (userType == "User" && storedUserType == "User")
                    {
                        // Redirect to user panel
                        this.getTheName(txt_userName.Text);
                        this.Hide();
                        Frm_Home userPanelForm = new Frm_Home();
                        userPanelForm.Type = type.Trim();
                        userPanelForm.Fname = fname.Trim();
                        userPanelForm.Lname = lname.Trim();
                        userPanelForm.Show();
                    }
                    else
                    {
                        // Invalid user type for the given username and password
                        lbl_Msg.ForeColor = Color.Red;
                        lbl_Msg.Text = "Invalid user type.";
                    }
                }


                myConn.Close(); // database connection close
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // click the check box show and hide password
        private void chb_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            // use the system password
            if (chb_showPassword.Checked)
            {
                // hide password
                txt_passWord.UseSystemPasswordChar = false;
            }
            else {
                // show password
                txt_passWord.UseSystemPasswordChar = true;
            }
        }
    }
}
