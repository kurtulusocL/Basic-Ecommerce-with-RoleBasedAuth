using SimpleApp_RoleBasedAuth.Core.CrossCuttingConcern.Dtos.AccountDtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SimpleApp_RoleBasedAuth.Business.Abstract
{
    public interface IAuthService
    {
        Task AdminLoginAsync(LoginDto model);
        Task AdminRegisterAsync(RegisterDto model);
        Task AdminLogoutAsync();
        Task UserLoginAsync(LoginDto model);
        Task UserRegisterAsync(RegisterDto model);
        Task UserLogoutAsync();
    }
}
