using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petanee
{
    partial class FormUse : Form
    {
        public User Pengguna;
        public FormUse()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Form login = new FormLogin();
            this.Hide();
            login.Show();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            Form dashboard = new FormDashboard(Pengguna);
            this.Hide();
            dashboard.Show();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Form getrecommendation = new FormGetRecommendation(Pengguna);
            this.Hide();
            getrecommendation.Show();
        }
    }
}
