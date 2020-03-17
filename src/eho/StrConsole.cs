using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace eho
{
    class StrConsole
    {
        private static string EhoMessage
        {
            get;
        }

        static StrConsole()
        {
            Console.Write("Ваше сообщение: ");
            EhoMessage = Console.ReadLine();
            Console.Write("Ввидет команду: ");
            OperationModeSelection(Console.ReadLine());
        }

        private static void OperationModeSelection(string workmod)
        {
           
            if (workmod == "-o" || workmod == "-O" )
            {
                Console.WriteLine( );
                Console.Write("Введите адрес файла: ");
                StrFile.FileRecord(EhoMessage, Console.ReadLine());
            }

            else if (workmod == "-h" || workmod == "-H")
            {
                ConsoleReference();
            }
            else
            {
                Console.WriteLine(EhoMessage);
            }
        }

        private static void ConsoleReference()
        {
            Console.WriteLine("Список команд: ");
            Console.Write(
                "\n" +
                "-o Вывод сообщения в фаил    \n" +
                "-h Справка по команндам      \n" +
                "Ввидет команду: ");
           OperationModeSelection(Console.ReadLine());
        }
    }
}
