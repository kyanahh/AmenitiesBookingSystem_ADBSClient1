using GroupProjectADBS.UserControls;
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
    public partial class Bookings : Form
    {

        MySqlConnection con = new MySqlConnection("datasource=localhost;username=root;password=;database=amenityreservation;");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader dtr;

        public Bookings(string username)
        {
            InitializeComponent();
            lblStudID.Text = username;
        }

        private void AddUserControl(UserControl uc)
        {
            usercontrolpanel.Controls.Clear();
            usercontrolpanel.Controls.Add(uc);
        }

        private void pbLogout_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to log out?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
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

        private void lblProfile_Click(object sender, EventArgs e)
        {
            Profile ucProfile = new Profile(lblStudID.Text);
            AddUserControl(ucProfile);
        }

        private void lblBookings_Click(object sender, EventArgs e)
        {
            Book ucBook = new Book(lblStudID.Text);
            AddUserControl(ucBook);
        }

        private void lblHMS2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
