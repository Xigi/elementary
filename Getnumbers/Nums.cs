using System;
using System.Collections.Generic;


namespace Getnumbers
{
    class Nums
    {
        public static int i = 0;
        public static IEnumerable<int> Generator ()
        {
             
            while (true)
            {
                yield return i++;
            }
        }
    }
}
