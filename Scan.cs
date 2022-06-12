using System;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp1
{
    static class Scan
    {
        static string[] files;

        public static string[] GetDirectories(string path)
        {
            try
            {
                return Directory.GetDirectories(path);
            }
            catch (Exception)
            {
                Array.Resize(ref Form1.pathArray, Form1.pathArray.Length - 1); //TODO: Delete this.
                return null;
            }
        }

        public static string[] GetFiles(string path, object selectedItem) //TODO: Object?
        {
            try
            {
                return Directory.GetFiles(path);;
            }
            catch (IOException)
            {
                return null;
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Access locked", caption:"Warning");
                
                if (Form1.pathArray.Length <= 1)
                {

                }
                else
                {
                    Array.Resize(ref Form1.pathArray, Form1.pathArray.Length - 1);
                }
                return null;
            }
        }

        public static DriveInfo[] GetDrives()
        {
            return DriveInfo.GetDrives();
        }
    }
}
