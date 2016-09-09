using System;
using System.Drawing;

namespace ImageToGrayscale.Filters
{
    /// <summary>
    /// 灰階
    /// </summary>
    [Serializable()]
    public class GrayFilter : IFilter
    {
        public GrayAlgorithmType Type { get; set; }

        public string Id => "Gray";
        public string Name => "灰階化";
        public string Description => "將彩色轉為黑白";

        public GrayFilter()
        {
            Type = GrayAlgorithmType.Average;
        }

        public GrayFilter(GrayAlgorithmType type)
        {
            Type = type;
        }

        public Bitmap Execute(Bitmap bitmap)
        {
            return BitmapUtils.GrayImage(bitmap, this.Type);
        }
    }
}