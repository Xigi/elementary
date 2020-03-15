using System;

namespace PersonHello
{
    public class Person
    {
        private readonly DateTime now = DateTime.Now;
        public string FirstName
        {
            get;
        }

        public string LastName
        {
            get;
        }

        public string Sex
        {
            get;
        }

        public int Age
        {
            get;
        }

        public DateTime Birthday
        {
            get;
        }

        public Person(string firstName, string lastname, string sex, int age, DateTime birthday)
        {
            if (age < 0)
            {
                throw new ArgumentException("age cannot be negative");
            }

            FirstName = firstName;
            LastName = lastname;
            Sex = sex;
            Age = age;
            Birthday = birthday;
        }

        public bool IsBirthday()
        {
            return (now.DayOfYear - Birthday.DayOfYear > -5) || (now.DayOfYear - Birthday.DayOfYear < 5);
        }

        public bool IsPensioner()
        {
            return (Age > 65 && Sex == "M")
                  || (Age > 60 && Sex == "F");
        }

        public bool IsAdult()
        {
            return Age > 18 && Age < 60;
        }

        public bool IsArmy()
        {
            return Age < 18 && Sex == "M";
        }

        public bool IsOld()
        {
            return (Age > 80);
        }
    }
}
