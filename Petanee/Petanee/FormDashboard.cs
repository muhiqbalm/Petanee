using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Petanee
{
    partial class FormDashboard : Form
    {
        public NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=ananta;Database=Petanee";
        public static NpgsqlCommand cmd;
        public string sql = null;
        public User Pengguna;

        public FormDashboard(User pengguna)
        {
            InitializeComponent();

            Pengguna = pengguna;
            string username = Pengguna.Username;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Form login = new FormLogin();
            this.Hide();
            login.Show();
        }


        private void panel2_Click(object sender, EventArgs e)
        {
            Form getrecommendation = new FormGetRecommendation();
            this.Hide();
            getrecommendation.Show();
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Location lokasi = new Location();
            lokasi.tambahLokasi(textBox1.Text, textBox2.Text, Pengguna.Username);
        }
    }
}
