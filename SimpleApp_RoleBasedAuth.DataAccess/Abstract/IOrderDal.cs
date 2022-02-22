using SimpleApp_RoleBasedAuth.Core.DataAccess;
using SimpleApp_RoleBasedAuth.Entities.Concrete;
using SimpleApp_RoleBasedAuth.Entities.Concrete.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleApp_RoleBasedAuth.DataAccess.Abstract
{
    public interface IOrderDal : IEntityRepository<Order>
    {
        List<Order> GetAllIncluding();       
        List<Payment> GetPaymentForOrderAdd();
        List<Order> GetAllUserOrders(string email);
        Order GetOrderByProductId(int? id);       
        Order GetOrderByPaymentId(int? id);
        void PayOrder(string namesurname, string identityName, string emailAddress, string address, int? productId, int paymentId);
    }
}
