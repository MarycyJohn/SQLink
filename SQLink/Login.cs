﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SQLink
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //WinAuth- łączenie autentykacją Windowsa
        //SqlConnection WinAuth = new SqlConnection(@"Data Source=SRV-SQL5;Initial Catalog=SQLinkDB;Integrated Security=True");
        private void button2_Click(object sender, EventArgs e)  //łączenie z bazą danych przy użyciu wprowadzonych danych (sa we bazie w tabeli)
        {
            
           DbConnection.Initlizlie(srvnamebox.Text, dbnamebox.Text, IDtextBox.Text, PasstextBox.Text);
           using (SqlConnection conn = new SqlConnection(DbConnection.ConnectionString)) //testuje czy działa połączenie

                try
                {
                    conn.Open();
                }
                    catch (Exception ex)
                    {
                    MessageBox.Show(ex.Message);
                    conn.Close();
                    DbConnection.isInitilized = false;
                    return;
                    };


            //to ponizej potencjalnie zbedne
            SqlConnection LogMEin = new SqlConnection(DbConnection.ConnectionString);
            string query = "Select * from SQLogin where username = '" + IDtextBox.Text.Trim() + "' and password = '" + PasstextBox.Text.Trim() + "'";
            SqlDataAdapter adapter1 = new SqlDataAdapter(query, LogMEin);
            DataTable Tab1 = new DataTable();
            adapter1.Fill(Tab1);
            greatJob B1 = new greatJob();
            this.Hide();
            B1.Show();
        }

        private void IDtextBox_TextChanged(object sender, EventArgs e)  //okienko na ID
        {

        }

        private void PasstextBox_TextChanged(object sender, EventArgs e)  //okienko na Password
        {

        }

        private void label3_Click(object sender, EventArgs e)  //password label
        {

        }

        private void label2_Click(object sender, EventArgs e) //label ID
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)  // checkbox zapamietaj login 
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)  //checkbox windows auth 
        {

        }

        private void Login_Load(object sender, EventArgs e)  //okno login ogólne 
        {

        }

        private void srvnamebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ADConnButton_Click(object sender, EventArgs e)
        {
            ADConnection.ADInitlizlie(srvnamebox.Text, dbnamebox.Text, IDtextBox.Text, PasstextBox.Text);
            using (SqlConnection connAD = new SqlConnection(ADConnection.ADConnectionString)) //testuje czy działa połączenie

                try
                {
                    connAD.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    connAD.Close();
                    ADConnection.isADInitilized = false;
                    return;
                };


        }
    }
}


