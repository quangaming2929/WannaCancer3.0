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
        FileStream fsEN;
        public GUIMain()
        {
            InitializeComponent();
            FileStreamInit();
            CustomInit();
        }

        private void FileStreamInit()
        {
            fsEN = new FileStream(@"C:\Program Files\Microsoft PowerShell Manager\EN.txt", FileMode.Open, FileAccess.Read);
        }

        private void CustomInit()
        {
            
        }
    }
}
