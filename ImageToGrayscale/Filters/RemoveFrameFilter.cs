using System;
using System.Drawing;


namespace ImageToGrayscale.Filters
{
    [Serializable()]
    public class RemoveFrameFilter : IFilter
    {

        public string Id => "RemoveFrame";

        public string Name => "移除邊框";
        public string Description => "移除邊 左上右下";
        public PaddingFrame Padding { get; set; }
        public Color Color { get; set; }

        public RemoveFrameFilter()
        {
            Padding=new PaddingFrame
            {
                Left = 0, Top = 0, Right = 0, Bottom = 0
            };
        }

        public Bitmap Execute(Bitmap bitmap)
        {
            return BitmapUtils.RemoveFrame(bitmap, this.Padding, this.Color);
        }
    }

    [Serializable()]
    public class PaddingFrame
    {
        public int Left { get; set; }
        public int Top { get; set; }
        public int Right { get; set; }
        public int Bottom { get; set; }
    }
}
