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
    public class OrderDal : EntityRepositoryBase<Order, ApplicationDbContext>, IOrderDal
    {
        public List<Order> GetAllIncluding()
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                return context.Set<Order>().Include("Product").Include("Payment").OrderByDescending(i => i.CreatedDate).ToList();
            }
        }

        public List<Order> GetAllUserOrders(string email)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                return context.Set<Order>().Include("Product").Include("Payment").Where(i => i.IdentityName == email).OrderByDescending(i => i.CreatedDate).ToList();
            }
        }

        public Order GetOrderByPaymentId(int? id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                return context.Set<Order>().Where(i => i.PaymentId == id).Include("Product").Include("Payment").FirstOrDefault();
            }
        }

        public Order GetOrderByProductId(int? id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                return context.Set<Order>().Where(i => i.ProductId == id).Include("Product").Include("Payment").FirstOrDefault();
            }
        }

        public List<Payment> GetPaymentForOrderAdd()
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                return context.Set<Payment>().Include("Orders").OrderBy(i => i.Orders.Count()).ToList();
            }
        }

        public void PayOrder(string namesurname, string identityName, string emailAddress, string address, int? productId, int paymentId)
        {
            var model = new Order
            {
                NameSurname = namesurname,
                EmailAddress = emailAddress,
                Address = address,
                ProductId = productId,
                PaymentId = paymentId,
                IdentityName = identityName
            };
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                context.Orders.Add(model);
                context.Entry(model).State = EntityState.Added;
                context.SaveChanges();
            }
        }
    }
}
