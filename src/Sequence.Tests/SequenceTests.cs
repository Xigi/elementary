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
                IEnumerable<int> sequence = Enumerable.Empty<int>();

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
                IEnumerable<int> sequence = Enumerable.Range(0, 5);

                if (sequence.Count() == 5)
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
