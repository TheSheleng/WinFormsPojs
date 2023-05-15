using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePaint
{
    public class MainMediator
    {
        public MainWindow View { get; private set; }
        public ModelCanva Canva { get; private set; }
        public ModelTools Tools { get; private set; }

        public ModelBitmapBackup Backups { get; private set; }

        public MainMediator()
        {
            View = new MainWindow(this);
            Canva = new ModelCanva(this);
            View.SetCanvaBitMap(Canva.Bitmap);

            Tools = new ModelTools();
            Backups = new ModelBitmapBackup(10);
            Backups.AddBackup(Canva.Bitmap);
        }

        public void ResizeCanva(int width, int height)
        {
            Canva.Reaize(width, height);
            View.SetCanvaBitMap(Canva.Bitmap);
        }

        #region Draw Method
        public void DrawLines(Point[] ps) => Canva.DrawLines(Tools.Pen, ps);
        public void EraseLines(Point[] ps) => Canva.DrawLines(Tools.Eraser, ps);
        public void DrawLine(Point p1, Point p2) => Canva.DrawLine(Tools.Pen, p1, p2);
        public void EraseLine(Point p1, Point p2) => Canva.DrawLine(Tools.Eraser, p1, p2);
        public void DrawRectangle(Point p1, Point p2) => Canva.DrawRectangle(Tools.Pen, p1, p2);
        public void DrawEllipse(Point p1, Point p2) => Canva.DrawEllipse(Tools.Pen, p1, p2);
        public void DrawPolygon(Point[] ps) => Canva.DrawPolygon(Tools.Pen, ps);
        public void ChangePenColor(Color c) => Tools.Pen.Color = c;
        public void ChangePenWidth(int w) => Tools.Eraser.Width = (int)((Tools.Pen.Width = w) * 1.5);
        public void Fill(int x, int y) => Canva.Fill(x, y, Tools.Pen.Color);
        #endregion

        public void GetColor(int x, int y)
        {
            Tools.Pen.Color = Canva.GetPixel(x, y);
            View.SetColorPicked(Tools.Pen.Color);
        }
        public void Clear(Color c) => Canva.Clear(c);

        #region File work
        public void Save() => Canva.Export();
        public void MakeBackup() => Backups.AddBackup(Canva.Bitmap);
        public void Undo()
        {
            Bitmap bm = Backups.Undo();
            if (bm != null) Canva.Graphic.DrawImage(Image.FromHbitmap(bm.GetHbitmap()), 0, 0);
        }
        public void Redo()
        {
            Bitmap bm = Backups.Redo();
            if (bm != null) Canva.Graphic.DrawImage(Image.FromHbitmap(bm.GetHbitmap()), 0, 0);
        }
        #endregion
    }
}
