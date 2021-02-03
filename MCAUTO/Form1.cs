using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using System.Timers;
using System.Runtime;
using System.Reflection;

namespace MCAUTO
{
    public partial class Form1 : Form
    {
        private List<string> jars = new List<string>();
        private int[] ram = { 1024, 2048, 3072, 4096, 5120, 6144 };
        private int lastRAM;
        private String ServerPath;
        private bool started;
        public Process ServerProc = new Process();
        bool dragWindow;
        private Point offset;
        const int WS_MINIMIZEBOX = 0x20000;
        const int CS_DBLCLKS = 0x8;
        DateTime startTime;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= WS_MINIMIZEBOX;
                cp.ClassStyle |= CS_DBLCLKS;
                return cp;
            }
        }
        public Form1()
        {
            InitializeComponent();
            ramDropDown.SelectedIndex = 0; //Add: check to see if a user has saved their preference.
            versionLabel.Text = Application.ProductVersion.ToString();
        }

        public void Server(string command)
        {
            if (!started)
            {
                string ServerJar = Path.GetFileName(ServerPath);
                var startInfo = new ProcessStartInfo("java", "-Xmx"+ram[ramDropDown.SelectedIndex]+"M -Xms1024M -jar " + ServerJar + " nogui");//--nojline

                lastRAM = ram[ramDropDown.SelectedIndex];

                startInfo.WorkingDirectory = Path.GetDirectoryName(ServerPath);
                startInfo.RedirectStandardInput = startInfo.RedirectStandardError = true;
                startInfo.UseShellExecute = false;
                startInfo.CreateNoWindow = true;
                startInfo.RedirectStandardInput = true;
                startInfo.RedirectStandardOutput = true;
                startInfo.RedirectStandardError = true;

                if (command == "start")
                {
                    ServerProc.StartInfo = startInfo;
                    ServerProc.EnableRaisingEvents = true;
                    ServerProc.ErrorDataReceived += new DataReceivedEventHandler(ServerProc_ErrorDataReceived);
                    ServerProc.OutputDataReceived += new DataReceivedEventHandler(ServerProcess_OutputDataReceived);
                    ServerProc.Exited += new EventHandler(ServerProc_Exited);
                    started = ServerProc.Start();
                    ServerProc.BeginErrorReadLine();
                    ServerProc.BeginOutputReadLine();
                    SetText("Starting...");
                    if (autoSaveCheckBox.Checked)
                    { autoSaveTimer.Enabled = true; startTime = DateTime.Now; }
                }
                else if (command == "stop" || command == "/stop") SetText("There are no active servers, to stop.");
                else if (command == "restart") SetText("There are no active servers, to restart.");
            }
            else
            {
                StreamWriter streamWriter = ServerProc.StandardInput;
                if (command == "stop" || command == "/stop")
                {
                    autoSaveTimer.Stop();
                    autoSaveTimer.Enabled = false;
                    streamWriter.WriteLine("stop");
                    ServerProc.CancelOutputRead();
                    ServerProc.CancelErrorRead();
                    try
                    {
                        while (!ServerProc.HasExited) { SetText("Stopping..."); }
                        ServerProc.Close();
                        streamWriter.Flush();
                        streamWriter.Close();
                        ServerProc.ErrorDataReceived -= new DataReceivedEventHandler(ServerProc_ErrorDataReceived);
                        ServerProc.OutputDataReceived -= new DataReceivedEventHandler(ServerProcess_OutputDataReceived);
                        ServerProc.Exited -= new EventHandler(ServerProc_Exited);
                        SetText("Stopped.");
                        started = false;
                    }
                    catch (Exception e)
                    {
                        //SetText("Please, be gentle with me: I almost had an error.");
                    }
                }
                else if (command == "restart")
                {
                    Server("stop");
                    while (started) {}
                    Server("start");
                }
                else if (command == "start")
                {
                    SetText("A Server is already active!");
                }
                else if (command == "PID")
                {
                    SetText(ServerProc.Id.ToString());
                    if (ServerProc.HasExited) {SetText("Process has closed!"); }
                }
                else
                {
                    streamWriter.WriteLine(command);
                    streamWriter.Flush();
                }
            }
        }

        private void ServerProcess_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Data))
            {
                UpdateLog(e.Data);
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (jarList.Items.Count != 0)
            {
                if (jarList.Items.Count > 1)
                {
                    if (jarList.SelectedIndex != -1)
                    {
                        if (!string.IsNullOrWhiteSpace(jarList.SelectedItem.ToString()))
                        {
                            ServerPath = jarList.SelectedItem.ToString();
                            Server("start");
                        }
                        else { log.AppendText("You must select a Launchable Server Jar, before proceeding." + Environment.NewLine); }
                    }
                    else { log.AppendText("You must select a Launchable Server Jar, before proceeding." + Environment.NewLine); }
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(jarList.Items[0].ToString()))
                    {
                        ServerPath = jarList.Items[0].ToString();
                        Server("start");
                    }
                    else
                    {
                        log.AppendText("You must add a Launchable Server Jar, before proceeding." + Environment.NewLine);
                    }
                }
            }
            else{ log.AppendText("You must add a Launchable Server Jar, before proceeding." + Environment.NewLine); }
        }

        private void ServerProc_Exited(object sender, EventArgs e)
        {
            if (started) { Server("stop"); started = false; }
        }

        private void ServerProc_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {

        }

        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            if (this.log.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.log.AppendText(text + Environment.NewLine);
                if (autoSaveTimer.Enabled) //Temporary Time remaining update method.
                {
                    TimeSpan elapsedTime = DateTime.Now - startTime;
                    int remainingTime = (autoSaveTimer.Interval / 1000) - Convert.ToInt32(elapsedTime.TotalSeconds);
                    remainingValue.Text = remainingTime.ToString();
                }
            }
        }

        public void UpdateLog(string data)
        {
            SetText(data);
        }

        private void jarList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(jarList.Items.Count != 0)
            {
                if(jarList.Items.Count > 1) { if (jarList.SelectedItem != null) ServerPath = jarList.SelectedItem.ToString(); }
                else { ServerPath = jarList.Items[0].ToString(); }
            }
            log.AppendText(jarList.SelectedItem + Environment.NewLine);
        }

        private void log_TextChanged(object sender, EventArgs e)
        {
            log.ScrollToCaret();
        }

        private void openJar_Click(object sender, EventArgs e)
        {
            openJarDialogue.ShowDialog();
            if (!string.IsNullOrEmpty(openJarDialogue.FileName))
            { jarList.Items.Add(openJarDialogue.FileName); jarList.SelectedItem = openJarDialogue.FileName; }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            Server("stop");
        }

        private void OnKeyDownHandler(object sender, KeyEventArgs kea) 
        {
            if (kea.KeyCode.Equals(Keys.Return))
            {
                if (!string.IsNullOrWhiteSpace(commandBox.Text))
                {
                    Server(commandBox.Text);
                    commandBox.Clear();
                    commandBox.ResetText();
                }
                else { SetText("Command cannot be empty!"); }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            jarList.Items.Clear();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            dragWindow = true;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragWindow)
            {
                Point currentScreenPosition = PointToScreen(e.Location);
                Location = new Point(currentScreenPosition.X - offset.X, currentScreenPosition.Y - offset.Y);
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            dragWindow = false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Server("stop");
            Application.Exit();
        }

        private void minimiseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void autoSaveTimer_Tick(object sender, EventArgs e)
        {
            Server("save-all");
            startTime = DateTime.Now;
        }

        private void ramDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (started && lastRAM != ram[ramDropDown.SelectedIndex]) SetText("Restart the server, to launch with: "+ramDropDown.SelectedItem.ToString()+".");
            else SetText(ramDropDown.SelectedItem.ToString()+": Selected.");
        }

        private void autoSaveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (autoSaveCheckBox.Checked)
            {
                if (started) autoSaveTimer.Start();
                startTime = DateTime.Now;
                SetText("Auto Save: Enabled");
            }
            else
            {
                if (started) autoSaveTimer.Stop();
                SetText("Auto Save: Disabled");
            }
        }

        private void creatorLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Laproxi");
        }

        private void autoSaveIntervalBox_ValueChanged(object sender, EventArgs e)
        {
            int newInterval = (Decimal.ToInt32(Math.Truncate(autoSaveIntervalBox.Value)) * 60) * 1000;
            autoSaveTimer.Interval = newInterval;
            if (autoSaveTimer.Enabled)
            {
                autoSaveTimer.Stop();
                autoSaveTimer.Start();
                startTime = DateTime.Now;
            }
            SetText("Auto Save Interval set to: " + autoSaveIntervalBox.Value + " minutes.");
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            Server("restart");
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Server("stop");
            base.OnFormClosing(e);
        }

        private void Form1_FormClosed(Object sender, FormClosedEventArgs e)
        {
            Server("stop");
        }
    }
}
