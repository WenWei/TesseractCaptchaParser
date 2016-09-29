using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageToGrayscale
{
    public class FileUtils
    {
        public static FileInfo GetNextUniqueFile(string path)
        {
            //if the given file doesn't exist, we're done
            var fi = new FileInfo(path);
            if (!File.Exists(path))
                return fi;

            //split the path into parts
            string dirName = fi.DirectoryName;
            string fileName = Path.GetFileNameWithoutExtension(path);
            string fileExt = Path.GetExtension(path);

            //get the directory
            DirectoryInfo dir = new DirectoryInfo(dirName);

            //get the list of existing files for this name and extension
            var existingFiles = dir.GetFiles(Path.ChangeExtension(fileName + " *", fileExt));

            //get the number strings from the existing files
            var NumberStrings = from file in existingFiles
                select Path.GetFileNameWithoutExtension(file.Name)
                    .Remove(0, fileName.Length /*we remove the space too*/);

            //find the highest existing number
            int highestNumber = 0;

            foreach (var numberString in NumberStrings)
            {
                int tempNum;
                if (Int32.TryParse(numberString, out tempNum) && tempNum > highestNumber)
                    highestNumber = tempNum;
            }

            //make the new FileInfo object
            string newFileName = fileName + " " + (highestNumber + 1).ToString();
            newFileName = Path.ChangeExtension(newFileName, fileExt);

            return new FileInfo(Path.Combine(dirName, newFileName));
        }
    }
}
