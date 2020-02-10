using System;
using static ConsolTest1.Item;

namespace ConsolTest1
{
    class Program
    {
        static void Main()
        {
            Item testlist = CreationItemList(10);

            //PrintItem(testlist);

            PrintItemEven(testlist);

            Console.WriteLine(Cycled(testlist));

            //ReverseItem(ref testlist);

            //PrintItem(testlist);

            PrintItemDenEven(testlist);
        }

        
    }
}