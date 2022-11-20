using Newtonsoft.Json;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Petanee
{
    public partial class FormGetRecommendation : Form
    {
        public string climate;
        public DataTable dt;

        public NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=ananta;Database=Petanee";
        public static NpgsqlCommand cmd;
        public string sql = null;

        public FormGetRecommendation()
        {
            InitializeComponent();
        }
        public string getClimate()
        {
            using (WebClient web = new WebClient())
            {
                string APIKEY = "758e555ef1dd0283ebba5f279e357b35";
                string fullURL = "https://api.openweathermap.org/data/2.5/weather?appid=" + APIKEY + "&q=" + tbSelectLocation.Text;
                string url = string.Format(fullURL);
                var json = web.DownloadString(url);

                Weather.root Info = JsonConvert.DeserializeObject<Weather.root>(json);
                string longitude = Info.coord.lon.ToString();
                string latitude = Info.coord.lat.ToString();

                float floatLatitude = float.Parse(latitude);
                float absLatitude = Math.Abs(floatLatitude);

                if (absLatitude < 66.5 && absLatitude >= 40)
                {
                    climate = "Temperate";
                }
                else if (absLatitude < 40 && absLatitude >= 23.4)
                {
                    climate = "Subtropic";
                }
                else if (absLatitude <= 23.4 && absLatitude >= 0)
                {
                    climate = "Tropic";
                }
                else
                {
                    climate = "Polar";
                }
            }
            return climate;

        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Form dashboard = new FormDashboard();
            this.Hide();
            dashboard.Show();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Form login = new FormLogin();
            this.Hide();
            login.Show();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            Form myplant = new FormMyPlant();
            this.Hide();
            myplant.Show();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            Form howtouse = new FormUse();
            this.Hide();
            howtouse.Show();
        }

        private void FormGetRecommendation_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            conn.Open();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            getClimate();
            try
            {


                dataGridView1.DataSource = null;
                string sqlqueryclimate = $"'%{climate}%'";
                sql = @"select * from plants where iklim like " + sqlqueryclimate;
                /*  sql = @"select * from plants";*/
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dataGridView1.DataSource = dt;
            }
            catch
            {

            }
            


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
