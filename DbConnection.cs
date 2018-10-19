using System;
using System.Data.SqlClient;

namespace SQLink
{
	public static class DbConnection
	{
		private static string connectionString;

		private static DbConnection()
		{

		}

		private static bool isInitilized = false;
		public static void Initlizlie(string server, string db, string login, string user)
		{
			if (isInitilized)
				throw new Exception("Connection already initilized. Make sure you have only one point of initalization");

			connectionString = string.Format("Data Source={0};Initial Catalog={1};User={2};Password={3}",
								server, db, login, user);
		}

		public static string ConnectionString
		{
			get
			{
				if (isInitilized)
					throw new Exception("Connection string is not initilized. Make sure you intilalize it first");

				return connectionString;
			}
		}
	}
}
