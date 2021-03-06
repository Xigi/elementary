﻿using System;


namespace RationalCalcul.Test
{
    class RationalTest
    {
        static void Main()
        {
            {
                Rational first = new Rational(1, 2);
                Rational second = new Rational(2, 3);
                Rational result = first + second;
                if (result == new Rational(7, 6))
                {
                    Console.WriteLine("Test summ PASS");
                }
                else
                {
                    Console.WriteLine("Test summ FAILED");
                }
            }

            {
                Rational first = new Rational(-1, 2);
                Rational second = new Rational(-2, 3);
                Rational result = first + second;
                if (result == new Rational(-7, 6))
                {
                    Console.WriteLine("Test summ negativ numerator fraction PASS");
                }
                else
                {
                    Console.WriteLine("Test summ negativ numerator fraction FAILED");
                }
            }

            {
                Rational first = new Rational(-1, 2);
                Rational second = new Rational(2, -3);
                Rational result = first + second;
                if (result == new Rational(-7, 6))
                {
                    Console.WriteLine("Test summ negativ numerator and denominator fraction PASS");
                }
                else
                {
                    Console.WriteLine("Test summ negativ numerator and denominator fraction FAILED");
                }
            }

            {
                Rational first = new Rational(1, 2);
                Rational second = new Rational(1, 3);
                Rational result = first - second;
                if (result == new Rational(1, 6))
                {
                    Console.WriteLine("Test minus PASS");
                }
                else
                {
                    Console.WriteLine("Test minus FAILED");
                }
            }

            {
                Rational first = new Rational(1, 2);
                Rational second = new Rational(2, 3);
                Rational result = first - second;
                if (result == new Rational(-1, 6))
                {
                    Console.WriteLine("Test negative answer PASS");
                }
                else
                {
                    Console.WriteLine("Test negative answer FAILED");
                }
            }

            {
                Rational first = new Rational(1, 2);
                Rational second = new Rational(2, 3);
                Rational result = first * second;
                if (result == new Rational(1, 3))
                {
                    Console.WriteLine("Test multy PASS");
                }
                else
                {
                    Console.WriteLine("Test multy FAILED");
                }
            }

            {
                Rational first = new Rational(1, 2);
                Rational second = new Rational(-2, 3);
                Rational result = first * second;
                if (result == new Rational(-1, 3))
                {
                    Console.WriteLine("Test negative multy PASS");
                }
                else
                {
                    Console.WriteLine("Test negative multy FAILED");
                }
            }

            {
                Rational first = new Rational(1, 2);
                Rational second = new Rational(2, -3);
                Rational result = first * second;
                if (result == new Rational(-1, 3))
                {
                    Console.WriteLine("Test negative denominator multy PASS");
                }
                else
                {
                    Console.WriteLine("Test negative denominator multy FAILED");
                }
            }

            {
                Rational first = new Rational(1, 2);
                Rational second = new Rational(2, 3);
                Rational result = first / second;
                if (result == new Rational(3, 4))
                {
                    Console.WriteLine("Test division PASS");
                }
                else
                {
                    Console.WriteLine("Test division FAILED");
                }
            }

            {
                Rational first = new Rational(1, 2);
                Rational second = new Rational(-2, 3);
                Rational result = first / second;
                if (result == new Rational(-3, 4))
                {
                    Console.WriteLine("Test negative division PASS");
                }
                else
                {
                    Console.WriteLine("Test negative division FAILED");
                }
            }

            {
                Rational first = new Rational(1, 2);
                Rational second = new Rational(2, -3);
                Rational result = first / second;
                if (result == new Rational(-3, 4))
                {
                    Console.WriteLine("Test negative denominator division PASS");
                }
                else
                {
                    Console.WriteLine("Test negative denominator division FAILED");
                }
            }

            {
                Rational first = new Rational(2, 4);
                Rational second = new Rational(2, 4);
                Rational result = first + second;
                if (result == new Rational(1, 1))
                {
                    Console.WriteLine("Test cut metod PASS");
                }
                else
                {
                    Console.WriteLine("Test cut metod FAILED");
                }
            }

            {
                try
                {
                    Rational.Parse("asdfasfd");
                    Console.WriteLine("Test Exception FAILED");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Test Exception PASS   " + ex.Message);
                }
            }

            {
                Rational first = new Rational(1, 2);
                Rational second = new Rational(1, 3);
                bool result = first > second;
                if (result)
                {
                    Console.WriteLine("Test comparisons > PASS");
                }
                else
                {
                    Console.WriteLine("Test comparisons > FAILED");
                }
            }

            {
                Rational first = new Rational(1, 2);
                Rational second = new Rational(2, 2);
                bool result = first < second;
                if (result)
                {
                    Console.WriteLine("Test comparisons < PASS");
                }
                else
                {
                    Console.WriteLine("Test comparisons < FAILED");
                }
            }

            {
                Rational first = new Rational(1, 2);
                first = -first;
                if (first == new Rational(-1, 2))
                {
                    Console.WriteLine("Test '-' metod PASS");
                }
                else
                {
                    Console.WriteLine("Test '-' metod FAILED");
                }
            }

            {
                Rational first = new Rational(-1, 2);
                first = +first;
                if (first == new Rational(1, 2))
                {
                    Console.WriteLine("Test '+' metod PASS");
                }
                else
                {
                    Console.WriteLine("Test '+' metod FAILED");
                }
            }
        }
    }
}
