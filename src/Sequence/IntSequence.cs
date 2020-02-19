using System.Collections.Generic;

namespace Sequence
{
    public class IntSequence
    {
        public int i = 0;

        public IEnumerable<int> Generator()
        {
            while (true)
            {
                yield return i++;
            }
        }
    }
}
