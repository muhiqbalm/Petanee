using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Petanee
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form login = new FormLogin();
            this.Hide();
            login.Show();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            User user = new User();

            if (tbPassSU1.Text == tbPassSU2.Text)
            {
                try
                {
                    user.Register(tbUsernameSU.Text, tbPassSU1.Text);
                    Form login = new FormLogin();
                    this.Hide();
                    login.Show();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            else
            {
                MessageBox.Show("Register  Gagal");
            }
            
        }
    }
}
