using SimpleApp_RoleBasedAuth.Business.Abstract;
using SimpleApp_RoleBasedAuth.DataAccess.Abstract;
using SimpleApp_RoleBasedAuth.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleApp_RoleBasedAuth.Business.Concrete
{
    public class OrderManager : IOrderService
    {
        IOrderDal _orderDal;
        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }
        public void Add(Order entity)
        {
            _orderDal.Add(entity);
        }

        public void Delete(Order entity)
        {
            _orderDal.Delete(entity);
        }

        public Order Get(int? id)
        {
            return _orderDal.Get(i => i.Id == id);
        }

        public List<Order> GetAll()
        {
            return _orderDal.GetAllIncluding();
        }

        public List<Order> GetAllUserOrders(string email)
        {
            return _orderDal.GetAllUserOrders(email);
        }

        public Order GetOrderByPaymentId(int? id)
        {
            return _orderDal.GetOrderByPaymentId(id);
        }

        public Order GetOrderByProductId(int? id)
        {
            return _orderDal.GetOrderByProductId(id);
        }

        public List<Payment> GetPaymentForOrderAdd()
        {
            return _orderDal.GetPaymentForOrderAdd();
        }

        public void PayOrder(string namesurname, string identityName, string emailAddress, string address, int? productId, int paymentId)
        {
            _orderDal.PayOrder(namesurname, identityName, emailAddress, address, productId, paymentId);
        }

        public void Update(Order entity)
        {
            _orderDal.Update(entity);
        }
    }
}
