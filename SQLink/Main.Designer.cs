namespace SQLink
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.sQLinkDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sQLinkDBDataSet = new SQLink.SQLinkDBDataSet();
            this.EnterTextBox = new System.Windows.Forms.TextBox();
            this.GoBtn = new System.Windows.Forms.Button();
            this.Poligon = new System.Windows.Forms.Button();
            this.tESTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tESTTableAdapter = new SQLink.SQLinkDBDataSetTableAdapters.TESTTableAdapter();
            this.MainViewGrid = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Active_connection = new System.Windows.Forms.Button();
            this.IDbox = new System.Windows.Forms.TextBox();
            this.Kill_session_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.Version = new System.Windows.Forms.Button();
            this.ActiveS = new System.Windows.Forms.Button();
            this.LastBackup = new System.Windows.Forms.Button();
            this.LogSpace = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sQLinkDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLinkDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tESTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainViewGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(496, 324);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "Check disk per DB";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.Location = new System.Drawing.Point(15, 14);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 27);
            this.button2.TabIndex = 4;
            this.button2.Text = "Reconnect";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // sQLinkDBDataSetBindingSource
            // 
            this.sQLinkDBDataSetBindingSource.DataSource = this.sQLinkDBDataSet;
            this.sQLinkDBDataSetBindingSource.Position = 0;
            // 
            // sQLinkDBDataSet
            // 
            this.sQLinkDBDataSet.DataSetName = "SQLinkDBDataSet";
            this.sQLinkDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EnterTextBox
            // 
            this.EnterTextBox.Location = new System.Drawing.Point(15, 49);
            this.EnterTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EnterTextBox.Multiline = true;
            this.EnterTextBox.Name = "EnterTextBox";
            this.EnterTextBox.Size = new System.Drawing.Size(455, 91);
            this.EnterTextBox.TabIndex = 6;
            this.EnterTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // GoBtn
            // 
            this.GoBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GoBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.GoBtn.Location = new System.Drawing.Point(480, 49);
            this.GoBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GoBtn.Name = "GoBtn";
            this.GoBtn.Size = new System.Drawing.Size(97, 57);
            this.GoBtn.TabIndex = 7;
            this.GoBtn.Text = "Execute";
            this.GoBtn.UseVisualStyleBackColor = false;
            this.GoBtn.Click += new System.EventHandler(this.GoBtn_Click);
            // 
            // Poligon
            // 
            this.Poligon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Poligon.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Poligon.Location = new System.Drawing.Point(479, 113);
            this.Poligon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Poligon.Name = "Poligon";
            this.Poligon.Size = new System.Drawing.Size(172, 28);
            this.Poligon.TabIndex = 8;
            this.Poligon.Text = "Poligon Testowy";
            this.Poligon.UseVisualStyleBackColor = false;
            this.Poligon.Click += new System.EventHandler(this.Poligon_Click);
            // 
            // tESTBindingSource
            // 
            this.tESTBindingSource.DataMember = "TEST";
            this.tESTBindingSource.DataSource = this.sQLinkDBDataSetBindingSource;
            // 
            // tESTTableAdapter
            // 
            this.tESTTableAdapter.ClearBeforeFill = true;
            // 
            // MainViewGrid
            // 
            this.MainViewGrid.AllowUserToOrderColumns = true;
            this.MainViewGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.MainViewGrid.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.MainViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainViewGrid.Location = new System.Drawing.Point(16, 177);
            this.MainViewGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MainViewGrid.Name = "MainViewGrid";
            this.MainViewGrid.Size = new System.Drawing.Size(456, 267);
            this.MainViewGrid.TabIndex = 5;
            this.MainViewGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(655, 220);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(133, 22);
            this.textBox2.TabIndex = 13;
            this.textBox2.Text = "Database";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(496, 217);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 27);
            this.button4.TabIndex = 14;
            this.button4.Text = "Free Space in DB";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Location = new System.Drawing.Point(653, 174);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(128, 27);
            this.button5.TabIndex = 15;
            this.button5.Text = "Free Space in file";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(653, 254);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(133, 22);
            this.textBox3.TabIndex = 16;
            this.textBox3.Text = "File name";
            // 
            // Active_connection
            // 
            this.Active_connection.AutoSize = true;
            this.Active_connection.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Active_connection.BackColor = System.Drawing.SystemColors.Highlight;
            this.Active_connection.Location = new System.Drawing.Point(496, 288);
            this.Active_connection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Active_connection.Name = "Active_connection";
            this.Active_connection.Size = new System.Drawing.Size(138, 27);
            this.Active_connection.TabIndex = 18;
            this.Active_connection.Text = "Active Connections";
            this.Active_connection.UseVisualStyleBackColor = false;
            this.Active_connection.Click += new System.EventHandler(this.Active_connection_Click);
            // 
            // IDbox
            // 
            this.IDbox.Location = new System.Drawing.Point(707, 293);
            this.IDbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IDbox.Name = "IDbox";
            this.IDbox.Size = new System.Drawing.Size(36, 22);
            this.IDbox.TabIndex = 19;
            this.IDbox.Text = "ID";
            this.IDbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Kill_session_button
            // 
            this.Kill_session_button.AutoSize = true;
            this.Kill_session_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Kill_session_button.BackColor = System.Drawing.SystemColors.Highlight;
            this.Kill_session_button.Location = new System.Drawing.Point(656, 290);
            this.Kill_session_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Kill_session_button.Name = "Kill_session_button";
            this.Kill_session_button.Size = new System.Drawing.Size(36, 27);
            this.Kill_session_button.TabIndex = 20;
            this.Kill_session_button.Text = "Kill";
            this.Kill_session_button.UseVisualStyleBackColor = false;
            this.Kill_session_button.Click += new System.EventHandler(this.Kill_session_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(520, 177);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "CHECK";
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(779, 15);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(33, 30);
            this.button3.TabIndex = 22;
            this.button3.UseMnemonic = false;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Version
            // 
            this.Version.BackColor = System.Drawing.SystemColors.Highlight;
            this.Version.Location = new System.Drawing.Point(496, 247);
            this.Version.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(128, 34);
            this.Version.TabIndex = 23;
            this.Version.Text = "SQL Version";
            this.Version.UseVisualStyleBackColor = false;
            this.Version.Click += new System.EventHandler(this.Version_Click);
            // 
            // ActiveS
            // 
            this.ActiveS.BackColor = System.Drawing.SystemColors.Highlight;
            this.ActiveS.Location = new System.Drawing.Point(644, 321);
            this.ActiveS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ActiveS.Name = "ActiveS";
            this.ActiveS.Size = new System.Drawing.Size(128, 33);
            this.ActiveS.TabIndex = 24;
            this.ActiveS.Text = "Active Sessions";
            this.ActiveS.UseVisualStyleBackColor = false;
            this.ActiveS.Click += new System.EventHandler(this.ActiveS_Click);
            // 
            // LastBackup
            // 
            this.LastBackup.BackColor = System.Drawing.SystemColors.Highlight;
            this.LastBackup.Location = new System.Drawing.Point(496, 358);
            this.LastBackup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LastBackup.Name = "LastBackup";
            this.LastBackup.Size = new System.Drawing.Size(133, 31);
            this.LastBackup.TabIndex = 25;
            this.LastBackup.Text = "Last Backup";
            this.LastBackup.UseVisualStyleBackColor = false;
            this.LastBackup.Click += new System.EventHandler(this.LastBackup_Click);
            // 
            // LogSpace
            // 
            this.LogSpace.BackColor = System.Drawing.SystemColors.Highlight;
            this.LogSpace.Location = new System.Drawing.Point(636, 358);
            this.LogSpace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LogSpace.Name = "LogSpace";
            this.LogSpace.Size = new System.Drawing.Size(100, 31);
            this.LogSpace.TabIndex = 26;
            this.LogSpace.Text = "Log space";
            this.LogSpace.UseVisualStyleBackColor = false;
            this.LogSpace.Click += new System.EventHandler(this.LogSpace_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(849, 458);
            this.Controls.Add(this.LogSpace);
            this.Controls.Add(this.LastBackup);
            this.Controls.Add(this.ActiveS);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Kill_session_button);
            this.Controls.Add(this.IDbox);
            this.Controls.Add(this.Active_connection);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Poligon);
            this.Controls.Add(this.GoBtn);
            this.Controls.Add(this.EnterTextBox);
            this.Controls.Add(this.MainViewGrid);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sQLinkDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLinkDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tESTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainViewGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox EnterTextBox;
        private System.Windows.Forms.Button GoBtn;
        private System.Windows.Forms.BindingSource sQLinkDBDataSetBindingSource;
        private SQLinkDBDataSet sQLinkDBDataSet;
        private System.Windows.Forms.Button Poligon;
        private System.Windows.Forms.BindingSource tESTBindingSource;
        private SQLinkDBDataSetTableAdapters.TESTTableAdapter tESTTableAdapter;
        private System.Windows.Forms.DataGridView MainViewGrid;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button Active_connection;
		private System.Windows.Forms.TextBox IDbox;
		private System.Windows.Forms.Button Kill_session_button;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Version;
        private System.Windows.Forms.Button ActiveS;
        private System.Windows.Forms.Button LastBackup;
        private System.Windows.Forms.Button LogSpace;
    }
}