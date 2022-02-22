using Microsoft.AspNetCore.Identity;
using SimpleApp_RoleBasedAuth.Core.CrossCuttingConcern.Dtos.AccountDtos;
using SimpleApp_RoleBasedAuth.Core.DataAccess.EntityFramework;
using SimpleApp_RoleBasedAuth.DataAccess.Abstract;
using SimpleApp_RoleBasedAuth.DataAccess.Concrete.EntityFramework.Context;
using SimpleApp_RoleBasedAuth.Entities.Concrete.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SimpleApp_RoleBasedAuth.DataAccess.Concrete.EntityFramework
{
    public class AuthDal : EntityRepositoryBase<ApplicationUser, ApplicationDbContext>, IAuthDal
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AuthDal(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public async Task AdminLoginAsync(LoginDto model)
        {
            await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, lockoutOnFailure: false);
        }

        public async Task AdminRegisterAsync(RegisterDto model)
        {
            var user = new ApplicationUser { UserName = model.Email, Email = model.Email };
            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "Admin");
                var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                await _signInManager.SignInAsync(user, isPersistent: false);
            }
        }

        public async Task AdminLogoutAsync()
        {
            await _signInManager.SignOutAsync();
        }

        public async Task UserLoginAsync(LoginDto model)
        {
            await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, lockoutOnFailure: false);
        }

        public async Task UserRegisterAsync(RegisterDto model)
        {
            var user = new ApplicationUser { UserName = model.Email, Email = model.Email };
            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "User");
                var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                await _signInManager.SignInAsync(user, isPersistent: false);
            }
        }

        public async Task UserLogoutAsync()
        {
            await _signInManager.SignOutAsync();
        }
    }
}
