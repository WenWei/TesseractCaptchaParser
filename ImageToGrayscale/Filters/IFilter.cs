using System.Drawing;

namespace ImageToGrayscale.Filters
{
    public interface IFilter
    {
        string Id { get; }
        string Name { get; }
        string Description { get; }
        Bitmap Execute(Bitmap bitmap);
    }
}
