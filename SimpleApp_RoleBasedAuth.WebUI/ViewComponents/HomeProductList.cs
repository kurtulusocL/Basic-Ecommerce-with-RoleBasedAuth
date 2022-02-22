using Microsoft.AspNetCore.Mvc;
using SimpleApp_RoleBasedAuth.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleApp_RoleBasedAuth.WebUI.ViewComponents
{
    public class HomeProductList:ViewComponent
    {
        IProductService _productService;
        public HomeProductList(IProductService productService)
        {
            _productService = productService;
        }
        public IViewComponentResult Invoke()
        {
            return View(_productService.GetAll());
        } 
    }
}
