namespace CarParkingManagement
{
    partial class Frm_adminVehicle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_adminVehicle));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Back = new System.Windows.Forms.Button();
            this.t_time = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_loggedAdmin = new System.Windows.Forms.Label();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbl_loggedUser = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgv_requestedData = new System.Windows.Forms.DataGridView();
            this.btn_adminSearch = new System.Windows.Forms.Button();
            this.cb_vehicleBrand = new System.Windows.Forms.ComboBox();
            this.txt_vehicleColor = new System.Windows.Forms.TextBox();
            this.txt_vehicleName = new System.Windows.Forms.TextBox();
            this.txt_vehicleNumber = new System.Windows.Forms.TextBox();
            this.txt_vehicleID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_date = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_gridSearchVehicle = new System.Windows.Forms.Button();
            this.cb_addedUsers = new System.Windows.Forms.ComboBox();
            this.cb_searchBrand = new System.Windows.Forms.ComboBox();
            this.dgv_loadAdminVehicle = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_requestedData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_loadAdminVehicle)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Back.BackgroundImage")));
            this.btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Back.Location = new System.Drawing.Point(721, 392);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(100, 43);
            this.btn_Back.TabIndex = 38;
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // t_time
            // 
            this.t_time.Tick += new System.EventHandler(this.t_time_Tick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lbl_date);
            this.panel3.Controls.Add(this.lbl_time);
            this.panel3.Location = new System.Drawing.Point(594, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(258, 63);
            this.panel3.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(30, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(164, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbl_date.Location = new System.Drawing.Point(30, 30);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(87, 16);
            this.lbl_date.TabIndex = 1;
            this.lbl_date.Text = "YYYY-MM-SS";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbl_time.Location = new System.Drawing.Point(164, 30);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(58, 16);
            this.lbl_time.TabIndex = 0;
            this.lbl_time.Text = "00:00:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(131, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 33);
            this.label3.TabIndex = 7;
            this.label3.Text = "VEHICLE";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(411, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 63);
            this.panel2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(183, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 63);
            this.panel1.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 562);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 20);
            this.label9.TabIndex = 44;
            this.label9.Text = "Administrator:";
            // 
            // lbl_loggedAdmin
            // 
            this.lbl_loggedAdmin.AutoSize = true;
            this.lbl_loggedAdmin.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loggedAdmin.Location = new System.Drawing.Point(116, 562);
            this.lbl_loggedAdmin.Name = "lbl_loggedAdmin";
            this.lbl_loggedAdmin.Size = new System.Drawing.Size(254, 20);
            this.lbl_loggedAdmin.TabIndex = 45;
            this.lbl_loggedAdmin.Text = "[Logged Admin\'s First Name & Last Name]";
            // 
            // pb_logo
            // 
            this.pb_logo.BackgroundImage = global::CarParkingManagement.Properties.Resources.Logo;
            this.pb_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_logo.Location = new System.Drawing.Point(12, 12);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(165, 63);
            this.pb_logo.TabIndex = 22;
            this.pb_logo.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 82);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(840, 472);
            this.tabControl1.TabIndex = 46;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.lbl_loggedUser);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.dgv_requestedData);
            this.tabPage1.Controls.Add(this.btn_Back);
            this.tabPage1.Controls.Add(this.btn_adminSearch);
            this.tabPage1.Controls.Add(this.cb_vehicleBrand);
            this.tabPage1.Controls.Add(this.txt_vehicleColor);
            this.tabPage1.Controls.Add(this.txt_vehicleName);
            this.tabPage1.Controls.Add(this.txt_vehicleNumber);
            this.tabPage1.Controls.Add(this.txt_vehicleID);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(832, 446);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Vehicle";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbl_loggedUser
            // 
            this.lbl_loggedUser.AutoSize = true;
            this.lbl_loggedUser.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loggedUser.Location = new System.Drawing.Point(417, 172);
            this.lbl_loggedUser.Name = "lbl_loggedUser";
            this.lbl_loggedUser.Size = new System.Drawing.Size(242, 20);
            this.lbl_loggedUser.TabIndex = 62;
            this.lbl_loggedUser.Text = "[Logged User\'s First Name & Last Name]";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(291, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 20);
            this.label11.TabIndex = 61;
            this.label11.Text = "Logged User";
            // 
            // dgv_requestedData
            // 
            this.dgv_requestedData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_requestedData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_requestedData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_requestedData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_requestedData.Location = new System.Drawing.Point(12, 214);
            this.dgv_requestedData.Name = "dgv_requestedData";
            this.dgv_requestedData.Size = new System.Drawing.Size(701, 222);
            this.dgv_requestedData.TabIndex = 60;
            // 
            // btn_adminSearch
            // 
            this.btn_adminSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_adminSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_adminSearch.BackgroundImage")));
            this.btn_adminSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_adminSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_adminSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_adminSearch.Location = new System.Drawing.Point(721, 18);
            this.btn_adminSearch.Name = "btn_adminSearch";
            this.btn_adminSearch.Size = new System.Drawing.Size(100, 43);
            this.btn_adminSearch.TabIndex = 59;
            this.btn_adminSearch.UseVisualStyleBackColor = false;
            this.btn_adminSearch.Click += new System.EventHandler(this.btn_adminSearch_Click_1);
            // 
            // cb_vehicleBrand
            // 
            this.cb_vehicleBrand.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.cb_vehicleBrand.FormattingEnabled = true;
            this.cb_vehicleBrand.Items.AddRange(new object[] {
            "Audi",
            "Bentley",
            "BMW",
            "Bugatti",
            "Daihatsu",
            "DFSK",
            "Dodge",
            "Ferrari",
            "Geely",
            "Honda",
            "Hummer",
            "Jaguar",
            "Jeep",
            "Kia",
            "Lamborgini",
            "Land Rover",
            "Lexus",
            "Mercedez-Benz",
            "Micro",
            "Mitzubishi",
            "Nissan",
            "Rolls Royce",
            "Suzuki",
            "Toyota",
            "Volkswagen"});
            this.cb_vehicleBrand.Location = new System.Drawing.Point(421, 78);
            this.cb_vehicleBrand.Name = "cb_vehicleBrand";
            this.cb_vehicleBrand.Size = new System.Drawing.Size(231, 28);
            this.cb_vehicleBrand.TabIndex = 58;
            // 
            // txt_vehicleColor
            // 
            this.txt_vehicleColor.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.txt_vehicleColor.Location = new System.Drawing.Point(421, 140);
            this.txt_vehicleColor.Name = "txt_vehicleColor";
            this.txt_vehicleColor.Size = new System.Drawing.Size(231, 25);
            this.txt_vehicleColor.TabIndex = 57;
            // 
            // txt_vehicleName
            // 
            this.txt_vehicleName.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.txt_vehicleName.Location = new System.Drawing.Point(421, 110);
            this.txt_vehicleName.Name = "txt_vehicleName";
            this.txt_vehicleName.Size = new System.Drawing.Size(231, 25);
            this.txt_vehicleName.TabIndex = 56;
            // 
            // txt_vehicleNumber
            // 
            this.txt_vehicleNumber.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.txt_vehicleNumber.Location = new System.Drawing.Point(421, 48);
            this.txt_vehicleNumber.Name = "txt_vehicleNumber";
            this.txt_vehicleNumber.Size = new System.Drawing.Size(231, 25);
            this.txt_vehicleNumber.TabIndex = 55;
            // 
            // txt_vehicleID
            // 
            this.txt_vehicleID.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.txt_vehicleID.Location = new System.Drawing.Point(421, 18);
            this.txt_vehicleID.Name = "txt_vehicleID";
            this.txt_vehicleID.Size = new System.Drawing.Size(231, 25);
            this.txt_vehicleID.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(291, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 20);
            this.label8.TabIndex = 53;
            this.label8.Text = "Vehicle Color";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(291, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 52;
            this.label7.Text = "Vehicle Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(291, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 51;
            this.label6.Text = "Vehicle Brand";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(291, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 50;
            this.label5.Text = "Vehicle Number";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CarParkingManagement.Properties.Resources.audi_jeep_q3_car_png_7;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(15, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 190);
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(291, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 48;
            this.label4.Text = "Vehicle ID";
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(this.txt_date);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.btn_gridSearchVehicle);
            this.tabPage2.Controls.Add(this.cb_addedUsers);
            this.tabPage2.Controls.Add(this.cb_searchBrand);
            this.tabPage2.Controls.Add(this.dgv_loadAdminVehicle);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(832, 446);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Search Vehicle";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_date
            // 
            this.txt_date.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.txt_date.Location = new System.Drawing.Point(464, 9);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(231, 25);
            this.txt_date.TabIndex = 90;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(371, 12);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 20);
            this.label16.TabIndex = 89;
            this.label16.Text = "Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(371, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 20);
            this.label10.TabIndex = 70;
            this.label10.Text = "Logged User";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 20);
            this.label12.TabIndex = 69;
            this.label12.Text = "Vehicle Brand";
            // 
            // btn_gridSearchVehicle
            // 
            this.btn_gridSearchVehicle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_gridSearchVehicle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_gridSearchVehicle.BackgroundImage")));
            this.btn_gridSearchVehicle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_gridSearchVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_gridSearchVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_gridSearchVehicle.Location = new System.Drawing.Point(722, 25);
            this.btn_gridSearchVehicle.Name = "btn_gridSearchVehicle";
            this.btn_gridSearchVehicle.Size = new System.Drawing.Size(100, 43);
            this.btn_gridSearchVehicle.TabIndex = 68;
            this.btn_gridSearchVehicle.UseVisualStyleBackColor = false;
            this.btn_gridSearchVehicle.Click += new System.EventHandler(this.btn_gridSearchVehicle_Click);
            // 
            // cb_addedUsers
            // 
            this.cb_addedUsers.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.cb_addedUsers.FormattingEnabled = true;
            this.cb_addedUsers.Location = new System.Drawing.Point(464, 40);
            this.cb_addedUsers.Name = "cb_addedUsers";
            this.cb_addedUsers.Size = new System.Drawing.Size(231, 28);
            this.cb_addedUsers.TabIndex = 67;
            // 
            // cb_searchBrand
            // 
            this.cb_searchBrand.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.cb_searchBrand.FormattingEnabled = true;
            this.cb_searchBrand.Items.AddRange(new object[] {
            "Audi",
            "Bentley",
            "BMW",
            "Bugatti",
            "Daihatsu",
            "DFSK",
            "Dodge",
            "Ferrari",
            "Geely",
            "Honda",
            "Hummer",
            "Jaguar",
            "Jeep",
            "Kia",
            "Lamborgini",
            "Land Rover",
            "Lexus",
            "Mercedez-Benz",
            "Micro",
            "Mitzubishi",
            "Nissan",
            "Rolls Royce",
            "Suzuki",
            "Toyota",
            "Volkswagen"});
            this.cb_searchBrand.Location = new System.Drawing.Point(102, 40);
            this.cb_searchBrand.Name = "cb_searchBrand";
            this.cb_searchBrand.Size = new System.Drawing.Size(176, 28);
            this.cb_searchBrand.TabIndex = 66;
            // 
            // dgv_loadAdminVehicle
            // 
            this.dgv_loadAdminVehicle.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgv_loadAdminVehicle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_loadAdminVehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_loadAdminVehicle.Location = new System.Drawing.Point(6, 74);
            this.dgv_loadAdminVehicle.Name = "dgv_loadAdminVehicle";
            this.dgv_loadAdminVehicle.Size = new System.Drawing.Size(819, 362);
            this.dgv_loadAdminVehicle.TabIndex = 0;
            // 
            // Frm_adminVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 598);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lbl_loggedAdmin);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pb_logo);
            this.Name = "Frm_adminVehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VEHICLE DETAILS: ADMINISTRATOR";
            this.Load += new System.EventHandler(this.Frm_adminVehicle_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_requestedData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_loadAdminVehicle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Timer t_time;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_loggedAdmin;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lbl_loggedUser;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgv_requestedData;
        private System.Windows.Forms.Button btn_adminSearch;
        private System.Windows.Forms.ComboBox cb_vehicleBrand;
        private System.Windows.Forms.TextBox txt_vehicleColor;
        private System.Windows.Forms.TextBox txt_vehicleName;
        private System.Windows.Forms.TextBox txt_vehicleNumber;
        private System.Windows.Forms.TextBox txt_vehicleID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_gridSearchVehicle;
        private System.Windows.Forms.ComboBox cb_addedUsers;
        private System.Windows.Forms.ComboBox cb_searchBrand;
        private System.Windows.Forms.DataGridView dgv_loadAdminVehicle;
        private System.Windows.Forms.TextBox txt_date;
        private System.Windows.Forms.Label label16;
    }
}