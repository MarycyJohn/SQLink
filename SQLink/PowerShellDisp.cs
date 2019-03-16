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
using RemotePowerShell;

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
        

        private void ExecutePS_Click(object sender, EventArgs e)
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




        private void FormPowerShellSample_DragDrop(object sender, DragEventArgs e)
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
        }

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

        private void LastEventLog_Click(object sender, EventArgs e)
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
        }

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

        private void RemoteTest_Click(object sender, EventArgs e)
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
        }

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

    }
}


