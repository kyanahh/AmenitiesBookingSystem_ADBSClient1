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
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.WinForms;




namespace GroupProjectADBS
{
    public partial class Graphs : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;username=root;password=;database=amenityreservation;");

        public string username;

        public Graphs(string username)
        {
            InitializeComponent();

            this.username = username;
        }

        private void Graphs_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                // Set the form's backcolor to 'Control'
                BackColor = SystemColors.Control;

                // Get the weekly reservations for each amenity
                string query = "SELECT amenityID, COUNT(*) AS ReservationCount FROM reservation " +
                               "WHERE resDate >= CURDATE() - INTERVAL DAYOFWEEK(CURDATE())-1 DAY " +
                               "GROUP BY amenityID";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                // Create the series collection for the pie chart
                SeriesCollection seriesCollection = new SeriesCollection();

                // Loop through the data reader and create a PieSeries for each amenity
                while (reader.Read())
                {
                    // Get the amenity ID and reservation count
                    int amenityID = reader.GetInt32("amenityID");
                    double reservationCount = reader.GetInt32("ReservationCount");

                    // Create a PieSeries for the amenity
                    PieSeries pieSeries = new PieSeries
                    {
                        Title = GetAmenityLabel(amenityID),
                        Values = new ChartValues<double> { reservationCount },
                        DataLabels = true
                    };

                    // Add the PieSeries to the series collection
                    seriesCollection.Add(pieSeries);
                }

                // Create the chart
                LiveCharts.WinForms.PieChart chart = new LiveCharts.WinForms.PieChart
                {
                    Series = seriesCollection,
                    LegendLocation = LegendLocation.Right,
                    Dock = DockStyle.Fill
                };

                // Set the chart size and location
                chart.Size = new Size(1058, 564);
                chart.Location = new Point(152, 93);

                // Add the chart to the form
                Controls.Add(chart);

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // Helper method to get the label for an amenity based on its ID
        private string GetAmenityLabel(int amenityID)
        {
            switch (amenityID)
            {
                case 1:
                    return "Computer Laboratory 1";
                case 2:
                    return "Computer Laboratory 2";
                case 3:
                    return "Computer Laboratory 3";
                case 4:
                    return "Computer Laboratory 4";
                case 5:
                    return "Computer Laboratory 5";
                case 6:
                    return "Computer Laboratory 6";
                case 7:
                    return "Speech Laboratory";
                case 8:
                    return "Biology Room";
                case 9:
                    return "Theater Room";
                case 10:
                    return "Kinetics Room";
                case 11:
                    return "Chapel";
                case 12:
                    return "Gymnasium";
                case 13:
                    return "Music Room";

                default:
                    return "Unknown Amenity";
            }
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

        private void pbCharts_Click_1(object sender, EventArgs e)
        {
            Graphs2 graphs = new Graphs2(username);
            graphs.Show();
            this.Visible = false;
        }
    }
}
