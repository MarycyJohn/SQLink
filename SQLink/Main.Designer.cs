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
            this.tESTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tESTTableAdapter = new SQLink.SQLinkDBDataSetTableAdapters.TESTTableAdapter();
            this.MainViewGrid = new System.Windows.Forms.DataGridView();
            this.Active_connection = new System.Windows.Forms.Button();
            this.IDbox = new System.Windows.Forms.TextBox();
            this.Kill_session_button = new System.Windows.Forms.Button();
            this.Version = new System.Windows.Forms.Button();
            this.ActiveS = new System.Windows.Forms.Button();
            this.LastBackup = new System.Windows.Forms.Button();
            this.LogSpace = new System.Windows.Forms.Button();
            this.sidepanel = new System.Windows.Forms.Panel();
            this.NewPSWindow = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sQLinkDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLinkDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tESTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainViewGrid)).BeginInit();
            this.sidepanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(0, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Check disk per DB";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button2.Location = new System.Drawing.Point(430, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 35);
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
            this.EnterTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnterTextBox.Location = new System.Drawing.Point(142, 71);
            this.EnterTextBox.Multiline = true;
            this.EnterTextBox.Name = "EnterTextBox";
            this.EnterTextBox.Size = new System.Drawing.Size(702, 75);
            this.EnterTextBox.TabIndex = 6;
            this.EnterTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // GoBtn
            // 
            this.GoBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.GoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.GoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GoBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.GoBtn.Location = new System.Drawing.Point(0, 63);
            this.GoBtn.Name = "GoBtn";
            this.GoBtn.Size = new System.Drawing.Size(136, 35);
            this.GoBtn.TabIndex = 7;
            this.GoBtn.Text = "Execute";
            this.GoBtn.UseVisualStyleBackColor = false;
            this.GoBtn.Click += new System.EventHandler(this.GoBtn_Click);
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
            this.MainViewGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainViewGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.MainViewGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.MainViewGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.MainViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainViewGrid.Location = new System.Drawing.Point(142, 151);
            this.MainViewGrid.Name = "MainViewGrid";
            this.MainViewGrid.Size = new System.Drawing.Size(700, 269);
            this.MainViewGrid.TabIndex = 5;
            this.MainViewGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Active_connection
            // 
            this.Active_connection.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Active_connection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Active_connection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Active_connection.Dock = System.Windows.Forms.DockStyle.Top;
            this.Active_connection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Active_connection.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Active_connection.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Active_connection.Location = new System.Drawing.Point(0, 133);
            this.Active_connection.Name = "Active_connection";
            this.Active_connection.Size = new System.Drawing.Size(136, 35);
            this.Active_connection.TabIndex = 18;
            this.Active_connection.Text = "Active Connections";
            this.Active_connection.UseVisualStyleBackColor = false;
            this.Active_connection.Click += new System.EventHandler(this.Active_connection_Click);
            // 
            // IDbox
            // 
            this.IDbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IDbox.BackColor = System.Drawing.SystemColors.Control;
            this.IDbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IDbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IDbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IDbox.Location = new System.Drawing.Point(82, 320);
            this.IDbox.Multiline = true;
            this.IDbox.Name = "IDbox";
            this.IDbox.Size = new System.Drawing.Size(54, 35);
            this.IDbox.TabIndex = 19;
            this.IDbox.Text = "Session\r\nID";
            this.IDbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IDbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Kill_session_button
            // 
            this.Kill_session_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Kill_session_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Kill_session_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Kill_session_button.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Kill_session_button.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Kill_session_button.Location = new System.Drawing.Point(0, 306);
            this.Kill_session_button.Name = "Kill_session_button";
            this.Kill_session_button.Size = new System.Drawing.Size(85, 35);
            this.Kill_session_button.TabIndex = 20;
            this.Kill_session_button.Text = "Kill";
            this.Kill_session_button.UseVisualStyleBackColor = false;
            this.Kill_session_button.Click += new System.EventHandler(this.Kill_session_button_Click);
            // 
            // Version
            // 
            this.Version.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Version.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Version.Dock = System.Windows.Forms.DockStyle.Top;
            this.Version.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Version.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Version.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Version.Location = new System.Drawing.Point(0, 168);
            this.Version.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(136, 35);
            this.Version.TabIndex = 23;
            this.Version.Text = "SQL Version";
            this.Version.UseVisualStyleBackColor = false;
            this.Version.Click += new System.EventHandler(this.Version_Click);
            // 
            // ActiveS
            // 
            this.ActiveS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ActiveS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ActiveS.Dock = System.Windows.Forms.DockStyle.Top;
            this.ActiveS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActiveS.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ActiveS.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ActiveS.Location = new System.Drawing.Point(0, 98);
            this.ActiveS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ActiveS.Name = "ActiveS";
            this.ActiveS.Size = new System.Drawing.Size(136, 35);
            this.ActiveS.TabIndex = 24;
            this.ActiveS.Text = "Active Sessions";
            this.ActiveS.UseVisualStyleBackColor = false;
            this.ActiveS.Click += new System.EventHandler(this.ActiveS_Click);
            // 
            // LastBackup
            // 
            this.LastBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.LastBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LastBackup.Dock = System.Windows.Forms.DockStyle.Top;
            this.LastBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LastBackup.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LastBackup.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LastBackup.Location = new System.Drawing.Point(0, 203);
            this.LastBackup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LastBackup.Name = "LastBackup";
            this.LastBackup.Size = new System.Drawing.Size(136, 35);
            this.LastBackup.TabIndex = 25;
            this.LastBackup.Text = "Last Backup";
            this.LastBackup.UseVisualStyleBackColor = false;
            this.LastBackup.Click += new System.EventHandler(this.LastBackup_Click);
            // 
            // LogSpace
            // 
            this.LogSpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.LogSpace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogSpace.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogSpace.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LogSpace.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LogSpace.Location = new System.Drawing.Point(0, 238);
            this.LogSpace.Name = "LogSpace";
            this.LogSpace.Size = new System.Drawing.Size(136, 35);
            this.LogSpace.TabIndex = 26;
            this.LogSpace.Text = "Log space";
            this.LogSpace.UseVisualStyleBackColor = false;
            this.LogSpace.Click += new System.EventHandler(this.LogSpace_Click);
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.sidepanel.Controls.Add(this.NewPSWindow);
            this.sidepanel.Controls.Add(this.button1);
            this.sidepanel.Controls.Add(this.Kill_session_button);
            this.sidepanel.Controls.Add(this.IDbox);
            this.sidepanel.Controls.Add(this.LogSpace);
            this.sidepanel.Controls.Add(this.LastBackup);
            this.sidepanel.Controls.Add(this.Version);
            this.sidepanel.Controls.Add(this.Active_connection);
            this.sidepanel.Controls.Add(this.ActiveS);
            this.sidepanel.Controls.Add(this.GoBtn);
            this.sidepanel.Controls.Add(this.panel2);
            this.sidepanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidepanel.Location = new System.Drawing.Point(0, 0);
            this.sidepanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(136, 428);
            this.sidepanel.TabIndex = 27;
            this.sidepanel.Paint += new System.Windows.Forms.PaintEventHandler(this.sidepanel_Paint);
            this.sidepanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sidepanel_MouseDown);
            // 
            // NewPSWindow
            // 
            this.NewPSWindow.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NewPSWindow.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.NewPSWindow.Location = new System.Drawing.Point(31, 363);
            this.NewPSWindow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NewPSWindow.Name = "NewPSWindow";
            this.NewPSWindow.Size = new System.Drawing.Size(59, 19);
            this.NewPSWindow.TabIndex = 27;
            this.NewPSWindow.Text = "NewPS";
            this.NewPSWindow.UseVisualStyleBackColor = true;
            this.NewPSWindow.Click += new System.EventHandler(this.NewPSWindow_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(169)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.LightGray;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(136, 63);
            this.panel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(136, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 63);
            this.panel1.TabIndex = 28;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGray;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Image = global::SQLink.Properties.Resources.exit;
            this.button3.Location = new System.Drawing.Point(540, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(34, 35);
            this.button3.TabIndex = 22;
            this.button3.UseMnemonic = false;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SQLink.Properties.Resources.sqlink_kopia;
            this.pictureBox1.Location = new System.Drawing.Point(9, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(852, 428);
            this.Controls.Add(this.EnterTextBox);
            this.Controls.Add(this.MainViewGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sidepanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.sQLinkDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLinkDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tESTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainViewGrid)).EndInit();
            this.sidepanel.ResumeLayout(false);
            this.sidepanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.BindingSource tESTBindingSource;
        private SQLinkDBDataSetTableAdapters.TESTTableAdapter tESTTableAdapter;
        private System.Windows.Forms.DataGridView MainViewGrid;
		private System.Windows.Forms.Button Active_connection;
		private System.Windows.Forms.TextBox IDbox;
		private System.Windows.Forms.Button Kill_session_button;
		private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Version;
        private System.Windows.Forms.Button ActiveS;
        private System.Windows.Forms.Button LastBackup;
        private System.Windows.Forms.Button LogSpace;
        private System.Windows.Forms.Panel sidepanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button NewPSWindow;
    }
}