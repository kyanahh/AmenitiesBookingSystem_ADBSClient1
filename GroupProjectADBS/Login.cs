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


namespace GroupProjectADBS
{
    public partial class Login : Form
    {

        MySqlConnection con = new MySqlConnection("datasource=localhost;username=root;password=;database=amenityreservation;");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader dtr;

        public Login()
        {
            InitializeComponent();
        }

        private void txtStudID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void lblForgot_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please contact admin to reset password", "Forgot Password", MessageBoxButtons.OK);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sql = "SELECT * FROM account where accountid = '" + txtAccountNumber.Text + "' AND password = '" + txtPass.Text + "'";
                cmd = new MySqlCommand(sql, con);
                dtr = cmd.ExecuteReader();


                DateTime now = DateTime.Now;

                if (dtr.Read()) 
                {
                    string type = dtr.GetValue(15).ToString();

                    dtr.Close();

                    string sql2 = "INSERT INTO log(log_time, accountid) VALUES('" + now.ToString() + "', '" + txtAccountNumber.Text + "')";
                    MySqlCommand cmd2 = new MySqlCommand(sql2, con);
                    MySqlDataReader dtr2 = cmd2.ExecuteReader();

                    if (type == "1")
                    {
                        AdminMain admin = new AdminMain(txtAccountNumber.Text);
                        admin.Show();
                        this.Visible = false;
                    }
                    else if(type == "2")
                    {
                        AdminMain admin = new AdminMain(txtAccountNumber.Text);
                        admin.Show();
                        this.Visible = false;
                        admin.btnLog.Enabled = false;
                        admin.btnCreate.Enabled = false;

                    }else if(type == "3")
                    {
                        Bookings book = new Bookings(txtAccountNumber.Text);
                        book.Show();
                        this.Visible = false;
                    }
                }
                else
                {
                    lblWrong.Text = "The account number/password you entered is incorrect";
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
