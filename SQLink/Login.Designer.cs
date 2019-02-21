namespace SQLink
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
            this.ConnectDBbtn = new System.Windows.Forms.Button();
            this.IDtextBox = new System.Windows.Forms.TextBox();
            this.PasstextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxAD = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.srvnamebox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.portnamebox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dbnamebox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ADConnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConnectDBbtn
            // 
            this.ConnectDBbtn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ConnectDBbtn.Location = new System.Drawing.Point(179, 159);
            this.ConnectDBbtn.Name = "ConnectDBbtn";
            this.ConnectDBbtn.Size = new System.Drawing.Size(75, 23);
            this.ConnectDBbtn.TabIndex = 0;
            this.ConnectDBbtn.Text = "Connect";
            this.ConnectDBbtn.UseVisualStyleBackColor = true;
            this.ConnectDBbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // IDtextBox
            // 
            this.IDtextBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IDtextBox.Location = new System.Drawing.Point(90, 82);
            this.IDtextBox.Name = "IDtextBox";
            this.IDtextBox.Size = new System.Drawing.Size(164, 30);
            this.IDtextBox.TabIndex = 3;
            this.IDtextBox.Text = "ink";
            this.IDtextBox.TextChanged += new System.EventHandler(this.IDtextBox_TextChanged);
            // 
            // PasstextBox
            // 
            this.PasstextBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PasstextBox.Location = new System.Drawing.Point(90, 124);
            this.PasstextBox.Name = "PasstextBox";
            this.PasstextBox.PasswordChar = '*';
            this.PasstextBox.Size = new System.Drawing.Size(164, 30);
            this.PasstextBox.TabIndex = 4;
            this.PasstextBox.Text = "P@ssw0rd";
            this.PasstextBox.TextChanged += new System.EventHandler(this.PasstextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(66, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(17, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // checkBoxAD
            // 
            this.checkBoxAD.AutoSize = true;
            this.checkBoxAD.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxAD.Location = new System.Drawing.Point(260, 119);
            this.checkBoxAD.Name = "checkBoxAD";
            this.checkBoxAD.Size = new System.Drawing.Size(147, 50);
            this.checkBoxAD.TabIndex = 8;
            this.checkBoxAD.Text = "Windows \r\nAuthentication";
            this.checkBoxAD.UseVisualStyleBackColor = true;
            this.checkBoxAD.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox2.Location = new System.Drawing.Point(260, 77);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(120, 50);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "Remember \r\nID";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // srvnamebox
            // 
            this.srvnamebox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.srvnamebox.Location = new System.Drawing.Point(90, 45);
            this.srvnamebox.Name = "srvnamebox";
            this.srvnamebox.Size = new System.Drawing.Size(111, 30);
            this.srvnamebox.TabIndex = 10;
            this.srvnamebox.Text = "SRV-SQL5";
            this.srvnamebox.TextChanged += new System.EventHandler(this.srvnamebox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(47, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Server name /Address";
            // 
            // portnamebox
            // 
            this.portnamebox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.portnamebox.Location = new System.Drawing.Point(207, 45);
            this.portnamebox.Name = "portnamebox";
            this.portnamebox.Size = new System.Drawing.Size(47, 30);
            this.portnamebox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(205, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Port";
            // 
            // dbnamebox
            // 
            this.dbnamebox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dbnamebox.Location = new System.Drawing.Point(260, 45);
            this.dbnamebox.Name = "dbnamebox";
            this.dbnamebox.Size = new System.Drawing.Size(111, 30);
            this.dbnamebox.TabIndex = 14;
            this.dbnamebox.Text = "SQLinkDB";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(253, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "DB name (optional)";
            // 
            // ADConnButton
            // 
            this.ADConnButton.Location = new System.Drawing.Point(260, 160);
            this.ADConnButton.Name = "ADConnButton";
            this.ADConnButton.Size = new System.Drawing.Size(75, 23);
            this.ADConnButton.TabIndex = 16;
            this.ADConnButton.Text = "AD Connect";
            this.ADConnButton.UseVisualStyleBackColor = true;
            this.ADConnButton.Click += new System.EventHandler(this.ADConnButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 209);
            this.Controls.Add(this.ADConnButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dbnamebox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.portnamebox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.srvnamebox);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBoxAD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PasstextBox);
            this.Controls.Add(this.IDtextBox);
            this.Controls.Add(this.ConnectDBbtn);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQLink";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ConnectDBbtn;
        private System.Windows.Forms.TextBox IDtextBox;
        private System.Windows.Forms.TextBox PasstextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.TextBox srvnamebox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox portnamebox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox dbnamebox;
		private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ADConnButton;
        public System.Windows.Forms.CheckBox checkBoxAD;
    }
}

