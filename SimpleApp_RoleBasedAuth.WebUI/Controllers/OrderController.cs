using Microsoft.AspNetCore.Mvc;
using SimpleApp_RoleBasedAuth.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleApp_RoleBasedAuth.WebUI.Controllers
{
    public class OrderController : Controller
    {
        IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        public IActionResult Index()
        {
            return View(_orderService.GetAll());
        }
       
        public ActionResult OrderDetail(int? id)
        {
            return View(_orderService.Get(id));
        }
        public IActionResult OrderProduct(int? id)
        {
            return View(_orderService.GetOrderByProductId(id));
        }
        public IActionResult OrderPayment(int? id)
        {
            return View(_orderService.GetOrderByPaymentId(id));
        }
        public IActionResult Delete(int? id)
        {
            var deleteOrder = _orderService.Get(id);
            if (deleteOrder!=null)
            {
                _orderService.Delete(deleteOrder);
                return RedirectToAction(nameof(Index));
            }
            return ViewBag.Error = "There is a mistake";
        }
    }
}
