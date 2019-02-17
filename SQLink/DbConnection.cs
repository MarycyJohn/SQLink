using System;
using System.Data.SqlClient;

namespace SQLink
{
	public static class DbConnection
	{
		private static string connectionString;

		public static bool isInitilized = false;


        public static void Initlizlie(string server, string db, string login, string user)
		{

			if (isInitilized)
				 new Exception("Connection already initilized. Make sure you have only one point of initalization");
 
            //MessageBox.Show("Connection already initilized. Make sure you have only one point of initalization You are now connected to " + srvnamebox.Text,
             //   "Server Info");


			isInitilized = true;
			connectionString = string.Format("Data Source={0};Database={1};User Id={2};Password={3}",
								server, db, login, user);
		}



		public static string ConnectionString
		{
			get
			{
                if (!isInitilized)          //#####################Przerobić na MessageBox

                throw new Exception("Connection string is not initilized. Make sure you intilalize it first");


				return connectionString;
			}
		}
	}
}
