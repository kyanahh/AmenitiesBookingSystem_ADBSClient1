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
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using LiveCharts.WinForms;

namespace GroupProjectADBS
{
    public partial class Graphs2 : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;username=root;password=;database=amenityreservation;");

        public string username;

        public Graphs2(string username)
        {
            InitializeComponent();

            this.username = username;

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

        private void Graphs2_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                // Retrieve weekly reservations for each amenity
                string query = "SELECT amenityID, YEAR(resDate) AS Year, MONTH(resDate) AS Month, WEEK(resDate) AS Week, COUNT(*) AS ReservationCount " +
                               "FROM reservation " +
                               "GROUP BY amenityID, YEAR(resDate), MONTH(resDate), WEEK(resDate)";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                // Create a dictionary to store the weekly reservations for each amenity
                Dictionary<int, Dictionary<int, List<ObservableValue>>> amenityData = new Dictionary<int, Dictionary<int, List<ObservableValue>>>();

                // Create a list to store the x-axis labels (week numbers)
                List<string> xLabels = new List<string>();

                // Initialize the amenityData dictionary with empty dictionaries for each amenity and month
                for (int amenityID = 1; amenityID <= 13; amenityID++)
                {
                    amenityData[amenityID] = new Dictionary<int, List<ObservableValue>>();
                }

                // Loop through the data reader and populate the amenityData dictionary
                while (reader.Read())
                {
                    int amenityID = reader.GetInt32("amenityID");
                    int month = reader.GetInt32("Month");
                    int week = reader.GetInt32("Week");
                    int reservationCount = reader.GetInt32("ReservationCount");

                    if (!amenityData[amenityID].ContainsKey(month))
                    {
                        amenityData[amenityID][month] = new List<ObservableValue>();
                    }

                    amenityData[amenityID][month].Add(new ObservableValue(reservationCount));
                }

                // Create the series collection for the line chart
                SeriesCollection seriesCollection = new SeriesCollection();

                // Create a LineSeries for each amenity and month and add it to the series collection
                foreach (var kvpAmenity in amenityData)
                {
                    int amenityID = kvpAmenity.Key;
                    Dictionary<int, List<ObservableValue>> monthData = kvpAmenity.Value;

                    // Add the amenity label to the x-axis labels list
                    xLabels.Add(GetAmenityLabel(amenityID));

                    foreach (var kvpMonth in monthData)
                    {
                        int month = kvpMonth.Key;
                        List<ObservableValue> data = kvpMonth.Value;

                        LineSeries lineSeries = new LineSeries
                        {
                            Title = GetAmenityLabel(amenityID) + " (Month " + month + ")",
                            Values = new ChartValues<ObservableValue>(data),
                            PointGeometrySize = 10
                        };

                        seriesCollection.Add(lineSeries);
                    }
                }

                // Create the chart
                LiveCharts.WinForms.CartesianChart chart = new LiveCharts.WinForms.CartesianChart
                {
                    Series = seriesCollection,
                    LegendLocation = LegendLocation.Right,
                    Dock = DockStyle.Fill
                };

                // Set the x-axis labels
                chart.AxisX.Add(new Axis
                {
                    Labels = xLabels
                });

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

        private void pbCharts_Click(object sender, EventArgs e)
        {
            Graphs graphs = new Graphs(username);
            graphs.Show();
            this.Visible = false;
        }
    }
}
