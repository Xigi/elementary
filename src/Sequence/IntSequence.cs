using System.Collections;
using System.Collections.Generic;

namespace Sequence
{
    public class IntSequence : IEnumerable<int>
    {
        private int _counter;

        public IntSequence(int start = 0)
        {
            _counter = start;
        }

        public IEnumerator<int> GetEnumerator()
        {
            while (true)
            {
                yield return _counter++;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
