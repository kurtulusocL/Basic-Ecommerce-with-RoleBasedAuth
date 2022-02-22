using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SimpleApp_RoleBasedAuth.Business.Abstract;
using SimpleApp_RoleBasedAuth.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleApp_RoleBasedAuth.WebUI.Controllers
{
    [Authorize(Policy = "RequireAdminRole")]
    public class PaymentController : Controller
    {
        IPaymentService _paymentService;
        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }
        public IActionResult Index()
        {
            return View(_paymentService.GetAll());
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Payment model)
        {
            if (ModelState.IsValid)
            {
                _paymentService.Add(model);
                return RedirectToAction(nameof(Create));
            }
            return RedirectToAction(nameof(Index));
        }
        public ActionResult Edit(int? id)
        {
            var updatePayment = _paymentService.Get(id);
            if (updatePayment!=null)
            {
                return View(updatePayment);
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Payment model)
        {
            if (ModelState.IsValid)
            {
                _paymentService.Update(model);
                return RedirectToAction(nameof(Edit));
            }
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int? id)
        {
            var deletePayment = _paymentService.Get(id);
            if (deletePayment!=null)
            {
                _paymentService.Delete(deletePayment);
                return RedirectToAction(nameof(Index));
            }
            return ViewBag.Error = "There is a mistake";
        }
    }
}
