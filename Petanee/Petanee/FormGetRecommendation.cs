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
using System.IO;
using System.Collections;


namespace Petanee
{
    partial class FormGetRecommendation : Form
    {
        public User Pengguna;

        public string climate;
        public DataTable dt;

        public NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=ananta;Database=Petanee";
        public static NpgsqlCommand cmd;
        public string sql = null;

        public DataGridViewRow r;

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
            Form dashboard = new FormDashboard(Pengguna);
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
            GetRecommendation("select Id, Nama, Iklim, Kategori, Image from plants where iklim like ");
            rbHias.Checked = tbKebun.Checked = false;
        }

        bool isHiasChecked = false;
        bool isKebunChecked = false;
        private void rbHias_CheckedChanged(object sender, EventArgs e)
        {
            isHiasChecked = rbHias.Checked;
        }

        private void GetRecommendation(string query)
        {
            try
            {
                conn = new NpgsqlConnection(connstring);
                string sqlqueryclimate = $"'%{climate}%'";
                //cmd = new NpgsqlCommand("select Nama, Iklim, Image from plants where iklim like " + sqlqueryclimate, conn);
                cmd = new NpgsqlCommand(query + $"'%{climate}%'", conn);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                dt.Clear();
                da.Fill(dt);
                dt.Columns.Add("Gambar", Type.GetType("System.Byte[]"));
                foreach (DataRow dr in dt.Rows)
                {
                    dr["Gambar"] = File.ReadAllBytes(dr["Image"].ToString());
                }
                dataGridView1.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Terjadi Error, Mungkin Lokasi yang Anda Masukkan Salah!");
            }
        }

        private void rbHias_Click(object sender, EventArgs e)
        {
            if (rbHias.Checked && !isHiasChecked)
            {
                rbHias.Checked = false;
                GetRecommendation("select Nama, Iklim, Kategori, Image from plants where iklim like ");
            }

            else
            {
                GetRecommendation("select Nama, Iklim, Kategori, Image from plants where kategori = 'Hias' and iklim like ");
                rbHias.Checked = true;
                isHiasChecked = false;
                tbKebun.Checked = false;
            }
        }

        private void tbKebun_CheckedChanged(object sender, EventArgs e)
        {
            isKebunChecked = tbKebun.Checked;
        }

        private void tbKebun_Click(object sender, EventArgs e)
        {
            if (tbKebun.Checked && !isKebunChecked)
            {
                tbKebun.Checked = false;
                GetRecommendation("select Nama, Iklim, Kategori, Image from plants where iklim like ");
            }

            else
            {
                GetRecommendation("select Nama, Iklim, Kategori, Image from plants where kategori = 'Kebun' and iklim like ");
                tbKebun.Checked = true;
                isKebunChecked = false;
                rbHias.Checked = false;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            tbSelectLocation.Text = "";
            rbHias.Checked = tbKebun.Checked = false;
            textBox1.Text = "";
        }

        //Search With TextBox
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(rbHias.Checked)
            {
                conn = new NpgsqlConnection(connstring);
                string sqlqueryclimate = $"'%{climate}%'";
                cmd = new NpgsqlCommand("select Nama, Iklim, Kategori, Image from plants where kategori = 'Hias' and iklim like " + sqlqueryclimate + " and Nama like " + $"'%{textBox1.Text}%'", conn);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                dt.Clear();
                da.Fill(dt);
                dt.Columns.Add("Gambar", Type.GetType("System.Byte[]"));
                foreach (DataRow dr in dt.Rows)
                {
                    dr["Gambar"] = File.ReadAllBytes(dr["Image"].ToString());
                }
                dataGridView1.DataSource = dt;
            }
            else if(tbKebun.Checked)
            {
                conn = new NpgsqlConnection(connstring);
                string sqlqueryclimate = $"'%{climate}%'";
                cmd = new NpgsqlCommand("select Nama, Iklim, Kategori, Image from plants where kategori = 'Kebun' and iklim like " + sqlqueryclimate + " and Nama like " + $"'%{textBox1.Text}%'", conn);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                dt.Clear();
                da.Fill(dt);
                dt.Columns.Add("Gambar", Type.GetType("System.Byte[]"));
                foreach (DataRow dr in dt.Rows)
                {
                    dr["Gambar"] = File.ReadAllBytes(dr["Image"].ToString());
                }
                dataGridView1.DataSource = dt;
            }
            else
            {
                conn = new NpgsqlConnection(connstring);
                string sqlqueryclimate = $"'%{climate}%'";
                cmd = new NpgsqlCommand("select Nama, Iklim, Kategori, Image from plants where iklim like " + sqlqueryclimate + " and Nama like " + $"'%{textBox1.Text}%'", conn);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                dt.Clear();
                da.Fill(dt);
                dt.Columns.Add("Gambar", Type.GetType("System.Byte[]"));
                foreach (DataRow dr in dt.Rows)
                {
                    dr["Gambar"] = File.ReadAllBytes(dr["Image"].ToString());
                }
                dataGridView1.DataSource = dt;
            }
        }

        public void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dataGridView1.Rows[e.RowIndex];
                string index = r.Cells["id"].Value.ToString();
                int index2 = int.Parse(index);
                FormDetailPlant detailPlant = new FormDetailPlant(index2);
                detailPlant.Show();
            }
        }
    }
}
