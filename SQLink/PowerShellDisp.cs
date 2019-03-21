using System;
using System.Text;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Drawing;
using System.Runtime.InteropServices;

namespace SQLink
{
    public partial class PowerShellDisp : Form
    {

       /* public string text;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        */


        private const string dragDropFormat = "FileDrop";
        public PowerShellDisp()
        {
            InitializeComponent();
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



        /*
        private void FormPowerShellSample_DragDrop(object sender, DragEventArgs e) // PRZETESTOWAĆ ODPALANIE DROP DOWN SKRYPTOW
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


        private void OutputBox_TextChanged(object sender, EventArgs e)
        {

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

        private void PSServerIP_Enter(object sender, EventArgs e)
        {
            if (PSServerIP.Text == "Remote Server name")
            {
                PSServerIP.Text = "";
                PSServerIP.ForeColor = Color.Black;

            }
        }

        private void PSServerIP_Leave(object sender, EventArgs e)
        {
            if (PSServerIP.Text == "")
            {
                PSServerIP.Text = "Remote Server name";
                PSServerIP.ForeColor = Color.Silver;

            }
        }
        Point lastPoint;
        private void PowerShellDisp_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }

        }

        private void PowerShellDisp_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}