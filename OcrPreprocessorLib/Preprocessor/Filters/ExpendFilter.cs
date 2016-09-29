using System;
using System.Drawing;

namespace OcrPreprocessorLib.Preprocessor.Filters
{
    /// <summary>
    /// 膨脹
    /// </summary>
    [Serializable()]
    public class ExpendFilter : IFilter
    {
        public string Id => "Expend";
        public string Name => "膨脹";
        public string Description => "將黑點變粗，九格中有黑點就變粗";

        public Bitmap Apply(Bitmap bitmap)
        {
            return BitmapUtils.expend(bitmap);
        }
    }
}