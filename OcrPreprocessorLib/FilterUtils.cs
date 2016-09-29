using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using OcrPreprocessorLib.Preprocessor.Filters;

namespace OcrPreprocessorLib
{
    public static class FilterUtils
    {
        public static List<IFilter> Load(string fullFileName)
        {
            var list = SerializableUtils.DeserializeFromBinary<List<Object>>(fullFileName)
                .Select(o => (IFilter) o)
                .ToList();
            return list;
        }

        public static Bitmap Apply(this List<IFilter> filters, Bitmap bitmap)
        {
            foreach(IFilter filter in filters)
            {
                bitmap = filter.Apply(bitmap);
            }
            return bitmap;
        }
    }
}
