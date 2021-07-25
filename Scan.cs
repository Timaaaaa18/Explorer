using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

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
                Array.Resize(ref Form1.pathArray, Form1.pathArray.Length - 1);
                return directories;
            }
        }

        public static string[] GetFiles(string path, object selectedItem)
        {
            try
            {
                files = Directory.GetFiles(path);
                return files;
            }
            catch (System.IO.IOException)
            {
                return files;
            }
            catch (System.UnauthorizedAccessException)
            {
                MessageBox.Show("lock access",caption:"Warning");
                
                if (Form1.pathArray.Length <= 1)
                {

                }
                else
                {
                    Array.Resize(ref Form1.pathArray, Form1.pathArray.Length - 1);
                }
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
