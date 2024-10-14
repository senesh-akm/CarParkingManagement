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
    public partial class Frm_User : Form
    {
        public Frm_User()
        {
            InitializeComponent();
        }

        // auto generating number
        private void generateNumber() {
            // error handling, try catch exception
            try
            {
                String Max;
                // mysql database connection
                MySqlConnection myConn = new MySqlConnection("server=localhost; userid=root; password=; database=car_parking_management");

                // mysql database query
                string query = "SELECT MAX(id) FROM users";

                // calling the mysql connection and data query
                MySqlCommand myComm = new MySqlCommand(query, myConn);

                myConn.Open(); // database connection open

                Max = myComm.ExecuteScalar().ToString();

                txt_userID.Text = Max;
                int test = Convert.ToInt32(txt_userID.Text);
                test = test + 1;

                txt_userID.Text = "" + test;

                myConn.Close(); // database connection close
            }
            catch (Exception ex) {
                // error message box showing
                MessageBox.Show("Error in Genarating, may be it doesnot have atleaset one record" + ex);
            }
        }

        private void Frm_User_Load(object sender, EventArgs e)
        {
            // auto generating number
            generateNumber();
        }

        private void cb_userType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // save the user
        private void btn_Save_Click(object sender, EventArgs e)
        {
            // Clear any previous error messages
            errorProvider1.Clear();

            // Validation: Check if the user ID is not empty
            if (string.IsNullOrWhiteSpace(txt_userID.Text))
            {
                errorProvider1.SetError(txt_userID, "User ID is required.");
                txt_userID.Focus();
                return; // Exit the method to prevent further execution
            }

            // Validation: Check if the first name is not empty
            if (string.IsNullOrWhiteSpace(txt_firstName.Text))
            {
                errorProvider1.SetError(txt_firstName, "First Name is required.");
                txt_firstName.Focus();
                return; // Exit the method to prevent further execution
            }

            // Validation: Check if the last name is not empty
            if (string.IsNullOrWhiteSpace(txt_lastName.Text))
            {
                errorProvider1.SetError(txt_lastName, "Last Name is required.");
                txt_lastName.Focus();
                return; // Exit the method to prevent further execution
            }

            // Validation: Check if the user type is not empty
            if (string.IsNullOrWhiteSpace(cb_userType.Text))
            {
                errorProvider1.SetError(cb_userType, "User type is required.");
                cb_userType.Focus();
                return; // Exit the method to prevent further execution
            }

            // Validation: Check if the username is not empty
            if (string.IsNullOrWhiteSpace(txt_userName.Text))
            {
                errorProvider1.SetError(txt_userName, "Username is required.");
                txt_userName.Focus();
                return; // Exit the method to prevent further execution
            }

            // Validation: Check if the username is not empty
            if (string.IsNullOrWhiteSpace(txt_passWord.Text))
            {
                errorProvider1.SetError(txt_passWord, "Password is required.");
                txt_passWord.Focus();
                return; // Exit the method to prevent further execution
            }

            // Validation: Check if the confirm password is not empty
            if (string.IsNullOrWhiteSpace(txt_confirmPassword.Text))
            {
                errorProvider1.SetError(txt_confirmPassword, "Confirm password is required.");
                txt_confirmPassword.Focus();
                return; // Exit the method to prevent further execution
            }

            // error handling, try catch exception
            try 
            {
                // mysql database connection
                MySqlConnection myConn = new MySqlConnection("server=localhost; userid=root; password=; database=car_parking_management");

                // mysql database query
                string query = "INSERT INTO `users`(`id`, `first_name`, `last_name`, `user_type`, `user_name`, `password`, `confirm_password`) VALUES ('" + txt_userID.Text + "','" + txt_firstName.Text + "','" + txt_lastName.Text + "','" + cb_userType.Text + "','" + txt_userName.Text + "','" + txt_passWord.Text + "','" + txt_confirmPassword.Text + "')";

                // calling the mysql connection and data query
                MySqlCommand myComm = new MySqlCommand(query, myConn);

                myConn.Open(); // database connection open
                myComm.ExecuteNonQuery();
                myConn.Close(); // database connection close

                // message box showing
                MessageBox.Show("Registration Successfully", "SAVE", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // auto generating number
                generateNumber();

                // hiding text
                txt_firstName.Text = "";
                txt_lastName.Text = "";
                cb_userType.Text = "";
                txt_userName.Text = "";
                txt_passWord.Text = "";
                txt_confirmPassword.Text = "";
            }
            catch(Exception ex){
                // error message box showing
                MessageBox.Show("This user is not registered..." + ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // update the user
        private void btn_Update_Click(object sender, EventArgs e)
        {
            // error handling, try catch exception
            try
            {
                // mysql database connection
                MySqlConnection myConn = new MySqlConnection("server=localhost; userid=root; password=; database=car_parking_management");

                // mysql database query
                string query = "UPDATE `users` SET `id`='" + txt_userID.Text + "',`first_name`='" + txt_firstName.Text + "',`last_name`='" + txt_lastName.Text + "',`user_type`='" + cb_userType.Text + "',`user_name`='" + txt_userName.Text + "',`password`='" + txt_passWord.Text + "',`confirm_password`='" + txt_confirmPassword.Text + "' WHERE `id`='" + txt_userID.Text + "'";

                // calling the mysql connection and data query
                MySqlCommand myComm = new MySqlCommand(query, myConn);

                myConn.Open(); // database connection open
                myComm.ExecuteNonQuery();
                myConn.Close(); // database connection close

                // message box showing
                MessageBox.Show("Update Successfully", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // auto generating number
                generateNumber();

                // hiding text
                txt_firstName.Text = "";
                txt_lastName.Text = "";
                cb_userType.Text = "";
                txt_userName.Text = "";
                txt_passWord.Text = "";
                txt_confirmPassword.Text = "";
            }
            catch (Exception ex)
            {
                // error message box showing
                MessageBox.Show("This user is not update..." + ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // going to login page
        private void btn_Back_Click(object sender, EventArgs e)
        {
            Frm_Login login = new Frm_Login();
            this.Hide();
            login.Show();
        }

        // select the user
        private void btn_Search_Click(object sender, EventArgs e)
        {
            // error handling, try catch exception
            try
            {
                // mysql database connection
                MySqlConnection myConn = new MySqlConnection("server=localhost; userid=root; password=; database=car_parking_management");

                // mysql database query
                string query = "SELECT * FROM `users` WHERE `id`='" + txt_userID.Text + "'";

                // calling the mysql connection and data query
                MySqlCommand myComm = new MySqlCommand(query, myConn);

                myConn.Open();

                MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
                DataTable dt = new DataTable();
                myAdp.Fill(dt);

                txt_firstName.Text = dt.Rows[0][1].ToString();
                txt_lastName.Text = dt.Rows[0][2].ToString();
                cb_userType.Text = dt.Rows[0][3].ToString();
                txt_userName.Text = dt.Rows[0][4].ToString();
                txt_passWord.Text = dt.Rows[0][5].ToString();
                txt_confirmPassword.Text = dt.Rows[0][6].ToString();

                myConn.Close();

                // message box showing
                MessageBox.Show("Record selected", "SELECT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) {
                // error message box showing
                MessageBox.Show("No Record" + ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
