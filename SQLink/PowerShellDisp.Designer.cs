namespace SQLink
{
    partial class PowerShellDisp
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
            this.InputBox = new System.Windows.Forms.TextBox();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.PSServerIP = new System.Windows.Forms.TextBox();
            this.RDP = new System.Windows.Forms.Button();
            this.execute_remote_button = new System.Windows.Forms.Button();
            this.execute_local_button = new System.Windows.Forms.Button();
            this.Get_logs_button = new System.Windows.Forms.Button();
            this.PSClosewindow = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // InputBox
            // 
            this.InputBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InputBox.Location = new System.Drawing.Point(21, 125);
            this.InputBox.Margin = new System.Windows.Forms.Padding(2);
            this.InputBox.Multiline = true;
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(555, 91);
            this.InputBox.TabIndex = 1;
            this.InputBox.TextChanged += new System.EventHandler(this.InputBox_TextChanged);
            // 
            // OutputBox
            // 
            this.OutputBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OutputBox.Location = new System.Drawing.Point(21, 244);
            this.OutputBox.Margin = new System.Windows.Forms.Padding(2);
            this.OutputBox.Multiline = true;
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(555, 194);
            this.OutputBox.TabIndex = 2;
            this.OutputBox.TextChanged += new System.EventHandler(this.OutputBox_TextChanged);
            // 
            // PSServerIP
            // 
            this.PSServerIP.Dock = System.Windows.Forms.DockStyle.Top;
            this.PSServerIP.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PSServerIP.ForeColor = System.Drawing.Color.Silver;
            this.PSServerIP.Location = new System.Drawing.Point(0, 125);
            this.PSServerIP.Margin = new System.Windows.Forms.Padding(2);
            this.PSServerIP.Multiline = true;
            this.PSServerIP.Name = "PSServerIP";
            this.PSServerIP.Size = new System.Drawing.Size(227, 45);
            this.PSServerIP.TabIndex = 5;
            this.PSServerIP.Text = "Remote Server name";
            this.PSServerIP.TextChanged += new System.EventHandler(this.PSServerIP_TextChanged);
            this.PSServerIP.Enter += new System.EventHandler(this.PSServerIP_Enter);
            this.PSServerIP.Leave += new System.EventHandler(this.PSServerIP_Leave);
            // 
            // RDP
            // 
            this.RDP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.RDP.Dock = System.Windows.Forms.DockStyle.Top;
            this.RDP.FlatAppearance.BorderSize = 0;
            this.RDP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RDP.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RDP.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RDP.Location = new System.Drawing.Point(0, 282);
            this.RDP.Margin = new System.Windows.Forms.Padding(2);
            this.RDP.Name = "RDP";
            this.RDP.Size = new System.Drawing.Size(227, 56);
            this.RDP.TabIndex = 8;
            this.RDP.Text = "Remote Desktop";
            this.RDP.UseVisualStyleBackColor = false;
            this.RDP.Click += new System.EventHandler(this.RDP_Click);
            // 
            // execute_remote_button
            // 
            this.execute_remote_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.execute_remote_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.execute_remote_button.FlatAppearance.BorderSize = 0;
            this.execute_remote_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.execute_remote_button.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.execute_remote_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.execute_remote_button.Location = new System.Drawing.Point(0, 170);
            this.execute_remote_button.Name = "execute_remote_button";
            this.execute_remote_button.Size = new System.Drawing.Size(227, 56);
            this.execute_remote_button.TabIndex = 9;
            this.execute_remote_button.Text = "Execute";
            this.execute_remote_button.UseVisualStyleBackColor = false;
            this.execute_remote_button.Click += new System.EventHandler(this.execute_remote_button_Click);
            // 
            // execute_local_button
            // 
            this.execute_local_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.execute_local_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.execute_local_button.FlatAppearance.BorderSize = 0;
            this.execute_local_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.execute_local_button.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.execute_local_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.execute_local_button.Location = new System.Drawing.Point(0, 338);
            this.execute_local_button.Name = "execute_local_button";
            this.execute_local_button.Size = new System.Drawing.Size(227, 56);
            this.execute_local_button.TabIndex = 10;
            this.execute_local_button.Text = "Local";
            this.execute_local_button.UseVisualStyleBackColor = false;
            this.execute_local_button.Click += new System.EventHandler(this.execute_local_button_Click);
            // 
            // Get_logs_button
            // 
            this.Get_logs_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Get_logs_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Get_logs_button.FlatAppearance.BorderSize = 0;
            this.Get_logs_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Get_logs_button.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Get_logs_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Get_logs_button.Location = new System.Drawing.Point(0, 226);
            this.Get_logs_button.Name = "Get_logs_button";
            this.Get_logs_button.Size = new System.Drawing.Size(227, 56);
            this.Get_logs_button.TabIndex = 11;
            this.Get_logs_button.Text = "Get logs";
            this.Get_logs_button.UseVisualStyleBackColor = false;
            this.Get_logs_button.Click += new System.EventHandler(this.Get_logs_button_Click);
            // 
            // PSClosewindow
            // 
            this.PSClosewindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.PSClosewindow.Dock = System.Windows.Forms.DockStyle.Top;
            this.PSClosewindow.FlatAppearance.BorderSize = 0;
            this.PSClosewindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PSClosewindow.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PSClosewindow.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PSClosewindow.Location = new System.Drawing.Point(0, 394);
            this.PSClosewindow.Margin = new System.Windows.Forms.Padding(2);
            this.PSClosewindow.Name = "PSClosewindow";
            this.PSClosewindow.Size = new System.Drawing.Size(227, 56);
            this.PSClosewindow.TabIndex = 3;
            this.PSClosewindow.Text = "Close";
            this.PSClosewindow.UseVisualStyleBackColor = false;
            this.PSClosewindow.Click += new System.EventHandler(this.PSClosewindow_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PSClosewindow);
            this.panel1.Controls.Add(this.execute_local_button);
            this.panel1.Controls.Add(this.RDP);
            this.panel1.Controls.Add(this.Get_logs_button);
            this.panel1.Controls.Add(this.execute_remote_button);
            this.panel1.Controls.Add(this.PSServerIP);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(593, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 460);
            this.panel1.TabIndex = 12;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 100);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(227, 25);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(227, 100);
            this.panel3.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::SQLink.Properties.Resources.ps_ink_kopia;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(593, 100);
            this.panel2.TabIndex = 13;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(18, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Output";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(18, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Input";
            // 
            // PowerShellDisp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(820, 460);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PowerShellDisp";
            this.Text = "PowerShellDisp";
            this.Load += new System.EventHandler(this.FormPowerShellSample_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PowerShellDisp_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PowerShellDisp_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.TextBox PSServerIP;
        private System.Windows.Forms.Button RDP;
        private System.Windows.Forms.Button execute_remote_button;
        private System.Windows.Forms.Button execute_local_button;
        private System.Windows.Forms.Button Get_logs_button;
        private System.Windows.Forms.TextBox OutputBox;
        private System.Windows.Forms.Button PSClosewindow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}