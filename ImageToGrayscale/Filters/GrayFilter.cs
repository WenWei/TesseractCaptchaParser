using System;
using System.Drawing;

namespace ImageToGrayscale.Filters
{
    /// <summary>
    /// �Ƕ�
    /// </summary>
    [Serializable()]
    public class GrayFilter : IFilter
    {
        public GrayAlgorithmType Type { get; set; }

        public string Id => "Gray";
        public string Name => "�Ƕ���";
        public string Description => "�N�m���ର�¥�";

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