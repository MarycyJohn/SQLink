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

        private void button1_Click(object sender, EventArgs e) //DBcheck button
        {
            using (SqlConnection conn_dbcheck = new SqlConnection(DbConnection.ConnectionString))
            {
                SqlCommand cmd_dbcheck = conn_dbcheck.CreateCommand();
                conn_dbcheck.Open();
                cmd_dbcheck.CommandType = CommandType.Text;
                cmd_dbcheck.CommandText = "Use master exec dbo.GeneralServerDBInfo";
                cmd_dbcheck.ExecuteNonQuery();
                DataTable dt_dbcheck = new DataTable();
                SqlDataAdapter da_dbcheck = new SqlDataAdapter(cmd_dbcheck);
                da_dbcheck.Fill(dt_dbcheck);
                MainViewGrid.DataSource = dt_dbcheck;
                conn_dbcheck.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)  //Reconnect button
        {
            try
            {
                Login reconnect_login = new Login();
                reconnect_login.Show();
                Login.AD_auth = false;
                this.Dispose(false);
             }
            catch (Exception close_login_ex)
            {
             MessageBox.Show(close_login_ex.Message, "SQLink Info");
             return;
             };
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void GoBtn_Click(object sender, EventArgs e) //Execute SQL command button
        {
            using (SqlConnection conn_execute = new SqlConnection(DbConnection.ConnectionString))
            {  
                    SqlCommand cmd_execute = conn_execute.CreateCommand();
                    conn_execute.Open();
                    cmd_execute.CommandType = CommandType.Text;
                    cmd_execute.CommandText = " " + EnterTextBox.Text.Trim() + " ";
                        try
                        {
                        cmd_execute.ExecuteNonQuery();
                        }
                        catch (Exception ex2)
                        {
                            MessageBox.Show(ex2.Message, "SQLink Info");
                            conn_execute.Close();
                            return;
                        };
                            DataTable dt_execute = new DataTable();
                            SqlDataAdapter da_execute = new SqlDataAdapter(cmd_execute);
                            da_execute.Fill(dt_execute);
                            MainViewGrid.DataSource = dt_execute;
                            conn_execute.Close();
                }
        }

       public void disp_data()  //wyświetlana na wstępnie pusta zawartość disp data by grid był czysty
        {

        } 

        private void Main_Load(object sender, EventArgs e)   //Poprzednie łączenie z bazą, dublowało połączenia
        {
             /* try 
                {
                    this.tESTTableAdapter.Fill(this.sQLinkDBDataSet.TEST);

                    disp_data();
                } 
                catch(Exception)
                {
                    new System.ArgumentNullException();
                }
                 */
            }

        private void button3_Click(object sender, EventArgs e) //Exit app button
        {
            this.Close();
            Environment.Exit(0);
        }

        private void Version_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn_ver_check = new SqlConnection(DbConnection.ConnectionString))
            {
                SqlCommand cmd_ver_check = conn_ver_check.CreateCommand();
                try
                {
                    conn_ver_check.Open();
                }
                catch (Exception ver_check_exception)
                {
                    MessageBox.Show(ver_check_exception.Message, "SQLink info");
                    return;
                };
                cmd_ver_check.CommandType = CommandType.Text;
                cmd_ver_check.CommandText = "select @@VERSION";
                cmd_ver_check.ExecuteNonQuery();
                DataTable dt_ver_check = new DataTable();
                SqlDataAdapter da_ver_check = new SqlDataAdapter(cmd_ver_check);
                da_ver_check.Fill(dt_ver_check);
                MainViewGrid.DataSource = dt_ver_check;
                conn_ver_check.Close();
            }
        }

        private void Active_connection_Click(object sender, EventArgs e) //active connections button
        {
            using (SqlConnection connection_actConn = new SqlConnection(DbConnection.ConnectionString))
            {               
                SqlCommand cmd_actConn = connection_actConn.CreateCommand();
                connection_actConn.Open();
                cmd_actConn.CommandType = CommandType.Text;
                cmd_actConn.CommandText = "SELECT DB_NAME(dbid) as DBName, COUNT(dbid) as NumberOfConnections, loginame as LoginName FROM sys.sysprocesses WHERE dbid > 0 GROUP BY dbid, loginame";
                cmd_actConn.ExecuteNonQuery();
                DataTable dt_actConnt = new DataTable();
                SqlDataAdapter adapter_actConn = new SqlDataAdapter(cmd_actConn);
                adapter_actConn.Fill(dt_actConnt);
                MainViewGrid.DataSource = dt_actConnt;
                connection_actConn.Close();
            }
        }

        private void ActiveS_Click(object sender, EventArgs e) //Active session Button
        {
            using (SqlConnection connection_actsession = new SqlConnection(DbConnection.ConnectionString))
            {
                SqlCommand cmd_actSession = connection_actsession.CreateCommand();
                connection_actsession.Open();
                cmd_actSession.CommandType = CommandType.Text;
                cmd_actSession.CommandText = "SELECT conn.session_id, host_name, program_name, nt_domain, login_name, connect_time, last_request_end_time FROM sys.dm_exec_sessions AS sess JOIN sys.dm_exec_connections AS conn ON sess.session_id = conn.session_id;";
                cmd_actSession.ExecuteNonQuery();
                DataTable dt_actSession = new DataTable();
                SqlDataAdapter adapter_actSession = new SqlDataAdapter(cmd_actSession);
                adapter_actSession.Fill(dt_actSession);
                MainViewGrid.DataSource = dt_actSession;
                connection_actsession.Close();
            }
        }

        private void Kill_session_button_Click(object sender, EventArgs e) //Kill session button
        {
            
            using (SqlConnection connection_kill = new SqlConnection(DbConnection.ConnectionString)) 
            { 
                SqlCommand cmd_kill = connection_kill.CreateCommand();
                connection_kill.Open();
                cmd_kill.CommandType = CommandType.Text;
                cmd_kill.CommandText = "kill " + IDbox.Text.Trim() + " ";              
                    try
                    {
                    cmd_kill.ExecuteNonQuery();
                    }
                    catch (Exception kill_button_exception)
                    {
                    MessageBox.Show("Type Session ID number to close it." + "\n" + kill_button_exception.Message, "SQLink info");
                    return;
                    };
                        connection_kill.Close();
                        MessageBox.Show("Session " + IDbox.Text.Trim() + " has been killed", "Session info");
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void LastBackup_Click(object sender, EventArgs e) //Backup check button
        {
            using(SqlConnection connection_backup = new SqlConnection(DbConnection.ConnectionString))
            { 
                SqlCommand cmd_backup = connection_backup.CreateCommand();
                connection_backup.Open();
                cmd_backup.CommandType = CommandType.Text;
                cmd_backup.CommandText = "SELECT msdb.dbo.backupset.database_name,  MAX(msdb.dbo.backupset.backup_finish_date) AS last_db_backup_date FROM   msdb.dbo.backupmediafamily  INNER JOIN msdb.dbo.backupset ON msdb.dbo.backupmediafamily.media_set_id = msdb.dbo.backupset.media_set_id  WHERE  msdb..backupset.type = 'D' GROUP BY msdb.dbo.backupset.database_name  ORDER BY  msdb.dbo.backupset.database_name";
                cmd_backup.ExecuteNonQuery();
                DataTable dt_backup = new DataTable();
                SqlDataAdapter adapter_backup = new SqlDataAdapter(cmd_backup);
                adapter_backup.Fill(dt_backup);
                MainViewGrid.DataSource = dt_backup;
                connection_backup.Close();
            }   
        }

        private void LogSpace_Click(object sender, EventArgs e) //check space
        {

            using (SqlConnection connection_logspace = new SqlConnection(DbConnection.ConnectionString))
            {
                SqlCommand cmd_logspace = connection_logspace.CreateCommand();
                connection_logspace.Open();
                cmd_logspace.CommandType = CommandType.Text;
                cmd_logspace.CommandText = "DBCC SQLPERF(logspace)";
                cmd_logspace.ExecuteNonQuery();
                DataTable dt_logspace = new DataTable();
                SqlDataAdapter adapter_logspace = new SqlDataAdapter(cmd_logspace);
                adapter_logspace.Fill(dt_logspace);
                MainViewGrid.DataSource = dt_logspace;
                connection_logspace.Close();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

