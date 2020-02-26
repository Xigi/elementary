using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class IntLinkedList : IEnumerable<int>
    {

        private Item _first;

        public IntLinkedList(int size = 0)
        {
            if (size > 0)
            {
                Item tmp = new Item() { Value = 0 };
                _first = tmp;

                for (int i = 1; i < size; i++)
                {
                    tmp.Next = new Item() { Value = i };
                    tmp = tmp.Next;
                }
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            Item tmp = _first;
            while (tmp != null)
            {
                yield return tmp.Value;
                tmp = tmp.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class Item
        {
            internal int Value;
            internal Item Next;
        }
    }
}
