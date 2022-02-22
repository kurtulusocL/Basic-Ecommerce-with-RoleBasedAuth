using Microsoft.AspNetCore.Identity;
using SimpleApp_RoleBasedAuth.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleApp_RoleBasedAuth.Entities.Concrete.Dtos
{
    public class ApplicationUser : IdentityUser, IEntity
    {
        public DateTime CreatedDate { get; set; }
        public void SetCreatedDate()
        {
            CreatedDate = DateTime.Now.ToLocalTime();
        }
    }
}
