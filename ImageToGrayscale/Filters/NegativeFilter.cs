using System;
using System.Drawing;

namespace ImageToGrayscale.Filters
{
    [Serializable()]
    public class NegativeFilter : IFilter
    {
        public string Id => "Negative";
        public string Name => "底片負片效果";
        public string Description => "負片效果";

        public Bitmap Execute(Bitmap bitmap)
        {
            return BitmapUtils.NegativeImage(bitmap);
        }
    }
}