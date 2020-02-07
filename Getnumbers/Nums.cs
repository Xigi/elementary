using System;
using System.Collections.Generic;


namespace Getnumbers
{
    class Nums
    {
        public int i = 0;
        
        public IEnumerable<int> Generator ()
        {
            
            while (true)
            {
                yield return i++;
            }
        }
    }
}
