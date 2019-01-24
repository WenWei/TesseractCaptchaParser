using System;
using System.Drawing;
using OcrPreprocessorLib.Preprocessor.Models;

namespace OcrPreprocessorLib.Preprocessor.Filters
{
    /// <summary>
    /// Grayscale
    /// </summary>
    [Serializable]
    public class GrayFilter : IFilter
    {
        public GrayAlgorithmTypes Type { get; set; }

        public string Id => "Gray";
        public string Name => "Grayscale"; //灰階化
        public string Description => "Convert RGB to grayscale";// 將彩色轉為灰階

        public GrayFilter()
        {
            Type = GrayAlgorithmTypes.Average;
        }

        public GrayFilter(GrayAlgorithmTypes type)
        {
            Type = type;
        }

        public Bitmap Apply(Bitmap bitmap)
        {
            return BitmapUtils.GrayImage(bitmap, this.Type);
        }
    }
}
