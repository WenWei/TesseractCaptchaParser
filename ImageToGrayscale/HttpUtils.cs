using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ImageToGrayscale
{
    class HttpUtils
    {
        /// <summary>
        /// WebClient
        /// </summary>
        /// <param name="uri"></param>
        /// <returns></returns>
        public MemoryStream DownloadStream1(Uri uri)
        {
            WebClient wc = new WebClient();
            byte[] bytes = wc.DownloadData(uri);
            MemoryStream ms = new MemoryStream(bytes);
            return ms;
            //System.Drawing.Image img = System.Drawing.Image.FromStream(ms);            
        }

        /// <summary>
        /// WebRequest
        /// </summary>
        /// <param name="uri"></param>
        /// <returns></returns>
        public MemoryStream DownloadStream2(Uri uri)
        {
            var req = WebRequest.Create(uri);
            var res = req.GetResponse();
            var stream = res.GetResponseStream();
            return (MemoryStream)stream;
        }

        public MemoryStream DownloadStream3(Uri uri)
        {
            var request = (HttpWebRequest) WebRequest.Create(uri);
            var response = (HttpWebResponse) request.GetResponse();
            if ((response.StatusCode == HttpStatusCode.OK ||
                 response.StatusCode == HttpStatusCode.Moved ||
                 response.StatusCode == HttpStatusCode.Redirect) &&
                response.ContentType.StartsWith("image", StringComparison.OrdinalIgnoreCase))
            {

                // if the remote file was found, download oit
                using (Stream inputStream = response.GetResponseStream())
                {
                    return (MemoryStream) inputStream;
                }

                //using (Stream outputStream = File.OpenWrite(fileName))
                //{
                //    byte[] buffer = new byte[4096];
                //    int bytesRead;
                //    do
                //    {
                //        bytesRead = inputStream.Read(buffer, 0, buffer.Length);
                //        outputStream.Write(buffer, 0, bytesRead);
                //    } while (bytesRead != 0);
                //}
            }

            throw new Exception("image download fail");
        }

        public Image GetImage(Uri uri)
        {
            var ms = DownloadStream1(uri);
            //var ms = DownloadStream2(uri);
            //var ms = DownloadStream3(uri);
            var image = Image.FromStream(ms);
            return image;
        }

        public Bitmap GetBitmap(Uri uri)
        {
            var ms = DownloadStream1(uri);
            return new Bitmap(ms);
        }

        public static Bitmap ByteToImage(byte[] blob)
        {
            using (MemoryStream mStream = new MemoryStream())
            {
                 mStream.Write(blob, 0, blob.Length);
                 mStream.Seek(0, SeekOrigin.Begin);

                 Bitmap bm = new Bitmap(mStream);
                 return bm;
            }
        }
    }
}
