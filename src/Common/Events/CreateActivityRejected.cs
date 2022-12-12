using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Common.Events
{
    public class CreateActivityRejected : IRejectedEvent
    {
        public Guid Id { get;}
        public string Reason {get;}

        public string Code {get;}

        protected CreateActivityRejected()
        {

        }

        public CreateActivityRejected(Guid id , string reason , string code )
        {
            Reason=reason;
            Id=id;
            Code=code;
        }
    }
}