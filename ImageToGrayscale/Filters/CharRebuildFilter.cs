using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageToGrayscale.Filters
{
    [Serializable]
    public class CharRebuildFilter : IFilter
    {
        public string Id => "CharRebuild";
        public string Name => "字元切割";
        public string Description => "字元切割後重建新圖";
        public List<Rectangle> Rectangles { get; set; }
        public int Space { get; set; }
        public PaddingFrame Margin { get; set; }
        public CharRebuildFilter()
        {
            Rectangles=new List<Rectangle>();
            Space = 0;
            Margin=new PaddingFrame();
        }

        public Bitmap Execute(Bitmap bitmap)
        {
            var w = 0;
            var h = 0;
            
            // Width for new bitmap
            for (int i = 0; i < Rectangles.Count; i++)
            {
                w += Rectangles[i].Width;
            }
            w = w + (Rectangles.Count - 1)*Space;
            w = w + Margin.Left + Margin.Right;

            // Height for new bitmap
            for(int i = 0; i < Rectangles.Count; i++)
            {
                h = Math.Max(h, Rectangles[i].Height);
            }
            h = h + Margin.Top + Margin.Bottom;

            var newbmp = new Bitmap(w,h);
            Graphics g = Graphics.FromImage(newbmp);
            var white = Color.FromArgb(255, 255, 255, 255);
            g.FillRectangle(new SolidBrush(white), 0, 0, w, h);
            

            int x = Margin.Left;
            int y = Margin.Top;

            for (int i = 0; i < Rectangles.Count; i++)
            {
                var srcRect = Rectangles[i];
                var destRect = new Rectangle(x, y, srcRect.Width, srcRect.Height);
                g.DrawImage(bitmap, destRect, srcRect, GraphicsUnit.Pixel);
                x += destRect.Width + Space;
            }
            return newbmp;
        }
    }
}
