﻿using System;

namespace Folders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Directory.CreateDirectory("../../../NewFolder");
            // Directory.Delete("../../../NewFolder");
            //Directory.Move("../../../NewFolder", "NewFolder");
            DirectoryInfo directoryInfo = new DirectoryInfo("../../../NewFolder");

            Console.WriteLine(directoryInfo.FullName);
            Console.WriteLine(directoryInfo.Name);
            Console.WriteLine(directoryInfo.CreationTime);
            Console.WriteLine(directoryInfo.LastAccessTime);

            Console.WriteLine("------------");
            FileInfo[] files = directoryInfo.GetFiles();
            foreach (var file in files)
            {
                Console.WriteLine(file.FullName);
                Console.WriteLine(file.Name);
                Console.WriteLine(file.CreationTime);
                Console.WriteLine(file.LastAccessTime);
                Console.WriteLine(file.Extension);
                Console.WriteLine(file.Exists);
                Console.WriteLine($"{file.Length/1024.0/1024.0} MB");

            }
            DirectoryInfo[] folders = directoryInfo.GetDirectories();

            Console.WriteLine("Dir-------------");

            foreach (var folder in folders)
            {
                Console.WriteLine(folder.Name);
            }
        }
    }
}