using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management.Automation;
using System.IO;

namespace RemotePowerShell
{
    public partial class Form1 : Form
    {
       /* private PowerShellEngine psEngine = new PowerShellEngine();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonExecute_Click(object sender, EventArgs e)  //guzik execute
        {
            textBoxResults.Clear();
            // textBoxRemoteMachine to pole adresu serwera, zostawić puste jak local ma być
            var results = psEngine.ExecuteScript(radioGetItem.Text, null, textBoxRemoteMachine.Text); //radiogetitem na input textbox komendy
                foreach (var result in results)
                {
                    textBoxResults.AppendText(result.ToString() + "\r\n");
                }
           
        }

        private void radioGetItem_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRemoteMachine_TextChanged(object sender, EventArgs e)
        {

        }*/
    }
}
