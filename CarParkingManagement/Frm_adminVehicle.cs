using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing.Printing;

namespace CarParkingManagement
{
    public partial class Frm_adminVehicle : Form
    {
        private MySqlConnection myConn;
        private DataTable dataTable1;
        private DataTable dataTable2;

        DataTable dbdataset2;

        Bitmap bitmap;

        Timer t = new Timer();

        public Frm_adminVehicle()
        {
            InitializeComponent();
            
        }

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

        // load requested delete data
        private void delete_request()
        {
            try
            {
                // Retrieve data from the second table
                string query = "SELECT * FROM delete_vehicle";
                MySqlCommand myComm = new MySqlCommand(query, myConn);
                MySqlDataAdapter adapter2 = new MySqlDataAdapter(myComm);

                // Fill the DataTable with the data from the second table
                adapter2.Fill(dataTable2);

                // Set the second DataGridView's DataSource to the second DataTable
                dgv_requestedData.DataSource = dataTable2;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data from table2: " + ex.Message);
            }
        }

        // Requested Data for Delete
        private void vehicle_data()
        {
            // mysql database connection
            MySqlConnection myConn = new MySqlConnection("server=localhost; userid=root; password=; database=car_parking_management");

            // mysql database query
            MySqlCommand myComm = new MySqlCommand("SELECT * FROM vehicle", myConn);

            // error handling, try catch exception
            try
            {
                MySqlDataAdapter myda = new MySqlDataAdapter();
                myda.SelectCommand = myComm;

                dbdataset2 = new DataTable();
                myda.Fill(dbdataset2);

                BindingSource bsource = new BindingSource();

                bsource.DataSource = dbdataset2;
                dgv_loadAdminVehicle.DataSource = bsource;
                myda.Update(dbdataset2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data" + ex); //Show error message
            }
        }

        // Load users to combo box
        private void LoadUserNames()
        {
            try
            {
                // Create a connection to the MySQL database
                using (MySqlConnection connection = new MySqlConnection("server=localhost; userid=root; password=; database=car_parking_management"))
                {
                    connection.Open();

                    // SQL query to select the 'name' column from the 'users' table
                    string query = "SELECT first_name, last_name FROM users";

                    // Create a command
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            // Clear any existing items in the ComboBox
                            cb_addedUsers.Items.Clear();

                            while (reader.Read())
                            {
                                // Add each user name to the ComboBox
                                string firstName = reader["first_name"].ToString();
                                string lastName = reader["last_name"].ToString();
                                string fullName = firstName + " " + lastName;
                                cb_addedUsers.Items.Add(fullName);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_adminVehicle_Load(object sender, EventArgs e)
        {
            // Set up MySQL connection
            string connectionString = "server=localhost;userid=root;password=;database=car_parking_management";
            MySqlConnection myConn = new MySqlConnection(connectionString);

            // date
            DateTime date = DateTime.UtcNow.Date;
            lbl_date.Text = Convert.ToString(date.ToString("yyyy-MM-dd"));

            //Timer interval
            t.Interval = 1000; //in millisecond

            //Run the Time
            t.Tick += new EventHandler(this.t_time_Tick);

            //Start timer when form loads
            t.Start(); //This will use timer_Tick() method

            vehicle_data();
            delete_request();

            LoadUserNames(); // load users to combo box

            lbl_loggedAdmin.Text = Fname + " " + Lname;
        }

        // running timer
        private void t_time_Tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            string time = "";

            if (hh < 10) // Hour
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";

            if (mm < 10) // Minutes
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";

            if (ss < 10) // Seconds
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }
            lbl_time.Text = time;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.getTheName(btn_Back.Text);
            this.Hide();
            Frm_Admin admin = new Frm_Admin();
            admin.Type = type.Trim();
            admin.Fname = fname.Trim();
            admin.Lname = lname.Trim();
            admin.Show();
        }

        private void btn_adminSearch_Click(object sender, EventArgs e)
        {
            // error handling, try catch exception
            try
            {
                // mysql database connection
                MySqlConnection myConn = new MySqlConnection("server=localhost; userid=root; password=; database=car_parking_management");

                string query = "SELECT * FROM `vehicle` WHERE `id`='" + txt_vehicleID.Text + "'";
                MySqlCommand myComm = new MySqlCommand(query, myConn);

                myConn.Open();

                MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
                DataTable myTb = new DataTable();
                myAdp.Fill(myTb);

                txt_vehicleNumber.Text = myTb.Rows[0][1].ToString();
                cb_vehicleBrand.Text = myTb.Rows[0][2].ToString();
                txt_vehicleName.Text = myTb.Rows[0][3].ToString();
                txt_vehicleColor.Text = myTb.Rows[0][4].ToString();
                lbl_loggedUser.Text = myTb.Rows[0][5].ToString();

                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "ERROR", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
        }

        private void btn_gridSearchVehicle_Click(object sender, EventArgs e)
        {
            string valueToBrand = cb_searchBrand.Text.ToString();
            searchVehicle(valueToBrand);

            string valueToDate = txt_date.Text.ToString();
            searchDate(valueToDate);

            string valueToUser = cb_addedUsers.Text.ToString();
            searchUser(valueToUser);
        }

        public void searchVehicle(string valueToBrand)
        {
            // mysql database connection
            MySqlConnection myConn = new MySqlConnection("server=localhost; userid=root; password=; database=car_parking_management");

            string query = "SELECT * FROM `vehicle` WHERE CONCAT(`vehicle_brand`) like '%" + valueToBrand + "%'";
            MySqlCommand myComm = new MySqlCommand(query, myConn);
            MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
            DataTable dt = new DataTable();
            myAdp.Fill(dt);
            dgv_loadAdminVehicle.DataSource = dt;
        }

        public void searchDate(string valueToDate)
        {
            // mysql database connection
            MySqlConnection myConn = new MySqlConnection("server=localhost; userid=root; password=; database=car_parking_management");

            string query = "SELECT * FROM `vehicle` WHERE CONCAT(`date`) like '%" + valueToDate + "%'";
            MySqlCommand myComm = new MySqlCommand(query, myConn);
            MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
            DataTable dt = new DataTable();
            myAdp.Fill(dt);
            dgv_loadAdminVehicle.DataSource = dt;
        }

        public void searchUser(string valueToUser)
        {
            // mysql database connection
            MySqlConnection myConn = new MySqlConnection("server=localhost; userid=root; password=; database=car_parking_management");

            string query = "SELECT * FROM `vehicle` WHERE CONCAT(`logged_user`) like '%" + valueToUser + "%'";
            MySqlCommand myComm = new MySqlCommand(query, myConn);
            MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
            DataTable dt = new DataTable();
            myAdp.Fill(dt);
            dgv_loadAdminVehicle.DataSource = dt;
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(printDriverRecord_PrintPage);

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        // Search vehicle
        private void btn_adminSearch_Click_1(object sender, EventArgs e)
        {
            // error handling, try catch exception
            try
            {
                // mysql database connection
                MySqlConnection myConn = new MySqlConnection("server=localhost; userid=root; password=; database=car_parking_management");

                string query = "SELECT * FROM `vehicle` WHERE `id`='" + txt_vehicleID.Text + "'";
                MySqlCommand myComm = new MySqlCommand(query, myConn);

                myConn.Open();

                MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
                DataTable myTb = new DataTable();
                myAdp.Fill(myTb);

                txt_vehicleNumber.Text = myTb.Rows[0][1].ToString();
                cb_vehicleBrand.Text = myTb.Rows[0][2].ToString();
                txt_vehicleName.Text = myTb.Rows[0][3].ToString();
                txt_vehicleColor.Text = myTb.Rows[0][4].ToString();
                lbl_loggedUser.Text = myTb.Rows[0][7].ToString();

                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "ERROR", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
        }
    }
}
