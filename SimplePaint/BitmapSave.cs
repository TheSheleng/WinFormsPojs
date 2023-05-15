using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace SimplePaint
{
    public class BitmapSave
    {
        SaveFileDialog dialog;

        Bitmap bitmap;
        public Bitmap Bitmap
        {
            get { return bitmap; }
            set 
            {
                if (value == null) bitmap = null;
                else
                    bitmap = value.Clone(
                        new Rectangle(0, 0, value.Width, value.Height), 
                        value.PixelFormat
                    );
            }
        }

        public BitmapSave()
        {
            dialog = new SaveFileDialog();
            dialog.FileName = "Image";
            dialog.Filter = "JPEG(*.jpg)|*.jpg|PNG(*.png)|*.png";
            Bitmap = null;
        }

        public BitmapSave(Bitmap bm) : this() { Bitmap = bm; }

        public async void Save()
        {
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                await Task.Run(() =>
                {
                    ImageFormat format = ImageFormat.Jpeg;
                    switch (dialog.FilterIndex)
                    {
                        case 0: format = ImageFormat.Jpeg; break;
                        case 1: format = ImageFormat.Png; break;
                    }

                    Bitmap.Save(
                        dialog.FileName,
                        format
                    );
                });
            }
        }
    }
}
