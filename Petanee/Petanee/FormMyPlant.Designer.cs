namespace Petanee
{
    partial class FormMyPlant
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelPlant = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(150, 970);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(95, 30);
            this.panel1.TabIndex = 1;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(1, 317);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(399, 81);
            this.panel2.TabIndex = 2;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(1, 404);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(399, 81);
            this.panel3.TabIndex = 2;
            this.panel3.Click += new System.EventHandler(this.panel3_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Location = new System.Drawing.Point(0, 585);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(399, 81);
            this.panel5.TabIndex = 3;
            this.panel5.Click += new System.EventHandler(this.panel5_Click);
            // 
            // panelPlant
            // 
            this.panelPlant.Location = new System.Drawing.Point(484, 148);
            this.panelPlant.Name = "panelPlant";
            this.panelPlant.Size = new System.Drawing.Size(238, 301);
            this.panelPlant.TabIndex = 4;
            this.panelPlant.Click += new System.EventHandler(this.panelPlant_Click);
            // 
            // FormMyPlant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Petanee.Properties.Resources.my_plant;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panelPlant);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormMyPlant";
            this.Text = "FormMyPlant";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panelPlant;
    }
}