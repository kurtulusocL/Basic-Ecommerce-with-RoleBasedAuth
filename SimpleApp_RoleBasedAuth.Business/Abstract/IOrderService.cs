using SimpleApp_RoleBasedAuth.Business.CrossCuttingConcern;
using SimpleApp_RoleBasedAuth.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleApp_RoleBasedAuth.Business.Abstract
{
    public interface IOrderService: IBusinessGenericRepository<Order>
    {
        List<Payment> GetPaymentForOrderAdd();
        List<Order> GetAllUserOrders(string email);
        Order GetOrderByProductId(int? id);       
        Order GetOrderByPaymentId(int? id);
        void PayOrder(string namesurname, string identityName, string emailAddress, string address, int? productId, int paymentId);
    }
}
