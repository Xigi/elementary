using System;
using System.Collections.Generic;
using System.Text;

namespace RationalCalcul
{
    public struct Rational
    {
        public Rational(int numerator = 0, int denominator = 1)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Denominator cannot be zero");
            }

            if (denominator < 0 && numerator >0)
            {
                numerator = -numerator;
                denominator = -denominator;
            }
             if ( numerator < 0 && denominator < 0)
            {
                denominator = -denominator;
            }

            int GCD = GetGCD(numerator, denominator);

            Numerator = numerator / GCD;
            Denominator = denominator / GCD;
        }

        public static bool TryParse(string s, out Rational result)
        {
            result = default;
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

            return new Rational(a * d + c * b, b * d);
        }

        public static Rational operator -(Rational left, Rational right)
        {
            int a = left.Numerator;
            int b = left.Denominator;

            int c = right.Numerator;
            int d = right.Denominator;

            return new Rational(a * d - c * b, b * d);
        }

        public static Rational operator *(Rational left, Rational right)
        {
            int a = left.Numerator;
            int b = left.Denominator;

            int c = right.Numerator;
            int d = right.Denominator;

            return new Rational(a * c, b * d);
        }

        public static Rational operator /(Rational left, Rational right)
        {
            Rational invers = new Rational(right.Denominator, right.Numerator);
            return left * invers;
        }

        public static bool operator ==(Rational left, Rational right)
        {
            return left.Numerator == right.Numerator && left.Denominator == right.Denominator;
        }

        public static bool operator !=(Rational left, Rational right)
        {
            return !(left == right);
        }

        public static bool operator <(Rational left, Rational right)
        {
            Rational result = left - right;
            return result.Numerator < 0;
        }

        public static bool operator >(Rational left, Rational right)
        {
            Rational result = left - right;
            return result.Numerator > 0;
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }

        private static int GetGCD(int numerator, int denominator)
        {
            numerator = Math.Abs(numerator);
            denominator = Math.Abs(denominator);

            while (numerator > 0 && denominator > 0)
            {
                if (numerator > denominator)
                {
                    numerator %= denominator;
                }
                else
                {
                    denominator %= numerator;
                }
            }

            return numerator + denominator;
        }
    }
}
