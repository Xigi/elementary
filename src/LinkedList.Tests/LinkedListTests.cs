using System;
using System.Collections.Generic;
using System.Linq;

namespace LinkedList.Tests
{
    internal class LinkedListTests
    {
        static void Main(string[] args)
        {
            {
                ICollection<int> sequence = new List<int>();

                if (sequence.Count == 0)
                {
                    Console.WriteLine("Nums 0 count PASS");
                }
                else
                {
                    Console.WriteLine("Nums 0 count FAILED");
                }

            }
            {
                ICollection<int> sequence = Enumerable.Range(0, 5).ToList();

                if (sequence.Count == 5)
                {
                    Console.WriteLine("Nums fixed count PASS");
                }
                else
                {
                    Console.WriteLine("Nums fixed count FAILED");
                }
            }
            {
                ICollection<int> sequence = Enumerable.Range(0, 5).ToList();
                sequence.Remove(4);
                if (sequence.Count == 4)
                {
                    Console.WriteLine("Nums remove one PASS");
                }
                else
                {
                    Console.WriteLine("Nums remove one FAILED");
                }
            }
            {
                ICollection<int> sequence = Enumerable.Range(0, 5).ToList();
                sequence.Add(5);
                if (sequence.Count == 6)
                {
                    Console.WriteLine("Nums add one PASS");
                }
                else
                {
                    Console.WriteLine("Nums add one FAILED");
                }
            }
        }
    }
}
