using System;

namespace PersonHello.Test
{
    class PersonTest
    {
        static void Main(string[] args)
        {
            {
                Person Person = new Person("Piter", "Garms", "M", 66);
                if(Person.Hello() == "Hello Piter you already enjoy your retirement")
                {
                    Console.WriteLine("Test age man PASS");
                }
                else
                {
                    Console.WriteLine("Test age man FAILED");
                }
            }

            {
                Person Person = new Person("Dasha", "Garms", "F", 66);
                if (Person.Hello() == "Hello grandma Dasha")
                {
                    Console.WriteLine("Test Age female PASS");
                }
                else
                {
                    Console.WriteLine("Test Age female FAILED");
                }
            }

            {
                Person Person = new Person("Piter", "Garms", "M", 40);
                if (Person.Hello() == "hi man how do you live in your 40s")
                {
                    Console.WriteLine("Test middle-age man PASS");
                }
                else
                {
                    Console.WriteLine("Test middle-age man FAILED");
                }
            }

            {
                Person Person = new Person("Dasha", "Garms", "F", 40);
                if (Person.Hello() == "hello beauty I would never say that to you 40")
                {
                    Console.WriteLine("Test middle-age female PASS");
                }
                else
                {
                    Console.WriteLine("Test middle-age female FAILED");
                }
            }

            {
                Person Person = new Person("Dasha", "Garms", "F", 17);
                if (Person.Hello() == "Hello girl, do you already know how to spend an owl's 18th birthday?")
                {
                    Console.WriteLine("Test birthday < 17 female PASS");
                }
                else
                {
                    Console.WriteLine("Test birthday < 17 female FAILED");
                }
            }

            {
                Person Person = new Person("Piter", "Garms", "M", 17);
                if (Person.Hello() == "Hi, how are you going to the army? you are already 17 years old, which means that in 1 years you will be in the army")
                {
                    Console.WriteLine("Test birthday < 17 man PASS");
                }
                else
                {
                    Console.WriteLine("Test birthday < 17 man FAILED");
                }
            }

            {

                Person Person = new Person("Piter", "Garms", "M", 82);
                if (Person.Hello() == "Hello! Mr. Piter, how did you manage to live to such an age")
                {
                    Console.WriteLine("Test age > 80 man PASS");
                }
                else
                {
                    Console.WriteLine("Test age > 80 man FAILED");
                }
            }

            {
                Person Person = new Person("Dasha", "Garms", "F", 82);
                if (Person.Hello() == "Hello! Ms. Dasha, how did you manage to live to such an age")
                {
                    Console.WriteLine("Test age > 80 female PASS");
                }
                else
                {
                    Console.WriteLine("Test age > 80 female FAILED");
                }

                {
                    try
                    {
                        new Person("Dasha", "Garms", "F", -1);
                        Console.WriteLine("Test Exception FAILED");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Test Exception PASS   " + ex.Message);
                    }
                }
            }
        }
    }
}
