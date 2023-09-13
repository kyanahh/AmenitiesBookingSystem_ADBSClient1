using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GroupProjectADBS.UserControls
{
    public partial class Book : UserControl
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;username=root;password=;database=amenityreservation;");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader dtr;

        public int course, dept, year, section, amenity, taym = 0;

        public Book(string username)
        {
            InitializeComponent();
            txtAccountNumber.Text = username;

            cbAmenity.SelectedIndex = 0;
            cbBuilding.SelectedIndex = 0;
            cbFloor.SelectedIndex = 0;
            cbTaym.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                DateTime now = DateTime.Now;

                // Get the reserverId  '" + reserverId + "',
                string reserverQuery = "SELECT accountid FROM account WHERE accountid = '" + txtAccountNumber.Text + "'";
                MySqlCommand reserverCmd = new MySqlCommand(reserverQuery, con);
                int reserverId = Convert.ToInt32(reserverCmd.ExecuteScalar());

                // Check if the selected date is tomorrow or later
                DateTime selectedDate = dtDate.Value.Date;
                DateTime nextDate = now.Date.AddDays(1);

                if (selectedDate < nextDate)
                {
                    MessageBox.Show("You can only book the date for tomorrow or later. Bookings should be made before the date of use.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if the same date, time, and amenityID combination already exists
                string checkQuery = "SELECT COUNT(*) FROM reservation WHERE resDate = '" + dtDate.Value.Date.ToString("yyyy-MM-dd") + "' " +
                                    "AND resTaym = " + taym + " AND amenityID = " + amenity + ";";
                MySqlCommand checkCmd = new MySqlCommand(checkQuery, con);
                int reservationCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (reservationCount > 0)
                {
                    MessageBox.Show("The selected time, date, and amenity are already taken for this day.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (MessageBox.Show("Are you sure you want to add this item?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    string sql = "INSERT INTO reservation(deptid, courseid, yearid, sectionid, resDate, resTaym," +
                            "accountid, amenityID, reserverid, booktaym) VALUES (" + dept + ", " + course + ", " +
                            "" + year + ", " + section + ", '" + dtDate.Value.Date.ToString("yyyy-MM-dd") + "'," +
                            "" + taym + ", '" + txtAccountNumber.Text + "', " + amenity + ", " + reserverId + "," +
                            "'" + now.ToString("yyyy-MM-dd hh:mm:ss tt") + "');";
                    cmd = new MySqlCommand(sql, con);
                    dtr = cmd.ExecuteReader();
                }
                else
                {
                    return;
                };
                MessageBox.Show("Booked successfully", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearAll();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            loadData();
        }

        public void ClearAll()
        {
            cbDepartment.SelectedIndex = 0;
            cbCourse.SelectedIndex = 0;
            cbYr.SelectedIndex = 0;
            cbSection.SelectedIndex = 0;
            cbAmenity.SelectedIndex = 0;
            dtDate.ResetText();
            cbTaym.SelectedIndex = 0;
        }

        private void cbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = cbCourse.SelectedItem.ToString();

            if (selectedItem == "BSIT")
            {
                course = 1;
            }
            else if (selectedItem == "BSCS")
            {
                course = 2;
            }
            else if (selectedItem == "ACT")
            {
                course = 3;
            }
            else if (selectedItem == "BA Comm")
            {
                course = 4;
            }
            else if (selectedItem == "BS Psych")
            {
                course = 5;
            }
            else if (selectedItem == "BSBA")
            {
                course = 6;
            }
            else if (selectedItem == "BSA")
            {
                course = 7;
            }
            else if (selectedItem == "BS Crim")
            {
                course = 8;
            }
            else if (selectedItem == "BEEd")
            {
                course = 9;
            }
            else if (selectedItem == "BSEd")
            {
                course = 10;
            }
            else if (selectedItem == "BAPS")
            {
                course = 11;
            }
        }

        private void cbYr_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = cbYr.SelectedItem.ToString();

            if (selectedItem == "1st year")
            {
                year = 1;
            }
            else if (selectedItem == "2nd year")
            {
                year = 2;
            }
            else if (selectedItem == "3rd year")
            {
                year = 3;
            }
            else if (selectedItem == "4th year")
            {
                year = 4;
            }
            else if (selectedItem == "5th year")
            {
                year = 5;
            }
        }

        private void cbSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = cbSection.SelectedItem.ToString();

            if (selectedItem == "A")
            {
                section = 1;
            }
            else if (selectedItem == "B")
            {
                section = 2;
            }
            else if (selectedItem == "C")
            {
                section = 3;
            }
            else if (selectedItem == "D")
            {
                section = 4;
            }
            else if (selectedItem == "E")
            {
                section = 5;
            }
            else if (selectedItem == "F")
            {
                section = 6;
            }
            else if (selectedItem == "G")
            {
                section = 7;
            }
            else if (selectedItem == "H")
            {
                section = 8;
            }
            else if (selectedItem == "I")
            {
                section = 9;
            }
            else if (selectedItem == "J")
            {
                section = 10;
            }
            else if (selectedItem == "K")
            {
                section = 11;
            }
            else if (selectedItem == "L")
            {
                section = 12;
            }
            else if (selectedItem == "M")
            {
                section = 13;
            }
            else if (selectedItem == "N")
            {
                section = 14;
            }
            else if (selectedItem == "O")
            {
                section = 15;
            }
            else if (selectedItem == "P")
            {
                section = 16;
            }
            else if (selectedItem == "Q")
            {
                section = 17;
            }
            else if (selectedItem == "R")
            {
                section = 18;
            }
            else if (selectedItem == "S")
            {
                section = 19;
            }
            else if (selectedItem == "T")
            {
                section = 20;
            }
            else if (selectedItem == "Y")
            {
                section = 21;
            }
            else if (selectedItem == "Z")
            {
                section = 22;
            }
        }

        private void cbAmenity_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbAmenity.SelectedIndex == 0)
            {
                amenity = 1;
                cbBuilding.SelectedIndex = 0;
                cbFloor.SelectedIndex = 1;
            }
            else if (cbAmenity.SelectedIndex == 1)
            {
                amenity = 2;
                cbBuilding.SelectedIndex = 0;
                cbFloor.SelectedIndex = 1;
            }
            else if (cbAmenity.SelectedIndex == 2)
            {
                amenity = 3;
                cbBuilding.SelectedIndex = 0;
                cbFloor.SelectedIndex = 1;
            }
            else if (cbAmenity.SelectedIndex == 3)
            {
                amenity = 4;
                cbBuilding.SelectedIndex = 0;
                cbFloor.SelectedIndex = 1;
            }
            else if (cbAmenity.SelectedIndex == 4)
            {
                amenity = 5;
                cbBuilding.SelectedIndex = 0;
                cbFloor.SelectedIndex = 1;
            }
            else if (cbAmenity.SelectedIndex == 5)
            {
                amenity = 6;
                cbBuilding.SelectedIndex = 0;
                cbFloor.SelectedIndex = 1;
            }
            else if (cbAmenity.SelectedIndex == 6)
            {
                amenity = 7;
                cbBuilding.SelectedIndex = 0;
                cbFloor.SelectedIndex = 1;
            }
            else if (cbAmenity.SelectedIndex == 7)
            {
                amenity = 8;
                cbBuilding.SelectedIndex = 0;
                cbFloor.SelectedIndex = 3;
            }
            else if (cbAmenity.SelectedIndex == 8)
            {
                amenity = 9;
                cbBuilding.SelectedIndex = 0;
                cbFloor.SelectedIndex = 2;
            }
            else if (cbAmenity.SelectedIndex == 9)
            {
                amenity = 10;
                cbBuilding.SelectedIndex = 0;
                cbFloor.SelectedIndex = 3;
            }
            else if (cbAmenity.SelectedIndex == 10)
            {
                amenity = 11;
                cbBuilding.SelectedIndex = 0;
                cbFloor.SelectedIndex = 0;
            }
            else if (cbAmenity.SelectedIndex == 11)
            {
                amenity = 12;
                cbBuilding.SelectedIndex = 2;
                cbFloor.SelectedIndex = 0;
            }
            else if (cbAmenity.SelectedIndex == 12)
            {
                amenity = 13;
                cbBuilding.SelectedIndex = 0;
                cbFloor.SelectedIndex = 3;
            }
        }

        private void Book_Load(object sender, EventArgs e)
        {
            loadData();

            try
            {
                con.Open();

                string sql = "SELECT * FROM account WHERE accountid = '" + txtAccountNumber.Text + "' ";
                cmd = new MySqlCommand(sql, con);
                dtr = cmd.ExecuteReader();

                while (dtr.Read())
                {
                    txtAccountNumber.Text = dtr.GetValue(0).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            try
            {
                con.Open();

                string sql = "SELECT account.accountid as Account_Number, reservation.resNumber as Reference_Number," +
                    "department.dept as Department, course.course as Course, year.year as Year, " +
                    "section.section as Section, date_format(reservation.resDate, '%M %d, %Y') as Reservation_Date, " +
                    "taym.reserveTaym as Reservation_Time, amenity.amenityType as Amenity, building.Building as Building, " +
                    "floor.floorLevel as Floor, reservation.reserverid as Reserver_ID, reservation.booktaym as Booking_Time " +
                    "FROM ((((((((( reservation INNER JOIN account on reservation.accountid = account.accountid)" +
                    "INNER JOIN department on reservation.deptid = department.deptid)" +
                    "INNER JOIN course on reservation.courseid = course.courseid)" +
                    "INNER JOIN year on reservation.yearid = year.yearid)" +
                    "INNER JOIN section on reservation.sectionid = section.sectionid)" +
                    "INNER JOIN taym on reservation.resTaym = taym.resTaym)" +
                    "INNER JOIN amenity on reservation.amenityID = amenity.amenityID)" +
                    "INNER JOIN building on amenity.buildingNumber = building.buildingNumber)" +
                    "INNER JOIN floor on amenity.floorID = floor.floorID) " +
                    "WHERE reservation.accountid =  '" + txtAccountNumber.Text + "' ORDER BY resNumber asc; ";

                cmd = new MySqlCommand(sql, con);
                dtr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dtr);
                dgvData.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void cbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCourse.Items.Clear();

            string selectedItem = cbDepartment.SelectedItem.ToString();

            if (selectedItem == "CITCS")
            {
                dept = 1;
                cbCourse.Items.Add("BSIT");
                cbCourse.Items.Add("BSCS");
                cbCourse.Items.Add("ACT");
            }
            else if (selectedItem == "CAS")
            {
                dept = 2;
                cbCourse.Items.Add("BA Comm");
                cbCourse.Items.Add("BS Psych");
            }
            else if (selectedItem == "CBA")
            {
                dept = 3;
                cbCourse.Items.Add("BSBA");
                cbCourse.Items.Add("BSA");
            }
            else if (selectedItem == "CCJ")
            {
                dept = 4;
                cbCourse.Items.Add("BS Crim");
            }
            else if (selectedItem == "CTE")
            {
                dept = 5;
                cbCourse.Items.Add("BEEd");
                cbCourse.Items.Add("BSEd");
            }
            else if (selectedItem == "IPPG")
            {
                dept = 6;
                cbCourse.Items.Add("BAPS");
            }

            cbCourse.SelectedIndex = 0;
        }

        private void cbTaym_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedItem = cbTaym.SelectedItem.ToString();

            if (selectedItem == "7:00am-8:00am")
            {
                taym = 1;
            }
            else if (selectedItem == "8:00am-9:00am")
            {
                taym = 2;
            }
            else if (selectedItem == "9:00am-10:00am")
            {
                taym = 3;
            }
            else if (selectedItem == "10:00am-11:00am")
            {
                taym = 4;
            }
            else if (selectedItem == "11:00am-12:00pm")
            {
                taym = 5;
            }
            else if (selectedItem == "12:00pm-1:00pm")
            {
                taym = 6;
            }
            else if (selectedItem == "1:00pm-2:00pm")
            {
                taym = 7;
            }
            else if (selectedItem == "2:00pm-3:00pm")
            {
                taym = 8;
            }
            else if (selectedItem == "3:00pm-4:00pm")
            {
                taym = 9;
            }
            else if (selectedItem == "4:00pm-5:00pm")
            {
                taym = 10;
            }
            else if (selectedItem == "5:00pm-6:00pm")
            {
                taym = 11;
            }
            else if (selectedItem == "6:00pm-7:00pm")
            {
                taym = 12;
            }
            else if (selectedItem == "7:00pm-8:00pm")
            {
                taym = 13;
            }
        }

    }
}
