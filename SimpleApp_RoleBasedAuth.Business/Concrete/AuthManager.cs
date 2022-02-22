using SimpleApp_RoleBasedAuth.Business.Abstract;
using SimpleApp_RoleBasedAuth.Core.CrossCuttingConcern.Dtos.AccountDtos;
using SimpleApp_RoleBasedAuth.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SimpleApp_RoleBasedAuth.Business.Concrete
{
    public class AuthManager : IAuthService
    {
        IAuthDal _authDal;
        public AuthManager(IAuthDal authDal)
        {
            _authDal = authDal;
        }

        public async Task AdminLoginAsync(LoginDto model)
        {
            await _authDal.AdminLoginAsync(model);
        }

        public async Task AdminLogoutAsync()
        {
            await _authDal.AdminLogoutAsync();
        }

        public async Task AdminRegisterAsync(RegisterDto model)
        {
            await _authDal.AdminRegisterAsync(model);
        }

        public async Task UserLoginAsync(LoginDto model)
        {
            await _authDal.UserLoginAsync(model);
        }

        public async Task UserLogoutAsync()
        {
            await _authDal.UserLogoutAsync();
        }

        public async Task UserRegisterAsync(RegisterDto model)
        {
            await _authDal.UserRegisterAsync(model);
        }
    }
}
