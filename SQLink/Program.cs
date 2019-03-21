using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SQLink
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login run_login = new Login();
            Application.Run(run_login);
            //PowerShellDisp asd = new PowerShellDisp();
           //Application.Run(asd);
           // Application.Run(new Login());  // program startuje z okna Login
        }
    }
}
