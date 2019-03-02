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
            this.SuspendLayout();
            // 
            // ExecutePS
            // 
            this.ExecutePS.Location = new System.Drawing.Point(774, 41);
            this.ExecutePS.Name = "ExecutePS";
            this.ExecutePS.Size = new System.Drawing.Size(75, 23);
            this.ExecutePS.TabIndex = 0;
            this.ExecutePS.Text = "Execute";
            this.ExecutePS.UseVisualStyleBackColor = true;
            this.ExecutePS.Click += new System.EventHandler(this.ExecutePS_Click);
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(12, 12);
            this.InputBox.Multiline = true;
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(756, 249);
            this.InputBox.TabIndex = 1;
            this.InputBox.TextChanged += new System.EventHandler(this.InputBox_TextChanged);
            // 
            // OutputBox
            // 
            this.OutputBox.Location = new System.Drawing.Point(12, 276);
            this.OutputBox.Multiline = true;
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(837, 244);
            this.OutputBox.TabIndex = 2;
            // 
            // PSClosewindow
            // 
            this.PSClosewindow.Location = new System.Drawing.Point(774, 12);
            this.PSClosewindow.Name = "PSClosewindow";
            this.PSClosewindow.Size = new System.Drawing.Size(75, 23);
            this.PSClosewindow.TabIndex = 3;
            this.PSClosewindow.Text = "Close";
            this.PSClosewindow.UseVisualStyleBackColor = true;
            this.PSClosewindow.Click += new System.EventHandler(this.PSClosewindow_Click);
            // 
            // PowerShellDisp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 532);
            this.Controls.Add(this.PSClosewindow);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.ExecutePS);
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
    }
}