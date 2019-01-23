using System;
using System.Drawing;

namespace OcrPreprocessorLib.Preprocessor.Filters
{
    [Serializable]
    public class NegativeFilter : IFilter
    {
        public string Id => "Negative";
        public string Name => "Negative film effect"; //底片負片效果
        public string Description => "Negative film effect";

        public Bitmap Apply(Bitmap bitmap)
        {
            return BitmapUtils.NegativeImage(bitmap);
        }
    }
}