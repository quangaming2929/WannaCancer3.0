using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WannaGetCancerID
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txbIn_TextChanged(object sender, EventArgs e)
        {
            char[] sp = txbIn.Text.ToArray();
            char[] spResult = new char[sp.Length];
            int keygen = int.Parse(txbKeyGen.Text);

            for (int i = 0; i < sp.Length; i++)
            {
                int temp = sp[i] + keygen;
                spResult[i] = (char)temp;
            }
            string result = new string(spResult);
            txbOut.Text = result;
        }
    }
}
