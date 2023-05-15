using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePaint
{
    public partial class MainWindow : Form
    {
        public MainMediator Mediator { get; private set; }

        public MainWindow(MainMediator mediator)
        {
            Mediator = mediator;
            InitializeComponent();

            ButtonDWPen.Tag = DrawMethod.Pen;
            ButtonDWFill.Tag = DrawMethod.Fill;
            ButtonDWPipette.Tag = DrawMethod.Pipette;
            ButtonDWEraser.Tag = DrawMethod.Eraser;
            ButtonDWLine.Tag = DrawMethod.Line;
            ButtonDWEllipse.Tag = DrawMethod.Ellipse;
            ButtonDWRectangle.Tag = DrawMethod.Rectangle;
            ButtonDWPolygon.Tag = DrawMethod.Polygon;

            ButtonDW_Click(ButtonDWPen, new EventArgs());

            Padding = new Padding(ResizeIndent);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            PenColorChanged(ButtonColor3, new EventArgs());
            PenWidthChanged(PenSize, new EventArgs());
        }

        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == 0x84) // WM_NCHITTEST
            {
                //Resizeble Window
                var cursor = PointToClient(Cursor.Position);

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

        public void SetCanvaBitMap(Bitmap bm)
        {
            Canva.Image = bm;
        }

        #region Draw Tools Setts
        enum DrawMethod
        {
            //Tools
            Pen,
            Eraser,
            Fill,
            Pipette,

            //Shapes
            Line,
            Ellipse,
            Rectangle, 
            Polygon,
        } DrawMethod dw;

        private void ButtonDW_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            dw = (DrawMethod)bt.Tag;

            ButtonDWPen.BackColor =
            ButtonDWFill.BackColor =
            ButtonDWPipette.BackColor =
            ButtonDWEraser.BackColor =
            ButtonDWLine.BackColor =
            ButtonDWEllipse.BackColor =
            ButtonDWRectangle.BackColor =
            ButtonDWPolygon.BackColor = Color.FromArgb(34, 39, 42);

            bt.BackColor = Color.FromArgb(22, 26, 29);

            if (dw != DrawMethod.Polygon)
            {
                polygon.Clear();
                Canva.Refresh();
            }
        }
        private void PenColorChanged(object sender, EventArgs e)
        {
            Mediator.ChangePenColor(ColorPicked.BackColor);
        }

        private void PenWidthChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text == "") textBox.Text = "1";
            Mediator.ChangePenWidth(Convert.ToInt16(PenSize.Text));
        }
        public void SetColorPicked(Color c)
        {
            ColorPicked.BackColor = c;
        }
        #endregion

        #region Mouse Canva
        Point startPoint, endPoint;
        bool isPainting = false;
        List<Point> polygon = new List<Point>();
        private void Canva_MouseDown(object sender, MouseEventArgs e)
        {
            isPainting = true;
            startPoint = e.Location;
        }

        private void Canva_MouseUp(object sender, MouseEventArgs e)
        {
            isPainting = false;

            switch (dw)
            {
                case DrawMethod.Line: Mediator.DrawLine(startPoint, endPoint); break;
                case DrawMethod.Rectangle: Mediator.DrawRectangle(startPoint, endPoint); break;
                case DrawMethod.Ellipse: Mediator.DrawEllipse(startPoint, endPoint); break;
            }

            if (dw != DrawMethod.Polygon) Mediator.MakeBackup();
        }

        private void Canva_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isPainting) return;

            endPoint = e.Location;
            switch (dw)
            {
                case DrawMethod.Pen:
                    Mediator.DrawLine(startPoint, endPoint);
                    startPoint = endPoint;
                    break;
                case DrawMethod.Eraser:
                    Mediator.EraseLine(startPoint, endPoint);
                    startPoint = endPoint;
                    break;
            } 

            Canva.Refresh();
        }

        private void Canva_MouseClick(object sender, MouseEventArgs e)
        {
            switch (dw)
            {
                case DrawMethod.Pipette: Mediator.GetColor(e.X, e.Y); break;
                case DrawMethod.Fill: Mediator.Fill(e.X, e.Y); break;
                case DrawMethod.Polygon: polygon.Add(e.Location); break;
            }
            Canva.Refresh();
        }

        private void Canva_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            switch (dw)
            {
                case DrawMethod.Polygon:
                    if (polygon.Count > 1) Mediator.DrawPolygon(polygon.ToArray());
                    polygon.Clear();
                    Mediator.MakeBackup();
                    break;
            }
        }
        #endregion

        #region Other Canva
        private void Canva_Paint(object sender, PaintEventArgs e)
        {
            if (!isPainting) return;
            Graphics g = e.Graphics;

            switch (dw)
            {
                case DrawMethod.Line: g.DrawLine(Mediator.Tools.Pen, startPoint, endPoint); break;
                case DrawMethod.Rectangle: 
                    g.DrawRectangle(Mediator.Tools.Pen, 
                        Math.Min(startPoint.X, endPoint.X), 
                        Math.Min(startPoint.Y, endPoint.Y), 
                        Math.Abs(startPoint.X - endPoint.X), 
                        Math.Abs(startPoint.Y - endPoint.Y)
                        ); 
                    break;
                case DrawMethod.Ellipse: 
                    g.DrawEllipse(Mediator.Tools.Pen, 
                        startPoint.X, startPoint.Y, 
                        endPoint.X - startPoint.X, endPoint.Y - startPoint.Y
                        ); 
                    break;
                case DrawMethod.Polygon: 
                    if (polygon.Count > 1) g.DrawPolygon(Mediator.Tools.Pen, polygon.ToArray());
                    break;
            }
        }

        private void FillUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContextMenuStrip owner = (sender as ToolStripItem).Owner as ContextMenuStrip;
            if (owner != null)
            {
                Mediator.Clear(owner.SourceControl.BackColor);
                Canva.Refresh();
            }
        }

        private void CanvaSizeChanged(object sender, EventArgs e)
        {
            int width; Int32.TryParse(CanvaWidht.Text, out width);
            int height; Int32.TryParse(CanvaHeight.Text, out height);

            if (width != 0 && height != 0)
            {
                Canva.Width = width;
                Canva.Height = height;
                Mediator.ResizeCanva(width, height);
            }
        }
        #endregion

        #region File Button
        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            Mediator.Save();
        }

        private void UndoButton_Click(object sender, EventArgs e)
        {
            Mediator.Undo();
            Canva.Refresh();
        }

        private void ReduButton_Click(object sender, EventArgs e)
        {
            Mediator.Redo();
            Canva.Refresh();
        }
        #endregion 

        #region View
        private void MainWindow_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                Padding = new Padding(0);
            else Padding = new Padding(3);
        }

        private void TextBoxWriteSize(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || //Only numbers
                textBox.TextLength == 0 && e.KeyChar == '0') //Can't write zero
            {
                e.Handled = true;
            }
            else if (e.KeyChar == (char)13)
            {
                if (textBox.Text == "") textBox.Text = "1";
                Canva.Focus();
            }
        }

        private void ButtonColor_Click(object sender, EventArgs e)
        {
            ColorPicked.BackColor = (sender as Button).BackColor;
        }

        private void ColorPicked_Click(object sender, EventArgs e)
        {
            if (ColorDialog.ShowDialog(this) == DialogResult.OK)
            {
                ColorPicked.BackColor = ColorDialog.Color;
            }
        }

        private void BrushUp_Click(object sender, EventArgs e)
        {
            int brSize = Convert.ToInt32(PenSize.Text);
            if (brSize < 999)
            {
                PenSize.Text = (Convert.ToInt32(PenSize.Text) + 1).ToString();
            }
        }

        private void BrushDown_Click(object sender, EventArgs e)
        {
            int brSize = Convert.ToInt32(PenSize.Text);
            if (brSize > 1)
            {
                PenSize.Text = (Convert.ToInt32(PenSize.Text) - 1).ToString();
            }
        }
        #endregion

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

        Rectangle Top { get { return new Rectangle(0, 0, ClientSize.Width, ResizeIndent); } }
        Rectangle Left { get { return new Rectangle(0, 0, ResizeIndent, ClientSize.Height); } }
        Rectangle Bottom { get { return new Rectangle(0, ClientSize.Height - ResizeIndent, ClientSize.Width, ResizeIndent); } }
        Rectangle Right { get { return new Rectangle(ClientSize.Width - ResizeIndent, 0, ResizeIndent, ClientSize.Height); } }
        Rectangle TopLeft { get { return new Rectangle(0, 0, ResizeIndent, ResizeIndent); } }
        Rectangle TopRight { get { return new Rectangle(ClientSize.Width - ResizeIndent, 0, ResizeIndent, ResizeIndent); } }
        Rectangle BottomLeft { get { return new Rectangle(0, ClientSize.Height - ResizeIndent, ResizeIndent, ResizeIndent); } }
        Rectangle BottomRight { get { return new Rectangle(ClientSize.Width - ResizeIndent, ClientSize.Height - ResizeIndent, ResizeIndent, ResizeIndent); } }
        #endregion

        #region Chrom Buttons
        private void ChromClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChromMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                //Первое решение
                //Rectangle wa = Screen.FromHandle(this.Handle).WorkingArea;
                //this.MaximizedBounds = new Rectangle(0, wa.Y, wa.Width, wa.Height);

                //Второе решение
                MaximizedBounds = Screen.PrimaryScreen.WorkingArea;

                WindowState = FormWindowState.Maximized;
            }
            else WindowState = FormWindowState.Normal;
        }

        private void ChromMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion
    }
}
