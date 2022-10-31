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
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Form login = new FormLogin();
            this.Hide();
            login.Show();
        }
    }
}
