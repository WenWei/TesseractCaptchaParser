using System;
using System.Drawing;

namespace ImageToGrayscale.Filters
{
    [Serializable()]
    public class ResizeFilter : IFilter
    {
        public string Id => "Resize";
        public string Name => "調整大小";
        public string Description => "改變圖檔大小";
        public Size Size { get; set; }

        public ResizeFilter()
        {
            Size=new Size(40,30);
        }
        public ResizeFilter(Size size)
        {
            Size=size;
        }
        public Bitmap Execute(Bitmap bitmap)
        {
            return BitmapUtils.ResizeImage(bitmap, Size);
        }
    }
}