using SimpleApp_RoleBasedAuth.Business.CrossCuttingConcern;
using SimpleApp_RoleBasedAuth.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleApp_RoleBasedAuth.Business.Abstract
{
    public interface IPaymentService: IBusinessGenericRepository<Payment>
    {
    }
}
