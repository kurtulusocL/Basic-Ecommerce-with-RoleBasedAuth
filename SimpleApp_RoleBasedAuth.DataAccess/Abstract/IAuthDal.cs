using SimpleApp_RoleBasedAuth.Core.CrossCuttingConcern.Dtos.AccountDtos;
using SimpleApp_RoleBasedAuth.Core.DataAccess;
using SimpleApp_RoleBasedAuth.Entities.Concrete.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SimpleApp_RoleBasedAuth.DataAccess.Abstract
{
    public interface IAuthDal : IEntityRepository<ApplicationUser>
    {
        Task AdminLoginAsync(LoginDto model);
        Task AdminRegisterAsync(RegisterDto model);
        Task AdminLogoutAsync();
        Task UserLoginAsync(LoginDto model);
        Task UserRegisterAsync(RegisterDto model);
        Task UserLogoutAsync();
    }
}
