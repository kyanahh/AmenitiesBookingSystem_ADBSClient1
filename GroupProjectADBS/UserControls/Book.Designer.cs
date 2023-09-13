
namespace GroupProjectADBS.UserControls
{
    partial class Book
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.cbTaym = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.cbFloor = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbBuilding = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbAmenity = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbSection = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbYr = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbCourse = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(53)))), ((int)(((byte)(0)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(1119, 97);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(152, 40);
            this.btnCancel.TabIndex = 95;
            this.btnCancel.Text = "Reset";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(53)))), ((int)(((byte)(0)))));
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBook.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.ForeColor = System.Drawing.Color.White;
            this.btnBook.Location = new System.Drawing.Point(1119, 44);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(152, 40);
            this.btnBook.TabIndex = 94;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvData.Location = new System.Drawing.Point(16, 174);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.Size = new System.Drawing.Size(1272, 262);
            this.dgvData.TabIndex = 98;
            // 
            // cbTaym
            // 
            this.cbTaym.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTaym.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTaym.FormattingEnabled = true;
            this.cbTaym.Items.AddRange(new object[] {
            "7:00am-8:00am",
            "8:00am-9:00am",
            "9:00am-10:00am",
            "10:00am-11:00am",
            "11:00am-12:00pm",
            "12:00pm-1:00pm",
            "1:00pm-2:00pm",
            "2:00pm-3:00pm",
            "3:00pm-4:00pm",
            "4:00pm-5:00pm",
            "5:00pm-6:00pm",
            "6:00pm-7:00pm",
            "7:00pm-8:00pm"});
            this.cbTaym.Location = new System.Drawing.Point(910, 116);
            this.cbTaym.Name = "cbTaym";
            this.cbTaym.Size = new System.Drawing.Size(168, 26);
            this.cbTaym.TabIndex = 131;
            this.cbTaym.SelectedIndexChanged += new System.EventHandler(this.cbTaym_SelectedIndexChanged_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.Control;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(906, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 19);
            this.label13.TabIndex = 130;
            this.label13.Text = "Reservation Time";
            // 
            // dtDate
            // 
            this.dtDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDate.Location = new System.Drawing.Point(910, 49);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(168, 26);
            this.dtDate.TabIndex = 129;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(906, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 19);
            this.label12.TabIndex = 128;
            this.label12.Text = "Reservation Date";
            // 
            // cbFloor
            // 
            this.cbFloor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFloor.Enabled = false;
            this.cbFloor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFloor.FormattingEnabled = true;
            this.cbFloor.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbFloor.Location = new System.Drawing.Point(692, 116);
            this.cbFloor.Name = "cbFloor";
            this.cbFloor.Size = new System.Drawing.Size(168, 26);
            this.cbFloor.TabIndex = 127;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(688, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 19);
            this.label11.TabIndex = 126;
            this.label11.Text = "Floor";
            // 
            // cbBuilding
            // 
            this.cbBuilding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBuilding.Enabled = false;
            this.cbBuilding.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBuilding.FormattingEnabled = true;
            this.cbBuilding.Items.AddRange(new object[] {
            "Main Building",
            "New Building (RLRC)",
            "Not Applicable"});
            this.cbBuilding.Location = new System.Drawing.Point(692, 48);
            this.cbBuilding.Name = "cbBuilding";
            this.cbBuilding.Size = new System.Drawing.Size(168, 26);
            this.cbBuilding.TabIndex = 125;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(688, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 19);
            this.label10.TabIndex = 124;
            this.label10.Text = "Building";
            // 
            // cbAmenity
            // 
            this.cbAmenity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAmenity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAmenity.FormattingEnabled = true;
            this.cbAmenity.Items.AddRange(new object[] {
            "Computer Laboratory 1",
            "Computer Laboratory 2",
            "Computer Laboratory 3",
            "Computer Laboratory 4",
            "Computer Laboratory 5",
            "Computer Laboratory 6",
            "Speech Laboratory",
            "Biology Room",
            "Theater Room",
            "Kinetics Room",
            "Chapel",
            "Gymnasium",
            "Music Room"});
            this.cbAmenity.Location = new System.Drawing.Point(478, 116);
            this.cbAmenity.Name = "cbAmenity";
            this.cbAmenity.Size = new System.Drawing.Size(168, 26);
            this.cbAmenity.TabIndex = 123;
            this.cbAmenity.SelectedIndexChanged += new System.EventHandler(this.cbAmenity_SelectedIndexChanged_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(474, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 19);
            this.label9.TabIndex = 122;
            this.label9.Text = "Amenity";
            // 
            // cbSection
            // 
            this.cbSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSection.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSection.FormattingEnabled = true;
            this.cbSection.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "Y",
            "Z"});
            this.cbSection.Location = new System.Drawing.Point(478, 48);
            this.cbSection.Name = "cbSection";
            this.cbSection.Size = new System.Drawing.Size(168, 26);
            this.cbSection.TabIndex = 121;
            this.cbSection.SelectedIndexChanged += new System.EventHandler(this.cbSection_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(474, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 19);
            this.label8.TabIndex = 120;
            this.label8.Text = "Section";
            // 
            // cbYr
            // 
            this.cbYr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYr.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbYr.FormattingEnabled = true;
            this.cbYr.Items.AddRange(new object[] {
            "1st year",
            "2nd year",
            "3rd year",
            "4th year",
            "5th year"});
            this.cbYr.Location = new System.Drawing.Point(253, 116);
            this.cbYr.Name = "cbYr";
            this.cbYr.Size = new System.Drawing.Size(168, 26);
            this.cbYr.TabIndex = 119;
            this.cbYr.SelectedIndexChanged += new System.EventHandler(this.cbYr_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(249, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 19);
            this.label7.TabIndex = 118;
            this.label7.Text = "Year";
            // 
            // cbCourse
            // 
            this.cbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCourse.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCourse.FormattingEnabled = true;
            this.cbCourse.Items.AddRange(new object[] {
            "BSIT",
            "BSCS",
            "ACT",
            "BA Comm",
            "BS Psych",
            "BSBA",
            "BSA",
            "BS Crim",
            "BEEd",
            "BSEd",
            "BAPS"});
            this.cbCourse.Location = new System.Drawing.Point(253, 48);
            this.cbCourse.Name = "cbCourse";
            this.cbCourse.Size = new System.Drawing.Size(168, 26);
            this.cbCourse.TabIndex = 117;
            this.cbCourse.SelectedIndexChanged += new System.EventHandler(this.cbCourse_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(249, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 19);
            this.label6.TabIndex = 116;
            this.label6.Text = "Course";
            // 
            // cbDepartment
            // 
            this.cbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartment.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Items.AddRange(new object[] {
            "CITCS",
            "CAS",
            "CBA",
            "CCJ",
            "CTE",
            "IPPG"});
            this.cbDepartment.Location = new System.Drawing.Point(30, 116);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(168, 26);
            this.cbDepartment.TabIndex = 115;
            this.cbDepartment.SelectedIndexChanged += new System.EventHandler(this.cbDepartment_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(26, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 19);
            this.label5.TabIndex = 114;
            this.label5.Text = "Department";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Enabled = false;
            this.txtAccountNumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNumber.Location = new System.Drawing.Point(30, 48);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(168, 26);
            this.txtAccountNumber.TabIndex = 111;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(26, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 19);
            this.label2.TabIndex = 110;
            this.label2.Text = "Account Number";
            // 
            // Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbTaym);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbFloor);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbBuilding);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbAmenity);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbSection);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbYr);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbCourse);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbDepartment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnBook);
            this.Name = "Book";
            this.Size = new System.Drawing.Size(1304, 447);
            this.Load += new System.EventHandler(this.Book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.ComboBox cbTaym;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbFloor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbBuilding;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbAmenity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbSection;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbYr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbCourse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label label2;
    }
}
