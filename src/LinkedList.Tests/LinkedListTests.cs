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
                IEnumerable<int> sequence = new IntLinkedList(10);

                foreach (int element in sequence)
                {
                    Console.WriteLine(element);
                }
            }
            {
                IEnumerable<int> sequence = new IntLinkedList();

                if (sequence.Count() == 0)
                {
                    Console.WriteLine("IntLinkedList 0 count PASS");
                }
                else
                {
                    Console.WriteLine("IntLinkedList 0 count FAILED");
                }
            }
            {
                IEnumerable<int> sequence = new IntLinkedList(5);

                if (sequence.Count() == 5)
                {
                    Console.WriteLine("IntLinkedList fixed count PASS");
                }
                else
                {
                    Console.WriteLine("IntLinkedList fixed count FAILED");
                }
            }
            {
                IEnumerable<int> sequence = new IntLinkedList(10).Take(5);

                if (sequence.Last() == 4 && sequence.Count() == 5)
                {
                    Console.WriteLine("Nums take 5 PASS");
                }
                else
                {
                    Console.WriteLine("Nums take 5 FAILED");
                }
            }

            //{
            //    ICollection<int> sequence = new List<int>();

            //    if (sequence.Count == 0)
            //    {
            //        Console.WriteLine("IntLinkedList 0 count PASS");
            //    }
            //    else
            //    {
            //        Console.WriteLine("IntLinkedList 0 count FAILED");
            //    }

            //}
            //{
            //    ICollection<int> sequence = Enumerable.Range(0, 5).ToList();

            //    if (sequence.Count == 5)
            //    {
            //        Console.WriteLine("IntLinkedList fixed count PASS");
            //    }
            //    else
            //    {
            //        Console.WriteLine("IntLinkedList fixed count FAILED");
            //    }
            //}
            //{
            //    ICollection<int> sequence = Enumerable.Range(0, 5).ToList();
            //    sequence.Remove(4);
            //    if (sequence.Count == 4)
            //    {
            //        Console.WriteLine("IntLinkedList remove one PASS");
            //    }
            //    else
            //    {
            //        Console.WriteLine("IntLinkedList remove one FAILED");
            //    }
            //}
            //{
            //    ICollection<int> sequence = Enumerable.Range(0, 5).ToList();
            //    sequence.Add(5);
            //    if (sequence.Count == 6)
            //    {
            //        Console.WriteLine("IntLinkedList add one PASS");
            //    }
            //    else
            //    {
            //        Console.WriteLine("IntLinkedList add one FAILED");
            //    }
            //}


        }
    }
}
