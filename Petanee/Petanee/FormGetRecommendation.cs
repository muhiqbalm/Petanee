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
    public partial class FormGetRecommendation : Form
    {
        public FormGetRecommendation()
        {
            InitializeComponent();
        }


        private void panel2_Click(object sender, EventArgs e)
        {
            Form dashboard = new FormDashboard();
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
    }
}
