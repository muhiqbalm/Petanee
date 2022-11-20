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
            this.tbLocation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbLocation
            // 
            this.tbLocation.BackColor = System.Drawing.Color.White;
            this.tbLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLocation.Location = new System.Drawing.Point(14, 14);
            this.tbLocation.Margin = new System.Windows.Forms.Padding(5);
            this.tbLocation.Multiline = true;
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Size = new System.Drawing.Size(566, 23);
            this.tbLocation.TabIndex = 1;
            // 
            // FormGetRecommendation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 642);
            this.Controls.Add(this.tbLocation);
            this.Name = "FormGetRecommendation";
            this.Text = "FormGetRecommendation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLocation;
    }
}