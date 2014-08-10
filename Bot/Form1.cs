using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace Bot
{
    public partial class Form1 : Form
    {
        private bool clicked = false;
        private Timer timer1;
        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 5;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (clicked)
            {
                var fb = GetFourthPixel(ScreenShot(), Color.FromArgb(235, 236, 235));
                if (fb.HasValue)
                {
                    memclr();
                    Cursor.Position = new Point(1050, 732);
                    mouse_event(MOUSEEVENTF_LEFTDOWN, 1959, 732, 0, new System.IntPtr());
                    System.Threading.Thread.Sleep(200);
                    mouse_event(MOUSEEVENTF_LEFTDOWN, 1050, 732, 0, new System.IntPtr());
                    mouse_event(MOUSEEVENTF_LEFTUP, 1050, 7832, 0, new System.IntPtr());
                    Cursor.Position = new Point(996, 849);
                    mouse_event(MOUSEEVENTF_LEFTDOWN, 996, 849, 0, new System.IntPtr());
                    System.Threading.Thread.Sleep(200);
                    mouse_event(MOUSEEVENTF_LEFTDOWN, 996, 849, 0, new System.IntPtr());
                    mouse_event(MOUSEEVENTF_LEFTUP, 996, 849, 0, new System.IntPtr());
                }
                else
                {
                    var pt = GetFirstPixel(ScreenShot(), Color.FromArgb(29, 55, 15));
                    if (pt.HasValue)
                    {
                        memclr();
                        mouse_event(MOUSEEVENTF_LEFTDOWN, 996, 849, 0, new System.IntPtr());
                    }
                    else
                    {
                        var rb = GetSecondPixel(ScreenShot(), Color.FromArgb(4, 48, 176));
                        if (rb.HasValue)
                        {
                            memclr();
                            mouse_event(MOUSEEVENTF_LEFTDOWN, 996, 849, 0, new System.IntPtr());
                        }
                        else
                        {
                            var ok = GetThirdPixel(ScreenShot(), Color.FromArgb(53, 156, 36));
                            var ok2 = GetFourthPixel(ScreenShot(), Color.FromArgb(58, 155, 40));
                            var ok3 = GetSixthPixel(ScreenShot(), Color.FromArgb(250, 164, 53));
                            mouse_event(MOUSEEVENTF_LEFTUP, 996, 849, 0, new System.IntPtr());
                            if (ok.HasValue)
                            {
                                memclr();
                                Cursor.Position = new Point(781, 781);
                                mouse_event(MOUSEEVENTF_LEFTDOWN, 781, 781, 0, new System.IntPtr());
                                System.Threading.Thread.Sleep(200);
                                mouse_event(MOUSEEVENTF_LEFTDOWN, 781, 781, 0, new System.IntPtr());
                                mouse_event(MOUSEEVENTF_LEFTUP, 781, 781, 0, new System.IntPtr());
                                Cursor.Position = new Point(996, 849);
                                mouse_event(MOUSEEVENTF_LEFTDOWN, 996, 849, 0, new System.IntPtr());
                                System.Threading.Thread.Sleep(200);
                                mouse_event(MOUSEEVENTF_LEFTDOWN, 996, 849, 0, new System.IntPtr());
                                mouse_event(MOUSEEVENTF_LEFTUP, 996, 849, 0, new System.IntPtr());
                            }
                            else if (ok2.HasValue)
                            {
                                memclr();
                                Cursor.Position = new Point(675, 776);
                                mouse_event(MOUSEEVENTF_LEFTDOWN, 675, 776, 0, new System.IntPtr());
                                System.Threading.Thread.Sleep(200);
                                mouse_event(MOUSEEVENTF_LEFTDOWN, 675, 776, 0, new System.IntPtr());
                                mouse_event(MOUSEEVENTF_LEFTUP, 675, 776, 0, new System.IntPtr());
                                Cursor.Position = new Point(996, 849);
                                mouse_event(MOUSEEVENTF_LEFTDOWN, 996, 849, 0, new System.IntPtr());
                                System.Threading.Thread.Sleep(200);
                                mouse_event(MOUSEEVENTF_LEFTDOWN, 996, 849, 0, new System.IntPtr());
                                mouse_event(MOUSEEVENTF_LEFTUP, 996, 849, 0, new System.IntPtr());
                                System.Threading.Thread.Sleep(200);
                                mouse_event(MOUSEEVENTF_LEFTDOWN, 996, 849, 0, new System.IntPtr());
                                mouse_event(MOUSEEVENTF_LEFTUP, 996, 849, 0, new System.IntPtr());
                            }
                            else if (ok3.HasValue)
                            {
                                memclr();
                                Cursor.Position = new Point(837, 802);
                                mouse_event(MOUSEEVENTF_LEFTDOWN, 837, 802, 0, new System.IntPtr());
                                System.Threading.Thread.Sleep(200);
                                mouse_event(MOUSEEVENTF_LEFTDOWN, 837, 802, 0, new System.IntPtr());
                                mouse_event(MOUSEEVENTF_LEFTUP, 837, 802, 0, new System.IntPtr());
                                Cursor.Position = new Point(996, 849);
                                mouse_event(MOUSEEVENTF_LEFTDOWN, 996, 849, 0, new System.IntPtr());
                                System.Threading.Thread.Sleep(200);
                                mouse_event(MOUSEEVENTF_LEFTDOWN, 996, 849, 0, new System.IntPtr());
                                mouse_event(MOUSEEVENTF_LEFTUP, 996, 849, 0, new System.IntPtr());
                            }
                        }
                    }
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitTimer();
        }

        [DllImport("user32.dll",
   CharSet = CharSet.Auto,
   CallingConvention = CallingConvention.StdCall)]
        private static extern void mouse_event(UInt32 dwFlags,
                                              UInt32 dx,
                                              UInt32 dy,
                                              UInt32 dwData,
                                              IntPtr dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;

        private void button1_Click(object sender, EventArgs e)
        {
            clicked = true;
            Cursor.Position = new Point(996, 849);
            mouse_event(MOUSEEVENTF_LEFTDOWN, 996, 849, 0, new System.IntPtr());
            System.Threading.Thread.Sleep(200);
            mouse_event(MOUSEEVENTF_LEFTDOWN, 996, 849, 0, new System.IntPtr());
            mouse_event(MOUSEEVENTF_LEFTUP, 996, 849, 0, new System.IntPtr());
            //colorsearch(ScreenShot());
            //MessageBox.Show(Cursor.Position.ToString());
        }

        private void colorsearch(Bitmap bitmap)
        {
            MessageBox.Show(bitmap.GetPixel(684, 803).ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public Bitmap ScreenShot()
        {
            memclr();
          var screenShot = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                                        Screen.PrimaryScreen.Bounds.Height,
                                        PixelFormat.Format32bppArgb);

            using (var g = Graphics.FromImage(screenShot))
            {
               g.CopyFromScreen(0, 0, 0, 0, Screen.PrimaryScreen.Bounds.Size);
            }

            return screenShot;
        }

        [DllImport("kernel32.dll", EntryPoint = "SetProcessWorkingSetSize", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]

        private static extern int SetProcessWorkingSetSize(IntPtr process, int minimumWorkingSetSize, int maximumWorkingSetSize);

        public static void memclr()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            SetProcessWorkingSetSize(System.Diagnostics.Process.GetCurrentProcess().Handle, -1, -1);
        }

        public Point? GetFirstPixel(Bitmap bitmap, Color color)
        {
            if (bitmap.GetPixel(996, 849).Equals(color))
            {
                return new Point(996, 849);
            }
            else
        return null;
        }

        public Point? GetSecondPixel(Bitmap bitmap, Color color)
        {
            if (bitmap.GetPixel(935, 781).Equals(color))
            {
                return new Point(935, 781);
            }
            else
                return null;
        }
        public Point? GetThirdPixel(Bitmap bitmap, Color color)
        {
            if (bitmap.GetPixel(781, 781).Equals(color))
            {
                return new Point(781, 781);
            }
            else
                return null;
        }
        public Point? GetFourthPixel(Bitmap bitmap, Color color)
        {
            if (bitmap.GetPixel(675, 776).Equals(color))
            {
                return new Point(675, 776);
            }
            else
                return null;
        }
        public Point? GetFifthPixel(Bitmap bitmap, Color color)
        {
            if (bitmap.GetPixel(1050, 732).Equals(color))
            {
                return new Point(1050, 732);
            }
            else
                return null;
        }
        public Point? GetSixthPixel(Bitmap bitmap, Color color)
        {
            if (bitmap.GetPixel(684, 803).Equals(color))
            {
                return new Point(684, 803);
            }
            else
                return null;
        }
    }
}
