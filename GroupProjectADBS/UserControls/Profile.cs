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
    public partial class Profile : UserControl
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;username=root;password=;database=amenityreservation;");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader dtr;

        public Profile(string username)
        {
            InitializeComponent();
            txtAccountNumber.Text = username;
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string sql = "SELECT account.accountid, account.lname, account.fname, account.mname, " +
                    "sex.sex, account.dateOfBirth, account.contactNo, account.email, " +
                    "account.address, account.barangay, account.city, account.state, " +
                    "account.zipCode, department.dept, user.usertype " +
                    "FROM ((( account " +
                    "INNER JOIN sex on account.sexNo = sex.sexNo) " +
                    "INNER JOIN department on account.deptid = department.deptid) " +
                    "INNER JOIN user on account.type = user.type) " +
                    "WHERE account.accountid = " + txtAccountNumber.Text + " ORDER BY account.accountid asc;";

                cmd = new MySqlCommand(sql, con);
                dtr = cmd.ExecuteReader();

                while (dtr.Read())
                {
                    txtAccountNumber.Text = dtr.GetValue(0).ToString();
                    txtLname.Text = dtr.GetValue(1).ToString();
                    txtFname.Text = dtr.GetValue(2).ToString();
                    txtMname.Text = dtr.GetValue(3).ToString();
                    txtSex.Text = dtr.GetValue(4).ToString();
                    txtBday.Text = dtr.GetValue(5).ToString();
                    txtPhone.Text = dtr.GetValue(6).ToString();
                    txtEmail.Text = dtr.GetValue(7).ToString();
                    txtAddress.Text = dtr.GetValue(8).ToString();
                    txtBrgy.Text = dtr.GetValue(9).ToString();
                    txtCity.Text = dtr.GetValue(10).ToString();
                    txtState.Text = dtr.GetValue(11).ToString();
                    txtZip.Text = dtr.GetValue(12).ToString();
                    txtDepartment.Text = dtr.GetValue(13).ToString();
                    txtType.Text = dtr.GetValue(14).ToString();
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
    }
}
