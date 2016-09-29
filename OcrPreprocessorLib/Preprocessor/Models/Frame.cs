using System;

namespace OcrPreprocessorLib.Preprocessor.Models
{
    [Serializable()]
    public abstract class Frame
    {
        public int Left { get; set; }
        public int Top { get; set; }
        public int Right { get; set; }
        public int Bottom { get; set; }
    }
}