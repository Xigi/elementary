using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TestappsortNumber
{
    class Num : IEnumerable<int>
    {
        public int[] testnums = new int[] { };

        public IEnumerator<int> GetEnumerator()
        {
            return ((IEnumerable<int>)testnums).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<int>)testnums).GetEnumerator();
        }
    }
}
