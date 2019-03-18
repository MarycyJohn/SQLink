using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections.ObjectModel;
using System.Management.Automation;
using System.Management.Automation.Runspaces;

//using RemotePowerShell;

namespace SQLink
{
    public partial class PowerShellDisp : Form
    {
 //       private PowerShellEngine psEngine = new PowerShellEngine();
        
        private const string dragDropFormat = "FileDrop";
        public PowerShellDisp()
        {
            InitializeComponent();
        }
        

     /*  private void ExecutePS_Click(object sender, EventArgs e) //do wywalenia execute local stary button
        {

            try
            {
                OutputBox.Clear();
                OutputBox.Text = RunScript(InputBox.Text);
            }
            catch (Exception PS_ex)
            {
                OutputBox.Text += String.Format("\r\nError in script : {0}\r\n", PS_ex.Message);
            }
        }*/

            private string RunScript(string scriptText)
            {

            Runspace runspace = RunspaceFactory.CreateRunspace();
                runspace.Open();
                Pipeline pipeline = runspace.CreatePipeline();
                pipeline.Commands.AddScript(scriptText);
                pipeline.Commands.Add("Out-String");
                Collection<PSObject> results = pipeline.Invoke();
                runspace.Close();

                StringBuilder stringBuilder = new StringBuilder();
                foreach (PSObject obj in results)
                {
                    stringBuilder.AppendLine(obj.ToString());
                }
                return stringBuilder.ToString();
            }




    /*    private void FormPowerShellSample_DragDrop(object sender, DragEventArgs e) // PRZETESTOWAĆ ODPALANIE DROP DOWN SKRYPTOW
        {
            if (e.Data.GetDataPresent(dragDropFormat)) //sprawdza czy to jest prawidłowy rodzaj skryptu
            {
                
                string[] files = (string[])e.Data.GetData(dragDropFormat); // dragging files onto the window yields an array of pathnames

                if (files.Length > 0)
                {
                    using (StreamReader sr = new StreamReader(files[0]))
                    {
                        InputBox.Text = sr.ReadToEnd();
                    }
                }
            }
        }*/

        private void FormPowerShellSample_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(dragDropFormat) ? DragDropEffects.Link : DragDropEffects.None; //akceptuje tylko pliki właściwego formatu
        }

        private void FormPowerShellSample_Load(object sender, EventArgs e)
        {

        }

        private void PSClosewindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InputBox_TextChanged(object sender, EventArgs e)
        {

        }

     /*   private void LastEventLog_Click(object sender, EventArgs e)  // do wywalenia event log stary button local
        {
            try
            {
                OutputBox.Clear();
                //OutputBox.Text = RunScript("Get-EventLog Application -After (Get-Date).AddHours(-2)");
                 OutputBox.Text = RunScript("Invoke-Command -ComputerName " + PSServerIP.Text + " -ScriptBlock {" + InputBox.Text + "}");
            }
            catch (Exception PS_ex)
            {
                OutputBox.Text += String.Format("\r\nError in script : {0}\r\n", PS_ex.Message);
            }   
        }*/

       /* private void TempExeButton_Click(object sender, EventArgs e)   //DELETE
        {
           
           OutputBox.Clear();
            // textBoxRemoteMachine to pole adresu serwera, zostawić puste jak local ma być
            var results = psEngine.ExecuteScript(InputBox.Text, null, PSServerIP.Text); //radiogetitem na input textbox komendy
            foreach (var result in results)
            {
                OutputBox.AppendText(result.ToString() + "\r\n");
            }
        }*/

        private void OutputBox_TextChanged(object sender, EventArgs e)
        {

        }

       /* private void RemoteTest_Click(object sender, EventArgs e)  // TEMP DO KOSZA
        {
            try
            {
                OutputBox.Clear();
                OutputBox.Text = RunScript("sdf");// '$password = "P@ssw0rd" | ConvertTo-SecureString -asPlainText -Force $username = "Administrator"  $credential = New - Object System.Management.Automation.PSCredential($username,$password) Invoke - Command - ComputerName WS2012 - ScriptBlock { get - process } -Credential $credential');
            }
            catch (Exception PS_ex)
            {
                OutputBox.Text += String.Format("\r\nError in script : {0}\r\n", PS_ex.Message);
            }
        }*/

        private void PSServerIP_TextChanged(object sender, EventArgs e)
        {

        }

        private void RDP_Click(object sender, EventArgs e)

            {
                try
                {
                    OutputBox.Clear();
                    OutputBox.Text = RunScript("mstsc /v:" + PSServerIP.Text);
                }
                catch (Exception PS_ex)
                {
                    OutputBox.Text += String.Format("\r\nError in script : {0}\r\n", PS_ex.Message);
                }
            }

        private void execute_remote_button_Click(object sender, EventArgs e) //remote ps console
        {
            try
            {
                OutputBox.Clear();
                OutputBox.Text = RunScript("Invoke-Command -ComputerName " + PSServerIP.Text + " -ScriptBlock {" + InputBox.Text + "}");
            }
            catch (Exception PS_ex)
            {
                OutputBox.Text += String.Format("\r\nError in script : {0}\r\n", PS_ex.Message);
            }
        }

        private void execute_local_button_Click(object sender, EventArgs e)  //local ps console
        {
            try
            {
                OutputBox.Clear();
                OutputBox.Text = RunScript(InputBox.Text);
            }
            catch (Exception PS_ex)
            {
                OutputBox.Text += String.Format("\r\nError in script : {0}\r\n", PS_ex.Message);
            }
        }



        // private void execute_remote_button_Click(object sender, EventArgs e) //remote ps console
        // {

        string get_logs_string = "C:\\Users\\Maurycy\\source\\repos\\SQLink\\SQLink\\sql_ink_get_logs.ps1";
        private void Get_logs_button_Click(object sender, EventArgs e)
        {
            try
            {
                OutputBox.Clear();
                OutputBox.Text = RunScript("Invoke-Command -ComputerName " + PSServerIP.Text + " -FilePath " + get_logs_string);
            }
            catch (Exception PS_ex)
            {
                OutputBox.Text += String.Format("\r\nError in script : {0}\r\n", PS_ex.Message);
            }
        }

    }
}





//RunScript(@"c:\users\zainnab\AddItUp.ps1")
//OutputBox.Text = RunScript(Invoke-Command -ComputerName " + PSServerIP.Text + " -FilePath @"C:\Users\Maurycy\source\repos\SQLink\SQLink\sql_ink_get_logs.ps1");
//Invoke-Command -ComputerName WS2012 -FilePath C:\Users\Maurycy\Desktop\sql_ink_get_logs.ps1
//OutputBox.Text = RunScript("Invoke-Command -ComputerName " + PSServerIP.Text + "-FilePath C:\Users\Maurycy\Desktop\sql_ink_get_logs.ps1");






// helper method that takes your script path, loads up the script  (@"C:\Users\Maurycy\source\repos\SQLink\SQLink\sql_ink_get_logs.ps1")
// into a variable, and passes the variable to the RunScript method 
// that will then execute the contents 
/*private string LoadScript(string filename)
{
    try
    {
        // Create an instance of StreamReader to read from our file. 
        // The using statement also closes the StreamReader. 
        using (StreamReader sr = new StreamReader(sql_ink_get_logs.ps1))
        {

            // use a string builder to get all our lines from the file 
            StringBuilder fileContents = new StringBuilder();

            // string to hold the current line 
            string curLine;

            // loop through our file and read each line into our 
            // stringbuilder as we go along 
            while ((curLine = sr.ReadLine()) != null)
            {
                // read each line and MAKE SURE YOU ADD BACK THE 
                // LINEFEED THAT IT THE ReadLine() METHOD STRIPS OFF 
                fileContents.Append(curLine + "\n");
            }

            // call RunScript and pass in our file contents 
            // converted to a string 
            return fileContents.ToString();
        }
    }
    catch (Exception e)
    {
        // Let the user know what went wrong. 
        string errorText = "The file could not be read:";
        errorText += e.Message + "\n";
        return errorText;
    }

}*/
