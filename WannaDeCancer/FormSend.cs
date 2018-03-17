using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WannaDeCancer
{
    public partial class FormSend : Form
    {
        #region Field
        string decryptID;
        #endregion

        #region Contructor
        public FormSend(string decryptID)
        {
            this.decryptID = decryptID;
            InitializeComponent();
            CustomInit();
        }
        #endregion

        private void CustomInit()
        {
            //Text
            txbEmailAddress.Text = @"@gmail.com";
            txbPort.Text = 587.ToString();
            txbNotes.Text = @"Please decrypt my files :(";
        }
    }
}
