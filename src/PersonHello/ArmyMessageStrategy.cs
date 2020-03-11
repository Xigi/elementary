using System;
using System.Collections.Generic;
using System.Text;

namespace PersonHello
{
    public class ArmyMessageStrategy : IMessageStrategy
    {
        public string Message { get; private set; }

        public bool Execute(Person p)
        {
            if (p.IsArmy())
            {
                Message = $"Hi, how are you going to the army? you are already {p.Age} years old, which means that in {18 - p.Age} years you will be in the army";
                return true;
            }
            return false;
        }
    }
}
