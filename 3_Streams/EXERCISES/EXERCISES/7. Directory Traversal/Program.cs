﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace E07_DirectoryTraversal
{
    public class Program
    {
        public static void Main()
        {
            string sourcePath = "../../../Files";
            string destinationPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); 

            var filesDict = new Dictionary<string, Dictionary<string, long>>();

            Console.WriteLine($"Searching directory (top level only)");

            var filesInDirectory = Directory.GetFiles(sourcePath, "*.*", SearchOption.TopDirectoryOnly);

            foreach (var file in filesInDirectory)
            {
                var fileInfo = new FileInfo(file);

                var extension = fileInfo.Extension;
                var name = fileInfo.Name;
                var length = fileInfo.Length;

                if (!filesDict.ContainsKey(extension))
                {
                    filesDict[extension] = new Dictionary<string, long>();
                }

                if (!filesDict[extension].ContainsKey(name))
                {
                    filesDict[extension][name] = length;
                }
            }

            var filesDictSorted = filesDict
                                .OrderByDescending(x => x.Value.Count)  
                                .ThenBy(x => x.Key);                    
           
            Console.WriteLine($@"Result saved in '{destinationPath}\report.txt'"); 

            using (var report = new StreamWriter($"{destinationPath}/report.txt"))
            {

                foreach (var x in filesDictSorted)
                {
                    var extension = x.Key;
                    var files = filesDict[extension].OrderByDescending(f => f.Value); 

                    report.WriteLine(extension);

                    foreach (var file in files)
                    {
                        report.WriteLine($"--{file.Key} - {(double)file.Value / 1024:f3} kb");
                    }
                }
            }
        }
    }
}