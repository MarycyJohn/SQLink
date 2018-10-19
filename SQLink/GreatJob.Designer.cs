namespace SQLink
{
    partial class greatJob
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
            this.GoodJob = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GoodJob
            // 
            this.GoodJob.AutoSize = true;
            this.GoodJob.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GoodJob.Location = new System.Drawing.Point(74, 40);
            this.GoodJob.Name = "GoodJob";
            this.GoodJob.Size = new System.Drawing.Size(112, 36);
            this.GoodJob.TabIndex = 0;
            this.GoodJob.Text = "Success!";
            this.GoodJob.Click += new System.EventHandler(this.GoodJob_Click);
            // 
            // greatJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 119);
            this.Controls.Add(this.GoodJob);
            this.Name = "greatJob";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login message";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GoodJob;
    }
}