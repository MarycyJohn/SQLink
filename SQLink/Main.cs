using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //sql things and stuff
using System.Xml.Linq;

namespace SQLink
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //check db button
        {
			SqlConnection SQLCon = new SqlConnection(DbConnection.ConnectionString);
			SqlCommand cmdX = SQLCon.CreateCommand(); // new SqlCommand();
			SQLCon.Open();
			cmdX.CommandType = CommandType.Text;
			cmdX.CommandText = "Use SQLinkDB exec dbo.GeneralServerDBInfo";
			cmdX.ExecuteNonQuery();
			disp_data2();
			SQLCon.Close();
		}

        //private void label1_Click(object sender, EventArgs e) //check db napis
        //{

        //}

        private void button2_Click(object sender, EventArgs e)  //connect to db guzik w main oknie
        {
            Login A1 = new Login();
            // uruchamia okno login
            A1.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) // glowne okno data grid
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) //enter textbox
        {

        }

		private void GoBtn_Click(object sender, EventArgs e) //exeture button
		{ 
			using (SqlConnection conn = new SqlConnection(DbConnection.ConnectionString))
			{

				{
					SqlConnection SQLCon = new SqlConnection(DbConnection.ConnectionString);
					SqlCommand cmdX = SQLCon.CreateCommand(); // new SqlCommand();
					SQLCon.Open();
					cmdX.CommandType = CommandType.Text;
					cmdX.CommandText = " " + EnterTextBox.Text.Trim() + " ";
					cmdX.ExecuteNonQuery();
					disp_data();
					SQLCon.Close();
				}
				//string EXECquery = " " + EnterTextBox.Text.Trim() + " "; //sql injection
				//SqlDataAdapter adapter2 = new SqlDataAdapter(EXECquery, conn); //queryString to connection string na zapytania
				//DataTable Tab2 = new DataTable();
				//adapter2.Fill(Tab2);
				//DataSet ds = new DataSet();
				////MainViewGrid.DataSource = adapter2. queryString.DataSource;
			}
		}
		//private void GoBtn_Click(object sender, EventArgs e) //exeture button
  //      {
  //          string connectionString = @"Data Source=SRV-SQL5;Initial Catalog=SQLinkDB;Integrated Security=True";

  //          using (SqlConnection conn = new SqlConnection(connectionString))
  //          {
  //              string EXECquery = " " + EnterTextBox.Text.Trim() + " "; //sql injection
  //              SqlDataAdapter adapter2 = new SqlDataAdapter(EXECquery, queryString); //queryString to connection string na zapytania
  //              DataTable Tab2 = new DataTable();
  //              adapter2.Fill(Tab2);
  //              DataSet ds = new DataSet();
  //              MainViewGrid.DataSource = queryString.DataSource;
  //          }
  //      }
		
        private void Poligon_Click(object sender, EventArgs e) //guzik do testow

        {
			SqlConnection SQLCon = new SqlConnection(DbConnection.ConnectionString);
			SqlCommand cmdX = SQLCon.CreateCommand(); // new SqlCommand();
            SQLCon.Open();
            cmdX.CommandType = CommandType.Text;
            cmdX.CommandText = "Use SQLinkDB exec dbo.GeneralServerDBInfo";
            cmdX.ExecuteNonQuery();
            disp_data2();
            SQLCon.Close();
        }

        public void disp_data()
        {
			SqlConnection SQLCon = new SqlConnection(@"Data Source=SRV-SQL5;Initial Catalog=SQLinkDB;Integrated Security=True");
			//SqlConnection SQLCon = new SqlConnection(@"Data Source=SRV-SQL5;Initial Catalog=SQLinkDB;Integrated Security=True"); //to jest nowe w avenidzie
			SQLCon.Open();
            SqlCommand cmdX = SQLCon.CreateCommand();
            cmdX.CommandType = CommandType.Text;
            cmdX.CommandText = " " + EnterTextBox.Text.Trim() + " ";
			//cmdX.CommandText = "Use SQLinkDB exec dbo.GeneralServerDBInfo" + EnterTextBox.Text.Trim(); //to jest nowe w avenidzie
			cmdX.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmdX);
            da.Fill(dt);
            MainViewGrid.DataSource = dt;
            SQLCon.Close();
        }

		public void disp_data2()
		{
			SqlConnection SQLCon = new SqlConnection(@"Data Source=SRV-SQL5;Initial Catalog=SQLinkDB;Integrated Security=True");
			//SqlConnection SQLCon = new SqlConnection(@"Data Source=SRV-SQL5;Initial Catalog=SQLinkDB;Integrated Security=True"); //to jest nowe w avenidzie
			SQLCon.Open();
			SqlCommand cmdX = SQLCon.CreateCommand();
			cmdX.CommandType = CommandType.Text;
			cmdX.CommandText = "Use SQLinkDB exec dbo.GeneralServerDBInfo";
			//cmdX.CommandText = "Use SQLinkDB exec dbo.GeneralServerDBInfo" + EnterTextBox.Text.Trim(); //to jest nowe w avenidzie
			cmdX.ExecuteNonQuery();
			DataTable dt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter(cmdX);
			da.Fill(dt);
			MainViewGrid.DataSource = dt;
			SQLCon.Close();
		}



		private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sQLinkDBDataSet.TEST' table. You can move, or remove it, as needed.
            this.tESTTableAdapter.Fill(this.sQLinkDBDataSet.TEST);
            disp_data();
        }

		private void button3_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}

