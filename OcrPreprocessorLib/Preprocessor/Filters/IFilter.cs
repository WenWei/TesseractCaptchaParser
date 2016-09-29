using System.Drawing;

namespace OcrPreprocessorLib.Preprocessor.Filters
{
    public interface IFilter
    {
        string Id { get; }
        string Name { get; }
        string Description { get; }
        Bitmap Apply(Bitmap bitmap);
    }
}
