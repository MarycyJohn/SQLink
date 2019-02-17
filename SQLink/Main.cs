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
using System.Xml.Linq;
using System.Configuration;

namespace SQLink
{
    public partial class Main : Form
    {
        public string text;
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //check db button
        {
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
            SQLCon.Close();

        }

        private void button2_Click(object sender, EventArgs e)  //reconnect to db guzik w main oknie
        {

            Login A1 = new Login();
            // uruchamia okno login
            A1.Show();
            //DODAĆ ZAMYKANIE OBECNYCH POŁĄCZEŃ, RESET CONNECTIONS TO SQL
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) // glowne okno data grid
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) //enter textbox
        {

        }

        private void GoBtn_Click(object sender, EventArgs e) //execure button
        {
            using (SqlConnection conn = new SqlConnection(DbConnection.ConnectionString))
            {

                {
                    SqlConnection SQL01 = new SqlConnection(DbConnection.ConnectionString);
                    SqlCommand cmd1 = SQL01.CreateCommand(); 
                    SQL01.Open();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = " " + EnterTextBox.Text.Trim() + " ";
                        try
                        {
                            cmd1.ExecuteNonQuery();
                        }
                        catch (Exception ex2)
                        {
                            MessageBox.Show(ex2.Message, "SQLink Error");
                            SQL01.Close();
                            return;
                        };
                    DataTable T1 = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd1);
                    da.Fill(T1);
                    MainViewGrid.DataSource = T1;
                    SQL01.Close();

                }
            }
        }

        private void Poligon_Click(object sender, EventArgs e) //guzik do testow

        {
            SqlConnection SQLCon = new SqlConnection(DbConnection.ConnectionString);
            SqlCommand cmdX = SQLCon.CreateCommand(); 
            SQLCon.Open();
            cmdX.CommandType = CommandType.Text;
            cmdX.CommandText = "select @@version;";
            cmdX.ExecuteNonQuery();
          //  disp_data2();
            SQLCon.Close();
        }

       
       public void disp_data()  //wyświetlana na wstępnie pusta zawartość disp data by grid był czysty
        {

        } 

    

        private void Main_Load(object sender, EventArgs e)   //pierwsze łączenie z bazą, domyślnie lokalnie
        {
            try {
                this.tESTTableAdapter.Fill(this.sQLinkDBDataSet.TEST);

                //disp_data();
            }
            catch(Exception)
            {
                new System.ArgumentNullException();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
            //Application.Exit;
        }

        private void Version_Click(object sender, EventArgs e)
        {


                {
                    SqlConnection conVer = new SqlConnection(DbConnection.ConnectionString);
                    SqlCommand cmdX = conVer.CreateCommand(); // new SqlCommand();
                                                              //totaj try catch (hasło sql wygasło)
                try
                {
                    conVer.Open();
                }
                catch (Exception)
                {
                    new System.ArgumentNullException();
                }

                    cmdX.CommandType = CommandType.Text;
                    cmdX.CommandText = "select @@VERSION";
                cmdX.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmdX);
                da.Fill(dt);
                MainViewGrid.DataSource = dt;
                conVer.Close();
                }

        }

        private void Active_connection_Click(object sender, EventArgs e)
        {
            {
                SqlConnection conAC = new SqlConnection(DbConnection.ConnectionString);
                SqlCommand cmdX = conAC.CreateCommand(); // new SqlCommand();
                conAC.Open();
                cmdX.CommandType = CommandType.Text;
                cmdX.CommandText = "SELECT DB_NAME(dbid) as DBName, COUNT(dbid) as NumberOfConnections, loginame as LoginName FROM sys.sysprocesses WHERE dbid > 0 GROUP BY dbid, loginame";
                cmdX.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmdX);
                da.Fill(dt);
                MainViewGrid.DataSource = dt;
                conAC.Close();
            }


        }

        private void ActiveS_Click(object sender, EventArgs e)
        {
            {
                SqlConnection conAS = new SqlConnection(DbConnection.ConnectionString);
                SqlCommand cmdX = conAS.CreateCommand(); // new SqlCommand();
                conAS.Open();
                cmdX.CommandType = CommandType.Text;
                cmdX.CommandText = "SELECT conn.session_id, host_name, program_name, nt_domain, login_name, connect_time, last_request_end_time FROM sys.dm_exec_sessions AS sess JOIN sys.dm_exec_connections AS conn ON sess.session_id = conn.session_id;";
                cmdX.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmdX);
                da.Fill(dt);
                MainViewGrid.DataSource = dt;
                conAS.Close();
            }
        }

        private void Kill_session_button_Click(object sender, EventArgs e)
        {
            {
                SqlConnection conKill = new SqlConnection(DbConnection.ConnectionString);
                SqlCommand cmdZ = conKill.CreateCommand(); // new SqlCommand();
                conKill.Open();
                cmdZ.CommandType = CommandType.Text;
                cmdZ.CommandText = "kill " + IDbox.Text.Trim() + " ";
                cmdZ.ExecuteNonQuery();
                //disp_data();
                conKill.Close();
                MessageBox.Show("Session " + IDbox.Text.Trim() + " has been killed", "Session info");
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void LastBackup_Click(object sender, EventArgs e)
        {

            {
                SqlConnection conLB = new SqlConnection(DbConnection.ConnectionString);
                SqlCommand cmdX = conLB.CreateCommand(); // new SqlCommand();
                conLB.Open();
                cmdX.CommandType = CommandType.Text;
                cmdX.CommandText = "SELECT msdb.dbo.backupset.database_name,  MAX(msdb.dbo.backupset.backup_finish_date) AS last_db_backup_date FROM   msdb.dbo.backupmediafamily  INNER JOIN msdb.dbo.backupset ON msdb.dbo.backupmediafamily.media_set_id = msdb.dbo.backupset.media_set_id  WHERE  msdb..backupset.type = 'D' GROUP BY msdb.dbo.backupset.database_name  ORDER BY  msdb.dbo.backupset.database_name";
                cmdX.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmdX);
                da.Fill(dt);
                MainViewGrid.DataSource = dt;
                conLB.Close();
            }
            
        }

        private void LogSpace_Click(object sender, EventArgs e)
        {
            {
                SqlConnection conLS = new SqlConnection(DbConnection.ConnectionString);
                SqlCommand cmdX = conLS.CreateCommand(); // new SqlCommand();
                conLS.Open();
                cmdX.CommandType = CommandType.Text;
                cmdX.CommandText = "DBCC SQLPERF(logspace)";
                cmdX.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmdX);
                da.Fill(dt);
                MainViewGrid.DataSource = dt;
                conLS.Close();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

