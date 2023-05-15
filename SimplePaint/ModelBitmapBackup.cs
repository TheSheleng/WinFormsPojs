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
            redo.Clear();

            if (undo.Count > MaxSize) undo.RemoveLast();
        }

        public Bitmap Undo()
        {
            if (undo.Count == 0) return null;
            redo.AddFirst(undo.First());
            undo.RemoveFirst();
            if (undo.Count == 0) return null;

            return undo.First().Clone(
                new Rectangle(0, 0, undo.First().Width, undo.First().Height),
                undo.First().PixelFormat
            );
        }

        public Bitmap Redo()
        {
            if (redo.Count == 0) return null;
            undo.AddFirst(redo.First());

            Bitmap res = redo.First().Clone(
                new Rectangle(0, 0, redo.First().Width, redo.First().Height),
                redo.First().PixelFormat
            );
            redo.RemoveFirst();
            return res;
        }
    }
}
