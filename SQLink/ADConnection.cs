using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLink
{
    class ADConnection
    {
            private static string ADconnectionString;

            public static bool isADInitilized = false;


            public static void ADInitlizlie(string server, string db, string login, string user)
            {

                if (isADInitilized)
                    throw new Exception("Connection already initilized. Make sure you have only one point of initalization");
                                                //##################Dodać tutaj popUP window zamiast tego

                isADInitilized = true;
            //ADconnectionString = string.Format("Data Source={0};Initial Catalog={1};Integrated Security=SSPI; User Id={2};Password={3}",
                ADconnectionString = string.Format("Server = {0}; Database= master; Integrated Security=True;",
                                    server, db, login, user);
            }
            //Data Source=SRV=SQL5;Initial Catalog=Master;Integrated Security=SSPI; User ID = SRV=SQL5\aduster;Password=P@ssw0rd;
            
        


        public static string ADConnectionString
            {
                get
                {                                   //#####################Ustawić default DB jako Master
                    if (!isADInitilized)            //#####################Przerobić na MessageBox
                                                    //#####################Wywal z App.config wklepane na sztywno local win connection for grid
                        throw new Exception("Connection string is not initilized. Make sure you intilalize it first");


                    return ADconnectionString;
                }
            }
        }
}

