using System;
using System.Collections.Generic;
using System.Text;

namespace Getnumbers
{
    public class Getnumber
    {
        public static int range;
        public static int[] number;
        public static int position = 0;
        public Getnumber(int n)
        {
            range = n;
        }

        public static int[] Arraynumber()
        {

            number = new int[range];
            for (int i = 0; i < range; i++)
            {
                number[i] = i;
            }
            return number;
        }

        public static int[] Take(int n)
        {
            number = Arraynumber();
            int[] result = new int[n];
            for (int i = 0; i < n; i++)
            {
                result[i] = number[position + i];
            }
            position += n;
            return result;

        }
    }
}
