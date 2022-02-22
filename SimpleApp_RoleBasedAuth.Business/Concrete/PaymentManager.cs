using SimpleApp_RoleBasedAuth.Business.Abstract;
using SimpleApp_RoleBasedAuth.DataAccess.Abstract;
using SimpleApp_RoleBasedAuth.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleApp_RoleBasedAuth.Business.Concrete
{
    public class PaymentManager : IPaymentService
    {
        IPaymentDal _paymentDal;
        public PaymentManager(IPaymentDal paymentDal)
        {
            _paymentDal = paymentDal;
        }
        public void Add(Payment entity)
        {
            _paymentDal.Add(entity);
        }

        public void Delete(Payment entity)
        {
            _paymentDal.Delete(entity);
        }

        public Payment Get(int? id)
        {
           return _paymentDal.Get(i => i.Id == id);
        }

        public List<Payment> GetAll()
        {
            return _paymentDal.GetAllIncluding();
        }

        public void Update(Payment entity)
        {
            _paymentDal.Update(entity);
        }
    }
}
