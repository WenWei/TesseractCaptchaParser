using System;
using System.Drawing;

namespace OcrPreprocessorLib.Preprocessor.Filters
{
    /// <summary>
    /// Grayscale to black and white
    /// </summary>
    [Serializable()]
    public class BinarizationFilter : IFilter
    {
        public string Id => "Binarization";
        public string Name => "Binarization"; //二值化
        public string Description => "Grayscale to black and white"; //將灰階色轉為黑白

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

        public Bitmap Apply(Bitmap bitmap)
        {
            return BitmapUtils.Binarization(bitmap, Threshold);
        }
    }
}