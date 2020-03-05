using System;
using System.Collections.Generic;
using System.Text;

namespace RationalCalcul
{
    public struct Rational
    {
        public Rational(int numerator = 0, int denominator = 1)
        {
            if (denominator < 1)
            {
                throw new ArgumentException("Denominator cannot be zero or negative");
            }

            Numerator = numerator;
            Denominator = denominator;

        }

        public Rational(string s)
        {
            Rational result = Parse(s);

            Numerator = result.Numerator;
            Denominator = result.Denominator;

        }
        public static bool TryParse(string s, out Rational result)
        {
            result = new Rational(1, 1);
            try
            {
                result = Parse(s);
                return true;
            }
            catch
            {
                return false;
            }

        }

        public static Rational Parse(string s)
        {
            string[] values = s.Split("/");
            if (values.Length != 2)
            {
                throw new ArgumentException($"Cannot parse to Rational - {s}");
            }

            if (!int.TryParse(values[0], out int numerator)
              || !int.TryParse(values[1], out int denominator))
            {
                throw new ArgumentException($"Cannot parse to Rational - {s}");
            }

            return new Rational(numerator, denominator);
        }

        public int Numerator
        {
            get;
        }

        public int Denominator
        {
            get;
        }

        public static Rational operator +(Rational left, Rational right)
        {
            int a = left.Numerator;
            int b = left.Denominator;

            int c = right.Numerator;
            int d = right.Denominator;

            Rational result =  new Rational(a * d + c * b, b * d);
            return CutFraction(result);

        }

        public static Rational operator -(Rational left, Rational right)
        {
            int a = left.Numerator;
            int b = left.Denominator;

            int c = right.Numerator;
            int d = right.Denominator;

            Rational result = new Rational(a * d - c * b, b * d);
            if (result.Denominator < 0 || result.Numerator < 0)
            {
                return result;
            }
            else
            {
                return CutFraction(result);
            }
            

        }

        public static Rational operator *(Rational left, Rational right)
        {
            int a = left.Numerator;
            int b = left.Denominator;

            int c = right.Numerator;
            int d = right.Denominator;

            Rational result = new Rational(a * c, b * d);
            return CutFraction(result);
        }

        public static Rational operator /(Rational left, Rational right)
        {
            int a = left.Numerator;
            int b = left.Denominator;

            int c = right.Numerator;
            int d = right.Denominator;

            Rational result = new Rational(a * d, b * c);
            return CutFraction(result);
        }

        public static bool operator == (Rational left, Rational right)
        {
            int a = left.Numerator;
            int b = left.Denominator;

            int c = right.Numerator;
            int d = right.Denominator;

            if (a == c & b == d)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool operator != (Rational left, Rational right)
        {
            int a = left.Numerator;
            int b = left.Denominator;

            int c = right.Numerator;
            int d = right.Denominator;

            if (a != c || b != d)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            if (Numerator == 1 && Denominator == 1)
            {
                return $"1";
            }
            else
            {
                return $"{Numerator}/{Denominator}";
            }
            
        }

        private static Rational CutFraction(Rational p)
        {
            int NOD = GetNOD(p.Numerator, p.Denominator);
            return new Rational(p.Numerator/ NOD, p.Denominator/ NOD);
        }

       private static int GetNOD(int val1, int val2)
        {
            while ((val1 != 0) && (val2 != 0))
            {
                if (val1 > val2)
                    val1 -= val2;
                else
                    val2 -= val1;
            }
            return Math.Max(val1, val2);
        }
    }
}
