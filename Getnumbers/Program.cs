using System;

namespace Getnumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = new Getnumber(30);
            int[] test = Getnumber.Take(10);

            foreach (int element in test)
            {
                Console.Write(element+" ");
            }

            Console.WriteLine();

            int[] test1 = Getnumber.Take(10);

            foreach (int element in test1)
            {
                Console.Write(element+" ");
            }

            Console.WriteLine();

            int[] test2 = Getnumber.Take(10);

            foreach (int element in test2)
            {
                Console.Write(element + " ");
            }
        }
    }
}
