using System;
using System.IO;


namespace eho
{
    class StrFile
    {
        static string  writePath = @"C:\Users\DEUS\Desktop\ehomassage.txt";

        public static void FileRecord(string message)
        {
            try
            {
                using StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default);
                sw.WriteLine(message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

