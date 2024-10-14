namespace CarParkingManagement
{
    partial class Frm_IncomeReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_IncomeReport));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.dgv_incomeUpdates = new System.Windows.Forms.DataGridView();
            this.txt_searchDate = new System.Windows.Forms.TextBox();
            this.btn_SearchIncome = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.lbl_loggedAdmin = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.t_time = new System.Windows.Forms.Timer(this.components);
            this.lbl_Income = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_income = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.printIncome = new System.Drawing.Printing.PrintDocument();
            this.printPreviewIncome = new System.Windows.Forms.PrintPreviewDialog();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_incomeUpdates)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lbl_date);
            this.panel3.Controls.Add(this.lbl_time);
            this.panel3.Location = new System.Drawing.Point(626, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(258, 63);
            this.panel3.TabIndex = 15;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(183, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 63);
            this.panel1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(99, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 33);
            this.label3.TabIndex = 7;
            this.label3.Text = "INCOME REPORT";
            // 
            // pb_logo
            // 
            this.pb_logo.BackgroundImage = global::CarParkingManagement.Properties.Resources.Logo;
            this.pb_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_logo.Location = new System.Drawing.Point(12, 12);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(165, 63);
            this.pb_logo.TabIndex = 13;
            this.pb_logo.TabStop = false;
            // 
            // dgv_incomeUpdates
            // 
            this.dgv_incomeUpdates.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_incomeUpdates.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_incomeUpdates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_incomeUpdates.Location = new System.Drawing.Point(12, 153);
            this.dgv_incomeUpdates.Name = "dgv_incomeUpdates";
            this.dgv_incomeUpdates.Size = new System.Drawing.Size(872, 288);
            this.dgv_incomeUpdates.TabIndex = 59;
            // 
            // txt_searchDate
            // 
            this.txt_searchDate.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.txt_searchDate.Location = new System.Drawing.Point(558, 113);
            this.txt_searchDate.Name = "txt_searchDate";
            this.txt_searchDate.Size = new System.Drawing.Size(154, 25);
            this.txt_searchDate.TabIndex = 60;
            // 
            // btn_SearchIncome
            // 
            this.btn_SearchIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_SearchIncome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_SearchIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SearchIncome.Location = new System.Drawing.Point(718, 112);
            this.btn_SearchIncome.Name = "btn_SearchIncome";
            this.btn_SearchIncome.Size = new System.Drawing.Size(166, 26);
            this.btn_SearchIncome.TabIndex = 61;
            this.btn_SearchIncome.Text = "Search Date";
            this.btn_SearchIncome.UseVisualStyleBackColor = false;
            this.btn_SearchIncome.Click += new System.EventHandler(this.btn_SearchIncome_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Back.BackgroundImage")));
            this.btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(766, 505);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(118, 43);
            this.btn_Back.TabIndex = 69;
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // lbl_loggedAdmin
            // 
            this.lbl_loggedAdmin.AutoSize = true;
            this.lbl_loggedAdmin.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loggedAdmin.Location = new System.Drawing.Point(186, 515);
            this.lbl_loggedAdmin.Name = "lbl_loggedAdmin";
            this.lbl_loggedAdmin.Size = new System.Drawing.Size(151, 20);
            this.lbl_loggedAdmin.TabIndex = 70;
            this.lbl_loggedAdmin.Text = "[Logged Administrator]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 515);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 20);
            this.label5.TabIndex = 71;
            this.label5.Text = "Logged Administrator:";
            // 
            // t_time
            // 
            this.t_time.Tick += new System.EventHandler(this.t_time_Tick);
            // 
            // lbl_Income
            // 
            this.lbl_Income.AutoSize = true;
            this.lbl_Income.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Income.Location = new System.Drawing.Point(217, 462);
            this.lbl_Income.Name = "lbl_Income";
            this.lbl_Income.Size = new System.Drawing.Size(124, 20);
            this.lbl_Income.TabIndex = 72;
            this.lbl_Income.Text = "LKR 000,000,000.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(142, 462);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 73;
            this.label6.Text = "Income:";
            // 
            // btn_income
            // 
            this.btn_income.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_income.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_income.BackgroundImage")));
            this.btn_income.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_income.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_income.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_income.Location = new System.Drawing.Point(362, 451);
            this.btn_income.Name = "btn_income";
            this.btn_income.Size = new System.Drawing.Size(118, 43);
            this.btn_income.TabIndex = 74;
            this.btn_income.UseVisualStyleBackColor = false;
            this.btn_income.Click += new System.EventHandler(this.btn_income_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_Print.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Print.BackgroundImage")));
            this.btn_Print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Print.Location = new System.Drawing.Point(527, 504);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(118, 43);
            this.btn_Print.TabIndex = 75;
            this.btn_Print.UseVisualStyleBackColor = false;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // printIncome
            // 
            this.printIncome.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printIncome_PrintPage);
            // 
            // printPreviewIncome
            // 
            this.printPreviewIncome.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewIncome.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewIncome.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewIncome.Document = this.printIncome;
            this.printPreviewIncome.Enabled = true;
            this.printPreviewIncome.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewIncome.Icon")));
            this.printPreviewIncome.Name = "printPreviewIncome";
            this.printPreviewIncome.Visible = false;
            // 
            // Frm_IncomeReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 560);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.btn_income);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_Income);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_loggedAdmin);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_SearchIncome);
            this.Controls.Add(this.txt_searchDate);
            this.Controls.Add(this.dgv_incomeUpdates);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pb_logo);
            this.Name = "Frm_IncomeReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INCOME REPORT: ADMINSTRATOR";
            this.Load += new System.EventHandler(this.Frm_IncomeReport_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_incomeUpdates)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.DataGridView dgv_incomeUpdates;
        private System.Windows.Forms.TextBox txt_searchDate;
        private System.Windows.Forms.Button btn_SearchIncome;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label lbl_loggedAdmin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer t_time;
        private System.Windows.Forms.Label lbl_Income;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_income;
        private System.Windows.Forms.Button btn_Print;
        private System.Drawing.Printing.PrintDocument printIncome;
        private System.Windows.Forms.PrintPreviewDialog printPreviewIncome;
    }
}