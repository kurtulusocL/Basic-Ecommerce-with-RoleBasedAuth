using Microsoft.AspNetCore.Http;
using SimpleApp_RoleBasedAuth.Business.Abstract;
using SimpleApp_RoleBasedAuth.Core.Utilities.Extensions;
using SimpleApp_RoleBasedAuth.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleApp_RoleBasedAuth.Business.Concrete
{
    public class BoxManager : IBoxService
    {
        IHttpContextAccessor _httpContextAccessor;
        public BoxManager(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public void AddBox(Product entity)
        {            
            var productList = _httpContextAccessor.HttpContext.Session.GetObject<List<Product>>("box");
            if (productList == null)
            {
                productList = new List<Product>();
                productList.Add(entity);
            }
            else
            {
                productList.Add(entity);
            }
            _httpContextAccessor.HttpContext.Session.SetObject("box", productList);
        }
        public void DeleteBox(Product entity)
        {
            var productList = _httpContextAccessor.HttpContext.Session.GetObject<List<Product>>("box");
            productList.Remove(entity);
            _httpContextAccessor.HttpContext.Session.SetObject("box", productList);
        }

        public void EmptyBox()
        {
            _httpContextAccessor.HttpContext.Session.Remove("box");
        }

        public List<Product> ProductListInBox()
        {
            return _httpContextAccessor.HttpContext.Session.GetObject<List<Product>>("box");
        }
    }
}
