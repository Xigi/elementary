using System;
using System.IO;


namespace eho
{
    class StrFile
    {
        public static void FileRecord(string message, string path)
        {
            try
            {
                using StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default);
                sw.WriteLine(message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

