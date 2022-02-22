using SimpleApp_RoleBasedAuth.Core.DataAccess.EntityFramework;
using SimpleApp_RoleBasedAuth.DataAccess.Abstract;
using SimpleApp_RoleBasedAuth.DataAccess.Concrete.EntityFramework.Context;
using SimpleApp_RoleBasedAuth.Entities.Concrete.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleApp_RoleBasedAuth.DataAccess.Concrete.EntityFramework
{
    public class UserDal : EntityRepositoryBase<ApplicationUser, ApplicationDbContext>, IUserDal
    {
        public ApplicationUser GetUserInformation(string email)
        {
            using (ApplicationDbContext context=new ApplicationDbContext())
            {
                return context.Set<ApplicationUser>().Where(i => i.Email == email).FirstOrDefault();
            }
        }
    }
}
