namespace Petanee
{
    partial class FormRegister
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.tbUsernameSU = new System.Windows.Forms.TextBox();
            this.tbPassSU1 = new System.Windows.Forms.TextBox();
            this.tbPassSU2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(1024, 766);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(54, 16);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sign In";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(155)))), ((int)(((byte)(109)))));
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(730, 692);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(460, 52);
            this.btnSignUp.TabIndex = 1;
            this.btnSignUp.Text = "Create Account";
            this.btnSignUp.UseVisualStyleBackColor = false;
            // 
            // tbUsernameSU
            // 
            this.tbUsernameSU.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUsernameSU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsernameSU.Location = new System.Drawing.Point(745, 416);
            this.tbUsernameSU.Name = "tbUsernameSU";
            this.tbUsernameSU.Size = new System.Drawing.Size(430, 20);
            this.tbUsernameSU.TabIndex = 2;
            // 
            // tbPassSU1
            // 
            this.tbPassSU1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassSU1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassSU1.Location = new System.Drawing.Point(745, 522);
            this.tbPassSU1.Name = "tbPassSU1";
            this.tbPassSU1.Size = new System.Drawing.Size(430, 20);
            this.tbPassSU1.TabIndex = 3;
            // 
            // tbPassSU2
            // 
            this.tbPassSU2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassSU2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassSU2.Location = new System.Drawing.Point(745, 625);
            this.tbPassSU2.Name = "tbPassSU2";
            this.tbPassSU2.Size = new System.Drawing.Size(430, 20);
            this.tbPassSU2.TabIndex = 4;
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Petanee.Properties.Resources.sign_up;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.tbPassSU2);
            this.Controls.Add(this.tbPassSU1);
            this.Controls.Add(this.tbUsernameSU);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.linkLabel1);
            this.Name = "FormRegister";
            this.Text = "FormRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.TextBox tbUsernameSU;
        private System.Windows.Forms.TextBox tbPassSU1;
        private System.Windows.Forms.TextBox tbPassSU2;
    }
}