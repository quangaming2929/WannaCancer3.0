using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace WannaDetector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
            TransparencyKey = Color.Black;
            
            CheckProcess();
        }

        private void CheckProcess()
        { 
            Process ps = Process.GetProcessesByName("TestPhanMemDangNhap")[0];
            ps.EnableRaisingEvents = true;
            ps.Exited += Ps_Exited;
        }

        private void Ps_Exited(object sender, EventArgs e)
        {
            ProcessStartInfo sd = new ProcessStartInfo("shutdown", "/s /t 10");
            sd.CreateNoWindow = true;
            sd.UseShellExecute = false;
            //Process.Start(sd); //Danger!!!
        }
    }
}
