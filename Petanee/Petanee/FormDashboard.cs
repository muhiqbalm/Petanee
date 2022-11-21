﻿using Npgsql;
using System;
using System.Collections;
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
        private DataGridViewRow r;

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
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                conn.Open();
                lokasi.tambahLokasi(textBox1.Text, textBox2.Text, Pengguna.Username);
                loadData();
            }
            else
            {
                MessageBox.Show("Data Tidak Lengkap");
            }

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dataGridView1.Rows[e.RowIndex];
            }
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            loadData();
            conn.Open();
        }
        public void loadData()
        {
            conn = new NpgsqlConnection(connstring);
            cmd = new NpgsqlCommand("select id, kota, negara from location where pemilik like " + $"'%{Pengguna.Username}%'", conn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Pilih data yang akan dihapus");
                return;
            }
            try
            {
                /*sql = @"select * from deletelocation(:_id)";
                cmd = new NpgsqlCommand(sql,conn);
                cmd.Parameters.AddWithValue("_id", r.Cells["_id"].Value.ToString());
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Lokasi Berhasil dihapus");
                    r=null;
                }*/

                NpgsqlCommand cmd = new NpgsqlCommand("Delete from location where id=" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "", conn);
                cmd.ExecuteNonQuery();
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                MessageBox.Show("Berhasil");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}