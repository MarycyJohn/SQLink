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
        public static bool AD_auth = false; //warunek do logowania przez Windows Authentication
                
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) //Guzik Connect od którego zaczyna się łączenie
        {

            DbConnection.Initlizlie(srvnamebox.Text, dbnamebox.Text, IDtextBox.Text, PasstextBox.Text);
            using (SqlConnection main_connection = new SqlConnection(DbConnection.ConnectionString))
            {
                try
                {
                    main_connection.Open();
                }
                catch (Exception first_connection_exception)
                {
                    MessageBox.Show(first_connection_exception.Message, "SQLink info");
                    DbConnection.isInitilized = false;
                    return;
                }
                MessageBox.Show("You are now connected to " + srvnamebox.Text, "Server Info");
            }


            try   //sprawdza czy jest otwarte więcej niż 1 okno main, jeżeli tak to je zamyka
            {
                if (Application.OpenForms.OfType<Main>().Count() == 1)
                {
                    Application.OpenForms.OfType<Main>().First().Close();
                }
              
                Main run_main = new Main(); //odpala główne okno programu po połączeniu do SQL Servera
                run_main.Show();
                this.Hide();
            }
            catch (Exception close_multi_main_exception)
            {
                MessageBox.Show(close_multi_main_exception.Message, "SQLink Info");
                return;
                
            };
            
        }
       
        private void IDtextBox_TextChanged(object sender, EventArgs e)  //okienko na SQL Login
        {

        }

        private void PasstextBox_TextChanged(object sender, EventArgs e)  //okienko na Password
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)  //checkbox Windows Authentication
        {
            if (checkBoxAD.Checked)
            {
                AD_auth = true;
            }
            else
            {
                AD_auth = false;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void srvnamebox_TextChanged(object sender, EventArgs e)
        {

        }
            
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


