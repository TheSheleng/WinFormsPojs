using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SimplePaint
{
    public class ModelCanva
    {
        public MainMediator Meditor { get; private set; }

        public Bitmap Bitmap { get; private set; }
        public Graphics Graphic { get; private set; }

        public ModelCanva(MainMediator mediator) : this(mediator, 500, 500) { }

        public ModelCanva(MainMediator mediator, int width, int height)
        {
            Meditor = mediator;

            Bitmap = new Bitmap(width, height);
            Graphic = Graphics.FromImage(Bitmap);
            Graphic.Clear(Color.White);
        }

        public void Reaize(int width, int height)
        {
            Image image = Image.FromHbitmap(Bitmap.GetHbitmap());
            Bitmap = new Bitmap(width, height);
            Graphic = Graphics.FromImage(Bitmap);
            Graphic.Clear(Color.White);
            Graphic.DrawImage(image, 0, 0);
        }

        public void DrawLines(Pen pen, Point[] ps) => Graphic.DrawLines(pen, ps);
        public void DrawLine(Pen pen, Point p1, Point p2) => Graphic.DrawLine(pen, p1, p2);
        public void DrawRectangle(Pen pen, Point p1, Point p2) => Graphic.DrawRectangle(pen,
                            Math.Min(p1.X, p2.X),
                            Math.Min(p1.Y, p2.Y),
                            Math.Abs(p1.X - p2.X),
                            Math.Abs(p1.Y - p2.Y)
                        );
        public void DrawEllipse(Pen pen, Point p1, Point p2) => Graphic.DrawEllipse(pen, p1.X, p1.Y, p2.X - p1.X, p2.Y - p1.Y);
        public void DrawPolygon(Pen pen, Point[] ps) => Graphic.DrawPolygon(pen, ps);

        public Color GetPixel(int x, int y) => Bitmap.GetPixel(x, y);
        public void Fill(int x, int y, Color c)
        {
            Color oldColor = Bitmap.GetPixel(x, y);
            Stack<Point> pixels = new Stack<Point>();
            pixels.Push(new Point(x, y));
            Bitmap.SetPixel(x, y, c);

            if (oldColor.ToArgb() == c.ToArgb()) return;
            while (pixels.Count > 0)
            { 
                Point p = pixels.Pop();
                if (p.X > 0 && p.Y > 0 && p.X < Bitmap.Width - 1 && p.Y < Bitmap.Height - 1)
                {
                    Validate(pixels, p.X - 1, p.Y, oldColor, c);
                    Validate(pixels, p.X, p.Y - 1, oldColor, c);
                    Validate(pixels, p.X + 1, p.Y, oldColor, c);
                    Validate(pixels, p.X, p.Y + 1, oldColor, c);
                    Validate(pixels, p.X - 1, p.Y - 1, oldColor, c);
                    Validate(pixels, p.X - 1, p.Y + 1, oldColor, c);
                    Validate(pixels, p.X + 1, p.Y - 1, oldColor, c);
                    Validate(pixels, p.X + 1, p.Y + 1, oldColor, c);
                }
            }
        }
        void Validate(Stack<Point> sp, int x, int y, Color oldColor, Color newColor)
        {
            if (Bitmap.GetPixel(x, y) != oldColor) return;

            sp.Push(new Point(x, y));
            Bitmap.SetPixel(x, y, newColor);
        }

        public void Clear(Color c)
        {
            Graphic.Clear(c);
        }

        public void Export()
        {
            BitmapSave bms = new BitmapSave();
            bms.Bitmap = Bitmap;
            bms.Save();
        }
    }
}
