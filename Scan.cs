using System;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp1
{   
    static class Scan
    {
        public delegate void EventHandler(string path);
        public static event EventHandler Notify;

        public static string[] GetDirectories(string path)
        {
            try
            {
                return Directory.GetDirectories(path);
            }
            catch { return null; }
            
        }

        public static string[] GetFiles(string path)
        { 

            try
            {
                return Directory.GetFiles(path);
            }
            catch (IOException)
            {
                Notify?.Invoke(path);
                return null;
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Access locked", caption: "Warning");
                return null;
            }
        }

        public static DriveInfo[] GetDrives()
        {
            return DriveInfo.GetDrives();
        }
    }
}
