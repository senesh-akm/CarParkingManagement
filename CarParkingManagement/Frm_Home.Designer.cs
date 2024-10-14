namespace CarParkingManagement
{
    partial class Frm_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Home));
            this.pb_homePic = new System.Windows.Forms.PictureBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_incomeReports = new System.Windows.Forms.Button();
            this.btn_checking = new System.Windows.Forms.Button();
            this.btn_vehicle = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_userLastName = new System.Windows.Forms.Label();
            this.lbl_userFirstName = new System.Windows.Forms.Label();
            this.lbl_Heading = new System.Windows.Forms.Label();
            this.pb_userIcon = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_parked = new System.Windows.Forms.Label();
            this.lbl_available = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_homePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_userIcon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_homePic
            // 
            this.pb_homePic.BackgroundImage = global::CarParkingManagement.Properties.Resources.parking;
            this.pb_homePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_homePic.Location = new System.Drawing.Point(245, 83);
            this.pb_homePic.Name = "pb_homePic";
            this.pb_homePic.Size = new System.Drawing.Size(508, 332);
            this.pb_homePic.TabIndex = 17;
            this.pb_homePic.TabStop = false;
            // 
            // btn_back
            // 
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(12, 377);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(227, 39);
            this.btn_back.TabIndex = 16;
            this.btn_back.Text = "Log out";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_incomeReports
            // 
            this.btn_incomeReports.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_incomeReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_incomeReports.Location = new System.Drawing.Point(12, 178);
            this.btn_incomeReports.Name = "btn_incomeReports";
            this.btn_incomeReports.Size = new System.Drawing.Size(227, 39);
            this.btn_incomeReports.TabIndex = 15;
            this.btn_incomeReports.Text = "Income Reports";
            this.btn_incomeReports.UseVisualStyleBackColor = true;
            this.btn_incomeReports.Click += new System.EventHandler(this.btn_incomeReports_Click);
            // 
            // btn_checking
            // 
            this.btn_checking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_checking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_checking.Location = new System.Drawing.Point(12, 130);
            this.btn_checking.Name = "btn_checking";
            this.btn_checking.Size = new System.Drawing.Size(227, 39);
            this.btn_checking.TabIndex = 14;
            this.btn_checking.Text = "Checking";
            this.btn_checking.UseVisualStyleBackColor = true;
            this.btn_checking.Click += new System.EventHandler(this.btn_checking_Click);
            // 
            // btn_vehicle
            // 
            this.btn_vehicle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_vehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vehicle.Location = new System.Drawing.Point(12, 83);
            this.btn_vehicle.Name = "btn_vehicle";
            this.btn_vehicle.Size = new System.Drawing.Size(227, 39);
            this.btn_vehicle.TabIndex = 12;
            this.btn_vehicle.Text = "Vehicle";
            this.btn_vehicle.UseVisualStyleBackColor = true;
            this.btn_vehicle.Click += new System.EventHandler(this.btn_vehicle_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::CarParkingManagement.Properties.Resources.Logo;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(12, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(165, 63);
            this.panel2.TabIndex = 11;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lbl_userLastName
            // 
            this.lbl_userLastName.AutoSize = true;
            this.lbl_userLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userLastName.Location = new System.Drawing.Point(82, 322);
            this.lbl_userLastName.Name = "lbl_userLastName";
            this.lbl_userLastName.Size = new System.Drawing.Size(132, 15);
            this.lbl_userLastName.TabIndex = 1;
            this.lbl_userLastName.Text = "[Logged User: Last]";
            // 
            // lbl_userFirstName
            // 
            this.lbl_userFirstName.AutoSize = true;
            this.lbl_userFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userFirstName.Location = new System.Drawing.Point(83, 300);
            this.lbl_userFirstName.Name = "lbl_userFirstName";
            this.lbl_userFirstName.Size = new System.Drawing.Size(133, 15);
            this.lbl_userFirstName.TabIndex = 0;
            this.lbl_userFirstName.Text = "[Logged User: First]";
            // 
            // lbl_Heading
            // 
            this.lbl_Heading.AutoSize = true;
            this.lbl_Heading.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_Heading.Location = new System.Drawing.Point(185, 12);
            this.lbl_Heading.Name = "lbl_Heading";
            this.lbl_Heading.Size = new System.Drawing.Size(183, 33);
            this.lbl_Heading.TabIndex = 1;
            this.lbl_Heading.Text = "USER PANEL";
            // 
            // pb_userIcon
            // 
            this.pb_userIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_userIcon.BackgroundImage")));
            this.pb_userIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_userIcon.Location = new System.Drawing.Point(12, 291);
            this.pb_userIcon.Name = "pb_userIcon";
            this.pb_userIcon.Size = new System.Drawing.Size(61, 55);
            this.pb_userIcon.TabIndex = 10;
            this.pb_userIcon.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lbl_Heading);
            this.panel1.Location = new System.Drawing.Point(183, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 63);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(267, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Lot Parked:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(507, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Lot Available:";
            // 
            // lbl_parked
            // 
            this.lbl_parked.AutoSize = true;
            this.lbl_parked.BackColor = System.Drawing.Color.White;
            this.lbl_parked.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_parked.ForeColor = System.Drawing.Color.Red;
            this.lbl_parked.Location = new System.Drawing.Point(353, 89);
            this.lbl_parked.Name = "lbl_parked";
            this.lbl_parked.Size = new System.Drawing.Size(23, 15);
            this.lbl_parked.TabIndex = 20;
            this.lbl_parked.Text = "00";
            // 
            // lbl_available
            // 
            this.lbl_available.AutoSize = true;
            this.lbl_available.BackColor = System.Drawing.Color.White;
            this.lbl_available.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_available.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_available.Location = new System.Drawing.Point(606, 89);
            this.lbl_available.Name = "lbl_available";
            this.lbl_available.Size = new System.Drawing.Size(23, 15);
            this.lbl_available.TabIndex = 21;
            this.lbl_available.Text = "00";
            // 
            // Frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 429);
            this.Controls.Add(this.lbl_available);
            this.Controls.Add(this.lbl_parked);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_userLastName);
            this.Controls.Add(this.pb_homePic);
            this.Controls.Add(this.lbl_userFirstName);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_incomeReports);
            this.Controls.Add(this.btn_checking);
            this.Controls.Add(this.btn_vehicle);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pb_userIcon);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USER PANEL";
            this.Load += new System.EventHandler(this.Frm_Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_homePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_userIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_homePic;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_incomeReports;
        private System.Windows.Forms.Button btn_checking;
        private System.Windows.Forms.Button btn_vehicle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_userLastName;
        private System.Windows.Forms.Label lbl_userFirstName;
        private System.Windows.Forms.Label lbl_Heading;
        private System.Windows.Forms.PictureBox pb_userIcon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_parked;
        private System.Windows.Forms.Label lbl_available;
    }
}