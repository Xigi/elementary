using System;
using System.Linq;

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
                Console.Write(element + " ");
            }

            Console.WriteLine();

            int[] test1 = Getnumber.Take(10);

            foreach (int element in test1)
            {
                Console.Write(element + " ");
            }

            Console.WriteLine();

            int[] test2 = Getnumber.Take(10);

            foreach (int element in test2)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();                    //block separator
            Console.WriteLine(new string('~', 50));
            Console.WriteLine(new string('~', 50));

            var numstest = new Nums();

            foreach(var element in Nums.Generator().Take(10))
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();                   //block separator
            

            foreach (var element in Nums.Generator().Take(10))
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();                     //block separator
            

            foreach (var element in Nums.Generator().Take(10))
            {
                Console.Write(element+" ");
            }

            Console.WriteLine();                     //block separator
            Console.WriteLine(new string('-', 50));
            Console.WriteLine(new string('-', 50));

            //TESTS for Getnumber

            {
                var prob = new Getnumber(0);
                int[] exempl = Getnumber.Take(0);
                if (exempl.Length == 0)
                {
                    Console.WriteLine("test 0 count array PASS");
                }
                else
                {
                    Console.WriteLine("test 0 count array FAILED");
                }

            }
            //{
            //    var probm = new Getnumber(5);  // works when the first call
            //    int[] exempl = Getnumber.Take(5);
            //    if (exempl.Length == 5)
            //    {
            //        Console.WriteLine("test fixed count array PASS");
            //    }
            //    else
            //    {
            //        Console.WriteLine("test fixed count array FAILED");
            //    }

            //}

            //TESTS for Nums 
            {
                var element =  Nums.Generator().Take(0);
                
                    if (element.Count() == 0)
                    {
                        Console.WriteLine("Nums 0 count PASS");
                    }
                    else
                    {
                        Console.WriteLine("Nums 0 count FAILED");
                    }
                
            }
            {
                var element = Nums.Generator().Take(5);

                if (element.Count() == 5)
                {
                    Console.WriteLine("Nums fixed count PASS");
                }
                else
                {
                    Console.WriteLine("Nums fixed count FAILED");
                }

            }
        }
    }
}
