using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Npgsql;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Petanee
{
    
    public partial class FormLogin : Form
    {
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=ananta;Password=ananta;Database=Petanee";
        public static NpgsqlCommand cmd;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = new User();
            try
            {
                user.Login(tbUsername.Text, tbPassword.Text);
                if(user.Security == 1)
                {
                    Form dashboard = new FormParent(user);
                    this.Hide();
                    dashboard.Show();
                }
                else
                {
                    tbUsername.Text = tbPassword.Text = "";
                    MessageBox.Show("Username dan Password SALAH!!!");
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            conn.Open();

        }

        private void lbSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form register = new FormRegister();
            this.Hide();
            register.Show();
        }
    }
}
