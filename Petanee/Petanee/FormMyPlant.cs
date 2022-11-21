using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Petanee
{
    public partial class FormMyPlant : Form
    {
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=ananta;Database=Petanee";
        public static NpgsqlCommand cmd;
        public string sql = null;

        public FormMyPlant()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            conn = new NpgsqlConnection(connstring);
            conn.Open();
            cmd = new NpgsqlCommand("select Nama, Image from plants", conn);
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
            //DataGridViewImageColumn img1 = new DataGridViewImageColumn();
            //img1 = (DataGridViewImageColumn)dataGridView1.Columns[2];
            //img1.ImageLayout = DataGridViewImageCellLayout.Stretch;

        }

        private void FormMyPlant_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
