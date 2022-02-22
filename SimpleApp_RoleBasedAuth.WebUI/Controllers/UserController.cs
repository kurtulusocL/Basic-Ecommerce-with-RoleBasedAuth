using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SimpleApp_RoleBasedAuth.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleApp_RoleBasedAuth.WebUI.Controllers
{
    [Authorize(Policy = "RequireUserRole")]
    public class UserController : Controller
    {
        IOrderService _orderService;
        IUserService _userService;
        public UserController(IOrderService orderService, IUserService userService)
        {
            _orderService = orderService;
            _userService = userService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MyOrders(string email)
        {
            email = User.Identity.Name;
            return View(_orderService.GetAllUserOrders(email));
        }
        public IActionResult Profile(string email)
        {
            email = User.Identity.Name;
            return View(_userService.GetUserInformation(email));
        }
    }
}
