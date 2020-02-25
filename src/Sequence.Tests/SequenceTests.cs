using System;
using System.Collections.Generic;
using System.Linq;

namespace Sequence.Tests
{
    internal class SequenceTests
    {
        static void Main(string[] args)
        {
            {
                IEnumerable<int> sequence = new IntSequence().Take(0);

                if (sequence.Count() == 0)
                {
                    Console.WriteLine("Nums 0 count PASS");
                }
                else
                {
                    Console.WriteLine("Nums 0 count FAILED");
                }

            }
            {
                IEnumerable<int> sequence = new IntSequence().Take(5);

                if (sequence.Count() == 5)
                {
                    Console.WriteLine("Nums fixed count PASS");
                }
                else
                {
                    Console.WriteLine("Nums fixed count FAILED");
                }
            }
            {
                IEnumerable<int> sequence = new IntSequence(5).Take(5).ToArray();

                if (sequence.Last() == 9 && sequence.Count() == 5)
                {
                    Console.WriteLine("Nums start point PASS");
                }
                else
                {
                    Console.WriteLine("Nums start point FAILED");
                }
            }
        }
    }
}
