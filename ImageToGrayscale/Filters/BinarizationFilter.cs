using System;
using System.Drawing;

namespace ImageToGrayscale.Filters
{
    /// <summary>
    /// 黑白
    /// </summary>
    [Serializable()]
    public class BinarizationFilter : IFilter
    {
        public string Id => "Binarization";
        public string Name => "二值化";
        public string Description => "將灰階色轉為黑白";

        private int _threshold = 128;
        public int Threshold
        {
            get { return _threshold; }
            set
            {
                if(value < 0)
                    _threshold = 0;
                else if(value > 255)
                    _threshold = 255;
                else
                    _threshold = value;
            }
        }

        public Bitmap Execute(Bitmap bitmap)
        {
            return BitmapUtils.Binarization(bitmap, Threshold);
        }
    }
}