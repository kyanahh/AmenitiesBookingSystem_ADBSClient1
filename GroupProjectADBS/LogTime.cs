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
    public partial class LogTime : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;username=root;password=;database=amenityreservation;");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader dtr;
        public string username;

        public LogTime(string username)
        {
            InitializeComponent();

            cbSearch.SelectedIndex = 0;
            lblUser.Text = username;

            this.username = username;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AdminMain admin = new AdminMain(username);
            admin.Show();
            this.Visible = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cbSearch.SelectedIndex = 0;
            loadData();
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

        public void loadData()
        {
            try
            {
                con.Open();

                string sql = "SELECT log.accountid as Account_Number, log_time as Login_Time FROM account INNER JOIN log on account.accountid = log.accountid";
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "";
                con.Open();

                if (cbSearch.Text == "Account Number")
                {
                    sql = "SELECT log.accountid as Account_Number, log_time as Login_Time FROM account " +
                        "INNER JOIN log on account.accountid = log.accountid " +
                        "WHERE account.accountid = " + txtSearch.Text + " ";
                }

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

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            AdminMain admin = new AdminMain(username);
            admin.Show();
            this.Visible = false;
        }

        private void LogTime_Load_1(object sender, EventArgs e)
        {
            loadData();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
