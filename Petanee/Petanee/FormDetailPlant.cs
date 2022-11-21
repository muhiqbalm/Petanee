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
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using FontAwesome.Sharp;
using System.Data.SqlClient;

namespace Petanee
{
    partial class FormDetailPlant : Form
    {

        FormGetRecommendation getRec;
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=ananta;Database=Petanee";
        public static NpgsqlCommand cmd;
        public string sql = null;

        public int Index;
        public FormDetailPlant(int index)
        {
            InitializeComponent();
            Index = index;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tanaman berhasil ditambahkan!");
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FormDetailPlant_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            sql = @"select * from plants where id = " + $"{Index}";

            cmd = new NpgsqlCommand(sql, conn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter();
            
            conn.Open();
            using (NpgsqlDataReader dr = cmd.ExecuteReader())
            {
                dr.Read();
                label1.Text = dr["iklim"].ToString();
                label2.Text = dr["kategori"].ToString();
                label3.Text = dr["siram"].ToString();
                label4.Text = dr["panen"].ToString();
                tbDeskripsi.Text = dr["deskripsi"].ToString();
                string pathimage = dr["image"].ToString();
                pbPlant.Image = Image.FromFile(@""+pathimage);
                label5.Text = dr["nama"].ToString();
                label6.Text = dr["nama_latin"].ToString();
                //pbPlant.BackgroundImage = File.ReadAllBytes(dr["image"].ToString());


            }
            conn.Close();
        
        }

        private void tbIklim_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
