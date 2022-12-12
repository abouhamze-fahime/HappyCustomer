using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Common.Commands
{
    public interface ICommandHandler<in T> where T :ICommand
    {
        Task HandelAsync(T command );
        
    }
}