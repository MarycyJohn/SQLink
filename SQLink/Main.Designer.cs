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
			this.button6 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button7 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
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
			this.button1.Location = new System.Drawing.Point(372, 263);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(117, 25);
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
			this.button2.Location = new System.Drawing.Point(11, 11);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(62, 25);
			this.button2.TabIndex = 4;
			this.button2.Text = "Connect";
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
			this.EnterTextBox.Location = new System.Drawing.Point(11, 40);
			this.EnterTextBox.Multiline = true;
			this.EnterTextBox.Name = "EnterTextBox";
			this.EnterTextBox.Size = new System.Drawing.Size(342, 75);
			this.EnterTextBox.TabIndex = 6;
			this.EnterTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// GoBtn
			// 
			this.GoBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.GoBtn.BackColor = System.Drawing.SystemColors.Highlight;
			this.GoBtn.Location = new System.Drawing.Point(360, 40);
			this.GoBtn.Name = "GoBtn";
			this.GoBtn.Size = new System.Drawing.Size(73, 46);
			this.GoBtn.TabIndex = 7;
			this.GoBtn.Text = "Execute";
			this.GoBtn.UseVisualStyleBackColor = false;
			this.GoBtn.Click += new System.EventHandler(this.GoBtn_Click);
			// 
			// Poligon
			// 
			this.Poligon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.Poligon.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.Poligon.Location = new System.Drawing.Point(359, 92);
			this.Poligon.Name = "Poligon";
			this.Poligon.Size = new System.Drawing.Size(129, 23);
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
			this.MainViewGrid.Location = new System.Drawing.Point(12, 144);
			this.MainViewGrid.Name = "MainViewGrid";
			this.MainViewGrid.Size = new System.Drawing.Size(342, 217);
			this.MainViewGrid.TabIndex = 5;
			this.MainViewGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(491, 179);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(101, 20);
			this.textBox2.TabIndex = 13;
			this.textBox2.Text = "Database";
			// 
			// button4
			// 
			this.button4.AutoSize = true;
			this.button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button4.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.button4.Location = new System.Drawing.Point(372, 176);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(113, 25);
			this.button4.TabIndex = 14;
			this.button4.Text = "Free Space in DB";
			this.button4.UseVisualStyleBackColor = false;
			// 
			// button5
			// 
			this.button5.AutoSize = true;
			this.button5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button5.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.button5.Location = new System.Drawing.Point(372, 205);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(112, 25);
			this.button5.TabIndex = 15;
			this.button5.Text = "Free Space in file";
			this.button5.UseVisualStyleBackColor = false;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(490, 206);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(101, 20);
			this.textBox3.TabIndex = 16;
			this.textBox3.Text = "File name";
			// 
			// button6
			// 
			this.button6.AutoSize = true;
			this.button6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button6.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.button6.Location = new System.Drawing.Point(372, 234);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(101, 25);
			this.button6.TabIndex = 18;
			this.button6.Text = "Active Sessions";
			this.button6.UseVisualStyleBackColor = false;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(530, 238);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(28, 20);
			this.textBox1.TabIndex = 19;
			this.textBox1.Text = "ID";
			// 
			// button7
			// 
			this.button7.AutoSize = true;
			this.button7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button7.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.button7.Location = new System.Drawing.Point(492, 236);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(34, 25);
			this.button7.TabIndex = 20;
			this.button7.Text = "Kill";
			this.button7.UseVisualStyleBackColor = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(390, 144);
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
			this.button3.Location = new System.Drawing.Point(584, 12);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(25, 24);
			this.button3.TabIndex = 22;
			this.button3.UseMnemonic = false;
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(637, 372);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button6);
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
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button3;
	}
}