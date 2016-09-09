using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ImageToGrayscale
{
    public static class SerializableUtils
    {
        public static void SerializeToFormatter<F>(object obj, string path) where F : IFormatter, new()
        {
            if (obj == null)
            {
                throw new NullReferenceException("obj Cannot be Null.");
            }

            if (obj.GetType().IsSerializable == false)
            {
                //  throw new 
            }
            IFormatter f = new F();
            SerializeToFormatter(obj, path, f);
        }

        public static T DeserializeFromFormatter<T, F>(string path) where F : IFormatter, new()
        {
            T t;
            IFormatter f = new F();
            using (FileStream fs = File.OpenRead(path))
            {
                t = (T) f.Deserialize(fs);
            }
            return t;
        }

        public static void SerializeToXML<T>(string path, object obj)
        {
            XmlSerializer xs = new XmlSerializer(typeof(T));
            using (FileStream fs = File.Create(path))
            {
                xs.Serialize(fs, obj);
            }
        }

        public static T DeserializeFromXML<T>(string path)
        {
            XmlSerializer xs = new XmlSerializer(typeof(T));
            using (FileStream fs = File.OpenRead(path))
            {
                return (T) xs.Deserialize(fs);
            }
        }


        private static void SerializeToFormatter(object obj, string path, IFormatter formatter)
        {
            using (FileStream fs = File.Create(path))
            {
                formatter.Serialize(fs, obj);
            }
        }

        public static void SerializeToBinary<T>(T targets, string targetPath)
        {
            IFormatter formatter = new BinaryFormatter();

            using (FileStream OutputStream = System.IO.File.Create(targetPath))
            {
                try
                {
                    formatter.Serialize(OutputStream, targets);
                }
                catch (SerializationException ex)
                {
                    //(Likely Failed to Mark Type as Serializable)
                    //...
                }
            }
        }

        public static T DeserializeFromBinary<T>(string targetPath)
        {
            IFormatter formatter=new BinaryFormatter();
            using (FileStream fs= File.OpenRead(targetPath))
            {
                return (T)formatter.Deserialize(fs);
            }
        }
    }
}
