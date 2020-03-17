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
           
            if (workmod == "-f" || workmod == "-F" )
            {
                Console.WriteLine( );
                StrFile.FileRecord(EhoMessage);
            }

            else if (workmod == "-k" || workmod == "-K")
            {
                Console.WriteLine("\n" + EhoMessage + "\n");
                Thread.Sleep(5000);
            }

            else if (workmod == "-h" || workmod == "-H")
            {
                ConsoleReference();
            }

            else
            {
                Console.Write("Вы ввели недопустимую команду. Для просмотра всех команд введите -h \n"+
                    "Ввидет команду: ");
                OperationModeSelection(Console.ReadLine());
            }
        }

        private static void ConsoleReference()
        {
            Console.WriteLine("Список команд: ");
            Console.Write(
                "\n" +
                "-k Вывод сообщения в консоль \n" +
                "-f Вывод сообщения в фаил    \n" +
                "-h Справка по команндам      \n" +
                "Ввидет команду: ");
           OperationModeSelection(Console.ReadLine());
        }
    }
}
