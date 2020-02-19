using System;

namespace LinkedList
{
    public class Item
    {
        public int Value;
        public Item Next;

        public static void ReverseItem(ref Item list)
        {
            Item first;
            Item rest;
            if (list == null) { return; }
            first = list;
            rest = first.Next;
            if (rest == null) { return; }
            ReverseItem(ref rest);
            first.Next.Next = first;
            first.Next = null;
            list = rest;
        }

        public static void PrintItem(Item list)
        {
            Item tmp = list;
            while (tmp != null)
            {
                Console.WriteLine(tmp.Value);
                tmp = tmp.Next;
            }
        }

        public static void AddItem(Item l, Item i)
        {
            while (l.Next != null)
            {
                l = l.Next;
            }
            l.Next = i;
        }

        public static void PrintItemEven(Item list)
        {
            int i = 1;
            while (list.Next != null)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(list.Value);
                }
                i++;
                list = list.Next;
                if (i % 2 == 0 && list.Next == null)
                {
                    Console.WriteLine(list.Value);
                }
            }
        }

        public static void PrintItemDenEven(Item list)
        {
            int i = 0;
            while (list.Next != null)
            {
                i++;
                list = list.Next;

                if (i % 2 != 0)
                {
                    Console.WriteLine(list.Value);
                }
            }
        }

        public static bool Cycled(Item l)
        {
            bool cycl = false;
            Item tmp, tmp1;
            tmp = tmp1 = l;
            l = l.Next;
            while (tmp != null)
            {
                while (l != null)
                {
                    if (tmp == l)
                    {
                        cycl = true;
                        return cycl;
                    }
                    else
                    {
                        l = l.Next;
                    }
                    if (tmp1 == l) { break; }
                }
                tmp = tmp.Next;
            }
            return cycl;
        }

        public static Item CreationItemList(int n)
        {
            Item List = new Item() { Value = 0 };
            Item tmp = List;

            for (int i = 1; i < n; i++)
            {
                tmp.Next = new Item() { Value = i };
                tmp = tmp.Next;
            }
            return List;
        }
    }
}