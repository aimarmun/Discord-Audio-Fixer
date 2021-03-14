using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Discord_Audio_Fixer
{
    public partial class Form1 : Form
    {
        private readonly string version = "0.1";
        public Form1()
        {
            InitializeComponent();
            checkBoxDefaultWhenExit.Checked = Properties.Settings.Default.DefaultsOnExit;
            checkBoxFixOnStart.Checked = Properties.Settings.Default.FixOnStart;
            CheckStatus();
            if (checkBoxFixOnStart.Checked)
            {
                Fix();
                WindowState = FormWindowState.Minimized;
            }
            Text += $" v{version}";
        }

        private void CheckStatus()
        {
            var affinityIntMask = GetIntMask();
            var audioodgPath = Path.Combine(Environment.SystemDirectory, "audiodg.exe").ToLower();
            var proccesses = Process.GetProcessesByName("audiodg");
            bool statusDefault = false;
            foreach (var p in proccesses)
            {
                p.Refresh();

                if (p.MainModule.FileName.ToLower().Equals(audioodgPath))
                {
                    if (!p.HasExited)
                    {
                        statusDefault = p.PriorityClass == ProcessPriorityClass.Normal &&
                        p.ProcessorAffinity == (IntPtr)affinityIntMask;

                    }
                }
            }
            if (statusDefault)
                label.Text = "audiodg.exe are running in defaults Windows process";
            else
                label.Text = "audiodg.exe Fixed for Discord!";
        }

        private void Fix()
        {
            Random random = new Random();
            var afinityProcessor = random.Next(0, Environment.ProcessorCount - 1);
            var @string = "";
            for (int i = 0; i < Environment.ProcessorCount; i++)
            {
                if (afinityProcessor == i)
                    @string += "1";
                else
                    @string += "0";
            }
            var result = Convert.ToInt32(@string, 2);
            var audioodgPath = Path.Combine(Environment.SystemDirectory, "audiodg.exe").ToLower();
            var proccesses = Process.GetProcessesByName("audiodg");
            foreach (var p in proccesses)
            {
                p.Refresh();

                if (p.MainModule.FileName.ToLower().Equals(audioodgPath))
                {
                    if (!p.HasExited)
                    {
                        p.PriorityClass = ProcessPriorityClass.High;
                        p.ProcessorAffinity = (IntPtr)result;
                        
                    }
                }
            }
            CheckStatus();
        }

        private void SetProcessToDefault()
        {
            int result = GetIntMask();
            var audioodgPath = Path.Combine(Environment.SystemDirectory, "audiodg.exe").ToLower();
            var proccesses = Process.GetProcessesByName("audiodg");
            foreach (var p in proccesses)
            {
                p.Refresh();

                if (p.MainModule.FileName.ToLower().Equals(audioodgPath))
                {
                    if (!p.HasExited)
                    {
                        p.PriorityClass = ProcessPriorityClass.Normal;
                        p.ProcessorAffinity = (IntPtr)result;
                    }
                }
            }
            CheckStatus();
        }

        private int GetIntMask()
        {
            var @string = "";
            for (int i = 0; i < Environment.ProcessorCount; i++)
            {
                @string += "1";
            }
            var result = Convert.ToInt32(@string, 2);
            return result;
        }


        private void buttonFix_Click(object sender, EventArgs e)
        {
            Fix();
        }

        private void buttonDefaults_Click(object sender, EventArgs e)
        {
            SetProcessToDefault();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (checkBoxDefaultWhenExit.Checked)
            {
                SetProcessToDefault();
            }
            Properties.Settings.Default.Save();
        }

        private void checkBoxFix_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.FixOnStart = checkBoxFixOnStart.Checked;
        }

        private void checkBoxDefaultWhenExit_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.DefaultsOnExit = checkBoxDefaultWhenExit.Checked;
        }
    }
}
