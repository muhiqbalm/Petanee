using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Petanee
{
    internal class Location
    {
        public NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=ananta;Database=Petanee";
        public static NpgsqlCommand cmd;
        public string sql = null;

        private string _city;
        private string _country;
        private string _loginusername;

        public void tambahLokasi(string City, string Country, string loginusername)
        {
            try
            {
                conn = new NpgsqlConnection(connstring);
                conn.Open();
                sql = @"select * from insertlocation(:_city,:_country,:_owner)";

                _city = City; ;
                _country = Country;
                _loginusername = loginusername;

                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_city", _city);
                cmd.Parameters.AddWithValue("_country", _country);
                cmd.Parameters.AddWithValue("_owner", _loginusername);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Lokasi berhasil ditambahkan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
