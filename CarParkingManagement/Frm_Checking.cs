using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using MySql.Data.MySqlClient;

namespace CarParkingManagement
{
    public partial class Frm_Checking : Form
    {
        private MySqlConnection myConn;
        private DataTable dataTable1;
        private DataTable dataTable2;

        Bitmap bitmap;

        Timer t = new Timer();

        public Frm_Checking()
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
                string query = "SELECT MAX(id) FROM checking";

                // calling the mysql connection and data query
                MySqlCommand myComm = new MySqlCommand(query, myConn);

                myConn.Open(); // database connection open

                Max = myComm.ExecuteScalar().ToString();

                txt_checkingID.Text = Max;
                int test = Convert.ToInt32(txt_checkingID.Text);
                test = test + 1;

                txt_checkingID.Text = "" + test;

                myConn.Close(); // database connection close
            }
            catch (Exception ex)
            {
                // error message box showing
                MessageBox.Show("Error in Genarating, may be it doesnot have atleaset one record" + ex);
            }
        }

        // load checking data
        private void checkIn_data()
        {
            try
            {
                // Retrieve data from the first table
                string query = "SELECT * FROM checking";
                MySqlCommand myComm = new MySqlCommand(query, myConn);
                MySqlDataAdapter adapter1 = new MySqlDataAdapter(myComm);

                // Fill the DataTable with the data from the first table
                adapter1.Fill(dataTable1);

                // Set the first DataGridView's DataSource to the first DataTable
                dgv_checkingUpdates.DataSource = dataTable1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data from table1: " + ex.Message);
            }
        }

        // load parking lot data
        private void parking_data()
        {
            try
            {
                // Retrieve data from the second table
                string query = "SELECT * FROM parking_lot";
                MySqlCommand myComm = new MySqlCommand(query, myConn);
                MySqlDataAdapter adapter2 = new MySqlDataAdapter(myComm);

                // Fill the DataTable with the data from the second table
                adapter2.Fill(dataTable2);

                // Set the second DataGridView's DataSource to the second DataTable
                dgv_parkingLot.DataSource = dataTable2;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data from table2: " + ex.Message);
            }
        }

        private void Frm_Checking_Load(object sender, EventArgs e)
        {
            // Set up MySQL connection
            string connectionString = "server=localhost;userid=root;password=;database=car_parking_management";
            myConn = new MySqlConnection(connectionString);

            // Initialize DataTables
            dataTable1 = new DataTable();
            dataTable2 = new DataTable();

            // Load data into DataGridViews
            checkIn_data();
            parking_data();
            generateNumber();

            // date
            DateTime date = DateTime.UtcNow.Date;
            lbl_date.Text = Convert.ToString(date.ToString("yyyy-MM-dd"));

            //Timer interval
            t.Interval = 1000; //in millisecond

            //Run the Time
            t.Tick += new EventHandler(this.t_time_Tick);

            //Start timer when form loads
            t.Start(); //This will use timer_Tick() method

            // checking status is auto selected first one
            cb_checkStatus.SelectedIndex = 0;
            cb_customerType.SelectedIndex = 0;

            lbl_loggedUser.Text = Fname + " " + Lname;
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

        // save the checking data
        private void btn_CheckIn_Click(object sender, EventArgs e)
        {
            cb_availableStatus.SelectedIndex = 1;

            // Clear any previous error messages
            errorProvider1.Clear();

            // Validation: Check if the vehicle number is not empty
            if (string.IsNullOrWhiteSpace(txt_checkingID.Text))
            {
                errorProvider1.SetError(txt_checkingID, "Vehicle number is required.");
                txt_checkingID.Focus();
                return; // Exit the method to prevent further execution
            }

            // Validation: Check if the vehicle number is not empty
            if (string.IsNullOrWhiteSpace(txt_vehicleNumber.Text))
            {
                errorProvider1.SetError(txt_vehicleNumber, "Vehicle number is required.");
                txt_vehicleNumber.Focus();
                return; // Exit the method to prevent further execution
            }

            // Validation: Check if a customer type is selected
            if (string.IsNullOrWhiteSpace(cb_customerType.Text))
            {
                errorProvider1.SetError(cb_customerType, "Please select a customer type.");
                cb_customerType.Focus();
                return; // Exit the method to prevent further execution
            }

            // Validation: Check if a checking status is selected
            if (string.IsNullOrWhiteSpace(cb_checkStatus.Text))
            {
                errorProvider1.SetError(cb_checkStatus, "Please select a checking status.");
                cb_checkStatus.Focus();
                return; // Exit the method to prevent further execution
            }

            // error handling, try catch exception
            try
            {
                if (lbl_issuedSlip.Text == "Issued")
                {
                    // mysql database connection
                    MySqlConnection myConn = new MySqlConnection("server=localhost; userid=root; password=; database=car_parking_management");

                    // mysql database query
                    string query = "INSERT INTO `checking`(`id`, `vehicle_number`, `customer_type`, `checking_status`, `lot_number`, `floor_number`, `print_slip`, `check_in_date`, `check_in_time`, `check_out_date`, `check_out_time`, `days`, `day_duration`, `time_duration`, `total_duration`, `payment`, `cash`, `balance`, `print_bill`, `print_report`, `c_date`, `c_time`, `logged_user`, `logged_user_In`) VALUES ('" + txt_checkingID.Text + "','" + txt_vehicleNumber.Text + "','" + cb_customerType.Text + "','" + cb_checkStatus.Text + "','" + lbl_lotNumber.Text + "','" + lbl_floorNumber.Text + "','" + lbl_issuedSlip.Text + "','" + txt_checkInDate.Text + "','" + txt_checkInTime.Text + "','" + txt_checkOutDate.Text + "','" + txt_checkOutTime.Text + "','" + txt_days.Text + "','" + txt_dayDuration.Text + "','" + txt_timeDuration.Text + "','" + txt_totalDuration.Text + "','" + txt_payment.Text + "','" + txt_cash.Text + "','" + txt_balance.Text + "','" + lbl_issuedBill.Text + "','" + lbl_issuedReport.Text + "','" + lbl_date.Text + "','" + lbl_time.Text + "','" + lbl_loggedUser.Text + "','" + lbl_loggedUserCheckIn.Text + "')";
                    string queryStr = "INSERT INTO `check_in`(`id`, `vehicle_number`, `customer_type`, `lot_no`, `floor_no`, `print_slip`, `c_date`, `c_time`, `logged_user`) VALUES ('" + txt_checkingID.Text + "','" + txt_vehicleNumber.Text + "','" + cb_customerType.Text + "','" + lbl_lotNumber.Text + "','" + lbl_floorNumber.Text + "','" + lbl_issuedSlip.Text + "','" + lbl_date.Text + "','" + lbl_time.Text + "','" + lbl_loggedUser.Text + "')";
                    string queryString = "UPDATE `parking_lot` SET `lot_no`='" + lbl_lotNumber.Text + "',`floor_no`='" + lbl_floorNumber.Text + "',`status`='" + cb_availableStatus.Text + "' WHERE `lot_no`='" + lbl_lotNumber.Text + "'";

                    // calling the mysql connection and data query
                    MySqlCommand myComm = new MySqlCommand(query, myConn);
                    MySqlCommand myCmd = new MySqlCommand(queryStr, myConn);
                    MySqlCommand Cmd = new MySqlCommand(queryString, myConn);

                    myConn.Open(); // database connection open
                    myComm.ExecuteNonQuery();
                    myCmd.ExecuteNonQuery();
                    Cmd.ExecuteNonQuery();
                    myConn.Close(); // database connection close

                    // message box showing
                    MessageBox.Show("Registration Successfully", "SAVE", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // auto generating number
                    generateNumber();

                    // display adding data
                    checkIn_data();
                    parking_data();

                    // reset filled textboxes
                    txt_vehicleNumber.Text = "";
                    cb_customerType.Text = "";
                    cb_checkStatus.Text = "";
                    lbl_lotNumber.Text = "";
                    lbl_floorNumber.Text = "";
                    cb_availableStatus.Text = "";
                }
                else
                {
                    MessageBox.Show("Slip is not issued", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting data: " + ex.Message);
            }
            finally
            {
                
            }
        }

        // select the checking data
        private void btn_SearchCheckIn_Click(object sender, EventArgs e)
        {
            // error handling, try catch exception
            try
            {
                string query = "SELECT * FROM `checking` WHERE `id`='" + txt_checkingID.Text + "'";
                MySqlCommand myComm = new MySqlCommand(query, myConn);

                myConn.Open();

                MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
                DataTable myTb = new DataTable();
                myAdp.Fill(myTb);

                txt_vehicleNumber.Text = myTb.Rows[0][1].ToString();
                cb_customerType.Text = myTb.Rows[0][2].ToString();
                cb_checkStatus.Text = myTb.Rows[0][3].ToString();
                lbl_lotNumber.Text = myTb.Rows[0][4].ToString();
                lbl_floorNumber.Text = myTb.Rows[0][5].ToString();
                lbl_issuedSlip.Text = myTb.Rows[0][6].ToString();
                txt_checkInDate.Text = myTb.Rows[0][20].ToString();
                txt_checkInTime.Text = myTb.Rows[0][21].ToString();
                txt_checkOutDate.Text = myTb.Rows[0][9].ToString();
                txt_checkOutTime.Text = myTb.Rows[0][10].ToString();
                txt_days.Text = myTb.Rows[0][11].ToString();
                txt_dayDuration.Text = myTb.Rows[0][12].ToString();
                txt_timeDuration.Text = myTb.Rows[0][13].ToString();
                txt_totalDuration.Text = myTb.Rows[0][14].ToString();
                txt_payment.Text = myTb.Rows[0][15].ToString();
                txt_cash.Text = myTb.Rows[0][16].ToString();
                txt_balance.Text = myTb.Rows[0][17].ToString();
                lbl_issuedBill.Text = myTb.Rows[0][18].ToString();
                lbl_issuedReport.Text = myTb.Rows[0][19].ToString();
                lbl_loggedUserCheckIn.Text = myTb.Rows[0][22].ToString();

                myConn.Close();
            }
            catch (Exception ex) {
                MessageBox.Show("Error" + ex.Message, "ERROR", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
        }

        // select parking lot and display text box
        private void dgv_parkingLot_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgv_parkingLot.Rows.Count - 1)
            {
                DataGridViewRow row = dgv_parkingLot.Rows[e.RowIndex];
                string lotNumber = row.Cells["lot_no"].Value.ToString();

                // error handling, try catch exception
                try
                {
                    // mysql database query
                    string query = "SELECT * FROM parking_lot WHERE lot_no = @lotNumber";
                    MySqlCommand myComm = new MySqlCommand(query, myConn); // calling the mysql connection and data query

                    myComm.Parameters.AddWithValue("@lotNumber", lotNumber);
                    MySqlDataReader reader;

                    myConn.Open(); // database connection open
                    reader = myComm.ExecuteReader();

                    if (reader.Read())
                    {
                        lbl_lotNumber.Text = reader["lot_no"].ToString();
                        lbl_floorNumber.Text = reader["floor_no"].ToString();
                        cb_availableStatus.Text = reader["status"].ToString();
                    }

                    reader.Close();

                    myConn.Close(); // database connection close
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    
                }
            }
        }

        // hide and show 'if check-out' group box
        private void cb_checkStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_checkStatus.SelectedIndex == 0)
            {
                // select check-in and disabled 'if check-out' group box
                gb_checkOut.Enabled = false;
                lbl_issuedBill.Enabled = false;
                lbl_issuedReport.Enabled = false;
                btn_printBill.Enabled = false;
                btn_printReport.Enabled = false;
                label25.Enabled = false;
                lbl_loggedUserCheckIn.Enabled = false;
            }
            else {
                // select check-in and enabled 'if check-out' group box
                gb_checkOut.Enabled = true;
                lbl_issuedBill.Enabled = true;
                lbl_issuedReport.Enabled = true;
                btn_printBill.Enabled = true;
                btn_printReport.Enabled = true;
                label25.Enabled = true;
                lbl_loggedUserCheckIn.Enabled = true;
            }
        }

        // print slip content
        private void printSlip_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            printSlip.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("CashR", 450, 450);

            SolidBrush Brush = new SolidBrush(Color.Black);
            float currentY = 40;
            e.Graphics.DrawString("Hotel the View Mirissa", new Font("Arial", 16, FontStyle.Bold), Brushes.Gray, 110, currentY);
            e.Graphics.DrawString("Parking & Services", new Font("Arial", 11, FontStyle.Bold), Brushes.Gray, 160, currentY + 30);

            e.Graphics.DrawString("Check-In", new Font("Arial", 12, FontStyle.Bold), Brushes.Gray, 185, currentY + 75);

            e.Graphics.DrawString("Invoice Number      : 000" + txt_checkingID.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, 35, currentY + 110);

            e.Graphics.DrawString("Address : Beach Access Road Koparamulla, Mirissa 81740", new Font("Arial", 9), Brushes.Black, 35, currentY + 140);
            e.Graphics.DrawString("Phone    : (+94)716002429", new Font("Arial", 9), Brushes.Black, 35, currentY + 160);
            e.Graphics.DrawString("Email     : info@theviewmirissa.lk", new Font("Arial", 9), Brushes.Black, 35, currentY + 180);
            e.Graphics.DrawString("Date       : " + lbl_date.Text, new Font("Arial", 9), Brushes.Black, 35, currentY + 200);
            e.Graphics.DrawString("Time      : " + lbl_time.Text, new Font("Arial", 9), Brushes.Black, 35, currentY + 220);

            e.Graphics.DrawString("******************************************************", new Font("Arial", 14), Brushes.Black, 20, currentY + 250);

            e.Graphics.DrawString("Vehicle Number        : " + txt_vehicleNumber.Text, new Font("Arial", 10), Brushes.Black, 35, currentY + 270);
            e.Graphics.DrawString("Parking Lot Number  : " + lbl_lotNumber.Text, new Font("Arial", 10), Brushes.Black, 35, currentY + 290);
            e.Graphics.DrawString("Parking Floor           : " + lbl_floorNumber.Text, new Font("Arial", 10), Brushes.Black, 35, currentY + 310);

            e.Graphics.DrawString("********************** Thank You ! Come Again **********************", new Font("Arial", 10), Brushes.Black, 22, currentY + 340);

            e.Graphics.DrawString("******************************************************", new Font("Arial", 14), Brushes.Black, 20, currentY + 370);
        }

        // click to slip printing
        private void btn_printSlip_Click(object sender, EventArgs e)
        {
            if (cb_checkStatus.SelectedIndex == 0)
            {
                Panel panel = new Panel();
                this.Controls.Add(panel);
                Graphics grp = panel.CreateGraphics();
                Size formSize = this.ClientSize;
                bitmap = new Bitmap(formSize.Width, formSize.Height, grp);
                grp = Graphics.FromImage(bitmap);
                Point panelLocation = PointToScreen(panel.Location);
                grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);
                printPreviewSlip.Document = printSlip;
                printPreviewSlip.PrintPreviewControl.Zoom = 1;
                printPreviewSlip.ShowDialog();

                lbl_issuedSlip.ForeColor = Color.Green;
                lbl_issuedSlip.Text = "Issued";
            }
            else {
                MessageBox.Show("Check-Out has not support. But Check-In has support from this event", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // press enter key and select data according to the ID
        private void txt_checkingID_KeyDown(object sender, KeyEventArgs e)
        {
            // enter keydown
            if (e.KeyCode == Keys.Enter)
            {
                // error handling, try catch exception
                try
                {
                    // mysql database query
                    string query = "SELECT * FROM `vehicle` WHERE `id`='" + txt_checkingID.Text + "'";

                    MySqlCommand myComm = new MySqlCommand(query, myConn);

                    myConn.Open(); // database connection open

                    MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
                    DataTable myTb = new DataTable();
                    myAdp.Fill(myTb);

                    txt_vehicleNumber.Text = myTb.Rows[0][1].ToString();

                    myConn.Close(); // database connection close
                }
                catch (Exception ex)
                {
                    MessageBox.Show("This Number is Not According to the Vehicle" + ex.ToString(), "ERROR", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                }
            }
        }

        // print bill content
        private void printBill_PrintPage(object sender, PrintPageEventArgs e)
        {
            printBill.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("CashR", 450, 650);

            SolidBrush Brush = new SolidBrush(Color.Black);
            float currentY = 40; // declare one variable for height measurement
            e.Graphics.DrawString("Hotel the View Mirissa", new Font("Arial", 18, FontStyle.Bold), Brushes.Gray, 90, currentY); //this will print one heading/title in every page of the document
            e.Graphics.DrawString("Parking & Services", new Font("Arial", 12, FontStyle.Bold), Brushes.Gray, 150, currentY + 40); //this will print one heading/title in every page of the document

            e.Graphics.DrawString("Invoice", new Font("Arial", 14, FontStyle.Bold), Brushes.Gray, 185, currentY + 70); //this will print one heading/title in every page of the document

            e.Graphics.DrawString("Invoice Number      : 000" + txt_checkingID.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, 35, currentY + 110); //this will print one heading/title in every page of the document

            e.Graphics.DrawString("Address : Beach Access Road Koparamulla, Mirissa 81740", new Font("Arial", 9), Brushes.Black, 35, currentY + 140); //this will print one heading/title in every page of the document
            e.Graphics.DrawString("Phone    : (+94)716002429", new Font("Arial", 9), Brushes.Black, 35, currentY + 160); //this will print one heading/title in every page of the document
            e.Graphics.DrawString("Email     : info@theviewmirissa.lk", new Font("Arial", 9), Brushes.Black, 35, currentY + 180); //this will print one heading/title in every page of the document
            e.Graphics.DrawString("Date       : " + lbl_date.Text, new Font("Arial", 9), Brushes.Black, 35, currentY + 200); //this will print one heading/title in every page of the document
            e.Graphics.DrawString("Time      : " + lbl_time.Text, new Font("Arial", 9), Brushes.Black, 35, currentY + 220); //this will print one heading/title in every page of the document

            e.Graphics.DrawString("******************************************************", new Font("Arial", 14), Brushes.Black, 20, currentY + 250);

            e.Graphics.DrawString("Vehicle Number             : " + txt_vehicleNumber.Text, new Font("Arial", 10), Brushes.Black, 35, currentY + 280); //this will print one heading/title in every page of the document
            e.Graphics.DrawString("Customer Type              : " + cb_customerType.Text + " Customer", new Font("Arial", 10), Brushes.Black, 35, currentY + 300); //this will print one heading/title in every page of the document

            e.Graphics.DrawString("Parking Lot Number       : " + lbl_lotNumber.Text, new Font("Arial", 10), Brushes.Black, 35, currentY + 330); //this will print one heading/title in every page of the document
            e.Graphics.DrawString("Parking Floor                 : " + lbl_floorNumber.Text + " Customer", new Font("Arial", 10), Brushes.Black, 35, currentY + 350); //this will print one heading/title in every page of the document

            StringFormat format = new StringFormat(StringFormatFlags.DirectionRightToLeft);
            int itemcount = dgv_checkingUpdates.Rows.Count;

            e.Graphics.DrawString("Check-In Time             : " + txt_checkInDate.Text + " " + " " + txt_checkInTime.Text, new Font("Arial", 10), Brushes.Black, 35, currentY + 380); //this will print one heading/title in every page of the document
            e.Graphics.DrawString("Check-Out Time          : " + txt_checkOutDate.Text + " " + " " + txt_checkOutTime.Text, new Font("Arial", 10), Brushes.Black, 35, currentY + 400); //this will print one heading/title in every page of the document
            e.Graphics.DrawString("Parking Duration         : " + txt_days.Text + " Day (s)" + " " + " " + txt_timeDuration.Text + " Hours", new Font("Arial", 10), Brushes.Black, 35, currentY + 420); //this will print one heading/title in every page of the document

            e.Graphics.DrawString("******************************************************", new Font("Arial", 14), Brushes.Black, 20, currentY + 450);

            e.Graphics.DrawString("| Cash             : Rs. " + txt_cash.Text, new Font("Arial", 10), Brushes.Black, 35, currentY + 480);
            e.Graphics.DrawString("| Balance         : Rs. " + txt_balance.Text, new Font("Arial", 10), Brushes.Black, 35, currentY + 500);
            e.Graphics.DrawString("| Total              : Rs. " + txt_payment.Text, new Font("Arial", 10), Brushes.Black, 35, currentY + 520);

            e.Graphics.DrawString("******************************************************", new Font("Arial", 14), Brushes.Black, 20, currentY + 550);

            e.Graphics.DrawString("********************** Thank You ! Come Again **********************", new Font("Arial", 10), Brushes.Black, 22, currentY + 570);
        }

        // click to bill printing
        private void btn_printBill_Click(object sender, EventArgs e)
        {
            if (cb_checkStatus.SelectedIndex == 1)
            {
                Panel panel = new Panel();
                this.Controls.Add(panel);
                Graphics grp = panel.CreateGraphics();
                Size formSize = this.ClientSize;
                bitmap = new Bitmap(formSize.Width, formSize.Height, grp);
                grp = Graphics.FromImage(bitmap);
                Point panelLocation = PointToScreen(panel.Location);
                grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);
                printPreviewBill.Document = printBill;
                printPreviewBill.PrintPreviewControl.Zoom = 1;
                printPreviewBill.ShowDialog();

                lbl_issuedBill.ForeColor = Color.Green;
                lbl_issuedBill.Text = "Issued";
            }
            else
            {
                MessageBox.Show("Check-Out has not support. But Check-In has support from this event", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // report content
        private void printReport_PrintPage(object sender, PrintPageEventArgs e)
        {
            float currentY = 40; // declare  one variable for height measurement
            e.Graphics.DrawString("Hotel the View Mirissa", new Font("Arial", 22, FontStyle.Bold), Brushes.OrangeRed, 270, currentY); //this will print one heading/title in every page of the document
            e.Graphics.DrawString("Parking & Services", new Font("Arial", 12, FontStyle.Bold), Brushes.Green, 360, currentY + 40); //this will print one heading/title in every page of the document

            e.Graphics.DrawString("Address : Beach Access Road Koparamulla, Mirissa 81740", new Font("Arial", 10), Brushes.Black, 30, currentY + 90); //this will print one heading/title in every page of the document
            e.Graphics.DrawString("Phone    : (+94)716002429", new Font("Arial", 10), Brushes.Black, 30, currentY + 110); //this will print one heading/title in every page of the document
            e.Graphics.DrawString("Email     : info@theviewmirissa.lk", new Font("Arial", 10), Brushes.Black, 30, currentY + 130); //this will print one heading/title in every page of the document
            e.Graphics.DrawString("Date      : " + lbl_date.Text, new Font("Arial", 10), Brushes.Black, 30, currentY + 150); //this will print one heading/title in every page of the document

            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, 30, currentY + 190);

            e.Graphics.DrawString("Vehicle Number      : " + txt_vehicleNumber.Text, new Font("Arial", 10), Brushes.Black, 35, currentY + 230); //this will print one heading/title in every page of the document
            e.Graphics.DrawString("Customer Type      : " + cb_customerType.Text + " Customer", new Font("Arial", 10), Brushes.Black, 35, currentY + 260); //this will print one heading/title in every page of the document

            e.Graphics.DrawString("Check-In Date        : " + txt_checkInDate.Text + " " + " " + txt_checkInTime.Text, new Font("Arial", 10), Brushes.Black, 35, currentY + 310); //this will print one heading/title in every page of the document
            e.Graphics.DrawString("Check-Out Date     : " + txt_checkOutDate.Text + " " + " " + txt_checkOutTime.Text, new Font("Arial", 10), Brushes.Black, 35, currentY + 340); //this will print one heading/title in every page of the document
            e.Graphics.DrawString("Parking Duration    : " + txt_days.Text + " Days" + " " + " " + txt_timeDuration.Text + " Hours", new Font("Arial", 10), Brushes.Black, 35, currentY + 370); //this will print one heading/title in every page of the document
            
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, 30, currentY + 480);
            e.Graphics.DrawString("                                                               - Parking Report -                                                     ", new Font("Arial", 12), Brushes.Black, 45, currentY + 500);

            e.Graphics.DrawString("Check-In User            : " + lbl_loggedUserCheckIn.Text, new Font("Arial", 10), Brushes.Black, 70, currentY + 540);
            e.Graphics.DrawString("Check-Out User          : " + lbl_loggedUser.Text, new Font("Arial", 10), Brushes.Black, 70, currentY + 570);
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, 30, currentY + 610);
            e.Graphics.DrawString("| Cash            : LKR " + txt_cash.Text + ".00", new Font("Arial", 10), Brushes.Black, 35, currentY + 840);
            e.Graphics.DrawString("| Payment     : LKR " + txt_payment.Text + ".00", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, 35, currentY + 870);
            e.Graphics.DrawString("| Balance       : LKR " + txt_balance.Text + ".00", new Font("Arial", 10), Brushes.Black, 35, currentY + 900);

            e.Graphics.DrawString("Customer Signature : ......................................", new Font("Arial", 10), Brushes.Black, 500, currentY + 900);

            e.Graphics.DrawString("******************************************* Thank You! Come Again ********************************************", new Font("Arial", 12), Brushes.YellowGreen, 31, currentY + 1000);
        }

        // print report button
        private void btn_printReport_Click(object sender, EventArgs e)
        {
            if (cb_checkStatus.SelectedIndex == 1)
            {
                Panel panel = new Panel();
                this.Controls.Add(panel);
                Graphics grp = panel.CreateGraphics();
                Size formSize = this.ClientSize;
                bitmap = new Bitmap(formSize.Width, formSize.Height, grp);
                grp = Graphics.FromImage(bitmap);
                Point panelLocation = PointToScreen(panel.Location);
                grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);
                printPreviewReport.Document = printReport;
                printPreviewReport.PrintPreviewControl.Zoom = 1;
                printPreviewReport.ShowDialog();

                lbl_issuedReport.ForeColor = Color.Green;
                lbl_issuedReport.Text = "Issued";
            }
            else
            {
                MessageBox.Show("Check-Out has not support. But Check-In has support from this event", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // go back user panel
        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.getTheName(btn_Back.Text);
            this.Hide();
            Frm_Home home = new Frm_Home();
            home.Type = type.Trim();
            home.Fname = fname.Trim();
            home.Lname = lname.Trim();
            home.Show();
        }

        // update the check-in to check-out
        private void btn_checkOut_Click(object sender, EventArgs e)
        {
            cb_availableStatus.SelectedIndex = 0;

            // Clear any previous error messages
            errorProvider1.Clear();

            // Validation: Check if the vehicle number is not empty
            if (string.IsNullOrWhiteSpace(txt_checkingID.Text))
            {
                errorProvider1.SetError(txt_checkingID, "Checking ID is required.");
                txt_checkingID.Focus();
                return; // Exit the method to prevent further execution
            }

            // Validation: Check if the vehicle number is not empty
            if (string.IsNullOrWhiteSpace(txt_vehicleNumber.Text))
            {
                errorProvider1.SetError(txt_vehicleNumber, "Vehicle number is required.");
                txt_vehicleNumber.Focus();
                return; // Exit the method to prevent further execution
            }

            // Validation: Check if a customer type is selected
            if (string.IsNullOrWhiteSpace(cb_customerType.Text))
            {
                errorProvider1.SetError(cb_customerType, "Please select a customer type.");
                cb_customerType.Focus();
                return; // Exit the method to prevent further execution
            }

            // Validation: Check if a checking status is selected
            if (string.IsNullOrWhiteSpace(cb_checkStatus.Text))
            {
                errorProvider1.SetError(cb_checkStatus, "Please select a checking status.");
                cb_checkStatus.Focus();
                return; // Exit the method to prevent further execution
            }

            // Validation: Check if a Check-In date is selected
            if (string.IsNullOrWhiteSpace(txt_checkInDate.Text))
            {
                errorProvider1.SetError(txt_checkInDate, "Check-In Date is required.");
                txt_checkInDate.Focus();
                return; // Exit the method to prevent further execution
            }

            // Validation: Check if a Check-In time is selected
            if (string.IsNullOrWhiteSpace(txt_checkInTime.Text))
            {
                errorProvider1.SetError(txt_checkInTime, "Check-In Time is required.");
                txt_checkInTime.Focus();
                return; // Exit the method to prevent further execution
            }

            // Validation: Check if a Check-Out Date is selected
            if (string.IsNullOrWhiteSpace(txt_checkOutDate.Text))
            {
                errorProvider1.SetError(txt_checkOutDate, "Check-Out Date is required.");
                txt_checkOutDate.Focus();
                return; // Exit the method to prevent further execution
            }

            // Validation: Check if a Check-Out time is selected
            if (string.IsNullOrWhiteSpace(txt_checkOutTime.Text))
            {
                errorProvider1.SetError(txt_checkOutTime, "Check-Out Time is required.");
                txt_checkOutTime.Focus();
                return; // Exit the method to prevent further execution
            }

            // Validation: Check if a days is selected
            if (string.IsNullOrWhiteSpace(txt_days.Text))
            {
                errorProvider1.SetError(txt_days, "Days is required.");
                txt_days.Focus();
                return; // Exit the method to prevent further execution
            }

            // Validation: Check if a day duration is selected
            if (string.IsNullOrWhiteSpace(txt_dayDuration.Text))
            {
                errorProvider1.SetError(txt_dayDuration, "Day duration is required.");
                txt_dayDuration.Focus();
                return; // Exit the method to prevent further execution
            }

            // Validation: Check if a time duration is selected
            if (string.IsNullOrWhiteSpace(txt_timeDuration.Text))
            {
                errorProvider1.SetError(txt_timeDuration, "Time duration is required.");
                txt_timeDuration.Focus();
                return; // Exit the method to prevent further execution
            }

            // Validation: Check if a total duration is selected
            if (string.IsNullOrWhiteSpace(txt_totalDuration.Text))
            {
                errorProvider1.SetError(txt_totalDuration, "Total duration is required.");
                txt_totalDuration.Focus();
                return; // Exit the method to prevent further execution
            }

            // Validation: Check if a cash is selected
            if (string.IsNullOrWhiteSpace(txt_cash.Text))
            {
                errorProvider1.SetError(txt_cash, "Cash is required.");
                txt_cash.Focus();
                return; // Exit the method to prevent further execution
            }

            // Validation: Check if a payment is selected
            if (string.IsNullOrWhiteSpace(txt_payment.Text))
            {
                errorProvider1.SetError(txt_payment, "Payment is required.");
                txt_payment.Focus();
                return; // Exit the method to prevent further execution
            }

            // Validation: Check if a balance is selected
            if (string.IsNullOrWhiteSpace(txt_balance.Text))
            {
                errorProvider1.SetError(txt_balance, "Balance is required.");
                txt_balance.Focus();
                return; // Exit the method to prevent further execution
            }

            
            // error handling, try catch exception
            try
            {
                if (lbl_issuedBill.Text == "Issued" && lbl_issuedReport.Text == "Issued")
                {
                    // mysql database connection
                    MySqlConnection myConn = new MySqlConnection("server=localhost; userid=root; password=; database=car_parking_management");

                    // mysql database query
                    string query = "UPDATE `checking` SET `vehicle_number` = '" + txt_vehicleNumber.Text + "', `customer_type` = '" + cb_customerType.Text + "', `checking_status` = '" + cb_checkStatus.Text + "', `lot_number` = '" + lbl_lotNumber.Text + "', `floor_number` = '" + lbl_floorNumber.Text + "', `print_slip` = '" + lbl_issuedSlip.Text + "', `check_in_date` = '" + txt_checkInDate.Text + "', `check_in_time` = '" + txt_checkInTime.Text + "', `check_out_date` = '" + txt_checkOutDate.Text + "', `check_out_time` = '" + txt_checkOutTime.Text + "', `days` = '" + txt_days.Text + "', `day_duration` = '" + txt_dayDuration.Text + "', `time_duration` = '" + txt_timeDuration.Text + "', `total_duration` = '" + txt_totalDuration.Text + "', `payment` = '" + txt_payment.Text + "', `cash` = '" + txt_cash.Text + "', `balance` = '" + txt_balance.Text + "', `print_bill` = '" + lbl_issuedBill.Text + "', `print_report` = '" + lbl_issuedReport.Text + "', `c_date` = '" + lbl_date.Text + "', `c_time` = '" + lbl_time.Text + "', `logged_user` = '" + lbl_loggedUser.Text + "', `logged_user_In` = '" + lbl_loggedUserCheckIn.Text + "' WHERE `id` = '" + txt_checkingID.Text + "'";
                    string queryString = "UPDATE `parking_lot` SET `lot_no`='" + lbl_lotNumber.Text + "',`floor_no`='" + lbl_floorNumber.Text + "',`status`='" + cb_availableStatus.Text + "' WHERE `lot_no`='" + lbl_lotNumber.Text + "'";

                    // calling the mysql connection and data query
                    MySqlCommand myComm = new MySqlCommand(query, myConn);
                    MySqlCommand Cmd = new MySqlCommand(queryString, myConn);

                    myConn.Open(); // database connection open
                    myComm.ExecuteNonQuery();
                    Cmd.ExecuteNonQuery();
                    myConn.Close(); // database connection close

                    // message box showing
                    MessageBox.Show("Registration Successfully", "SAVE", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // auto generating number
                    generateNumber();

                    // display adding data
                    checkIn_data();
                    parking_data();

                    // reset filled textboxes
                    txt_vehicleNumber.Text = "";
                    cb_customerType.Text = "";
                    cb_checkStatus.Text = "";
                    lbl_lotNumber.Text = "";
                    lbl_floorNumber.Text = "";
                    cb_availableStatus.Text = "";
                }
                else
                {
                    MessageBox.Show("Bill and Report are not issued", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting data: " + ex.Message);
            }
            finally
            {
                
            }
        }

        // charge the payment
        private void btn_Payment_Click(object sender, EventArgs e)
        {
            // Date
            DateTime date = DateTime.UtcNow.Date;
            txt_checkOutDate.Text = Convert.ToString(date.ToString("yyyy-MM-dd"));

            // Current Time
            DateTime stopTime = DateTime.Now;
            txt_checkOutTime.Text = stopTime.ToShortTimeString();

            // Calculate days
            DateTime dt1 = Convert.ToDateTime(txt_checkInDate.Text);
            DateTime dt2 = Convert.ToDateTime(txt_checkOutDate.Text);
            txt_days.Text = "" + ((dt1 > dt2) ? (dt1 - dt2).TotalDays : (dt2 - dt1).TotalDays);

            // Calculate Day Hours
            TimeSpan difference = dt2 - dt1;
            txt_dayDuration.Text = "" + difference.TotalHours.ToString();

            // Time Duration
            DateTime startTime = Convert.ToDateTime(txt_checkInTime.Text);
            DateTime endTime = Convert.ToDateTime(txt_checkOutTime.Text);
            TimeSpan duration = new TimeSpan();
            duration = endTime - startTime;

            int elapsedMinutes;
            if (endTime.Minute >= startTime.Minute)
                elapsedMinutes = endTime.Minute - startTime.Minute;
            else
            {
                int secondTo60 = 60 - startTime.Minute;
                elapsedMinutes = endTime.Minute + secondTo60;
            }
            txt_timeDuration.Text = string.Format("{0:0}", (int)duration.TotalHours, elapsedMinutes);

            // Calculate Total Duration
            double timetotal = Convert.ToDouble(txt_timeDuration.Text);
            double datetotal = Convert.ToDouble(txt_dayDuration.Text);

            double ans = timetotal + datetotal;
            txt_totalDuration.Text = ans.ToString();

            // According to Total Hours for Parking Charges
            try
            {
                // mysql database connection
                MySqlConnection myConn = new MySqlConnection("server=localhost; userid=root; password=; database=car_parking_management");

                myConn.Open();
                MySqlCommand mycomm = myConn.CreateCommand();
                mycomm.CommandType = CommandType.Text;
                mycomm.CommandText = "SELECT * FROM `parking_charges` WHERE `hours`='" + txt_totalDuration.Text + "'";
                mycomm.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter myadp = new MySqlDataAdapter(mycomm);
                myadp.Fill(dt);

                txt_payment.Text = dt.Rows[0][1].ToString();

                myConn.Close();
                MessageBox.Show("Payment details are selected", "SELECT", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Payment details are selected failed" + ex.ToString(), "ERROR", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }

        private void dgv_parkingLot_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Refresh Page
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            this.getTheName(btn_refresh.Text);
            this.Hide();
            Frm_Checking checking = new Frm_Checking();
            checking.Type = type.Trim();
            checking.Fname = fname.Trim();
            checking.Lname = lname.Trim();
            checking.Show();
        }

        // Calculate the cash - payment = balance
        private void btn_calculate_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txt_cash.Text);
            double num2 = Convert.ToDouble(txt_payment.Text);

            double sum = num1 - num2;
            txt_balance.Text = sum.ToString();
        }

        // Add new checking
        private void btn_addNew_Click(object sender, EventArgs e)
        {
            generateNumber();

            txt_checkingID.Clear();
            txt_vehicleNumber.Clear();
            cb_customerType.ResetText();
            cb_checkStatus.ResetText();
            cb_availableStatus.ResetText();
            txt_checkInDate.Clear();
            txt_checkInTime.Clear();
            txt_checkOutDate.Clear();
            txt_checkOutTime.Clear();
            txt_days.Clear();
            txt_dayDuration.Clear();
            txt_timeDuration.Clear();
            txt_totalDuration.Clear();
            txt_cash.Clear();
            txt_payment.Clear();
            txt_balance.Clear();

            lbl_lotNumber.ResetText();
            lbl_floorNumber.ResetText();
            lbl_issuedSlip.ResetText();
            lbl_issuedBill.ResetText();
            lbl_issuedReport.ResetText();
        }

        private void cb_availableStat_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valueToSearch = cb_availableStat.Text.ToString();
            searchData(valueToSearch);
        }

        public void searchData(string valueToSearch)
        {
            // mysql database connection
            MySqlConnection myConn = new MySqlConnection("server=localhost; userid=root; password=; database=car_parking_management");

            string query = "SELECT * FROM `parking_lot` WHERE CONCAT(`status`) like '%" + valueToSearch + "%'";
            MySqlCommand myComm = new MySqlCommand(query, myConn);
            MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
            DataTable dt = new DataTable();
            myAdp.Fill(dt);
            dgv_parkingLot.DataSource = dt;
        }
    }
}
