using Microsoft.EntityFrameworkCore;
using SimpleApp_RoleBasedAuth.Core.DataAccess.EntityFramework;
using SimpleApp_RoleBasedAuth.DataAccess.Abstract;
using SimpleApp_RoleBasedAuth.DataAccess.Concrete.EntityFramework.Context;
using SimpleApp_RoleBasedAuth.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleApp_RoleBasedAuth.DataAccess.Concrete.EntityFramework
{
    public class PaymentDal : EntityRepositoryBase<Payment, ApplicationDbContext>, IPaymentDal
    {
        public List<Payment> GetAllIncluding()
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                return context.Set<Payment>().Include("Orders").OrderByDescending(i => i.CreatedDate).ToList();
            }
        }
    }
}
