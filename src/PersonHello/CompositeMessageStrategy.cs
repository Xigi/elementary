using System;
using System.Collections.Generic;
using System.Text;

namespace PersonHello
{
    public class CompositeMessageStrategy : IMessageStrategy
    {
        private readonly IMessageStrategy _s1;
        private readonly IMessageStrategy _s2;

        public CompositeMessageStrategy(
          IMessageStrategy s1, IMessageStrategy s2)
        {
            _s1 = s1;
            _s2 = s2;
        }

        public string Message { get; private set; }

        public bool Execute(Person p)
        {
            if (_s1.Execute(p) && _s2.Execute(p))
            {
                Message = _s1.Message + " " + _s2.Message;
                return true;
            }

            return false;
        }
    }
}
