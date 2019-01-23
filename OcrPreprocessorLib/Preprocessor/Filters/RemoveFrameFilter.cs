using System;
using System.Drawing;
using OcrPreprocessorLib.Preprocessor.Models;

namespace OcrPreprocessorLib.Preprocessor.Filters
{
    [Serializable()]
    public class RemoveFrameFilter : IFilter
    {

        public string Id => "RemoveFrame";

        public string Name => "Remove Frame"; //移除邊框
        public string Description => "Remove border (left, top, right, bottom)"; //移除邊 左上右下
        public Paddings Padding { get; set; }
        public Color Color { get; set; }

        public RemoveFrameFilter()
        {
            Padding=new Paddings
            {
                Left = 0, Top = 0, Right = 0, Bottom = 0
            };
        }

        public Bitmap Apply(Bitmap bitmap)
        {
            return BitmapUtils.RemoveFrame(bitmap, this.Padding, this.Color);
        }
    }
}
