using System;
using System.Collections.Generic;
using System.Text;

namespace PersonHello
{
    public class BirthdayMessageStrategy : IMessageStrategy
    {
        public string Message { get; private set; }

        public bool Execute(Person p)
        {
            if (p.IsBirthday())
            {
                Message = $"Hello { p.FirstName } you already enjoy your birthday";
                return true;
            }

            return false;
        }
    }
}
