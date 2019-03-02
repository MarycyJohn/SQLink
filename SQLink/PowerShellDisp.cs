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
                // create Powershell runspace
                Runspace runspace = RunspaceFactory.CreateRunspace();

                // open it
                runspace.Open();

                // create a pipeline and feed it the script text
                Pipeline pipeline = runspace.CreatePipeline();
                pipeline.Commands.AddScript(scriptText);

                // add an extra command to transform the script output objects into nicely formatted strings
                // remove this line to get the actual objects that the script returns. For example, the script
                // "Get-Process" returns a collection of System.Diagnostics.Process instances.
                pipeline.Commands.Add("Out-String");

                // execute the script
                Collection<PSObject> results = pipeline.Invoke();

                // close the runspace
                runspace.Close();

                // convert the script result into a single string
                StringBuilder stringBuilder = new StringBuilder();
                foreach (PSObject obj in results)
                {
                    stringBuilder.AppendLine(obj.ToString());
                }

                return stringBuilder.ToString();
            }

        private void FormPowerShellSample_DragDrop(object sender, DragEventArgs e)
        {
            // is it the correct type of data?
            if (e.Data.GetDataPresent(dragDropFormat))
            {
                // dragging files onto the window yields an array of pathnames
                string[] files = (string[])e.Data.GetData(dragDropFormat);

                if (files.Length > 0)
                {
                    // just read the first file
                    using (StreamReader sr = new StreamReader(files[0]))
                    {
                        // and plunk the contents in the textbox
                        InputBox.Text = sr.ReadToEnd();
                    }
                }
            }
        }

        private void FormPowerShellSample_DragEnter(object sender, DragEventArgs e)
        {
            // only accept the dropped data if it has the correct format
            e.Effect = e.Data.GetDataPresent(dragDropFormat) ? DragDropEffects.Link : DragDropEffects.None;
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
    }
}


