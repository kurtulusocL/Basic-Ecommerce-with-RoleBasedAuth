using SimpleApp_RoleBasedAuth.Core.DataAccess;
using SimpleApp_RoleBasedAuth.Entities.Concrete.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleApp_RoleBasedAuth.DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<ApplicationUser>
    {
        ApplicationUser GetUserInformation(string email);

    }
}
