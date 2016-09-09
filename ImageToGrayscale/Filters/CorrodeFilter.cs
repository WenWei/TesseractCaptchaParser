using System;
using System.Drawing;

namespace ImageToGrayscale.Filters
{
    [Serializable()]
    public class CorrodeFilter : IFilter
    {
        public string Id => "Corrode";
        public string Name => "�G�k";
        public string Description => "�N���I�ܲӡA�E�椤�����I�N�ܲ�";

        public Bitmap Execute(Bitmap bitmap)
        {
            return BitmapUtils.Corrode(bitmap);
        }
    }
}