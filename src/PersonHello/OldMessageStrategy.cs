using System;
using System.Collections.Generic;
using System.Text;

namespace PersonHello
{
    class OldMessageStrategy : IMessageStrategy
    {
        public string Message { get; private set; }

        public bool Execute(Person p)
        {
            if (p.IsOld())
            {
                Message = $"Hello! Mr. { p.FirstName }, how did you manage to live to such an age";
                return true;
            }
            return false;

        }

    }
}
