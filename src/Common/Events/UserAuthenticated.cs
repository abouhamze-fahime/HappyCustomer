using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Common.Events
{
    public class UserAuthenticated:IEvent
    {
        public string  Email { get; set; }
        public UserAuthenticated()
        {
            
        }
        public UserAuthenticated(string email )
        {
            Email=email;
        }
    }
}