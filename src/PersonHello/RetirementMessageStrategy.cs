using System;
using System.Collections.Generic;
using System.Text;

namespace PersonHello
{
    public class RetirementMessageStrategy : IMessageStrategy
    {
        public string Message { get; private set; }

        public bool Execute(Person p)
        {
            if (p.IsPensioner())
            {
                Message = $"Hello { p.FirstName } you already enjoy your retirement";
                return true;
            }

            return false;
        }
    }
}
