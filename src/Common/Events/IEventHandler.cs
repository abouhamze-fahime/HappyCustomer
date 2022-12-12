using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Common.Events
{
    public interface IEventHandler<in T> where T:IEvent
    {
        Task HandelAsync(T @event);
    }
}