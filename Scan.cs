using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace WinFormsApp1
{
    static class FileOperations
    {
        static string[] directories;
        static string[] files;

        public static string[] GetDirectories(string path)
        {
            try
            {
                directories = Directory.GetDirectories(path);
                return directories;
            }
            catch (Exception)
            {
                //File.Open(currentPath, FileMode.Open);
                return directories;
            }
        }

        public static string[] GetFiles(string path)
        {
            try
            {
                files = Directory.GetFiles(path);
                return files;
            }
            catch (System.IO.IOException)
            {
                //File.Open(currentPath, FileMode.Open);
                return files;
            }
        }

        public static DriveInfo[] GetDrives()
        {

            var files = DriveInfo.GetDrives();
            return files;
        }

        public static void Open()
        {

        }

    }
}
