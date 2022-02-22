using SimpleApp_RoleBasedAuth.Core.Entities.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleApp_RoleBasedAuth.Entities.Concrete
{
    public class Payment : BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
