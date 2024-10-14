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
    public partial class Frm_userVehicle : Form
    {
        DataTable dbdataset2;

        Timer t = new Timer();

        public Frm_userVehicle()
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

        // auto generating number
        private void generateNumber()
        {
            // error handling, try catch exception
            try
            {
                String Max;
                // mysql database connection
                MySqlConnection myConn = new MySqlConnection("server=localhost; userid=root; password=; database=car_parking_management");

                // mysql database query
                string query = "SELECT MAX(id) FROM vehicle";

                // calling the mysql connection and data query
                MySqlCommand myComm = new MySqlCommand(query, myConn);

                myConn.Open(); // database connection open

                Max = myComm.ExecuteScalar().ToString();

                txt_vehicleID.Text = Max;
                int test = Convert.ToInt32(txt_vehicleID.Text);
                test = test + 1;

                txt_vehicleID.Text = "" + test;

                myConn.Close(); // database connection close
            }
            catch (Exception ex)
            {
                // error message box showing
                MessageBox.Show("Error in Genarating, may be it doesnot have atleaset one record" + ex);
            }
        }

        // load vehicle data to grid view
        private void load_data()
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
                dgv_vehicle.DataSource = bsource;
                myda.Update(dbdataset2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data" + ex); //Show error message
            }
        }

        private void Frm_userVehicle_Load(object sender, EventArgs e)
        {
            // date
            DateTime date = DateTime.UtcNow.Date;
            lbl_date.Text = Convert.ToString(date.ToString("yyyy-MM-dd"));

            //Timer interval
            t.Interval = 1000; //in millisecond

            //Run the Time
            t.Tick += new EventHandler(this.t_time_Tick);

            //Start timer when form loads
            t.Start(); //This will use timer_Tick() method

            generateNumber(); // auto generation number

            load_data(); // load vehicle data to grid view

            lbl_loggedUser.Text = Fname + " " + Lname;
        }

        // save the vehicle date
        private void btn_vehicleSave_Click(object sender, EventArgs e)
        {
            // Clear any previous error messages
            errorProvider1.Clear();

            // Validation: Check if the vehicle ID is not empty
            if (string.IsNullOrWhiteSpace(txt_vehicleID.Text))
            {
                errorProvider1.SetError(txt_vehicleID, "Vehicle ID is required.");
                txt_vehicleID.Focus();
                return; // Exit the method to prevent further execution
            }

            // Validation: Check if the vehicle number is not empty
            if (string.IsNullOrWhiteSpace(txt_vehicleNumber.Text))
            {
                errorProvider1.SetError(txt_vehicleNumber, "Vehicle number is required.");
                txt_vehicleNumber.Focus();
                return; // Exit the method to prevent further execution
            }

            // Validation: Check if a vehicle brand is selected
            if (string.IsNullOrWhiteSpace(cb_vehicleBrand.Text))
            {
                errorProvider1.SetError(cb_vehicleBrand, "Please select a vehicle brand.");
                cb_vehicleBrand.Focus();
                return; // Exit the method to prevent further execution
            }

            // Validation: Check if the vehicle name is not empty
            if (string.IsNullOrWhiteSpace(txt_vehicleName.Text))
            {
                errorProvider1.SetError(txt_vehicleName, "Vehicle name is required.");
                txt_vehicleName.Focus();
                return; // Exit the method to prevent further execution
            }

            // Validation: Check if the vehicle color is not empty
            if (string.IsNullOrWhiteSpace(txt_vehicleColor.Text))
            {
                errorProvider1.SetError(txt_vehicleColor, "Vehicle color is required.");
                txt_vehicleColor.Focus();
                return; // Exit the method to prevent further execution
            }

            // error handling, try catch exception
            try
            {
                // mysql database connection
                MySqlConnection myConn = new MySqlConnection("server=localhost; userid=root; password=; database=car_parking_management");

                // mysql database query
                string query = "INSERT INTO `vehicle`(`id`, `vehicle_number`, `vehicle_brand`, `vehicle_name`, `vehicle_color`, `date`, `time`, `logged_user`) VALUES ('" + txt_vehicleID.Text + "','" + txt_vehicleNumber.Text + "','" + cb_vehicleBrand.Text + "','" + txt_vehicleName.Text + "','" + txt_vehicleColor.Text + "','" + lbl_date.Text + "','" + lbl_time.Text + "', '" + lbl_loggedUser.Text + "')";

                // calling the mysql connection and data query
                MySqlCommand myComm = new MySqlCommand(query, myConn);

                myConn.Open(); // database connection open
                myComm.ExecuteNonQuery();
                myConn.Close(); // database connection close

                // message box showing
                MessageBox.Show("Registration Successfully", "SAVE", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // auto generating number
                generateNumber();

                // display adding data
                load_data();

                // reset filled textboxes
                txt_vehicleNumber.Text = "";
                cb_vehicleBrand.Text = "";
                txt_vehicleName.Text = "";
                txt_vehicleColor.Text = "";
            }
            catch (Exception ex)
            {
                // error message box showing
                MessageBox.Show("This vehicle is not registered..." + ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // running timer
        private void t_time_Tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            string time = "";

            if (hh < 10) //Hour
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";

            if (mm < 10) //Minutes
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";

            if (ss < 10) //Seconds
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }
            lbl_time.Text = time;
        }

        // going to home page
        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.getTheName(btn_Back.Text);
            this.Hide();
            Frm_Home userPanel = new Frm_Home();
            userPanel.Type = type.Trim();
            userPanel.Fname = fname.Trim();
            userPanel.Lname = lname.Trim();
            userPanel.Show();
        }

        // request the delete to administrator
        private void btn_requestDelete_Click(object sender, EventArgs e)
        {
            // error handling, try catch exception
            try
            {
                // mysql database connection
                MySqlConnection myConn = new MySqlConnection("server=localhost; userid=root; password=; database=car_parking_management");

                // mysql database query
                string query = "DELETE FROM `vehicle` WHERE `id`='" + txt_vehicleID.Text + "'";
                string queryRequest = "INSERT INTO `delete_vehicle`(`id`, `vehicle_number`, `vehicle_brand`, `vehicle_name`, `vehicle_color`, `date`, `time`, `logged_user`) VALUES ('" + txt_vehicleID.Text + "','" + txt_vehicleNumber.Text + "','" + cb_vehicleBrand.Text + "','" + txt_vehicleName.Text + "','" + txt_vehicleColor.Text + "','" + lbl_date.Text + "','" + lbl_time.Text + "', '" + lbl_loggedUser.Text + "')";

                // calling the mysql connection and data query
                MySqlCommand myComm = new MySqlCommand(queryRequest, myConn);
                MySqlCommand myCmd = new MySqlCommand(query, myConn);

                myConn.Open(); // database connection open
                myComm.ExecuteNonQuery();
                myCmd.ExecuteNonQuery();
                myConn.Close(); // database connection close

                // message box showing
                MessageBox.Show("Requested Delete", "REQUEST", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // auto generating number
                generateNumber();

                // display adding data
                load_data();

                // reset filled textboxes
                txt_vehicleNumber.Text = "";
                cb_vehicleBrand.Text = "";
                txt_vehicleName.Text = "";
                txt_vehicleColor.Text = "";
            }
            catch (Exception ex)
            {
                // error message box showing
                MessageBox.Show("This vehicle is not registered..." + ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Update Vehicle
        private void btn_vehicleUpdate_Click(object sender, EventArgs e)
        {
            // Clear any previous error messages
            errorProvider1.Clear();

            // Validation: Check if the vehicle number is not empty
            if (string.IsNullOrWhiteSpace(txt_vehicleID.Text))
            {
                errorProvider1.SetError(txt_vehicleID, "Vehicle ID is required.");
                txt_vehicleID.Focus();
                return; // Exit the method to prevent further execution
            }

            // Validation: Check if the vehicle number is not empty
            if (string.IsNullOrWhiteSpace(txt_vehicleNumber.Text))
            {
                errorProvider1.SetError(txt_vehicleNumber, "Vehicle number is required.");
                txt_vehicleNumber.Focus();
                return; // Exit the method to prevent further execution
            }

            // Validation: Check if a vehicle brand is selected
            if (string.IsNullOrWhiteSpace(cb_vehicleBrand.Text))
            {
                errorProvider1.SetError(cb_vehicleBrand, "Please select a vehicle brand.");
                cb_vehicleBrand.Focus();
                return; // Exit the method to prevent further execution
            }

            // Validation: Check if the vehicle name is not empty
            if (string.IsNullOrWhiteSpace(txt_vehicleName.Text))
            {
                errorProvider1.SetError(txt_vehicleName, "Vehicle name is required.");
                txt_vehicleName.Focus();
                return; // Exit the method to prevent further execution
            }

            // Validation: Check if the vehicle color is not empty
            if (string.IsNullOrWhiteSpace(txt_vehicleColor.Text))
            {
                errorProvider1.SetError(txt_vehicleColor, "Vehicle color is required.");
                txt_vehicleColor.Focus();
                return; // Exit the method to prevent further execution
            }

            // error handling, try catch exception
            try
            {
                // mysql database connection
                MySqlConnection myConn = new MySqlConnection("server=localhost; userid=root; password=; database=car_parking_management");

                // mysql database query
                string query = "UPDATE `vehicle` SET `id`='" + txt_vehicleID.Text + "',`vehicle_number`='" + txt_vehicleNumber.Text + "',`vehicle_brand`='" + cb_vehicleBrand.Text + "',`vehicle_name`='" + txt_vehicleName.Text + "',`vehicle_color`='" + txt_vehicleColor.Text + "',`date`='" + lbl_date.Text + "',`time`='" + lbl_time.Text + "',`logged_user`='" + lbl_loggedUser.Text + "' WHERE `id`='" + txt_vehicleID.Text + "'";

                // calling the mysql connection and data query
                MySqlCommand myComm = new MySqlCommand(query, myConn);

                myConn.Open(); // database connection open
                myComm.ExecuteNonQuery();
                myConn.Close(); // database connection close

                // message box showing
                MessageBox.Show("Vehicle Updated", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // auto generating number
                generateNumber();

                // display adding data
                load_data();

                // reset filled textboxes
                txt_vehicleNumber.Text = "";
                cb_vehicleBrand.Text = "";
                txt_vehicleName.Text = "";
                txt_vehicleColor.Text = "";
            }
            catch (Exception ex)
            {
                // error message box showing
                MessageBox.Show("Vehicle Not Updated..." + ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_searchVehicle_Click(object sender, EventArgs e)
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

                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "ERROR", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
        }

        // Add new vehicle
        private void btn_addNew_Click(object sender, EventArgs e)
        {
            generateNumber();

            txt_vehicleNumber.Clear();
            cb_vehicleBrand.ResetText();
            txt_vehicleName.Clear();
            txt_vehicleColor.Clear();
        }
    }
}
