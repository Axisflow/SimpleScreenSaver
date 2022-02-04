using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace ScreenSaverTest
{
    public partial class Main : Form
    {
        private void UpdateComponent()
        {
            this.labelTest.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Main_MouseClick);
            this.labelTest.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);

            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Main_KeyPress);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Main_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);

            Cursor.Hide();
            labelTest.Font = new Font(labelTest.Font.Name, (float)Math.Min(this.Size.Width, this.Size.Height) / 5, labelTest.Font.Style, labelTest.Font.Unit);
        }

        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        static extern bool GetClientRect(IntPtr hWnd, out Rectangle lpRect);

        private bool previewMode = false;
        public Main(IntPtr PreviewWndHandle)
        {
            InitializeComponent();

            // Set the preview window as the parent of this window
            SetParent(this.Handle, PreviewWndHandle);

            // Make this a child window so it will close when the parent dialog closes
            // GWL_STYLE = -16, WS_CHILD = 0x40000000
            SetWindowLong(this.Handle, -16, new IntPtr(GetWindowLong(this.Handle, -16) | 0x40000000));

            // Place our window inside the parent
            Rectangle ParentRect;
            GetClientRect(PreviewWndHandle, out ParentRect);
            Size = ParentRect.Size;
            Location = new Point(0, 0);

            previewMode = true;
        }

        public Main(Rectangle Bounds)
        {
            InitializeComponent();
            this.Bounds = Bounds;

            UpdateComponent();
        }

        public Main()
        {
            InitializeComponent();

            UpdateComponent();
        }

        private Point mouseLocation;
        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mouseLocation.IsEmpty)
            {
                // Terminate if mouse is moved a significant distance
                if (Math.Abs(mouseLocation.X - e.X) > 5 ||
                    Math.Abs(mouseLocation.Y - e.Y) > 5)
                    Application.Exit();
            }

            // Update current mouse location
            mouseLocation = e.Location;

        }
        private void Main_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void Main_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!previewMode)
            {
                Application.Exit();
            }
        }

        private void timerTest_Tick(object sender, EventArgs e)
        {
            progressBar_test.Value = (progressBar_test.Value + rand.Next(1, 20)) % 100;
        }
        
        Random rand = new Random();
        public int Mod(int x, int y)
        {
            int mutliple = x * y;
            return ((mutliple < 0 ? -mutliple : mutliple) + x) % y;
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            labelTest.ForeColor = Color.FromArgb(Mod((labelTest.ForeColor.R + (Convert.ToBoolean(rand.Next(0, 2)) ? 5 : -5)), 256), Mod((labelTest.ForeColor.G + (Convert.ToBoolean(rand.Next(0, 2)) ? 5 : -5)), 256), Mod((labelTest.ForeColor.B + (Convert.ToBoolean(rand.Next(0, 2)) ? 5 : -5)), 256));
        }
    }
}
