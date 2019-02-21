using System;
using System.Data.SqlClient;
using System.Windows.Forms;

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
            isInitilized = true;
            //=============================================================================================

            if (Login.AD_auth == true)
                {
                    MessageBox.Show("logujemy po AD", "SQLink Info");
                /* connectionString = string.Format("Data Source={0};Database={1};User Id={2};Password={3}",
                 server, db, login, user);*/

                connectionString = string.Format("Data Source={0};initial catalog={1};persist security info=True;Integrated Security=SSPI;",
                    server, db);//, login, user);

            }
            else
                {
                    MessageBox.Show("logujemy po SQL", "SQLink Info");
                    connectionString = string.Format("Data Source={0};Database={1};User Id={2};Password={3}",
                server, db, login, user);
            };

            // powyzej sprawdza jaka jest wyrana autentykacja        


                                
        }



        public static string ConnectionString
        {
            get
            {   
                 /* try
                  {                
                    if (!isInitilized)
                    {
                    return connectionString;
                    }
                  }
                    catch (Exception ex7)
                    {
                        //MessageBox.Show("Connection string is not initilized. Make sure you intilalize it first", "SQLink Info");
                    MessageBox.Show(ex7.Message);
                    return connectionString;
                    };
                    */
                   if (!isInitilized)
                   throw new Exception("Connection string is not initilized. Make sure you intilalize it first");
                   return connectionString;
                }
            }
        }
    }

