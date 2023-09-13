
namespace GroupProjectADBS
{
    partial class Bookings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bookings));
            this.main = new System.Windows.Forms.Panel();
            this.lblStudID = new System.Windows.Forms.Label();
            this.usercontrolpanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Panel();
            this.lblBookings = new System.Windows.Forms.Label();
            this.lblProfile = new System.Windows.Forms.Label();
            this.lblSARS = new System.Windows.Forms.Label();
            this.pbLogout = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHMS2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.main.SuspendLayout();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // main
            // 
            this.main.BackColor = System.Drawing.SystemColors.Control;
            this.main.Controls.Add(this.lblStudID);
            this.main.Controls.Add(this.usercontrolpanel);
            this.main.Controls.Add(this.label2);
            this.main.Controls.Add(this.header);
            this.main.Controls.Add(this.label1);
            this.main.Controls.Add(this.lblHMS2);
            this.main.Controls.Add(this.pictureBox1);
            this.main.Location = new System.Drawing.Point(26, 26);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(1313, 633);
            this.main.TabIndex = 0;
            // 
            // lblStudID
            // 
            this.lblStudID.AutoSize = true;
            this.lblStudID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStudID.Location = new System.Drawing.Point(92, 19);
            this.lblStudID.Name = "lblStudID";
            this.lblStudID.Size = new System.Drawing.Size(0, 19);
            this.lblStudID.TabIndex = 82;
            // 
            // usercontrolpanel
            // 
            this.usercontrolpanel.BackColor = System.Drawing.Color.Transparent;
            this.usercontrolpanel.Location = new System.Drawing.Point(1, 154);
            this.usercontrolpanel.Name = "usercontrolpanel";
            this.usercontrolpanel.Size = new System.Drawing.Size(1309, 476);
            this.usercontrolpanel.TabIndex = 79;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(15, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 81;
            this.label2.Text = "Welcome ";
            // 
            // header
            // 
            this.header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.header.Controls.Add(this.lblBookings);
            this.header.Controls.Add(this.lblProfile);
            this.header.Controls.Add(this.lblSARS);
            this.header.Controls.Add(this.pbLogout);
            this.header.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.header.Location = new System.Drawing.Point(0, 87);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1313, 66);
            this.header.TabIndex = 78;
            // 
            // lblBookings
            // 
            this.lblBookings.AutoSize = true;
            this.lblBookings.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBookings.Location = new System.Drawing.Point(1110, 20);
            this.lblBookings.Name = "lblBookings";
            this.lblBookings.Size = new System.Drawing.Size(99, 22);
            this.lblBookings.TabIndex = 80;
            this.lblBookings.Text = "Bookings";
            this.lblBookings.Click += new System.EventHandler(this.lblBookings_Click);
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblProfile.Location = new System.Drawing.Point(992, 20);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(70, 22);
            this.lblProfile.TabIndex = 79;
            this.lblProfile.Text = "Profile";
            this.lblProfile.Click += new System.EventHandler(this.lblProfile_Click);
            // 
            // lblSARS
            // 
            this.lblSARS.AutoSize = true;
            this.lblSARS.Font = new System.Drawing.Font("Alien Encounters", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSARS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSARS.Location = new System.Drawing.Point(2, 13);
            this.lblSARS.Name = "lblSARS";
            this.lblSARS.Size = new System.Drawing.Size(153, 38);
            this.lblSARS.TabIndex = 12;
            this.lblSARS.Text = "SARS";
            // 
            // pbLogout
            // 
            this.pbLogout.Image = ((System.Drawing.Image)(resources.GetObject("pbLogout.Image")));
            this.pbLogout.Location = new System.Drawing.Point(1253, 16);
            this.pbLogout.Name = "pbLogout";
            this.pbLogout.Size = new System.Drawing.Size(26, 30);
            this.pbLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogout.TabIndex = 77;
            this.pbLogout.TabStop = false;
            this.pbLogout.Click += new System.EventHandler(this.pbLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(452, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = " University Rd, Poblacion, Muntinlupa, Metro Manila";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblHMS2
            // 
            this.lblHMS2.AutoSize = true;
            this.lblHMS2.BackColor = System.Drawing.SystemColors.Control;
            this.lblHMS2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHMS2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHMS2.Location = new System.Drawing.Point(420, 19);
            this.lblHMS2.Name = "lblHMS2";
            this.lblHMS2.Size = new System.Drawing.Size(469, 24);
            this.lblHMS2.TabIndex = 23;
            this.lblHMS2.Text = "PAMANTASAN NG LUNGSOD NG MUNTINLUPA";
            this.lblHMS2.Click += new System.EventHandler(this.lblHMS2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(348, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Bookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(53)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Bookings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "School Amenities Reservation System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.main.ResumeLayout(false);
            this.main.PerformLayout();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel main;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHMS2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbLogout;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label lblSARS;
        private System.Windows.Forms.Label lblBookings;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.Panel usercontrolpanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStudID;
    }
}