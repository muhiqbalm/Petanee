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
    partial class FormParent : Form
    {
        public User Pengguna;
        public FormParent(User pengguna)
        {
            InitializeComponent();

            Pengguna = pengguna;
            string username = Pengguna.Username;

            loadForm(new FormHowToUse());
            btnHowToUse.BackColor = Color.FromArgb(3, 59, 39);
        }

        public void loadForm(object Form)
        {
            if (this.panelForm.Controls.Count > 0)
                this.panelForm.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelForm.Controls.Add(f);
            this.panelForm.Tag = f;
            f.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            btnHowToUse.BackColor = btnGetRecommend.BackColor = Color.FromArgb(4, 79, 52);
            btnDashboard.BackColor = Color.FromArgb(3, 59, 39);
            loadForm(new FormDashboard(Pengguna));
        }

        private void btnHowToUse_Click(object sender, EventArgs e)
        {
            loadForm(new FormHowToUse());
            btnDashboard.BackColor = btnGetRecommend.BackColor = Color.FromArgb(4, 79, 52);
            btnHowToUse.BackColor = Color.FromArgb(3, 59, 39);
        }

        private void btnGetRecommend_Click(object sender, EventArgs e)
        {
            loadForm(new FormGetRecommendation(Pengguna));
            btnDashboard.BackColor = btnHowToUse.BackColor = Color.FromArgb(4, 79, 52);
            btnGetRecommend.BackColor = Color.FromArgb(3, 59, 39);
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Form login = new FormLogin();
            this.Hide();
            login.Show();
        }

        private void panelForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
