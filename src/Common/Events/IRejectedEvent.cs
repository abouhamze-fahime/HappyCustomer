using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Common.Events
{
    public interface IRejectedEvent :IEvent
    {
        string Reason {get;}
        string Code {get;}
    }
}