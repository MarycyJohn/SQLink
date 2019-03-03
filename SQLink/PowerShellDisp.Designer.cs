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
            this.ExecutePS = new System.Windows.Forms.Button();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.PSClosewindow = new System.Windows.Forms.Button();
            this.LastEventLog = new System.Windows.Forms.Button();
            this.PSServerIP = new System.Windows.Forms.TextBox();
            this.TempExeButton = new System.Windows.Forms.Button();
            this.RemoteTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExecutePS
            // 
            this.ExecutePS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExecutePS.Location = new System.Drawing.Point(602, 33);
            this.ExecutePS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExecutePS.Name = "ExecutePS";
            this.ExecutePS.Size = new System.Drawing.Size(56, 19);
            this.ExecutePS.TabIndex = 0;
            this.ExecutePS.Text = "Execute";
            this.ExecutePS.UseVisualStyleBackColor = true;
            this.ExecutePS.Click += new System.EventHandler(this.ExecutePS_Click);
            // 
            // InputBox
            // 
            this.InputBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputBox.Location = new System.Drawing.Point(9, 10);
            this.InputBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.InputBox.Multiline = true;
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(590, 166);
            this.InputBox.TabIndex = 1;
            this.InputBox.TextChanged += new System.EventHandler(this.InputBox_TextChanged);
            // 
            // OutputBox
            // 
            this.OutputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputBox.Location = new System.Drawing.Point(9, 224);
            this.OutputBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OutputBox.Multiline = true;
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(650, 199);
            this.OutputBox.TabIndex = 2;
            this.OutputBox.TextChanged += new System.EventHandler(this.OutputBox_TextChanged);
            // 
            // PSClosewindow
            // 
            this.PSClosewindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PSClosewindow.Location = new System.Drawing.Point(602, 10);
            this.PSClosewindow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PSClosewindow.Name = "PSClosewindow";
            this.PSClosewindow.Size = new System.Drawing.Size(56, 19);
            this.PSClosewindow.TabIndex = 3;
            this.PSClosewindow.Text = "Close";
            this.PSClosewindow.UseVisualStyleBackColor = true;
            this.PSClosewindow.Click += new System.EventHandler(this.PSClosewindow_Click);
            // 
            // LastEventLog
            // 
            this.LastEventLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LastEventLog.Location = new System.Drawing.Point(602, 57);
            this.LastEventLog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LastEventLog.Name = "LastEventLog";
            this.LastEventLog.Size = new System.Drawing.Size(56, 35);
            this.LastEventLog.TabIndex = 4;
            this.LastEventLog.Text = "Event Log";
            this.LastEventLog.UseVisualStyleBackColor = true;
            this.LastEventLog.Click += new System.EventHandler(this.LastEventLog_Click);
            // 
            // PSServerIP
            // 
            this.PSServerIP.Location = new System.Drawing.Point(10, 181);
            this.PSServerIP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PSServerIP.Multiline = true;
            this.PSServerIP.Name = "PSServerIP";
            this.PSServerIP.Size = new System.Drawing.Size(105, 39);
            this.PSServerIP.TabIndex = 5;
            // 
            // TempExeButton
            // 
            this.TempExeButton.Location = new System.Drawing.Point(128, 181);
            this.TempExeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TempExeButton.Name = "TempExeButton";
            this.TempExeButton.Size = new System.Drawing.Size(56, 19);
            this.TempExeButton.TabIndex = 6;
            this.TempExeButton.Text = "exeCUTE";
            this.TempExeButton.UseVisualStyleBackColor = true;
            this.TempExeButton.Click += new System.EventHandler(this.TempExeButton_Click);
            // 
            // RemoteTest
            // 
            this.RemoteTest.Location = new System.Drawing.Point(605, 98);
            this.RemoteTest.Name = "RemoteTest";
            this.RemoteTest.Size = new System.Drawing.Size(75, 56);
            this.RemoteTest.TabIndex = 7;
            this.RemoteTest.Text = "Remote process check";
            this.RemoteTest.UseVisualStyleBackColor = true;
            this.RemoteTest.Click += new System.EventHandler(this.RemoteTest_Click);
            // 
            // PowerShellDisp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 432);
            this.Controls.Add(this.RemoteTest);
            this.Controls.Add(this.TempExeButton);
            this.Controls.Add(this.PSServerIP);
            this.Controls.Add(this.LastEventLog);
            this.Controls.Add(this.PSClosewindow);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.ExecutePS);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PowerShellDisp";
            this.Text = "PowerShellDisp";
            this.Load += new System.EventHandler(this.FormPowerShellSample_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExecutePS;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.TextBox OutputBox;
        private System.Windows.Forms.Button PSClosewindow;
        private System.Windows.Forms.Button LastEventLog;
        private System.Windows.Forms.TextBox PSServerIP;
        private System.Windows.Forms.Button TempExeButton;
        private System.Windows.Forms.Button RemoteTest;
    }
}