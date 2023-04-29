using System.Diagnostics;

namespace ADBrun
{
    public partial class Form1 : Form
    {
        string output = "";
        string errorOutput = "";

        /*To do:
            Files push
            Files pull 
            Package install
            Package remove
         */

        public Form1()
        {
            InitializeComponent();
        }
        private void Run_ProcessAdvanced(string args, bool window = true)
        {
            using (Process myProcess = new Process())
            {
                myProcess.StartInfo.CreateNoWindow = window;
                myProcess.StartInfo.FileName = "cmd";
                myProcess.StartInfo.Arguments = args;
                myProcess.StartInfo.RedirectStandardOutput = true;
                myProcess.StartInfo.RedirectStandardError = true;
                myProcess.OutputDataReceived += (sender, args) => output += (args.Data + '\n');
                myProcess.ErrorDataReceived += (sender, args) => errorOutput += (args.Data + '\n');


                myProcess.Start();
                myProcess.BeginOutputReadLine();
                myProcess.BeginErrorReadLine();
                myProcess.WaitForExit();


                if (!string.IsNullOrEmpty(output) && output.Length > 1)
                    MessageBox.Show(output, "Output");

                if (!string.IsNullOrEmpty(errorOutput) && errorOutput.Length > 1)
                    MessageBox.Show(errorOutput, "Error");

                output = "";
                errorOutput = "";
            }
        }
        private void IpTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PortTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            var command = $"/C adb usb";
            Run_ProcessAdvanced(command, true);
        }

        private void DevicesButton_Click(object sender, EventArgs e)
        {
            var command = "/C adb devices";
            Run_ProcessAdvanced(command, true);
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            var command = $"/C adb tcpip 5555 && adb connect {IpTextBox.Text}:{PortTextBox.Text}";
            Run_ProcessAdvanced(command);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DiscButton_Click(object sender, EventArgs e)
        {
            var command = $"/C adb disconnect {DisconnectTextBkx.Text}:{DiscPortTextBox.Text}";
            Run_ProcessAdvanced(command);
        }

        private void AttachButton_Click(object sender, EventArgs e)
        {
            var command = "/C adb attach";
            Run_ProcessAdvanced(command);
        }

        private void DetachButton_Click(object sender, EventArgs e)
        {
            var command = "/C adb detach";
            Run_ProcessAdvanced(command);
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            var command = "/C adb help";
            Run_ProcessAdvanced(command);
        }

        private void CLIButton_Click(object sender, EventArgs e)
        {
            Run_ProcessAdvanced("/C" + CLITextBox.Text);
        }
    }
}