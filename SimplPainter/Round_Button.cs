using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace SimplPainter
{
    internal class Round_Button : Button
    {
        private int borderSize = 0;
        private int borderRadius = 40;
        private Color borderColor = Color.PaleVioletRed;

        [Category("Round_Button")]
        public int BorderSize
        { 
            get { return borderSize; } 
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        [Category("Round_Button")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                if (value <= Height) borderRadius = value;
                else borderRadius = Height;
                this.Invalidate();
            }
        }

        [Category("Round_Button")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        [Category("Round_Button")]
        public Color BackgroundColor
        {
            get { return BackColor; }
            set { BackColor = value; }
        }

        [Category("Round_Button")]
        public Color TextColor
        {
            get { return ForeColor; }
            set { ForeColor = value; }
        }

        public Round_Button()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Size = new Size(150, 40);
            BackColor = Color.MediumSlateBlue;
            ForeColor = Color.White;
            Resize += new EventHandler(Button_Resize);
        }

        private void Button_Resize(object sender, EventArgs e)
        { 
            if (borderRadius > Height) borderRadius = Height;
        }

        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            RectangleF rectSurface = new RectangleF(0, 0, Width, Height);
            RectangleF rectBorder = new RectangleF(1, 1, Width - 0.5F, Height - 1);

            if (borderRadius > 2)
            {
                //using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                //using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - 1F))
                //using (Pen penSurface = new Pen(Parent.BackColor, 2))
                //using (Pen penBorder = new Pen(borderColor, borderSize))
                //{
                //    penBorder.Alignment = PenAlignment.Inset;

                //    GraphicsPath p = new GraphicsPath();
                //    p.AddEllipse(1, 1, Width - 4, Height - 4);
                //    Region = new Region(p);

                //    //pevent.Graphics.DrawRectangle(penBorder, rectSurface);
                //    //pevent.Graphics.DrawRectangle(penSurface, rectBorder);
                //}

                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - 1F))
                using (Pen penSurface = new Pen(Parent.BackColor, 2))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    Region = new Region(pathSurface);
                    pevent.Graphics.DrawPath(penSurface, pathSurface);

                    if (borderSize >= 1) pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else 
            {
                Region = new Region(rectSurface);

                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, Width - 1, Height - 1);
                    }
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            //Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        { 
            Invalidate();
        }
    }
}
