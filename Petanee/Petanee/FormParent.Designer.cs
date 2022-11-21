namespace Petanee
{
    partial class FormParent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormParent));
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnHowToUse = new System.Windows.Forms.Button();
            this.btnMyPlant = new System.Windows.Forms.Button();
            this.btnGetRecommend = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelForm = new System.Windows.Forms.Panel();
            this.panelSideBar.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideBar
            // 
            this.panelSideBar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(79)))), ((int)(((byte)(52)))));
            this.panelSideBar.Controls.Add(this.btnSignOut);
            this.panelSideBar.Controls.Add(this.btnHowToUse);
            this.panelSideBar.Controls.Add(this.btnMyPlant);
            this.panelSideBar.Controls.Add(this.btnGetRecommend);
            this.panelSideBar.Controls.Add(this.btnDashboard);
            this.panelSideBar.Controls.Add(this.panelLogo);
            this.panelSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideBar.Location = new System.Drawing.Point(0, 0);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(294, 681);
            this.panelSideBar.TabIndex = 0;
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(79)))), ((int)(((byte)(52)))));
            this.btnSignOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSignOut.FlatAppearance.BorderSize = 0;
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(197)))), ((int)(((byte)(133)))));
            this.btnSignOut.Location = new System.Drawing.Point(0, 599);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(294, 82);
            this.btnSignOut.TabIndex = 8;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // btnHowToUse
            // 
            this.btnHowToUse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(79)))), ((int)(((byte)(52)))));
            this.btnHowToUse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHowToUse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHowToUse.FlatAppearance.BorderSize = 0;
            this.btnHowToUse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHowToUse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHowToUse.Image = global::Petanee.Properties.Resources.menu_howtouse;
            this.btnHowToUse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHowToUse.Location = new System.Drawing.Point(0, 421);
            this.btnHowToUse.Name = "btnHowToUse";
            this.btnHowToUse.Padding = new System.Windows.Forms.Padding(31, 0, 0, 0);
            this.btnHowToUse.Size = new System.Drawing.Size(294, 61);
            this.btnHowToUse.TabIndex = 7;
            this.btnHowToUse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHowToUse.UseVisualStyleBackColor = false;
            this.btnHowToUse.Click += new System.EventHandler(this.btnHowToUse_Click);
            // 
            // btnMyPlant
            // 
            this.btnMyPlant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(79)))), ((int)(((byte)(52)))));
            this.btnMyPlant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMyPlant.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMyPlant.FlatAppearance.BorderSize = 0;
            this.btnMyPlant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyPlant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyPlant.Image = global::Petanee.Properties.Resources.menu_myplant;
            this.btnMyPlant.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyPlant.Location = new System.Drawing.Point(0, 360);
            this.btnMyPlant.Name = "btnMyPlant";
            this.btnMyPlant.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnMyPlant.Size = new System.Drawing.Size(294, 61);
            this.btnMyPlant.TabIndex = 6;
            this.btnMyPlant.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMyPlant.UseVisualStyleBackColor = false;
            this.btnMyPlant.Click += new System.EventHandler(this.btnMyPlant_Click);
            // 
            // btnGetRecommend
            // 
            this.btnGetRecommend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(79)))), ((int)(((byte)(52)))));
            this.btnGetRecommend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetRecommend.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGetRecommend.FlatAppearance.BorderSize = 0;
            this.btnGetRecommend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetRecommend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetRecommend.Image = global::Petanee.Properties.Resources.menu_getrecommend;
            this.btnGetRecommend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGetRecommend.Location = new System.Drawing.Point(0, 299);
            this.btnGetRecommend.Name = "btnGetRecommend";
            this.btnGetRecommend.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnGetRecommend.Size = new System.Drawing.Size(294, 61);
            this.btnGetRecommend.TabIndex = 5;
            this.btnGetRecommend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGetRecommend.UseVisualStyleBackColor = false;
            this.btnGetRecommend.Click += new System.EventHandler(this.btnGetRecommend_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(79)))), ((int)(((byte)(52)))));
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Image = global::Petanee.Properties.Resources.menu_dashboard;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 238);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(294, 61);
            this.btnDashboard.TabIndex = 4;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = global::Petanee.Properties.Resources.logo_2;
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelLogo.Controls.Add(this.panel1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(294, 238);
            this.panelLogo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(300, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 681);
            this.panel1.TabIndex = 1;
            // 
            // panelForm
            // 
            this.panelForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panelForm.Location = new System.Drawing.Point(294, 0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(930, 681);
            this.panelForm.TabIndex = 0;
            this.panelForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelForm_Paint);
            // 
            // FormParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 681);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelSideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormParent";
            this.Text = " Petanee";
            this.panelSideBar.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel panelSideBar;
        private System.Windows.Forms.Button btnGetRecommend;
        private System.Windows.Forms.Button btnHowToUse;
        private System.Windows.Forms.Button btnMyPlant;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Panel panelForm;
    }
}