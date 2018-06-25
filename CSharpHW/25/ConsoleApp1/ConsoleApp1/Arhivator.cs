using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using System.Threading;

namespace ConsoleApp1
{
    class Arhivator
    {
        public static void Zip(string path)
        {
            List<FileInfo> fileInfoList = GetFileInfo(GetAllPases(path));
            
            foreach (var file in fileInfoList)
            {
                new Thread(() => Compression(file)).Start();
            }
            Console.WriteLine("Archiving of " + path +" completed");
        }

        private static void Compression(FileInfo file)
        {            
            string directory = file.DirectoryName + "\\" + file.Name.Remove(file.Name.IndexOf('.'));
            Directory.CreateDirectory(directory);
            file.MoveTo(directory + "\\" + file.Name);
            ZipFile.CreateFromDirectory(directory, directory + ".zip");
            Directory.Delete(directory, true);
        }

        public static void UnZip(string path)
        {
            List<FileInfo> fileInfoList = GetFileInfo(GetAllPases(path));

            foreach (var file in fileInfoList)
            {
                new Thread(() => Decompression(file)).Start();
            }
            Console.WriteLine("Decompression of " + path + " completed");
        }

        private static void Decompression(FileInfo file)
        {
            ZipFile.ExtractToDirectory(file.FullName, file.FullName.Remove(file.FullName.IndexOf('.')) + "Unzipped");
            file.Delete();
        }

        private static List<string> GetAllPases(string path)
        {
            string[] folders = Directory.GetDirectories(path);

            var files = new List<string>();

            if (folders.Length != 0)
            {

                files.AddRange(Directory.GetFiles(path));

                foreach (var folder in folders)
                {
                    files.AddRange(GetAllPases(folder));
                }
            }
            else
            {
                return Directory.GetFiles(path).ToList();
            }
            return files;
        }

        private static List<FileInfo> GetFileInfo(List<string> files)
        {
            List<FileInfo> fileInfoList = new List<FileInfo>();
            foreach (var file in files)
            {
                fileInfoList.Add(new FileInfo(file));
            }
            return fileInfoList;
        }
    }
}
