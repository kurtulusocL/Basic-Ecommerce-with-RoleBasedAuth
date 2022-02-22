using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SimpleApp_RoleBasedAuth.Core.IoC
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}