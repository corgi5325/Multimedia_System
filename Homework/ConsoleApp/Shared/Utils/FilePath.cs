using System;

namespace ConsoleApp.Utils
{
    public class FilePath
    {
        public static string GetFullPath(string fileName)
        {
            return System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App_Data", fileName);
        }

    }
}
