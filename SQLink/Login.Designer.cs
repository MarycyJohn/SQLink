﻿namespace SQLink
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.ConnectDBbtn = new System.Windows.Forms.Button();
            this.IDtextBox = new System.Windows.Forms.TextBox();
            this.PasstextBox = new System.Windows.Forms.TextBox();
            this.checkBoxAD = new System.Windows.Forms.CheckBox();
            this.srvnamebox = new System.Windows.Forms.TextBox();
            this.dbnamebox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit_login_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ConnectDBbtn
            // 
            this.ConnectDBbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ConnectDBbtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ConnectDBbtn.FlatAppearance.BorderSize = 0;
            this.ConnectDBbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConnectDBbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ConnectDBbtn.ForeColor = System.Drawing.Color.LightGray;
            this.ConnectDBbtn.Location = new System.Drawing.Point(0, 211);
            this.ConnectDBbtn.Name = "ConnectDBbtn";
            this.ConnectDBbtn.Size = new System.Drawing.Size(310, 45);
            this.ConnectDBbtn.TabIndex = 0;
            this.ConnectDBbtn.Text = "Connect";
            this.ConnectDBbtn.UseVisualStyleBackColor = false;
            this.ConnectDBbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // IDtextBox
            // 
            this.IDtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IDtextBox.ForeColor = System.Drawing.Color.Silver;
            this.IDtextBox.Location = new System.Drawing.Point(23, 163);
            this.IDtextBox.Name = "IDtextBox";
            this.IDtextBox.Size = new System.Drawing.Size(127, 22);
            this.IDtextBox.TabIndex = 3;
            this.IDtextBox.Text = "SQL Login";
            this.IDtextBox.TextChanged += new System.EventHandler(this.IDtextBox_TextChanged);
            this.IDtextBox.Enter += new System.EventHandler(this.IDtextBox_Enter);
            this.IDtextBox.Leave += new System.EventHandler(this.IDtextBox_Leave);
            // 
            // PasstextBox
            // 
            this.PasstextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PasstextBox.ForeColor = System.Drawing.Color.Silver;
            this.PasstextBox.Location = new System.Drawing.Point(169, 163);
            this.PasstextBox.Name = "PasstextBox";
            this.PasstextBox.PasswordChar = '*';
            this.PasstextBox.Size = new System.Drawing.Size(127, 22);
            this.PasstextBox.TabIndex = 4;
            this.PasstextBox.Text = "P@ssw0rd";
            this.PasstextBox.TextChanged += new System.EventHandler(this.PasstextBox_TextChanged);
            this.PasstextBox.Enter += new System.EventHandler(this.PasstextBox_Enter);
            this.PasstextBox.Leave += new System.EventHandler(this.PasstextBox_Leave);
            // 
            // checkBoxAD
            // 
            this.checkBoxAD.AutoSize = true;
            this.checkBoxAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxAD.Location = new System.Drawing.Point(169, 103);
            this.checkBoxAD.Name = "checkBoxAD";
            this.checkBoxAD.Size = new System.Drawing.Size(110, 36);
            this.checkBoxAD.TabIndex = 8;
            this.checkBoxAD.Text = "Windows \r\nAuthentication";
            this.checkBoxAD.UseVisualStyleBackColor = true;
            this.checkBoxAD.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // srvnamebox
            // 
            this.srvnamebox.BackColor = System.Drawing.Color.White;
            this.srvnamebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.srvnamebox.ForeColor = System.Drawing.Color.Silver;
            this.srvnamebox.Location = new System.Drawing.Point(23, 89);
            this.srvnamebox.Name = "srvnamebox";
            this.srvnamebox.Size = new System.Drawing.Size(127, 22);
            this.srvnamebox.TabIndex = 10;
            this.srvnamebox.Text = "SQL Server name";
            this.srvnamebox.TextChanged += new System.EventHandler(this.srvnamebox_TextChanged);
            this.srvnamebox.Enter += new System.EventHandler(this.srvnamebox_Enter);
            this.srvnamebox.Leave += new System.EventHandler(this.srvnamebox_Leave);
            // 
            // dbnamebox
            // 
            this.dbnamebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dbnamebox.ForeColor = System.Drawing.Color.Silver;
            this.dbnamebox.Location = new System.Drawing.Point(23, 117);
            this.dbnamebox.Name = "dbnamebox";
            this.dbnamebox.Size = new System.Drawing.Size(127, 22);
            this.dbnamebox.TabIndex = 14;
            this.dbnamebox.Text = "DB name";
            this.dbnamebox.TextChanged += new System.EventHandler(this.dbnamebox_TextChanged);
            this.dbnamebox.Enter += new System.EventHandler(this.dbnamebox_Enter);
            this.dbnamebox.Leave += new System.EventHandler(this.dbnamebox_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.exit_login_button);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 68);
            this.panel1.TabIndex = 19;
            // 
            // exit_login_button
            // 
            this.exit_login_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit_login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.exit_login_button.FlatAppearance.BorderSize = 0;
            this.exit_login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_login_button.Image = global::SQLink.Properties.Resources.exit;
            this.exit_login_button.Location = new System.Drawing.Point(169, 0);
            this.exit_login_button.Name = "exit_login_button";
            this.exit_login_button.Size = new System.Drawing.Size(141, 73);
            this.exit_login_button.TabIndex = 17;
            this.exit_login_button.UseVisualStyleBackColor = false;
            this.exit_login_button.Click += new System.EventHandler(this.exit_login_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SQLink.Properties.Resources.sqlink_kopia;
            this.pictureBox1.Location = new System.Drawing.Point(0, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(310, 256);
            this.Controls.Add(this.dbnamebox);
            this.Controls.Add(this.srvnamebox);
            this.Controls.Add(this.ConnectDBbtn);
            this.Controls.Add(this.checkBoxAD);
            this.Controls.Add(this.PasstextBox);
            this.Controls.Add(this.IDtextBox);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQLink";
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_MouseMove);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ConnectDBbtn;
        private System.Windows.Forms.TextBox IDtextBox;
        private System.Windows.Forms.TextBox PasstextBox;
		private System.Windows.Forms.TextBox srvnamebox;
		private System.Windows.Forms.TextBox dbnamebox;
        public System.Windows.Forms.CheckBox checkBoxAD;
        private System.Windows.Forms.Button exit_login_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}

