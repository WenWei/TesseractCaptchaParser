using System;
using System.Drawing;
using OcrPreprocessorLib.Preprocessor.Models;

namespace OcrPreprocessorLib.Preprocessor.Filters
{
    /// <summary>
    /// �Ƕ�
    /// </summary>
    [Serializable()]
    public class GrayFilter : IFilter
    {
        public GrayAlgorithmTypes Type { get; set; }

        public string Id => "Gray";
        public string Name => "�Ƕ���";
        public string Description => "�N�m���ର�¥�";

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