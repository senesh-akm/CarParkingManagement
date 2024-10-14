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
    public partial class Frm_IncomeReport : Form
    {
        DataTable dbdataset2;

        Timer t = new Timer();

        public Frm_IncomeReport()
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

        // load checking data
        private void checkIn_data()
        {
            // mysql database connection
            MySqlConnection myConn = new MySqlConnection("server=localhost; userid=root; password=; database=car_parking_management");

            // mysql database query
            MySqlCommand myComm = new MySqlCommand("SELECT * FROM income_repo", myConn);

            // error handling, try catch exception
            try
            {
                MySqlDataAdapter myda = new MySqlDataAdapter();
                myda.SelectCommand = myComm;

                dbdataset2 = new DataTable();
                myda.Fill(dbdataset2);

                BindingSource bsource = new BindingSource();

                bsource.DataSource = dbdataset2;
                dgv_incomeUpdates.DataSource = bsource;
                myda.Update(dbdataset2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data" + ex); //Show error message
            }
        }

        private void Frm_IncomeReport_Load(object sender, EventArgs e)
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

            checkIn_data(); // load checking data

            lbl_loggedAdmin.Text = Fname + " " + Lname;
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

        private void btn_SearchIncome_Click(object sender, EventArgs e)
        {
            string valueToSearch = txt_searchDate.Text.ToString();
            searchData(valueToSearch);
        }

        public void searchData(string valueToSearch)
        {
            // mysql database connection
            MySqlConnection myConn = new MySqlConnection("server=localhost; userid=root; password=; database=car_parking_management");

            string query = "SELECT * FROM `income_repo` WHERE CONCAT(`checkOut-date`) like '%" + valueToSearch + "%'";
            MySqlCommand myComm = new MySqlCommand(query, myConn);
            MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
            DataTable dt = new DataTable();
            myAdp.Fill(dt);
            dgv_incomeUpdates.DataSource = dt;
        }

        private void btn_income_Click(object sender, EventArgs e)
        {
            double total = 0;
            for (int rows = 0; rows < dgv_incomeUpdates.Rows.Count - 1; rows++)
            {
                string amount = dgv_incomeUpdates.Rows[rows].Cells[8].Value.ToString();
                if (amount == "")
                {
                }
                else
                {
                    total += Double.Parse(amount);
                }
            }
            lbl_Income.Text = "LKR " + total + ".00";
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {

        }

        private void printIncome_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }
    }
}
