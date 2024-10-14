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
    public partial class Frm_Home : Form
    {
        // mysql database connection
        MySqlConnection myConn = new MySqlConnection("server=localhost; userid=root; password=; database=car_parking_management");

        private String type;
        public String Type
        {
            get { return type; }
            set { type = value; }
        }

        private String fname;
        public String Fname
        {
            get { return fname; }
            set { fname = value; }
        }

        private String lname;
        public String Lname
        {
            get { return lname; }
            set { lname = value; }
        }

        public Frm_Home()
        {
            InitializeComponent();
        }

        private void statusPark()
        {
            // Define your MySQL connection string.
            string connectionString = "server=localhost; userid=root; password=; database=car_parking_management";

            // Define your SQL query to retrieve the count of available data.
            string query = "SELECT COUNT(*) FROM parking_lot WHERE `status`='Parked'";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Execute the query and retrieve the count.
                    int availableCount = Convert.ToInt32(command.ExecuteScalar());

                    // Display the count in the lbl_count label.
                    lbl_parked.Text = availableCount.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void statusAvailable()
        {
            // Define your MySQL connection string.
            string connectionString = "server=localhost; userid=root; password=; database=car_parking_management";

            // Define your SQL query to retrieve the count of available data.
            string query = "SELECT COUNT(*) FROM parking_lot WHERE `status`='Available'";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Execute the query and retrieve the count.
                    int availableCount = Convert.ToInt32(command.ExecuteScalar());

                    // Display the count in the lbl_count label.
                    lbl_available.Text = availableCount.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void Frm_Home_Load(object sender, EventArgs e)
        {
            lbl_userFirstName.Text = Fname;
            lbl_userLastName.Text = Lname;

            btn_incomeReports.Enabled = false;

            statusPark();
            statusAvailable();
        }

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

        // going to vehicle registration
        private void btn_vehicle_Click(object sender, EventArgs e)
        {
            this.getTheName(btn_vehicle.Text);
            this.Hide();
            Frm_userVehicle vehicle = new Frm_userVehicle();
            vehicle.Type = type.Trim();
            vehicle.Fname = fname.Trim();
            vehicle.Lname = lname.Trim();
            vehicle.Show();
        }

        // going to checking
        private void btn_checking_Click(object sender, EventArgs e)
        {
            this.getTheName(btn_checking.Text);
            this.Hide();
            Frm_Checking checking = new Frm_Checking();
            checking.Type = type.Trim();
            checking.Fname = fname.Trim();
            checking.Lname = lname.Trim();
            checking.Show();
        }

        // going to income report
        private void btn_incomeReports_Click(object sender, EventArgs e)
        {
            this.getTheName(lbl_userFirstName.Text);
            this.Hide();
            Frm_IncomeReport checking = new Frm_IncomeReport();
            checking.Type = type.Trim();
            checking.Fname = fname.Trim();
            checking.Lname = lname.Trim();
            checking.Show();
        }

        // logout the system
        private void btn_back_Click(object sender, EventArgs e)
        {
            // click the exit button and display the message box
            if (MessageBox.Show("Do you want to logout this system?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Frm_Login login = new Frm_Login();
                login.Show();
                this.Hide();
            }
        }

        private void Frm_Home_Load_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
