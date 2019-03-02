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


namespace SQLink
{
    public partial class PowerShellDisp : Form
    {
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
                OutputBox.Text = RunScript("Get-EventLog Application -After (Get-Date).AddHours(-2)");
            }
            catch (Exception PS_ex)
            {
                OutputBox.Text += String.Format("\r\nError in script : {0}\r\n", PS_ex.Message);
            }   
        }
    }
}


