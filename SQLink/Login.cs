using System;
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
            SqlConnection main_connection = new SqlConnection(DbConnection.ConnectionString); //testuje czy działa połączenie
            //using (SqlConnection conn = new SqlConnection(DbConnection.ConnectionString)) //testuje czy działa połączenie
                                                                                          //  bool conn = (connection.State == ConnectionState.Open);
                try
                {

                /* 


        SqlConnection SQLCon = new SqlConnection(DbConnection.ConnectionString);
        SqlCommand cmdX = SQLCon.CreateCommand();
        SQLCon.Open();
        cmdX.CommandType = CommandType.Text;
        cmdX.CommandText = "Use master exec dbo.GeneralServerDBInfo";
        cmdX.ExecuteNonQuery();

        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmdX);
        da.Fill(dt);
        MainViewGrid.DataSource = dt;
        SQLCon.Close();

                


                 */
                main_connection.Open();
                SqlConnection.ClearPool(main_connection);
               // conn.Close();
               // conn.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "SQLink info");
                   // conn.Close();
                   // conn.Dispose();
                    DbConnection.isInitilized = false;
                    return;
                }
                finally
                {
                
              //  conn.Close();
               // conn.Dispose();
            }

  

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
        /*
        private void ADConnButton_Click(object sender, EventArgs e)  //to ponizej do wywalenia
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

        }*/
        
        private void exit_login_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

        private void portnamebox_TextChanged(object sender, EventArgs e)
        {
        }

        private void portnamebox_Click(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= portnamebox_TextChanged;
        }

        private void srvnamebox_Enter(object sender, EventArgs e)
        {
            if (srvnamebox.Text == "SQL Server name")
            {
                srvnamebox.Text = "";
                srvnamebox.ForeColor = Color.Black;

            }
        }

        private void srvnamebox_Leave(object sender, EventArgs e)
        {
            if (srvnamebox.Text == "")
            {
                srvnamebox.Text = "SQL Server name";
                srvnamebox.ForeColor = Color.Silver;

            }
        }

        private void PasstextBox_Enter(object sender, EventArgs e)
        {
            if (PasstextBox.Text == "Password")
            {
                PasstextBox.Text = "";
                PasstextBox.ForeColor = Color.Black;

            }
        }

        private void PasstextBox_Leave(object sender, EventArgs e)
        {
            if (PasstextBox.Text == "")
            {
                PasstextBox.Text = "Password";
                PasstextBox.ForeColor = Color.Silver;

            }
        }

        private void IDtextBox_Enter(object sender, EventArgs e)
        {
            if (IDtextBox.Text == "SQL Login")
            {
                IDtextBox.Text = "";
                IDtextBox.ForeColor = Color.Black;

            }
        }

        private void IDtextBox_Leave(object sender, EventArgs e)
        {
            if (IDtextBox.Text == "")
            {
                IDtextBox.Text = "SQL Login";
                IDtextBox.ForeColor = Color.Silver;

            }
        }

        private void dbnamebox_Enter(object sender, EventArgs e)
        {
            
            if (dbnamebox.Text == "DB name")
            {
                dbnamebox.Text = "";
                dbnamebox.ForeColor = Color.Black;

            }
        }

        private void dbnamebox_Leave(object sender, EventArgs e)
        {
            if (dbnamebox.Text == "")
            {
                dbnamebox.Text = "DB name";
                dbnamebox.ForeColor = Color.Silver;

            }
        }
    }
}


