namespace Project
{
    partial class Settings
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTheme = new System.Windows.Forms.ComboBox();
            this.btnAppPass = new Guna.UI2.WinForms.Guna2Button();
            this.btnAppTheme = new Guna.UI2.WinForms.Guna2Button();
            this.lblReset_1 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.picSet = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.picSet);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 338);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(278, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "SETTINGS ";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.White;
            this.lblUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.Green;
            this.lblUser.Location = new System.Drawing.Point(152, 92);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(203, 26);
            this.lblUser.TabIndex = 9;
            this.lblUser.Text = "Admin New Password ";
            // 
            // txtNewPass
            // 
            this.txtNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass.Location = new System.Drawing.Point(152, 121);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(273, 26);
            this.txtNewPass.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(152, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "Theme";
            // 
            // cmbTheme
            // 
            this.cmbTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTheme.FormattingEnabled = true;
            this.cmbTheme.Items.AddRange(new object[] {
            "Gold",
            "Crimson",
            "Default"});
            this.cmbTheme.Location = new System.Drawing.Point(152, 219);
            this.cmbTheme.Name = "cmbTheme";
            this.cmbTheme.Size = new System.Drawing.Size(273, 28);
            this.cmbTheme.TabIndex = 14;
            // 
            // btnAppPass
            // 
            this.btnAppPass.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAppPass.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAppPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAppPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAppPass.FillColor = System.Drawing.Color.Silver;
            this.btnAppPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAppPass.Location = new System.Drawing.Point(475, 112);
            this.btnAppPass.Name = "btnAppPass";
            this.btnAppPass.Size = new System.Drawing.Size(113, 35);
            this.btnAppPass.TabIndex = 25;
            this.btnAppPass.Text = "APPLY";
            this.btnAppPass.Click += new System.EventHandler(this.btnAppPass_Click);
            // 
            // btnAppTheme
            // 
            this.btnAppTheme.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAppTheme.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAppTheme.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAppTheme.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAppTheme.FillColor = System.Drawing.Color.Silver;
            this.btnAppTheme.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppTheme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAppTheme.Location = new System.Drawing.Point(475, 212);
            this.btnAppTheme.Name = "btnAppTheme";
            this.btnAppTheme.Size = new System.Drawing.Size(113, 35);
            this.btnAppTheme.TabIndex = 27;
            this.btnAppTheme.Text = "APPLY";
            this.btnAppTheme.Click += new System.EventHandler(this.btnAppTheme_Click);
            // 
            // lblReset_1
            // 
            this.lblReset_1.AutoSize = true;
            this.lblReset_1.BackColor = System.Drawing.Color.White;
            this.lblReset_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblReset_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReset_1.ForeColor = System.Drawing.Color.Green;
            this.lblReset_1.Location = new System.Drawing.Point(307, 284);
            this.lblReset_1.Name = "lblReset_1";
            this.lblReset_1.Size = new System.Drawing.Size(118, 35);
            this.lblReset_1.TabIndex = 28;
            this.lblReset_1.Text = "RESET";
            this.lblReset_1.Click += new System.EventHandler(this.lblReset_1_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Project.Properties.Resources.cross_image;
            this.pictureBox5.Location = new System.Drawing.Point(577, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(49, 35);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 24;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // picSet
            // 
            this.picSet.Image = global::Project.Properties.Resources.Files;
            this.picSet.Location = new System.Drawing.Point(3, 12);
            this.picSet.Name = "picSet";
            this.picSet.Size = new System.Drawing.Size(128, 94);
            this.picSet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSet.TabIndex = 10;
            this.picSet.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project.Properties.Resources._3114883;
            this.pictureBox1.Location = new System.Drawing.Point(137, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 338);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblReset_1);
            this.Controls.Add(this.btnAppTheme);
            this.Controls.Add(this.btnAppPass);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.cmbTheme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTheme;
        private System.Windows.Forms.PictureBox pictureBox5;
        private Guna.UI2.WinForms.Guna2Button btnAppPass;
        private Guna.UI2.WinForms.Guna2Button btnAppTheme;
        private System.Windows.Forms.Label lblReset_1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}