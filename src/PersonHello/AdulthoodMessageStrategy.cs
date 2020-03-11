using System;
using System.Collections.Generic;
using System.Text;

namespace PersonHello
{
    public class AdulthoodMessageStrategy : IMessageStrategy
    {
        public string Message { get; private set; }

        public bool Execute(Person p)
        {
            if (p.IsAdult() && !p.IsPensioner())
            {
                Message = $"Hello { p.FirstName } you already enjoy your adulthood";
                return true;
            }

            return false;
        }
    }
}
