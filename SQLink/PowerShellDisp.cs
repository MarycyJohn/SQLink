using System;
using System.Text;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Drawing;

namespace SQLink
{
    public partial class PowerShellDisp : Form
    {

        private const string dragDropFormat = "FileDrop";
        public PowerShellDisp()
        {
            InitializeComponent();
        }
        
            private string Ps_console(string scriptText)
            {

                Runspace ps_ink = RunspaceFactory.CreateRunspace();
                ps_ink.Open();
                Pipeline PS_ink_pl = ps_ink.CreatePipeline();
                PS_ink_pl.Commands.AddScript(scriptText);
                PS_ink_pl.Commands.Add("Out-String");
                Collection<PSObject> results = PS_ink_pl.Invoke();
                ps_ink.Close();
                StringBuilder ps_ink_sb = new StringBuilder();
                    foreach (PSObject obj in results)
                    {
                        ps_ink_sb.AppendLine(obj.ToString());
                    }
                return ps_ink_sb.ToString();
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
                    OutputBox.Text = Ps_console("mstsc /v:" + PSServerIP.Text);
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
                OutputBox.Text = Ps_console("Invoke-Command -ComputerName " + PSServerIP.Text + " -ScriptBlock {" + InputBox.Text + "}");
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
                OutputBox.Text = Ps_console(InputBox.Text);
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
                OutputBox.Text = Ps_console("Invoke-Command -ComputerName " + PSServerIP.Text + " -FilePath " + get_logs_string);
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