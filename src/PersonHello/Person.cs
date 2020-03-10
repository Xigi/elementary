using System;

namespace PersonHello
{
    public class Person
    {
        //private DateTime Birthday
        //{
        //    get;
        //}
        private String Name
        {
            get;
        }

        private String LastName
        {
            get;
        }

        private String Sex
        {
            get;
        }

        private int Age
        {
            get;
        }

        public Person(String name, String lastname, String sex, int age)
        {
            if (age < 0)
            {
                throw new ArgumentException("age cannot be negative");
            }

            Name = name;
            LastName = lastname;
            Sex = sex;
            Age = age;
        }

        public String Hello()
        {

            if (Age > 65 && Age < 80 && Sex == "M")
            {
                return $"Hello { Name } you already enjoy your retirement";
            }

            if (Age > 65 && Age < 80 && Sex == "F")
            {
                return $"Hello grandma { Name }";
            }

            if (Age < 65 && Age > 18 && Sex == "M")
            {
                return $"hi man how do you live in your {Age}s";
            }

            if (Age < 65 && Age > 18 && Sex == "F")
            {
                return $"hello beauty I would never say that to you {Age}";
            }

            if (Age < 18 && Sex == "F")
            {
                return $"Hello girl, do you already know how to spend an owl's 18th birthday?";
            }

            if (Age < 18 && Sex == "M")
            {
                return $"Hi, how are you going to the army? you are already {Age} years old, which means that in {18-Age} years you will be in the army";
            }

            if (Age > 80 && Sex == "M")
            {
                return $"Hello! Mr. { Name }, how did you manage to live to such an age";
            }

            if (Age > 80 && Sex == "F")
            {
                return $"Hello! Ms. { Name }, how did you manage to live to such an age";
            }

            return $"Hello { Name }";
        }
    }
}
