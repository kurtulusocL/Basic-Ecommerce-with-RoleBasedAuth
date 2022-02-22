using SimpleApp_RoleBasedAuth.Entities.Concrete;
using SimpleApp_RoleBasedAuth.Entities.Concrete.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleApp_RoleBasedAuth.Business.Abstract
{
    public interface IBoxService
    {
        void AddBox(Product entity);
        void DeleteBox(Product entity);
        List<Product> ProductListInBox();
        void EmptyBox();       
    }
}
