namespace CarParkingManagement
{
    partial class Frm_userVehicle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_userVehicle));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv_vehicle = new System.Windows.Forms.DataGridView();
            this.txt_vehicleID = new System.Windows.Forms.TextBox();
            this.txt_vehicleNumber = new System.Windows.Forms.TextBox();
            this.txt_vehicleName = new System.Windows.Forms.TextBox();
            this.txt_vehicleColor = new System.Windows.Forms.TextBox();
            this.cb_vehicleBrand = new System.Windows.Forms.ComboBox();
            this.btn_vehicleSave = new System.Windows.Forms.Button();
            this.t_time = new System.Windows.Forms.Timer(this.components);
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_vehicleUpdate = new System.Windows.Forms.Button();
            this.btn_requestDelete = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_loggedUser = new System.Windows.Forms.Label();
            this.btn_searchVehicle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_addNew = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vehicle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 5;
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
            this.panel3.TabIndex = 6;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(288, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Vehicle ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(288, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Vehicle Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(288, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Vehicle Brand";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(288, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Vehicle Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(288, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Vehicle Color";
            // 
            // dgv_vehicle
            // 
            this.dgv_vehicle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_vehicle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_vehicle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_vehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vehicle.Location = new System.Drawing.Point(12, 283);
            this.dgv_vehicle.Name = "dgv_vehicle";
            this.dgv_vehicle.Size = new System.Drawing.Size(701, 206);
            this.dgv_vehicle.TabIndex = 13;
            // 
            // txt_vehicleID
            // 
            this.txt_vehicleID.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.txt_vehicleID.Location = new System.Drawing.Point(418, 104);
            this.txt_vehicleID.Name = "txt_vehicleID";
            this.txt_vehicleID.Size = new System.Drawing.Size(231, 25);
            this.txt_vehicleID.TabIndex = 14;
            // 
            // txt_vehicleNumber
            // 
            this.txt_vehicleNumber.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.txt_vehicleNumber.Location = new System.Drawing.Point(418, 139);
            this.txt_vehicleNumber.Name = "txt_vehicleNumber";
            this.txt_vehicleNumber.Size = new System.Drawing.Size(231, 25);
            this.txt_vehicleNumber.TabIndex = 15;
            // 
            // txt_vehicleName
            // 
            this.txt_vehicleName.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.txt_vehicleName.Location = new System.Drawing.Point(418, 207);
            this.txt_vehicleName.Name = "txt_vehicleName";
            this.txt_vehicleName.Size = new System.Drawing.Size(231, 25);
            this.txt_vehicleName.TabIndex = 16;
            // 
            // txt_vehicleColor
            // 
            this.txt_vehicleColor.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.txt_vehicleColor.Location = new System.Drawing.Point(418, 241);
            this.txt_vehicleColor.Name = "txt_vehicleColor";
            this.txt_vehicleColor.Size = new System.Drawing.Size(231, 25);
            this.txt_vehicleColor.TabIndex = 17;
            // 
            // cb_vehicleBrand
            // 
            this.cb_vehicleBrand.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.cb_vehicleBrand.FormattingEnabled = true;
            this.cb_vehicleBrand.Items.AddRange(new object[] {
            "Audi",
            "Bentley",
            "BMW",
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
            this.cb_vehicleBrand.Location = new System.Drawing.Point(418, 173);
            this.cb_vehicleBrand.Name = "cb_vehicleBrand";
            this.cb_vehicleBrand.Size = new System.Drawing.Size(231, 28);
            this.cb_vehicleBrand.TabIndex = 18;
            // 
            // btn_vehicleSave
            // 
            this.btn_vehicleSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_vehicleSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_vehicleSave.BackgroundImage")));
            this.btn_vehicleSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_vehicleSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_vehicleSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_vehicleSave.Location = new System.Drawing.Point(752, 166);
            this.btn_vehicleSave.Name = "btn_vehicleSave";
            this.btn_vehicleSave.Size = new System.Drawing.Size(100, 43);
            this.btn_vehicleSave.TabIndex = 19;
            this.btn_vehicleSave.UseVisualStyleBackColor = false;
            this.btn_vehicleSave.Click += new System.EventHandler(this.btn_vehicleSave_Click);
            // 
            // t_time
            // 
            this.t_time.Tick += new System.EventHandler(this.t_time_Tick);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Back.BackgroundImage")));
            this.btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Back.Location = new System.Drawing.Point(752, 482);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(100, 43);
            this.btn_Back.TabIndex = 20;
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_vehicleUpdate
            // 
            this.btn_vehicleUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_vehicleUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_vehicleUpdate.BackgroundImage")));
            this.btn_vehicleUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_vehicleUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_vehicleUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_vehicleUpdate.Location = new System.Drawing.Point(752, 292);
            this.btn_vehicleUpdate.Name = "btn_vehicleUpdate";
            this.btn_vehicleUpdate.Size = new System.Drawing.Size(100, 43);
            this.btn_vehicleUpdate.TabIndex = 21;
            this.btn_vehicleUpdate.UseVisualStyleBackColor = false;
            this.btn_vehicleUpdate.Click += new System.EventHandler(this.btn_vehicleUpdate_Click);
            // 
            // btn_requestDelete
            // 
            this.btn_requestDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_requestDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_requestDelete.BackgroundImage")));
            this.btn_requestDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_requestDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_requestDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_requestDelete.Location = new System.Drawing.Point(752, 350);
            this.btn_requestDelete.Name = "btn_requestDelete";
            this.btn_requestDelete.Size = new System.Drawing.Size(100, 43);
            this.btn_requestDelete.TabIndex = 22;
            this.btn_requestDelete.UseVisualStyleBackColor = false;
            this.btn_requestDelete.Click += new System.EventHandler(this.btn_requestDelete_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 498);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Logged User:";
            // 
            // lbl_loggedUser
            // 
            this.lbl_loggedUser.AutoSize = true;
            this.lbl_loggedUser.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loggedUser.Location = new System.Drawing.Point(109, 498);
            this.lbl_loggedUser.Name = "lbl_loggedUser";
            this.lbl_loggedUser.Size = new System.Drawing.Size(142, 20);
            this.lbl_loggedUser.TabIndex = 24;
            this.lbl_loggedUser.Text = "[Logged User\'s Name]";
            // 
            // btn_searchVehicle
            // 
            this.btn_searchVehicle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_searchVehicle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_searchVehicle.BackgroundImage")));
            this.btn_searchVehicle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_searchVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_searchVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_searchVehicle.Location = new System.Drawing.Point(752, 227);
            this.btn_searchVehicle.Name = "btn_searchVehicle";
            this.btn_searchVehicle.Size = new System.Drawing.Size(100, 43);
            this.btn_searchVehicle.TabIndex = 25;
            this.btn_searchVehicle.UseVisualStyleBackColor = false;
            this.btn_searchVehicle.Click += new System.EventHandler(this.btn_searchVehicle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CarParkingManagement.Properties.Resources.audi_jeep_q3_car_png_7;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 183);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pb_logo
            // 
            this.pb_logo.BackgroundImage = global::CarParkingManagement.Properties.Resources.Logo;
            this.pb_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_logo.Location = new System.Drawing.Point(12, 12);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(165, 63);
            this.pb_logo.TabIndex = 4;
            this.pb_logo.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btn_addNew
            // 
            this.btn_addNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_addNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_addNew.BackgroundImage")));
            this.btn_addNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_addNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_addNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_addNew.Location = new System.Drawing.Point(752, 104);
            this.btn_addNew.Name = "btn_addNew";
            this.btn_addNew.Size = new System.Drawing.Size(100, 43);
            this.btn_addNew.TabIndex = 26;
            this.btn_addNew.UseVisualStyleBackColor = false;
            this.btn_addNew.Click += new System.EventHandler(this.btn_addNew_Click);
            // 
            // Frm_userVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 537);
            this.Controls.Add(this.btn_addNew);
            this.Controls.Add(this.btn_searchVehicle);
            this.Controls.Add(this.lbl_loggedUser);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_requestDelete);
            this.Controls.Add(this.btn_vehicleUpdate);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_vehicleSave);
            this.Controls.Add(this.cb_vehicleBrand);
            this.Controls.Add(this.txt_vehicleColor);
            this.Controls.Add(this.txt_vehicleName);
            this.Controls.Add(this.txt_vehicleNumber);
            this.Controls.Add(this.txt_vehicleID);
            this.Controls.Add(this.dgv_vehicle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pb_logo);
            this.Name = "Frm_userVehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VEHICLE REGISTRATION: USER";
            this.Load += new System.EventHandler(this.Frm_userVehicle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vehicle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgv_vehicle;
        private System.Windows.Forms.TextBox txt_vehicleID;
        private System.Windows.Forms.TextBox txt_vehicleNumber;
        private System.Windows.Forms.TextBox txt_vehicleName;
        private System.Windows.Forms.TextBox txt_vehicleColor;
        private System.Windows.Forms.ComboBox cb_vehicleBrand;
        private System.Windows.Forms.Button btn_vehicleSave;
        private System.Windows.Forms.Timer t_time;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_vehicleUpdate;
        private System.Windows.Forms.Button btn_requestDelete;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_loggedUser;
        private System.Windows.Forms.Button btn_searchVehicle;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btn_addNew;
    }
}