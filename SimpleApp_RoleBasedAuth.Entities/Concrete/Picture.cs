using SimpleApp_RoleBasedAuth.Core.Entities.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleApp_RoleBasedAuth.Entities.Concrete
{
    public class Picture : BaseEntity
    {
        public string Title { get; set; }
        public string ImageUrl { get; set; }

        public int? ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
