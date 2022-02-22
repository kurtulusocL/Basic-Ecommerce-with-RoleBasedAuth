using SimpleApp_RoleBasedAuth.Entities.Concrete.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleApp_RoleBasedAuth.Business.Abstract
{
    public interface IUserService
    {
        ApplicationUser GetUserInformation(string email);
    }
}
