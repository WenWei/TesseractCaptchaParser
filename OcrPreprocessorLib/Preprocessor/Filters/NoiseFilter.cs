using System;
using System.Collections.Generic;
using System.Drawing;

namespace OcrPreprocessorLib.Preprocessor.Filters
{
    [Serializable()]
    public class NoiseFilter : IFilter
    {
        public string Id => "Noise";
        public string Name => "Reduce noise"; //降雜訊
        public string Description => "";

        public Bitmap Apply(Bitmap bitmap)
        {
            return RemoveNoise(bitmap);
        }

        private Bitmap RemoveNoise(Bitmap bitmap)
        {
            List<Point> lst = new List<Point>();
            for(int x = 0; x < bitmap.Width; x++)
                for(int y = 0; y < bitmap.Height; y++)
                {
                    Color c = bitmap.GetPixel(x, y);
                    if((c.R + c.G + c.B) / 3 > 0x60)
                        bitmap.SetPixel(x, y, Color.White);
                    else
                        bitmap.SetPixel(x, y, Color.Black);
                }

            for (int x = 0; x < bitmap.Width; x++)
                for (int y = 0; y < bitmap.Height; y++)
                {
                    Color c = bitmap.GetPixel(x, y);
                    if (c != Color.White)
                    {
                        int size = 0;
                        Bitmap tmp = (Bitmap) bitmap.Clone();
                        CalcArea(ref tmp, x, y, ref size);
                        if (size < 60)
                        {
                            bitmap.Dispose();
                            bitmap = tmp;
                        }
                        else
                        {
                            tmp.Dispose();
                        }
                    }
                }
            return bitmap;
        }

        private void CalcArea(ref Bitmap bm, int x, int y, ref int size)
        {
            if (x < 0 || x >= bm.Width || y < 0 || y >= bm.Height) return;
            Color c = bm.GetPixel(x, y);
            if (c.R == 0xff && c.G == 0xff && c.B == 0xff)
            {
                return;
            }
            else
            {
                size++;
                bm.SetPixel(x, y, Color.White);
                CalcArea(ref bm, x - 1, y, ref size);
                CalcArea(ref bm, x, y - 1, ref size);
                CalcArea(ref bm, x + 1, y, ref size);
                CalcArea(ref bm, x, y + 1, ref size);
            }
        }
    }
}
