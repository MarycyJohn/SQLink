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
            this.PSClosewindow = new System.Windows.Forms.Button();
            this.PSServerIP = new System.Windows.Forms.TextBox();
            this.RDP = new System.Windows.Forms.Button();
            this.execute_remote_button = new System.Windows.Forms.Button();
            this.execute_local_button = new System.Windows.Forms.Button();
            this.Get_logs_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputBox
            // 
            this.InputBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputBox.Location = new System.Drawing.Point(9, 10);
            this.InputBox.Margin = new System.Windows.Forms.Padding(2);
            this.InputBox.Multiline = true;
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(567, 166);
            this.InputBox.TabIndex = 1;
            this.InputBox.TextChanged += new System.EventHandler(this.InputBox_TextChanged);
            // 
            // OutputBox
            // 
            this.OutputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputBox.Location = new System.Drawing.Point(9, 224);
            this.OutputBox.Margin = new System.Windows.Forms.Padding(2);
            this.OutputBox.Multiline = true;
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(652, 199);
            this.OutputBox.TabIndex = 2;
            this.OutputBox.TextChanged += new System.EventHandler(this.OutputBox_TextChanged);
            // 
            // PSClosewindow
            // 
            this.PSClosewindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PSClosewindow.Location = new System.Drawing.Point(604, 10);
            this.PSClosewindow.Margin = new System.Windows.Forms.Padding(2);
            this.PSClosewindow.Name = "PSClosewindow";
            this.PSClosewindow.Size = new System.Drawing.Size(56, 19);
            this.PSClosewindow.TabIndex = 3;
            this.PSClosewindow.Text = "Close";
            this.PSClosewindow.UseVisualStyleBackColor = true;
            this.PSClosewindow.Click += new System.EventHandler(this.PSClosewindow_Click);
            // 
            // PSServerIP
            // 
            this.PSServerIP.Location = new System.Drawing.Point(10, 181);
            this.PSServerIP.Margin = new System.Windows.Forms.Padding(2);
            this.PSServerIP.Multiline = true;
            this.PSServerIP.Name = "PSServerIP";
            this.PSServerIP.Size = new System.Drawing.Size(105, 39);
            this.PSServerIP.TabIndex = 5;
            this.PSServerIP.TextChanged += new System.EventHandler(this.PSServerIP_TextChanged);
            // 
            // RDP
            // 
            this.RDP.Location = new System.Drawing.Point(602, 159);
            this.RDP.Margin = new System.Windows.Forms.Padding(2);
            this.RDP.Name = "RDP";
            this.RDP.Size = new System.Drawing.Size(58, 48);
            this.RDP.TabIndex = 8;
            this.RDP.Text = "Remote Desktop";
            this.RDP.UseVisualStyleBackColor = true;
            this.RDP.Click += new System.EventHandler(this.RDP_Click);
            // 
            // execute_remote_button
            // 
            this.execute_remote_button.Location = new System.Drawing.Point(604, 97);
            this.execute_remote_button.Name = "execute_remote_button";
            this.execute_remote_button.Size = new System.Drawing.Size(56, 23);
            this.execute_remote_button.TabIndex = 9;
            this.execute_remote_button.Text = "Execute";
            this.execute_remote_button.UseVisualStyleBackColor = true;
            this.execute_remote_button.Click += new System.EventHandler(this.execute_remote_button_Click);
            // 
            // execute_local_button
            // 
            this.execute_local_button.Location = new System.Drawing.Point(602, 126);
            this.execute_local_button.Name = "execute_local_button";
            this.execute_local_button.Size = new System.Drawing.Size(54, 23);
            this.execute_local_button.TabIndex = 10;
            this.execute_local_button.Text = "Local";
            this.execute_local_button.UseVisualStyleBackColor = true;
            this.execute_local_button.Click += new System.EventHandler(this.execute_local_button_Click);
            // 
            // Get_logs_button
            // 
            this.Get_logs_button.Location = new System.Drawing.Point(602, 68);
            this.Get_logs_button.Name = "Get_logs_button";
            this.Get_logs_button.Size = new System.Drawing.Size(59, 23);
            this.Get_logs_button.TabIndex = 11;
            this.Get_logs_button.Text = "Get logs";
            this.Get_logs_button.UseVisualStyleBackColor = true;
            this.Get_logs_button.Click += new System.EventHandler(this.Get_logs_button_Click);
            // 
            // PowerShellDisp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 432);
            this.Controls.Add(this.Get_logs_button);
            this.Controls.Add(this.execute_local_button);
            this.Controls.Add(this.execute_remote_button);
            this.Controls.Add(this.RDP);
            this.Controls.Add(this.PSServerIP);
            this.Controls.Add(this.PSClosewindow);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.InputBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PowerShellDisp";
            this.Text = "PowerShellDisp";
            this.Load += new System.EventHandler(this.FormPowerShellSample_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.TextBox OutputBox;
        private System.Windows.Forms.Button PSClosewindow;
        private System.Windows.Forms.TextBox PSServerIP;
        private System.Windows.Forms.Button RDP;
        private System.Windows.Forms.Button execute_remote_button;
        private System.Windows.Forms.Button execute_local_button;
        private System.Windows.Forms.Button Get_logs_button;
    }
}