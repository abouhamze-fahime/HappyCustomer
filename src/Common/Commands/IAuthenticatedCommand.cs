using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Common.Commands
{
    public interface IAuthenticatedCommand:ICommand
    {
        Guid UserId {get; set;}
    }
}