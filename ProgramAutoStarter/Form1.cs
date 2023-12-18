using ConfigDefender;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ProgramAutoStarter
{
    public partial class Form1 : Form
    {
        private bool run;

        public Form1()
        {
            InitializeComponent();
            WriteLog("Program start.");
        }
       // public string Set

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                programListBox.Items.Add(openFileDialog1.FileName);
                WriteLog("Add by user: "+openFileDialog1.FileName);
            }        
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (programListBox.SelectedIndex==-1)
            {
                MessageBox.Show("Please select one item from list before delete!");
            }
            else
            {
                string tmp = programListBox.GetItemText(programListBox.SelectedItem);
                programListBox.Items.RemoveAt(programListBox.SelectedIndex);
                WriteLog("Deleted by user: "+tmp);
            }
        }

        private void startStopSelProgram_Click(object sender, EventArgs e)
        {
          
            string selProgramNames = programListBox.GetItemText(programListBox.SelectedItem);
            if (selProgramNames.Length>0)
            {
                string tmpName = selProgramNames.Substring(selProgramNames.LastIndexOf("\\") + 1);
                tmpName = tmpName.Substring(0, tmpName.LastIndexOf("."));
                Process[] procArr = Process.GetProcessesByName(tmpName);
                if (procArr.Length==0)
                {
                    WriteLog("Manual start process by user: " + selProgramNames);
                    StartStopProcess(selProgramNames);
                }
                else
                {
                    foreach (Process item in procArr)
                    {
                        WriteLog("Manual stopped process by user: " + item.ProcessName+",id: "+item.Id);
                        item.Kill();
                    }
                    
                }
               
            }                   
        }

        private void startStopBtn_Click(object sender, EventArgs e)
        {
            if (!run)
            {
                run = true;
                new Thread(new ThreadStart(MainThread)).Start();
                WriteLog("Auto checking started");
            }
            else
            {
                run = false;
                WriteLog("Auto checking stopped");
            }
        }

        private void MainThread()
        {
            startStopBtn.Invoke((MethodInvoker)(() => 
            {               
                startStopBtn.Text = "Autostart started"; startStopBtn.BackColor = Color.LightGreen;
                addBtn.Enabled = false;
                delBtn.Enabled = false;
                startStopSelProgramBtn.Enabled = false;
            }));
            while (run)
            {               
                foreach (string item in programListBox.Items)
                {
                    if (!run) break;
                    StartStopProcess(item);
                }
                Thread.Sleep(1000);
            }
            startStopBtn.Invoke((MethodInvoker)(() => 
            {
                startStopBtn.Text = "Autostart stopped"; startStopBtn.BackColor = Color.Tomato;
                addBtn.Enabled = true;
                delBtn.Enabled = true;
                startStopSelProgramBtn.Enabled = true;
            }));
        }


        private void StartStopProcess(string programFullName)
        {
            try
            {
                string tmpName = programFullName.Substring(programFullName.LastIndexOf("\\") + 1);
                tmpName = tmpName.Substring(0, tmpName.LastIndexOf("."));
                Process[] tmpProcArr = Process.GetProcessesByName(tmpName);
                if (tmpProcArr.Length>1)
                {
                    WriteLog("Stopped process: " + tmpProcArr[1].ProcessName + ", id: " + tmpProcArr[1].Id);
                    tmpProcArr[1].Kill();
                    
                }
                if (tmpProcArr.Length==0)
                {
                    Process.Start(programFullName);
                    WriteLog("Started process: " + programFullName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                WriteLog(ex.Message);
            }
        }
        private void WriteLog(string data)
        {
            try
            {
                using (StreamWriter wr = new StreamWriter("log.txt", true))
                {
                    wr.WriteLine($"- {DateTime.Now.ToString("yyy.MM.dd HH:mm:ss")}: {data}");
                    wr.Flush();
                    wr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                WriteLog(ex.Message);
            }
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            startStopBtn_Click(sender, e);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            PassForm form = new PassForm("vision");
            if (form.ShowDialog()!=DialogResult.OK)
            {
                e.Cancel = true ;  
            }
            WriteLog("Program exit.");
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState==FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Icon = this.Icon;
                notifyIcon1.Text = "ProgramAutoStarter";
                notifyIcon1.Visible = true;
                notifyIcon1.ContextMenuStrip  = new System.Windows.Forms.ContextMenuStrip();
                notifyIcon1.ContextMenuStrip.Items.Add("Show window",null, ShowMain);
                notifyIcon1.ContextMenuStrip.Items.Add("Exit", null, Exit);
                WriteLog("Program minimized");
            }
            else if(this.WindowState == FormWindowState.Normal)
            {              
                notifyIcon1.Visible = false;
                WriteLog("Program show is active");
            }
        }

        internal void Exit(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ShowMain(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "The program is able to monitor the running of the configured programs. If the configured program is not running but is listed and Autosstart started." +
                "If multiple instances are running at one time, the program can stop them and run only 1 instance." +
                "Ability to start and stop programs manually." +
                "It can be minimized to the tray for smooth operation.", "vision", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
