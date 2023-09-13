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
    using System.Globalization;


namespace GroupProjectADBS
    {
        public partial class CreateAccount : Form
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost;username=root;password=;database=amenityreservation;");
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader dtr;

            int gender = 0, dept = 0, type = 0;
            public string username;

            public CreateAccount(string username)
            {
                InitializeComponent();

                cbType.SelectedIndex = 0;
                lblUser.Text = username;

                this.username = username;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to create this account?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    con.Open();

                    RDB();

                    string sql = "INSERT INTO account(lname, fname, mname, sexNo, dateOfBirth," +
                        "contactNo, email, address, barangay, city, state, zipCode, deptid, " +
                        "password, type) VALUES ('" + txtLname.Text + "', '" + txtFname.Text + "', '" + txtMname.Text + "'," +
                        "" + gender + ", '" + dtBday.Value.Date.ToString("yyyy-MM-dd") + "', '" + txtPhone.Text + "'," +
                        "'" + txtEmail.Text + "', '" + txtAddress.Text + "', " +
                        "'" + txtBrgy.Text + "', '" + txtCity.Text + "', '" + txtState.Text + "', '" + txtZip.Text + "'," +
                        "" + dept + ", '" + txtPassword.Text + "', '" + type + "')";
                    MySqlCommand cmd2 = new MySqlCommand(sql, con);
                    cmd2.ExecuteNonQuery();

                }
                

                MessageBox.Show("Record added successfully", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);

                loadData();
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


        }

        private void btnReset_Click(object sender, EventArgs e)
            {
                ClearAll();
            }

        public void RDB()
        {
            if (rbMale.Checked)
            {
                gender = 1;
            }else if (rbFemale.Checked)
            {
                gender = 2;
            }
        }

            public void ClearAll()
            {
                txtAccountNumber.Clear();
                txtLname.Clear();
                txtFname.Clear();
                txtMname.Clear();
                rbMale.Checked = false;
                rbFemale.Checked = false;
                dtBday.ResetText();
                txtPhone.Clear();
                txtEmail.Clear();
                txtAddress.Clear();
                txtBrgy.Clear();
                txtCity.Clear();
                txtState.Clear();
                txtZip.Clear();
                cbDepartment.SelectedIndex = 0;
                txtPassword.Clear();
                cbType.SelectedIndex = 0;
            }

            private void pbLogout_Click(object sender, EventArgs e)
            {
                if (MessageBox.Show("Are you sure you want to log out?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Login login = new Login();
                    login.Show();
                    this.Visible = false;
                }
                else
                {
                    return;
                }
            }

            private void pbBack_Click(object sender, EventArgs e)
            {
                AdminMain admin = new AdminMain(username);
                admin.Show();
                this.Visible = false;
            }

        private void cbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = cbDepartment.SelectedItem.ToString();

            if (selectedItem == "CITCS")
            {
                dept = 1;
            }
            else if (selectedItem == "CAS")
            {
                dept = 2;
            }
            else if (selectedItem == "CBA")
            {
                dept = 3;
            }
            else if (selectedItem == "CCJ")
            {
                dept = 4;
            }
            else if (selectedItem == "CTE")
            {
                dept = 5;
            }
            else if (selectedItem == "IPPG")
            {
                dept = 6;
            } else if (selectedItem == "N/A")
            {
                dept = 7;
            }
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = cbType.SelectedItem.ToString();

            if (selectedItem == "Admin")
            {
                type = 1;
            }
            else if (selectedItem == "Department Head")
            {
                type = 2;
            }
            else if (selectedItem == "Professor")
            {
                type = 3;
            }
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this item?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    con.Open();
                    string sql = "UPDATE account SET lname = '" + txtLname.Text + "', mname = '" + txtMname.Text + "', " +
                        "contactNo = '" + txtPhone.Text + "', email = '" + txtEmail.Text + "',  " +
                        "address = '" + txtAddress.Text + "', barangay = '" + txtBrgy.Text + "', " +
                        "city = '" + txtCity.Text + "', state = '" + txtState.Text + "', " +
                        "zipCode = '" + txtZip.Text + "', deptid = " + dept + ", " +
                        "password = '" + txtPassword.Text + "', type = " + type + " " +
                        "WHERE accountid = "+ txtAccountNumber.Text +"; ";
                    cmd = new MySqlCommand(sql, con);
                    dtr = cmd.ExecuteReader();
                }
                else
                {
                    return;
                };
                MessageBox.Show("Record updated successfully", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);

                loadData();

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to permanently remove this item?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    con.Open();
                    string sql = "DELETE FROM account WHERE accountid = '" + txtAccountNumber.Text + "' ";
                    cmd = new MySqlCommand(sql, con);
                    dtr = cmd.ExecuteReader();
                }
                else
                {
                    return;
                };
                MessageBox.Show("Record deleted successfully", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);

                loadData();

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

        private void pbReload_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = dgvData.Rows[index];
            txtAccountNumber.Text = row.Cells[0].Value.ToString();
            txtLname.Text = row.Cells[1].Value.ToString();
            txtFname.Text = row.Cells[2].Value.ToString();
            txtMname.Text = row.Cells[3].Value.ToString();

            string gender = row.Cells[4].Value.ToString();
            if (gender == "Male")
            {
                rbMale.Checked = true;
            }
            else if (gender == "Female")
            {
                rbFemale.Checked = true;
            }

            string dateString = row.Cells[5].Value.ToString();
            DateTime date;

            if (DateTime.TryParseExact(dateString, "MMMM dd, yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {
                dtBday.Value = date;
            }
            else
            {
                MessageBox.Show("Invalid date format in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            txtPhone.Text = row.Cells[6].Value.ToString();
            txtEmail.Text = row.Cells[7].Value.ToString();
            txtAddress.Text = row.Cells[8].Value.ToString();
            txtBrgy.Text = row.Cells[9].Value.ToString();
            txtCity.Text = row.Cells[10].Value.ToString();
            txtState.Text = row.Cells[11].Value.ToString();
            txtZip.Text = row.Cells[12].Value.ToString();

            string department = row.Cells[13].Value.ToString();
            if (department == "CITCS")
            {
                cbDepartment.SelectedIndex = 0;
            }
            else if (department == "CAS")
            {
                cbDepartment.SelectedIndex = 1;
            }
            else if (department == "CBA")
            {
                cbDepartment.SelectedIndex = 2;
            }
            else if (department == "CCJ")
            {
                cbDepartment.SelectedIndex = 3;
            }
            else if (department == "CTE")
            {
                cbDepartment.SelectedIndex = 4;
            }
            else if (department == "IPPG")
            {
                cbDepartment.SelectedIndex = 5;
            }
            else if (department == "N/A")
            {
                cbDepartment.SelectedIndex = 6;
            }

            txtPassword.Text = row.Cells[14].Value.ToString();

            string userType = row.Cells[15].Value.ToString();
            if (userType == "Admin")
            {
                cbType.SelectedIndex = 0;
            }
            else if (userType == "Department Head")
            {
                cbType.SelectedIndex = 1;
            }
            else if (userType == "Professor")
            {
                cbType.SelectedIndex = 2;
            }

        }

        public void loadData()
        {
            try
            {
                con.Open();

                string sql = "SELECT account.accountid as Account_Number, account.lname as Last_Name, " +
                    "account.fname as First_Name, account.mname as Middle_Name, sex.sex as Sex, " +
                    "date_format(account.dateOfBirth, '%M %d, %Y') as Birthdate, account.contactNo as Phone, " +
                    "account.email as Email, account.address as Address, account.barangay as Brgy, " +
                    "account.city as City, account.state as State, account.zipCode as Zip_Code, " +
                    "department.dept as Department, account.password as Password, user.usertype as User_Type " +
                    "FROM (((account INNER JOIN sex on account.sexNo = sex.sexNo) " +
                    "INNER JOIN department on account.deptid = department.deptid) " +
                    "INNER JOIN user on account.type = user.type) ORDER BY account.accountid asc;";

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
    }
    }
