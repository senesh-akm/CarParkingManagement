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
    public partial class Frm_adminChecking : Form
    {
        // mysql database connection
        MySqlConnection myConn = new MySqlConnection("server=localhost; userid=root; password=; database=car_parking_management");

        DataTable dbdataset2;

        Bitmap bitmap;

        Timer t = new Timer();

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

        public Frm_adminChecking()
        {
            InitializeComponent();
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

        // Checking Data Loading
        private void load_data()
        {
            // mysql database connection
            MySqlConnection myConn = new MySqlConnection("server=localhost; userid=root; password=; database=car_parking_management");

            // mysql database query
            MySqlCommand myComm = new MySqlCommand("SELECT * FROM checking", myConn);

            // error handling, try catch exception
            try
            {
                MySqlDataAdapter myda = new MySqlDataAdapter();
                myda.SelectCommand = myComm;

                dbdataset2 = new DataTable();
                myda.Fill(dbdataset2);

                BindingSource bsource = new BindingSource();

                bsource.DataSource = dbdataset2;
                dgv_checkingUpdates.DataSource = bsource;
                myda.Update(dbdataset2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data" + ex); //Show error message
            }
        }

        private void Frm_adminChecking_Load(object sender, EventArgs e)
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

            load_data();
            //this.reportViewer1.RefreshReport();

            lbl_loggedAdmin.Text = Fname + " " + Lname;
        }

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

        // go back to admin panel
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

        // click the row and display the data
        private void dgv_checkingUpdates_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgv_checkingUpdates.Rows.Count - 1)
            {
                DataGridViewRow row = dgv_checkingUpdates.Rows[e.RowIndex];
                string ch_id = row.Cells["id"].Value.ToString();

                // mysql database connection
                MySqlConnection myConn = new MySqlConnection("server=localhost; userid=root; password=; database=car_parking_management");

                // error handling, try catch exception
                try
                {
                    // mysql database query
                    string query = "SELECT * FROM checking WHERE id = @id";
                    MySqlCommand myComm = new MySqlCommand(query, myConn); // calling the mysql connection and data query

                    myComm.Parameters.AddWithValue("@id", ch_id);
                    MySqlDataReader reader;

                    myConn.Open(); // database connection open
                    reader = myComm.ExecuteReader();

                    if (reader.Read())
                    {
                        txt_checkingID.Text = reader["id"].ToString();
                        txt_vehicleNumber.Text = reader["vehicle_number"].ToString();
                        cb_customerType.Text = reader["customer_type"].ToString();
                        cb_checkStatus.Text = reader["checking_status"].ToString();
                        lbl_lotNumber.Text = reader["lot_number"].ToString();
                        lbl_floorNumber.Text = reader["floor_number"].ToString();
                        lbl_issuedSlip.Text = reader["print_slip"].ToString();
                        txt_checkInDate.Text = reader["check_in_date"].ToString();
                        txt_checkInTime.Text = reader["check_in_time"].ToString();
                        txt_checkOutDate.Text = reader["check_out_date"].ToString();
                        txt_checkOutTime.Text = reader["check_out_time"].ToString();
                        txt_days.Text = reader["days"].ToString();
                        txt_dayDuration.Text = reader["day_duration"].ToString();
                        txt_timeDuration.Text = reader["time_duration"].ToString();
                        txt_totalDuration.Text = reader["total_duration"].ToString();
                        txt_payment.Text = reader["payment"].ToString();
                        txt_cash.Text = reader["cash"].ToString();
                        txt_balance.Text = reader["balance"].ToString();
                        lbl_issuedBill.Text = reader["print_bill"].ToString();
                        lbl_issuedReport.Text = reader["print_report"].ToString();
                        lbl_CheckInUser.Text = reader["logged_user"].ToString();
                        lbl_CheckOutUser.Text = reader["logged_user_In"].ToString();
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

        // Search Checking Data
        private void btn_SearchChecking_Click(object sender, EventArgs e)
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
                txt_checkInDate.Text = myTb.Rows[0][7].ToString();
                txt_checkInTime.Text = myTb.Rows[0][8].ToString();
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
                lbl_CheckOutUser.Text = myTb.Rows[0][22].ToString();
                lbl_CheckInUser.Text = myTb.Rows[0][23].ToString();

                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "ERROR", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
        }

        private void printSlip_PrintPage(object sender, PrintPageEventArgs e)
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

        private void btn_printSlip_Click(object sender, EventArgs e)
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
        }

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

        private void btn_printBill_Click(object sender, EventArgs e)
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
        }

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

            e.Graphics.DrawString("Check-In User            : " + lbl_CheckInUser.Text, new Font("Arial", 10), Brushes.Black, 70, currentY + 540);
            e.Graphics.DrawString("Check-Out User          : " + lbl_CheckOutUser.Text, new Font("Arial", 10), Brushes.Black, 70, currentY + 570);
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, 30, currentY + 610);
            e.Graphics.DrawString("| Cash            : LKR " + txt_cash.Text + ".00", new Font("Arial", 10), Brushes.Black, 35, currentY + 840);
            e.Graphics.DrawString("| Payment     : LKR " + txt_payment.Text + ".00", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, 35, currentY + 870);
            e.Graphics.DrawString("| Balance       : LKR " + txt_balance.Text + ".00", new Font("Arial", 10), Brushes.Black, 35, currentY + 900);

            e.Graphics.DrawString("Customer Signature : ......................................", new Font("Arial", 10), Brushes.Black, 500, currentY + 900);

            e.Graphics.DrawString("******************************************* Thank You! Come Again ********************************************", new Font("Arial", 12), Brushes.YellowGreen, 31, currentY + 1000);
        }

        private void btn_printReport_Click(object sender, EventArgs e)
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
    }
}
