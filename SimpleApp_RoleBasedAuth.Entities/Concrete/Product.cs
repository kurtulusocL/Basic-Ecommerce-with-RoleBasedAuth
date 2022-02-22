using SimpleApp_RoleBasedAuth.Core.Entities.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleApp_RoleBasedAuth.Entities.Concrete
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string IdentityName { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public virtual ICollection<Picture> Pictures { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
