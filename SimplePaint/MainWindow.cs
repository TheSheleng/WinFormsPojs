using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePaint
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Padding = new Padding(ResizeIndent);
        }

        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == 0x84) // WM_NCHITTEST
            {
                //Resizeble Window
                var cursor = this.PointToClient(Cursor.Position);

                if (TopLeft.Contains(cursor)) message.Result = (IntPtr)HTTOPLEFT;
                else if (TopRight.Contains(cursor)) message.Result = (IntPtr)HTTOPRIGHT;
                else if (BottomLeft.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMLEFT;
                else if (BottomRight.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMRIGHT;

                else if (Top.Contains(cursor)) message.Result = (IntPtr)HTTOP;
                else if (Left.Contains(cursor)) message.Result = (IntPtr)HTLEFT;
                else if (Right.Contains(cursor)) message.Result = (IntPtr)HTRIGHT;
                else if (Bottom.Contains(cursor)) message.Result = (IntPtr)HTBOTTOM;
            }
        }

        private void MainWindow_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.Padding = new Padding(0);
            else this.Padding = new Padding(3);
        }

        #region Drag Window
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        private void ChromPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xF012, 0);
        }
        #endregion

        #region Sizeble Window Vars
        private const int
            HTLEFT =        10,
            HTRIGHT =       11,
            HTTOP =         12,
            HTTOPLEFT =     13,
            HTTOPRIGHT =    14,
            HTBOTTOM =      15,
            HTBOTTOMLEFT =  16,
            HTBOTTOMRIGHT = 17;

        const int ResizeIndent = 3;

        Rectangle Top { get { return new Rectangle(0, 0, this.ClientSize.Width, ResizeIndent); } }
        Rectangle Left { get { return new Rectangle(0, 0, ResizeIndent, this.ClientSize.Height); } }
        Rectangle Bottom { get { return new Rectangle(0, this.ClientSize.Height - ResizeIndent, this.ClientSize.Width, ResizeIndent); } }
        Rectangle Right { get { return new Rectangle(this.ClientSize.Width - ResizeIndent, 0, ResizeIndent, this.ClientSize.Height); } }
        Rectangle TopLeft { get { return new Rectangle(0, 0, ResizeIndent, ResizeIndent); } }
        Rectangle TopRight { get { return new Rectangle(this.ClientSize.Width - ResizeIndent, 0, ResizeIndent, ResizeIndent); } }
        Rectangle BottomLeft { get { return new Rectangle(0, this.ClientSize.Height - ResizeIndent, ResizeIndent, ResizeIndent); } }
        Rectangle BottomRight { get { return new Rectangle(this.ClientSize.Width - ResizeIndent, this.ClientSize.Height - ResizeIndent, ResizeIndent, ResizeIndent); } }
        #endregion

        #region Chrom Buttons
        private void ChromClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChromMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                //Первое решение
                //Rectangle wa = Screen.FromHandle(this.Handle).WorkingArea;
                //this.MaximizedBounds = new Rectangle(0, wa.Y, wa.Width, wa.Height);

                //Второе решение
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

                this.WindowState = FormWindowState.Maximized;
            }
            else this.WindowState = FormWindowState.Normal;
        }

        private void ChromMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion
    }
}
