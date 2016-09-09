using System;
using System.Drawing;

namespace ImageToGrayscale.Filters
{
    [Serializable()]
    public class CorrodeFilter : IFilter
    {
        public string Id => "Corrode";
        public string Name => "腐蝕";
        public string Description => "將黑點變細，九格中有白點就變細";

        public Bitmap Execute(Bitmap bitmap)
        {
            return BitmapUtils.Corrode(bitmap);
        }
    }
}