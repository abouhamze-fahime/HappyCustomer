using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Common.Events
{
    public class ActivityCreated : IAuthenticateEvent
    {
        public Guid Id { get;  }
        public Guid UserId {get;}
        public string Category { get; }
        public string Name { get;  }
        public string Description { get;  }
        public DateTime CreateAt { get;  }

        protected ActivityCreated ()
        {

        }
        public ActivityCreated(Guid id , Guid userId , string category , string name , string desciption , DateTime createAt)
        {
            this.Id=id;
            this.UserId=userId;
            this.CreateAt=createAt;
            this.Category=category;
            this.Description=desciption;
            this.Name=name;
        }
    }
}