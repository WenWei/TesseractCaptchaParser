using System;
using System.Drawing;

namespace OcrPreprocessorLib.Preprocessor.Filters
{
    [Serializable]
    public class CorrodeFilter : IFilter
    {
        public string Id => "Corrode";
        public string Name => "corrosion"; //腐蝕
        public string Description => "Thinning the black dots, and the white spots in the nine grids become thinner"; //將黑點變細，九格中有白點就變細

        public Bitmap Apply(Bitmap bitmap)
        {
            return BitmapUtils.Corrode(bitmap);
        }
    }
}
