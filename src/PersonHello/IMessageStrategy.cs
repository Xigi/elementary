using System;
using System.Collections.Generic;
using System.Text;

namespace PersonHello
{
    public interface IMessageStrategy
    {
        string Message { get; }
        bool Execute(Person p);
    }
}
