using System;

namespace PersonHello
{
    public class Person
    {
        public String FirstName
        {
            get;
        }

        public String LastName
        {
            get;
        }

        public String Sex
        {
            get;
        }

        public int Age
        {
            get;
        }

        public Person(String firstName, String lastname, String sex, int age)
        {
            if (age < 0)
            {
                throw new ArgumentException("age cannot be negative");
            }

            FirstName = firstName;
            LastName = lastname;
            Sex = sex;
            Age = age;
        }

        public bool IsBirthday()
        {
            return false;
        }

        public bool IsPensioner()
        {
            return (Age > 65 && Sex == "M")
                  || (Age > 60 && Sex == "F");
        }

        public bool IsAdult()
        {
            return Age > 18 && Age < 65;
        }

        public bool IsArmy()
        {
            return Age < 18 && Sex == "M";
        }

        public bool IsOld()
        {
            return (Age > 80);
        }
        //public String Hello()
        //{

        //    if (Age > 65 && Age < 80 && Sex == "M")
        //    {
        //        return $"Hello { Name } you already enjoy your retirement";++++
        //    }

        //    if (Age > 65 && Age < 80 && Sex == "F")
        //    {
        //        return $"Hello grandma { Name }";++++++
        //    }

        //    if (Age < 65 && Age > 18 && Sex == "M")
        //    {
        //        return $"hi man how do you live in your {Age}s";
        //    }

        //    if (Age < 65 && Age > 18 && Sex == "F")
        //    {
        //        return $"hello beauty I would never say that to you {Age}";
        //    }

        //    if (Age < 18 && Sex == "F")
        //    {
        //        return $"Hello girl, do you already know how to spend an owl's 18th birthday?";
        //    }

        //    if (Age < 18 && Sex == "M")
        //    {
        //        return $"Hi, how are you going to the army? you are already {Age} years old, which means that in {18-Age} years you will be in the army";
        //    }++++++

        //    if (Age > 80 && Sex == "M")
        //    {
        //        return $"Hello! Mr. { Name }, how did you manage to live to such an age";++++++
        //    }

        //    if (Age > 80 && Sex == "F")
        //    {
        //        return $"Hello! Ms. { Name }, how did you manage to live to such an age";+++++
        //    }

        //    return $"Hello { Name }";
        //}
    }
}
