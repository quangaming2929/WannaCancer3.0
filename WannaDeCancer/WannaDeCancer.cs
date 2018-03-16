using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace WannaDeCancer
{
    public enum Style : int
    {
        Fill,
        Fit,
        Span,
        Tile,
        Stretch,
        Center
    }

    public partial class WannaDeCancer : Form
    {
        const int SPI_SETDESKWALLPAPER = 20;
        const int SPIF_UPDATEINIFILE = 0x01;
        const int SPIF_SENDWININICHANGE = 0x02;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

        Thread labelCursor;
        Thread pgBarProgress;
        GUIMain main = new GUIMain();
        public WannaDeCancer()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            CustomInit();
        }

        private void CustomInit()
        {
            Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            lbCursor.BackColor = Color.Transparent;
            lbCursor.Parent = ptbInit;
            ptbInit.Controls.Add(lbCursor);
            labelCursor = new Thread(CursorLabel);
            labelCursor.Start();
            BackGround(Style.Center);

            pgBarProgress = new Thread(PgProcess);
            pgBarProgress.Start();
            main.Show();
        }

        private void PgProcess()
        {
            for (int i = 0; i < 50; i++)
            {
                pbInit.Value += 1;
                Thread.Sleep(100);
            }
            this.Hide();
        }

        private void CursorLabel()
        {
            while(true)
            {
                lbCursor.Location = new Point(Cursor.Position.X - 100, Cursor.Position.Y);
            }
        }

        private void BackGround(Style style)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);

            if (style == Style.Fill)
            {
                key.SetValue(@"WallpaperStyle", 10.ToString());
                key.SetValue(@"TileWallpaper", 0.ToString());
            }
            if (style == Style.Fit)
            {
                key.SetValue(@"WallpaperStyle", 6.ToString());
                key.SetValue(@"TileWallpaper", 0.ToString());
            }
            if (style == Style.Span) // Windows 8 or newer only!
            {
                key.SetValue(@"WallpaperStyle", 22.ToString());
                key.SetValue(@"TileWallpaper", 0.ToString());
            }
            if (style == Style.Stretch)
            {
                key.SetValue(@"WallpaperStyle", 2.ToString());
                key.SetValue(@"TileWallpaper", 0.ToString());
            }
            if (style == Style.Tile)
            {
                key.SetValue(@"WallpaperStyle", 0.ToString());
                key.SetValue(@"TileWallpaper", 1.ToString());
            }
            if (style == Style.Center)
            {
                key.SetValue(@"WallpaperStyle", 0.ToString());
                key.SetValue(@"TileWallpaper", 0.ToString());
            }

            string tempPath = @"C:\Users\quanm\OneDrive\Máy tính\WannaCancer Resources";
            SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, tempPath, SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
            pbInit.Value += 50;
        }
    }
}
