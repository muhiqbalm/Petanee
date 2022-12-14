namespace Petanee
{
    partial class FormGetRecommendation
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Gambar = new System.Windows.Forms.DataGridViewImageColumn();
            this.rbHias = new System.Windows.Forms.RadioButton();
            this.tbKebun = new System.Windows.Forms.RadioButton();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbLocation = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(79)))), ((int)(((byte)(52)))));
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(594, 92);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(229, 37);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "START";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Gambar});
            this.dataGridView1.Location = new System.Drawing.Point(112, 237);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 200;
            this.dataGridView1.Size = new System.Drawing.Size(705, 330);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Gambar
            // 
            this.Gambar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Gambar.DataPropertyName = "Gambar";
            this.Gambar.HeaderText = "Gambar";
            this.Gambar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Gambar.Name = "Gambar";
            this.Gambar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Gambar.Width = 150;
            // 
            // rbHias
            // 
            this.rbHias.AutoSize = true;
            this.rbHias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.rbHias.Location = new System.Drawing.Point(594, 193);
            this.rbHias.Name = "rbHias";
            this.rbHias.Size = new System.Drawing.Size(106, 19);
            this.rbHias.TabIndex = 4;
            this.rbHias.TabStop = true;
            this.rbHias.Text = "Tanaman Hias";
            this.rbHias.UseVisualStyleBackColor = true;
            this.rbHias.CheckedChanged += new System.EventHandler(this.rbHias_CheckedChanged);
            this.rbHias.Click += new System.EventHandler(this.rbHias_Click);
            // 
            // tbKebun
            // 
            this.tbKebun.AutoSize = true;
            this.tbKebun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.tbKebun.Location = new System.Drawing.Point(711, 193);
            this.tbKebun.Name = "tbKebun";
            this.tbKebun.Size = new System.Drawing.Size(117, 19);
            this.tbKebun.TabIndex = 5;
            this.tbKebun.TabStop = true;
            this.tbKebun.Text = "Tanaman Kebun";
            this.tbKebun.UseVisualStyleBackColor = true;
            this.tbKebun.CheckedChanged += new System.EventHandler(this.tbKebun_CheckedChanged);
            this.tbKebun.Click += new System.EventHandler(this.tbKebun_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(594, 593);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(229, 37);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Reset";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox1.Location = new System.Drawing.Point(153, 192);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(407, 22);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cbLocation
            // 
            this.cbLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.Location = new System.Drawing.Point(114, 97);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(448, 26);
            this.cbLocation.TabIndex = 9;
            // 
            // FormGetRecommendation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.BackgroundImage = global::Petanee.Properties.Resources.form_recommend1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(930, 681);
            this.Controls.Add(this.cbLocation);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.tbKebun);
            this.Controls.Add(this.rbHias);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSubmit);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGetRecommendation";
            this.Text = "FormGetRecommendation";
            this.Load += new System.EventHandler(this.FormGetRecommendation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rbHias;
        private System.Windows.Forms.RadioButton tbKebun;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewImageColumn Gambar;
        private System.Windows.Forms.ComboBox cbLocation;
    }
}