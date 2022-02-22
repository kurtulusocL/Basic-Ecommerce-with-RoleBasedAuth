using SimpleApp_RoleBasedAuth.Core.Entities.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleApp_RoleBasedAuth.Entities.Concrete
{
    public class Order : BaseEntity
    {
        public string NameSurname { get; set; }

        public string EmailAddress { get; set; }
        public string Address { get; set; }
        public string IdentityName { get; set; }

        public int? ProductId { get; set; }
        public int PaymentId { get; set; }

        public virtual Product Product { get; set; }
        public virtual Payment Payment { get; set; }
    }
}
