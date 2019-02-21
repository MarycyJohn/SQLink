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
        public static bool AD_auth = false;
       // public static bool connect_again = false;

        // public override void conn.Close();
        public Login()
        {
            InitializeComponent();
        }

        //WinAuth- łączenie autentykacją Windowsa
        //SqlConnection WinAuth = new SqlConnection(@"Data Source=SRV-SQL5;Initial Catalog=SQLinkDB;Integrated Security=True");
        private void button2_Click(object sender, EventArgs e)  //łączenie z bazą danych przy użyciu wprowadzonych danych (sa we bazie w tabeli)
        {


            //zmienna aktyv_login= true
            //if aktiv_login=1
            //conn.closez

            //zmienna connect_again = true, w guziku reconnect (1 to false 0 to true)
            //tuaj jeśli zmienna connect_again = true to conn.close else conn open, connect_again = false

            /*
             
             
             
             
             */


          //  conn.Close();
            DbConnection.Initlizlie(srvnamebox.Text, dbnamebox.Text, IDtextBox.Text, PasstextBox.Text);
            using (SqlConnection conn = new SqlConnection(DbConnection.ConnectionString)) //testuje czy działa połączenie
                                                                                          //  bool conn = (connection.State == ConnectionState.Open);
                    try
                {

                 /*   if (Login.connect_again == true)
                    {
                        conn.Close();
                        conn.Dispose();
                        Login.connect_again = false;
                        return;
                    }
                    else
                    {
                        conn.Open();
                        Login.connect_again = false;
                    }
                    */
                    conn.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "SQLink info");
                    conn.Close();
                    conn.Dispose();
                    DbConnection.isInitilized = false;
                    return;
                };

            MessageBox.Show("You are now connected to " + srvnamebox.Text, "Server Info");
            //if number of conn <1, close first conn

            this.Hide();



            try   //sprawdza czy jest otwarte okno main, jak jest to je zamyka
            {
                if (Application.OpenForms.OfType<Main>().Count() == 1)
                {
                    Application.OpenForms.OfType<Main>().First().Close();
                }
                /*  if (Application.OpenForms.OfType<Login>().Count() == 1)
                    {
                        Application.OpenForms.OfType<Login>().First().Close();
                        //  conn.Close();
                    }*/
                    
                 Main run_main = new Main(); //odpala główne okno programu
                 run_main.Show();
            }
            catch (Exception ex4)
            {
                MessageBox.Show(ex4.Message, "SQLink Info");
                return;
            };

        }
        
        
        //transfer adresu serwera miedzy formami (faza testów
       /* Main originalForm;
        public Login(Main incomingForm)
        {
            originalForm = incomingForm;
            InitializeComponent();
        }*/
        //transfer adresu serwera miedzy formami


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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)  //checkbox windows auth było private nie public
        {
            if (checkBoxAD.Checked)
            {

                AD_auth = true;
            }
            else
            {
                AD_auth = false;
            }
              /*((CheckBox)(checkBoxAD)).Checked.ToString();
                  MessageBox.Show("po AD będzie", "SQLink Info");
              }
              else 
              {
                  //Połączenie po SQL auth
              }*/
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
                    MessageBox.Show(ex.Message, "SQLink Info");
                    connAD.Close();
                    ADConnection.isADInitilized = false;
                    return;
                };
            MessageBox.Show("You are now connected to " + srvnamebox.Text, "SQLink Info");
            this.Hide();
            Main C2 = new Main();
            C2.Show();

        }
    }
}


