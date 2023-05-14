using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePaint
{
    public class Canva
    {
        public MainMediator Meditor { get; private set; }

        Bitmap BitmapCanva;
        Graphics GraphicCanva;
        Pen PenCanva;
        Pen EraserCanva;

        Point StartLinePint, EndLinePint;
        bool isPainting = false;

        public Canva(MainMediator mediator)
        {
            Meditor = mediator;
        }

        public void SetSize(int width, int height) 
        {
            BitmapCanva = new Bitmap(width, height);
            GraphicCanva = Graphics.FromImage(BitmapCanva);
            GraphicCanva.Clear(Color.White);
        }

        public void Reaize(int width, int height)
        {
            Image image = Image.FromHbitmap(BitmapCanva.GetHbitmap());
            BitmapCanva = new Bitmap(width, height);
            GraphicCanva = Graphics.FromImage(BitmapCanva);
            GraphicCanva.Clear(Color.White);
            GraphicCanva.DrawImage(image, 0, 0);
        }
    }
}
