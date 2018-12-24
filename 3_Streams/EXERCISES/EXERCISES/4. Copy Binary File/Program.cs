using System;
using System.IO;

namespace _4._CopyBinaryFile
{
    public class Program
    {     
        public static void Main()
        {
            Console.WriteLine($"Copy file 'copyMe.png'");
            Console.WriteLine($"To file 'imageCopy.jpg'");

            var sourceFilePath = "copyMe.png";
            var copyFilePath = "imageCopy.jpg";

            using (var sourceFile = new FileStream(sourceFilePath, FileMode.Open))
            {
                using (var copyFile = new FileStream(copyFilePath, FileMode.Create))
                {
                    byte[] buffer = new byte[4096];

                    while (true)
                    {
                        int readBytes = sourceFile.Read(buffer, 0, buffer.Length);

                        if (readBytes == 0) break;

                        copyFile.Write(buffer, 0, readBytes);
                        
                    }
                }
            }
        }
    }
}
