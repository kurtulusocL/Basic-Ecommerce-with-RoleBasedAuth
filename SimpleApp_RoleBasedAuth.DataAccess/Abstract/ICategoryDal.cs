using SimpleApp_RoleBasedAuth.Core.DataAccess;
using SimpleApp_RoleBasedAuth.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleApp_RoleBasedAuth.DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
        List<Category> GetAllIncluding();
    }
}
