using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using OcrPreprocessorLib.Preprocessor.Models;

namespace OcrPreprocessorLib.Preprocessor
{
    public static class BitmapUtils
    {
        //旋转90,180,270
        public static Bitmap RotateImage(Bitmap bmp, int angle)
        {
            if(angle != 90 && angle != 180 && angle != 270)
            {
                return null;
            }
            int width = bmp.Width;
            int height = bmp.Height;

            if(angle == 90)
            {
                Bitmap newbmp = new Bitmap(height, width);
                using(Graphics g = Graphics.FromImage(newbmp))
                {
                    Point[] destinationPoints =
                    {
                        new Point(height, 0), // destination for upper-left point of original
                        new Point(height, width), // destination for upper-right point of original
                        new Point(0, 0)
                    }; // destination for lower-left point of original
                    g.DrawImage(bmp, destinationPoints);
                }
                return newbmp;
            }

            if(angle == 180)
            {
                Bitmap newbmp = new Bitmap(width, height);
                using(Graphics g = Graphics.FromImage(newbmp))
                {
                    Point[] destinationPoints =
                    {
                        new Point(width, height), // destination for upper-left point of original
                        new Point(0, height), // destination for upper-right point of original
                        new Point(width, 0)
                    }; // destination for lower-left point of original
                    g.DrawImage(bmp, destinationPoints);
                }
                return newbmp;
            }

            if(angle == 270)
            {
                Bitmap newbmp = new Bitmap(height, width);
                using(Graphics g = Graphics.FromImage(newbmp))
                {
                    Point[] destinationPoints =
                    {
                        new Point(0, width), // destination for upper-left point of original
                        new Point(0, 0), // destination for upper-right point of original
                        new Point(height, width)
                    }; // destination for lower-left point of original
                    g.DrawImage(bmp, destinationPoints);
                }
                return newbmp;
            }
            return null;
        }

        /// <summary>
        /// Reset size
        /// </summary>
        /// <param name="bmp"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public static Bitmap ResizeImage(Bitmap bmp, Size size)
        {
            Bitmap newbmp = new Bitmap(size.Width, size.Height);
            using(Graphics g = Graphics.FromImage(newbmp))
            {
                g.DrawImage(bmp, new Rectangle(Point.Empty, size));
            }
            return newbmp;
        }

        /// <summary>
        /// 看起來像底片負片的效果
        /// </summary>
        /// <param name="bmp"></param>
        /// <returns></returns>
        public static Bitmap NegativeImage(Bitmap bmp)
        {
            int height = bmp.Height;
            int width = bmp.Width;
            Bitmap newbmp = new Bitmap(width, height);

            LockBitmap lbmp = new LockBitmap(bmp);
            LockBitmap newlbmp = new LockBitmap(newbmp);
            lbmp.LockBits();
            newlbmp.LockBits();

            Color pixel;

            // Assumes alpha is in the rightmost byte, change as needed

            for(int x = 1; x < width; x++)
            {
                for(int y = 1; y < height; y++)
                {
                    int r, g, b;
                    pixel = lbmp.GetPixel(x, y);
                    //newlbmp.SetPixel(x, y, Color.FromArgb((int) (0xFFFFFF00u ^ pixel.ToArgb())));
                    r = 255 - pixel.R;
                    g = 255 - pixel.G;
                    b = 255 - pixel.B;
                    newlbmp.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }
            lbmp.UnlockBits();
            newlbmp.UnlockBits();
            return newbmp;
        }

        /// <summary>
        /// 灰階
        /// </summary>
        /// <param name="bmp"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static Bitmap GrayImage(Bitmap bmp, GrayAlgorithmTypes type)
        {
            int height = bmp.Height;
            int width = bmp.Width;
            Bitmap newbmp = new Bitmap(width, height);

            LockBitmap lbmp = new LockBitmap(bmp);
            LockBitmap newlbmp = new LockBitmap(newbmp);
            lbmp.LockBits();
            newlbmp.LockBits();

            Color pixel;
            for(int x = 0; x < width; x++)
            {
                for(int y = 0; y < height; y++)
                {
                    pixel = lbmp.GetPixel(x, y);
                    int r, g, b, Result = 0;
                    r = pixel.R;
                    g = pixel.G;
                    b = pixel.B;
                    switch(type)
                    {
                        case GrayAlgorithmTypes.Average: //平均值
                            Result = ((r + g + b) / 3);
                            break;
                        case GrayAlgorithmTypes.Maximum: //最大值
                            Result = r > g ? r : g;
                            Result = Result > b ? Result : b;
                            break;
                        case GrayAlgorithmTypes.WeightedAverage: //加權平均值
                            Result = ((int)(0.299 * r) + (int)(0.587 * g) + (int)(0.114 * b));
                            break;
                    }
                    newlbmp.SetPixel(x, y, Color.FromArgb(Result, Result, Result));
                }
            }
            lbmp.UnlockBits();
            newlbmp.UnlockBits();
            return newbmp;
        }

        /// <summary>
        /// 浮雕
        /// 找附近像赤 r1, abs(r-r2+128)
        /// </summary>
        /// <param name="bmp"></param>
        /// <returns></returns>
        public static Bitmap EmbossmentImage(Bitmap bmp)
        {
            int height = bmp.Height;
            int width = bmp.Width;
            Bitmap newbmp = new Bitmap(width, height);

            LockBitmap lbmp = new LockBitmap(bmp);
            LockBitmap newlbmp = new LockBitmap(newbmp);
            lbmp.LockBits();
            newlbmp.LockBits();

            Color pixel1, pixel2;
            for(int x = 0; x < width - 1; x++)
            {
                for(int y = 0; y < height - 1; y++)
                {
                    int r = 0, g = 0, b = 0;
                    pixel1 = lbmp.GetPixel(x, y);
                    pixel2 = lbmp.GetPixel(x + 1, y + 1);
                    r = Math.Abs(pixel1.R - pixel2.R + 128);
                    g = Math.Abs(pixel1.G - pixel2.G + 128);
                    b = Math.Abs(pixel1.B - pixel2.B + 128);
                    if(r > 255)
                        r = 255;
                    if(r < 0)
                        r = 0;
                    if(g > 255)
                        g = 255;
                    if(g < 0)
                        g = 0;
                    if(b > 255)
                        b = 255;
                    if(b < 0)
                        b = 0;
                    newlbmp.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }
            lbmp.UnlockBits();
            newlbmp.UnlockBits();
            return newbmp;
        }

        //柔化
        public static Bitmap SoftenImage(Bitmap bmp)
        {
            int height = bmp.Height;
            int width = bmp.Width;
            Bitmap newbmp = new Bitmap(width, height);

            LockBitmap lbmp = new LockBitmap(bmp);
            LockBitmap newlbmp = new LockBitmap(newbmp);
            lbmp.LockBits();
            newlbmp.LockBits();

            Color pixel;
            //高斯模板
            int[] Gauss = { 1, 2, 1, 2, 4, 2, 1, 2, 1 };
            for(int x = 1; x < width - 1; x++)
            {
                for(int y = 1; y < height - 1; y++)
                {
                    int r = 0, g = 0, b = 0;
                    int Index = 0;
                    for(int col = -1; col <= 1; col++)
                    {
                        for(int row = -1; row <= 1; row++)
                        {
                            pixel = lbmp.GetPixel(x + row, y + col);
                            r += pixel.R * Gauss[Index];
                            g += pixel.G * Gauss[Index];
                            b += pixel.B * Gauss[Index];
                            Index++;
                        }
                    }
                    r /= 16;
                    g /= 16;
                    b /= 16;
                    //处理颜色值溢出
                    r = r > 255 ? 255 : r;
                    r = r < 0 ? 0 : r;
                    g = g > 255 ? 255 : g;
                    g = g < 0 ? 0 : g;
                    b = b > 255 ? 255 : b;
                    b = b < 0 ? 0 : b;
                    newlbmp.SetPixel(x - 1, y - 1, Color.FromArgb(r, g, b));
                }
            }
            lbmp.UnlockBits();
            newlbmp.UnlockBits();
            return newbmp;
        }

        //锐化
        public static Bitmap SharpenImage(Bitmap bmp)
        {
            int height = bmp.Height;
            int width = bmp.Width;
            Bitmap newbmp = new Bitmap(width, height);

            LockBitmap lbmp = new LockBitmap(bmp);
            LockBitmap newlbmp = new LockBitmap(newbmp);
            lbmp.LockBits();
            newlbmp.LockBits();

            Color pixel;
            //拉普拉斯模板
            int[] Laplacian = { -1, -1, -1, -1, 9, -1, -1, -1, -1 };
            for(int x = 1; x < width - 1; x++)
            {
                for(int y = 1; y < height - 1; y++)
                {
                    int r = 0, g = 0, b = 0;
                    int Index = 0;
                    for(int col = -1; col <= 1; col++)
                    {
                        for(int row = -1; row <= 1; row++)
                        {
                            pixel = lbmp.GetPixel(x + row, y + col);
                            r += pixel.R * Laplacian[Index];
                            g += pixel.G * Laplacian[Index];
                            b += pixel.B * Laplacian[Index];
                            Index++;
                        }
                    }
                    //处理颜色值溢出
                    r = r > 255 ? 255 : r;
                    r = r < 0 ? 0 : r;
                    g = g > 255 ? 255 : g;
                    g = g < 0 ? 0 : g;
                    b = b > 255 ? 255 : b;
                    b = b < 0 ? 0 : b;
                    newlbmp.SetPixel(x - 1, y - 1, Color.FromArgb(r, g, b));
                }
            }
            lbmp.UnlockBits();
            newlbmp.UnlockBits();
            return newbmp;
        }

        //雾化
        public static Bitmap AtomizationImage(Bitmap bmp)
        {
            int height = bmp.Height;
            int width = bmp.Width;
            Bitmap newbmp = new Bitmap(width, height);

            LockBitmap lbmp = new LockBitmap(bmp);
            LockBitmap newlbmp = new LockBitmap(newbmp);
            lbmp.LockBits();
            newlbmp.LockBits();

            System.Random MyRandom = new Random();
            Color pixel;
            for(int x = 1; x < width - 1; x++)
            {
                for(int y = 1; y < height - 1; y++)
                {
                    int k = MyRandom.Next(123456);
                    //像素块大小
                    int dx = x + k % 19;
                    int dy = y + k % 19;
                    if(dx >= width)
                        dx = width - 1;
                    if(dy >= height)
                        dy = height - 1;
                    pixel = lbmp.GetPixel(dx, dy);
                    newlbmp.SetPixel(x, y, pixel);
                }
            }
            lbmp.UnlockBits();
            newlbmp.UnlockBits();
            return newbmp;
        }

        //去噪音雜訊
        public static Bitmap MedianFilter(Bitmap sourceBitmap, int matrixSize, int bias = 0, bool grayscale = false)
        {
            BitmapData sourceData =
                sourceBitmap.LockBits(new Rectangle(0, 0,
                        sourceBitmap.Width, sourceBitmap.Height),
                    ImageLockMode.ReadOnly,
                    PixelFormat.Format32bppArgb);


            byte[] pixelBuffer = new byte[sourceData.Stride *
                                          sourceData.Height];


            byte[] resultBuffer = new byte[sourceData.Stride *
                                           sourceData.Height];


            Marshal.Copy(sourceData.Scan0, pixelBuffer, 0,
                pixelBuffer.Length);


            sourceBitmap.UnlockBits(sourceData);


            if(grayscale == true)
            {
                float rgb = 0;


                for(int k = 0; k < pixelBuffer.Length; k += 4)
                {
                    rgb = pixelBuffer[k] * 0.11f;
                    rgb += pixelBuffer[k + 1] * 0.59f;
                    rgb += pixelBuffer[k + 2] * 0.3f;


                    pixelBuffer[k] = (byte)rgb;
                    pixelBuffer[k + 1] = pixelBuffer[k];
                    pixelBuffer[k + 2] = pixelBuffer[k];
                    pixelBuffer[k + 3] = 255;
                }
            }


            int filterOffset = (matrixSize - 1) / 2;
            int calcOffset = 0;


            int byteOffset = 0;

            List<int> neighbourPixels = new List<int>();
            byte[] middlePixel;


            for(int offsetY = filterOffset;
                offsetY <
                sourceBitmap.Height - filterOffset;
                offsetY++)
            {
                for(int offsetX = filterOffset;
                    offsetX <
                    sourceBitmap.Width - filterOffset;
                    offsetX++)
                {
                    byteOffset = offsetY *
                                 sourceData.Stride +
                                 offsetX * 4;


                    neighbourPixels.Clear();


                    for(int filterY = -filterOffset;
                        filterY <= filterOffset;
                        filterY++)
                    {
                        for(int filterX = -filterOffset;
                            filterX <= filterOffset;
                            filterX++)
                        {


                            calcOffset = byteOffset +
                                         (filterX * 4) +
                                         (filterY * sourceData.Stride);


                            neighbourPixels.Add(BitConverter.ToInt32(
                                pixelBuffer, calcOffset));
                        }
                    }


                    neighbourPixels.Sort();

                    middlePixel = BitConverter.GetBytes(
                        neighbourPixels[filterOffset]);


                    resultBuffer[byteOffset] = middlePixel[0];
                    resultBuffer[byteOffset + 1] = middlePixel[1];
                    resultBuffer[byteOffset + 2] = middlePixel[2];
                    resultBuffer[byteOffset + 3] = middlePixel[3];
                }
            }


            Bitmap resultBitmap = new Bitmap(sourceBitmap.Width,
                sourceBitmap.Height);


            BitmapData resultData =
                resultBitmap.LockBits(new Rectangle(0, 0,
                        resultBitmap.Width, resultBitmap.Height),
                    ImageLockMode.WriteOnly,
                    PixelFormat.Format32bppArgb);


            Marshal.Copy(resultBuffer, 0, resultData.Scan0,
                resultBuffer.Length);


            resultBitmap.UnlockBits(resultData);


            return resultBitmap;
        }

        /// <summary>
        /// 二值化
        /// </summary>
        /// <param name="bitmap"></param>
        /// <param name="threshold"></param>
        /// <returns></returns>
        public static Bitmap Binarization(Bitmap bitmap, int threshold = 127)
        {
            int height = bitmap.Height;
            int width = bitmap.Width;
            Bitmap newBmp = new Bitmap(width, height);
            Color c;
            for(int i = 0; i < height; i++)
            {
                for(int j = 0; j < width; j++)
                {
                    c = bitmap.GetPixel(j, i);
                    int r = c.R;
                    int g = c.G;
                    int b = c.B;
                    if((r + g + b) / 3 >= threshold)
                    {
                        newBmp.SetPixel(j, i, Color.FromArgb(255, 255, 255));
                    }
                    else
                    {
                        newBmp.SetPixel(j, i, Color.FromArgb(0, 0, 0));
                    }
                }
            }
            return newBmp;
        }

        /// <summary>
        /// 膨脹
        /// </summary>
        /// <param name="bmp"></param>
        /// <returns></returns>
        public static Bitmap expend(Bitmap bmp)
        {
            int height = bmp.Height;
            int width = bmp.Width;
            Bitmap newBmp = new Bitmap(width, height);

            bool[] pixels;
            for(int i = 1; i < width - 1; i++)
            {
                for(int j = 1; j < height - 1; j++)
                {

                    if(bmp.GetPixel(i, j).R != 0)
                    {
                        pixels = getRoundPixel(bmp, i, j);
                        for(int k = 0; k < pixels.Length; k++)
                        {
                            if(pixels[k] == true)
                            {
                                //set this piexl's color to black
                                newBmp.SetPixel(i, j, Color.FromArgb(0, 0, 0));
                                break;
                            }
                        }
                    }
                }
            }
            return newBmp;

        }

        /// <summary>
        /// 腐蝕
        /// </summary>
        /// <param name="bmp"></param>
        /// <returns></returns>
        public static Bitmap Corrode(Bitmap bmp)
        {
            int height = bmp.Height;
            int width = bmp.Width;
            Bitmap newbmp = new Bitmap(width, height);

            Color c;
            bool[] pixels;
            for(int i = 1; i < width - 1; i++)
            {
                for(int j = 1; j < height - 1; j++)
                {
                    c = bmp.GetPixel(i, j);
                    if(bmp.GetPixel(i, j).R == 0)
                    {
                        pixels = getRoundPixel(bmp, i, j);
                        for(int k = 0; k < pixels.Length; k++)
                        {
                            if(pixels[k] == false)
                            {
                                //set this piexl's color to black
                                newbmp.SetPixel(i, j, Color.FromArgb(255, 255, 255));
                                break;
                            }
                        }
                    }
                }
            }
            return newbmp;
        }

        //返回(x,y)周围像素的情况，为黑色，则设置为true
        public static bool[] getRoundPixel(Bitmap bitmap, int x, int y)
        {
            bool[] pixels = new bool[8];
            Color c;
            int num = 0;
            for(int i = -1; i < 2; i++)
            {
                for(int j = -1; j < 2; j++)
                {
                    c = bitmap.GetPixel(x + i, y + j);
                    if(i != 0 || j != 0)
                    {
                        if(255 == c.G) //因为经过了二值化，所以只要检查RGB中一个属性的值
                        {
                            pixels[num] = false; //为白色，设置为false
                            num++;
                        }
                        else if(0 == c.G)
                        {
                            pixels[num] = true; //为黑色，设置为true
                            num++;
                        }
                    }
                }
            }
            return pixels;
        }

        public static Bitmap RemoveFrame(Bitmap bitmap, Paddings padding, Color color)
        {
            int height = bitmap.Height;
            int width = bitmap.Width;

            var top = padding.Top;
            var right = width - padding.Right;
            var bottom = height - padding.Bottom;
            var left = padding.Left;

            Bitmap newbmp = new Bitmap(width, height);

            Color c;
            for(int i = 1; i < width - 1; i++)
            {
                for(int j = 1; j < height - 1; j++)
                {
                    c = bitmap.GetPixel(i, j);
                    if(i <= left || i >= right || j <= top || j >= bottom)
                    {
                        newbmp.SetPixel(i, j, color);
                    }
                    else
                    {
                        newbmp.SetPixel(i, j, c);
                    }
                }
            }
            return newbmp;
        }

        /// <summary>
        /// 調整Gamma 值
        /// https://dotblogs.com.tw/junegoat/2012/08/20/c-sharp-gamma-filter
        /// </summary>
        /// <param name="src">原圖</param>
        /// <param name="r"></param>
        /// <param name="g"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Bitmap AdjustGamma(Bitmap src, double r, double g, double b)
        {
            // 判斷是不是在0.2~5 之間
            r = Math.Min(Math.Max(0.2, r), 5);
            g = Math.Min(Math.Max(0.2, g), 5);
            b = Math.Min(Math.Max(0.2, b), 5);

            // 依照 Format24bppRgb 每三個表示一 Pixel 0: 藍 1: 綠 2: 紅
            BitmapData bitmapData = src.LockBits(new Rectangle(0, 0, src.Width, src.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);


            unsafe
            {
                // 抓住第一個 Pixel 第一個數值
                byte* p = (byte*)(void*)bitmapData.Scan0;

                // 跨步值 - 寬度 *3 可以算出畸零地 之後跳到下一行
                int nOffset = bitmapData.Stride - src.Width * 3;



                for(int y = 0; y < src.Height; y++)
                {
                    for(int x = 0; x < src.Width; x++)
                    {
                        double buffer = 0;

                        p[2] = (byte)Math.Min(255, (int)((255.0 * Math.Pow(p[2] / 255.0, 1.0 / r)) + 0.5));
                        p[1] = (byte)Math.Min(255, (int)((255.0 * Math.Pow(p[1] / 255.0, 1.0 / g)) + 0.5));
                        p[0] = (byte)Math.Min(255, (int)((255.0 * Math.Pow(p[0] / 255.0, 1.0 / b)) + 0.5));


                        // 跳去下一個 Pixel
                        p += 3;

                    }
                    // 跨越畸零地
                    p += nOffset;
                }
            }
            src.UnlockBits(bitmapData);
            return src;

        }
    }
}

