using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePaint
{
    public class ModelBitmapBackup
    {
        LinkedList<Bitmap> undo;
        LinkedList<Bitmap> redo;
        int index = 0;
        int MaxSize;

        public ModelBitmapBackup(int maxSize)
        {
            undo = new LinkedList<Bitmap>();
            redo = new LinkedList<Bitmap>();

            MaxSize = maxSize;
        }

        public void AddBackup(Bitmap bt)
        {
            undo.AddFirst(
                bt.Clone(
                    new Rectangle(0, 0, bt.Width, bt.Height),
                    bt.PixelFormat
                ));

            if (undo.Count > MaxSize) undo.RemoveLast();
            else index++;
        }

        public Bitmap Undo()
        {
            redo.AddFirst(undo.First());
            undo.RemoveFirst();
            return redo.First().Clone(
                new Rectangle(0, 0, redo.First().Width, redo.First().Height),
                redo.First().PixelFormat
            );
        }
    }
}
