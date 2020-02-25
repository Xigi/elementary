using System;
using System.Linq;

namespace TestappsortNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 2, 2, 2, 2, 6, 7, 8, 9, 0 };

            Num oject = new Num();
            
            oject.testnums = nums;


            foreach (int element in oject)
            {
                Console.WriteLine(element);
            }
            

        }
    }
}
