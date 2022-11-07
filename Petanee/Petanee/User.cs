using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Npgsql;

namespace Petanee
{
    internal class User
    {
        public NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=ananta;Database=Petanee";
        public static NpgsqlCommand cmd;
        public string sql = null;
        

        private string _username;
        private string _password;
        private string _id;
        public int _loginsecurity;

        public string Username { get { return _username; } set { _username = value; }  }
        public string Password { get { return _password; } set { _password = value; } }
        public string ID { get { return _id; } set { _id = value; } }
        public int Security { get { return _loginsecurity; } set { _loginsecurity = value; } }

        public void Login(string Username, string Password)
        {
            try
            {
                conn = new NpgsqlConnection(connstring);
                conn.Open();
                sql = @"select * from login(:_username,:_sandi)";

                _username = Username;
                _password = Password;
                _loginsecurity = Security;
                _loginsecurity = 0;

                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_username", _username);
                cmd.Parameters.AddWithValue("_sandi", _password);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    _loginsecurity = 1;
                    MessageBox.Show("Berhasil");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Register(string Username, string Password)
        {
            try
            {
                conn = new NpgsqlConnection(connstring);
                conn.Open();
                sql = @"select * from register(:_username,:_sandi)";
                _username = Username;
                _password = Password;

                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_username", _username);
                cmd.Parameters.AddWithValue("_sandi", _password);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Berhasil");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
