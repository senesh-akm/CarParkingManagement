namespace CarParkingManagement
{
    partial class Frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.btn_user = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Msg = new System.Windows.Forms.Label();
            this.chb_showPassword = new System.Windows.Forms.CheckBox();
            this.btn_logIn = new System.Windows.Forms.Button();
            this.txt_passWord = new System.Windows.Forms.TextBox();
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.cb_userType = new System.Windows.Forms.ComboBox();
            this.lbl_userName = new System.Windows.Forms.Label();
            this.lbl_passWord = new System.Windows.Forms.Label();
            this.lbl_userType = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_Heading = new System.Windows.Forms.Label();
            this.btn_support = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_user
            // 
            this.btn_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_user.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_user.BackgroundImage")));
            this.btn_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_user.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_user.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_user.Location = new System.Drawing.Point(12, 298);
            this.btn_user.Name = "btn_user";
            this.btn_user.Size = new System.Drawing.Size(100, 43);
            this.btn_user.TabIndex = 0;
            this.btn_user.UseVisualStyleBackColor = false;
            this.btn_user.Click += new System.EventHandler(this.btn_user_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(187, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 290);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lbl_Msg);
            this.panel2.Controls.Add(this.chb_showPassword);
            this.panel2.Controls.Add(this.btn_logIn);
            this.panel2.Controls.Add(this.txt_passWord);
            this.panel2.Controls.Add(this.txt_userName);
            this.panel2.Controls.Add(this.cb_userType);
            this.panel2.Controls.Add(this.lbl_userName);
            this.panel2.Controls.Add(this.lbl_passWord);
            this.panel2.Controls.Add(this.lbl_userType);
            this.panel2.Location = new System.Drawing.Point(24, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(622, 245);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CarParkingManagement.Properties.Resources.key_log_off_icon_7;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(388, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 164);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Msg
            // 
            this.lbl_Msg.AutoSize = true;
            this.lbl_Msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Msg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_Msg.Location = new System.Drawing.Point(281, 194);
            this.lbl_Msg.Name = "lbl_Msg";
            this.lbl_Msg.Size = new System.Drawing.Size(73, 15);
            this.lbl_Msg.TabIndex = 7;
            this.lbl_Msg.Text = "MESSAGE";
            // 
            // chb_showPassword
            // 
            this.chb_showPassword.AutoSize = true;
            this.chb_showPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_showPassword.Location = new System.Drawing.Point(150, 130);
            this.chb_showPassword.Name = "chb_showPassword";
            this.chb_showPassword.Size = new System.Drawing.Size(148, 19);
            this.chb_showPassword.TabIndex = 6;
            this.chb_showPassword.Text = "SHOW PASSWORD";
            this.chb_showPassword.UseVisualStyleBackColor = true;
            this.chb_showPassword.CheckedChanged += new System.EventHandler(this.chb_showPassword_CheckedChanged);
            // 
            // btn_logIn
            // 
            this.btn_logIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_logIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_logIn.BackgroundImage")));
            this.btn_logIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_logIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logIn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_logIn.Location = new System.Drawing.Point(150, 168);
            this.btn_logIn.Name = "btn_logIn";
            this.btn_logIn.Size = new System.Drawing.Size(106, 43);
            this.btn_logIn.TabIndex = 3;
            this.btn_logIn.UseVisualStyleBackColor = false;
            this.btn_logIn.Click += new System.EventHandler(this.btn_logIn_Click);
            // 
            // txt_passWord
            // 
            this.txt_passWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_passWord.Location = new System.Drawing.Point(150, 95);
            this.txt_passWord.Name = "txt_passWord";
            this.txt_passWord.Size = new System.Drawing.Size(176, 21);
            this.txt_passWord.TabIndex = 5;
            this.txt_passWord.UseSystemPasswordChar = true;
            // 
            // txt_userName
            // 
            this.txt_userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userName.Location = new System.Drawing.Point(150, 62);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(176, 21);
            this.txt_userName.TabIndex = 4;
            // 
            // cb_userType
            // 
            this.cb_userType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_userType.FormattingEnabled = true;
            this.cb_userType.Items.AddRange(new object[] {
            "Administrator",
            "User"});
            this.cb_userType.Location = new System.Drawing.Point(150, 29);
            this.cb_userType.Name = "cb_userType";
            this.cb_userType.Size = new System.Drawing.Size(177, 23);
            this.cb_userType.TabIndex = 3;
            // 
            // lbl_userName
            // 
            this.lbl_userName.AutoSize = true;
            this.lbl_userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userName.Location = new System.Drawing.Point(40, 65);
            this.lbl_userName.Name = "lbl_userName";
            this.lbl_userName.Size = new System.Drawing.Size(84, 15);
            this.lbl_userName.TabIndex = 2;
            this.lbl_userName.Text = "USERNAME";
            // 
            // lbl_passWord
            // 
            this.lbl_passWord.AutoSize = true;
            this.lbl_passWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_passWord.Location = new System.Drawing.Point(40, 98);
            this.lbl_passWord.Name = "lbl_passWord";
            this.lbl_passWord.Size = new System.Drawing.Size(84, 15);
            this.lbl_passWord.TabIndex = 1;
            this.lbl_passWord.Text = "PASSWORD";
            // 
            // lbl_userType
            // 
            this.lbl_userType.AutoSize = true;
            this.lbl_userType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userType.Location = new System.Drawing.Point(41, 32);
            this.lbl_userType.Name = "lbl_userType";
            this.lbl_userType.Size = new System.Drawing.Size(83, 15);
            this.lbl_userType.TabIndex = 0;
            this.lbl_userType.Text = "USER TYPE";
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Exit.BackgroundImage")));
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Exit.Location = new System.Drawing.Point(12, 360);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(100, 43);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lbl_Heading);
            this.panel3.Location = new System.Drawing.Point(198, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(671, 63);
            this.panel3.TabIndex = 5;
            // 
            // lbl_Heading
            // 
            this.lbl_Heading.AutoSize = true;
            this.lbl_Heading.BackColor = System.Drawing.Color.LightSlateGray;
            this.lbl_Heading.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Heading.Location = new System.Drawing.Point(264, 14);
            this.lbl_Heading.Name = "lbl_Heading";
            this.lbl_Heading.Size = new System.Drawing.Size(100, 33);
            this.lbl_Heading.TabIndex = 0;
            this.lbl_Heading.Text = "LOGIN";
            // 
            // btn_support
            // 
            this.btn_support.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_support.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_support.BackgroundImage")));
            this.btn_support.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_support.Cursor = System.Windows.Forms.Cursors.Help;
            this.btn_support.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_support.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_support.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_support.Location = new System.Drawing.Point(12, 170);
            this.btn_support.Name = "btn_support";
            this.btn_support.Size = new System.Drawing.Size(100, 43);
            this.btn_support.TabIndex = 6;
            this.btn_support.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::CarParkingManagement.Properties.Resources.Logo;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(12, 15);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(165, 63);
            this.panel4.TabIndex = 12;
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 415);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btn_support);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_user);
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_user;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_userName;
        private System.Windows.Forms.Label lbl_passWord;
        private System.Windows.Forms.Label lbl_userType;
        private System.Windows.Forms.TextBox txt_passWord;
        private System.Windows.Forms.TextBox txt_userName;
        private System.Windows.Forms.ComboBox cb_userType;
        private System.Windows.Forms.CheckBox chb_showPassword;
        private System.Windows.Forms.Button btn_logIn;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_Msg;
        private System.Windows.Forms.Label lbl_Heading;
        private System.Windows.Forms.Button btn_support;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}