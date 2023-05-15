using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePaint
{
    public class ModelTools
    {
        public Pen Pen { get; private set; }
        public Pen Eraser { get; private set; }

        public ModelTools()
        {
            Pen = new Pen(Color.Black, 1);
            Eraser = new Pen(Color.White, 1.5f);

            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            Eraser.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Eraser.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }
    }
}
