using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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
    public class ProductController : Controller
    {
        IProductService _productService;
        IPictureService _pictureService;
        IBoxService _boxService;
        IOrderService _orderService;
        public ProductController(IProductService productService, IPictureService pictureService, IBoxService boxService, IOrderService orderService)
        {
            _productService = productService;
            _pictureService = pictureService;
            _boxService = boxService;
            _orderService = orderService;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View(_productService.GetAll());
        }

        [AllowAnonymous]
        public IActionResult Category(int? id)
        {
            return View(_productService.GetAllProductsByCategoryId(id));
        }

        [AllowAnonymous]
        public IActionResult Detail(int? id)
        {
            return View(_productService.GetProductById(id));
        }

        [AllowAnonymous]
        public IActionResult AddBox(int id, Product model)
        {
            model = _productService.Get(id);
            model.IdentityName = User.Identity.Name;
            _boxService.AddBox(model);
            TempData["msg"] = "The product is in your box.";
            return RedirectToAction(nameof(Detail), new { id = model.Id });
        }

        [AllowAnonymous]
        public IActionResult CustomerBox()
        {
            return View(_boxService.ProductListInBox());
        }

        [AllowAnonymous]
        public IActionResult GetEmptyBox()
        {
            _boxService.EmptyBox();
            return RedirectToAction(nameof(CustomerBox));
        }

        [AllowAnonymous]
        public IActionResult DeleteFromBox(int id)
        {
            var product = _productService.Get(id);
            _boxService.DeleteBox(product);
            return RedirectToAction(nameof(CustomerBox));
        }

        [AllowAnonymous]
        public IActionResult Pay(int? id)
        {
            ViewBag.Payments = _orderService.GetPaymentForOrderAdd();
            ViewBag.ProductId = _productService.Get(id);
            ViewBag.IdentityName = User.Identity.Name;

            Order model = new Order
            {
                ProductId = id,
                IdentityName = User.Identity.Name
            };
            return View("Pay", model);
        }

        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Pay(string namesurname, string identityName, string emailAddress, string address, int? productId, int paymentId)
        {
            if (ModelState.IsValid)
            {
                _orderService.PayOrder(namesurname, identityName, emailAddress, address, productId, paymentId);
                return RedirectToAction(nameof(EndOrder));
            }
            return RedirectToAction(nameof(CustomerBox));
        }

        [AllowAnonymous]
        public IActionResult EndOrder()
        {
            return View();
        }
        public IActionResult ProductList()
        {
            return View(_productService.GetAll());
        }
        public IActionResult CategoryProduct(int? id)
        {
            return View(_productService.GetAllProductsByCategoryId(id));
        }
        public IActionResult ProductDetail(int? id)
        {
            return View(_productService.GetProductById(id));
        }
        public IActionResult Create()
        {
            ViewBag.Categories = _productService.GetCategoryForProductAdd();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product model)
        {
            if (ModelState.IsValid)
            {
                _productService.Add(model);
                return RedirectToAction(nameof(Create));
            }
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Edit(int? id)
        {
            ViewBag.Categories = _productService.GetCategoryForProductAdd();
            var updateProduct = _productService.Get(id);
            if (updateProduct != null)
            {
                return View(updateProduct);
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Product model)
        {
            if (ModelState.IsValid)
            {
                _productService.Update(model);
                return RedirectToAction(nameof(Edit));
            }
            return RedirectToAction(nameof(Index));
        }
        public IActionResult CreatePhoto(int? id)
        {
            ViewBag.ProductId = _productService.Get(id);
            Picture model = new Picture
            {
                ProductId = id,
            };
            return View("CreatePhoto", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreatePhoto(int? productId, string title, IEnumerable<IFormFile> images)
        {
            _productService.AddPhotos(productId, title, images);
            return RedirectToAction(nameof(CreatePhoto));
        }
        public IActionResult Delete(int? id)
        {
            var deleteProduct = _productService.Get(id);
            if (deleteProduct != null)
            {
                _productService.Get(id);
                return RedirectToAction(nameof(Index));
            }
            return ViewBag.Error = "There is a mistake";
        }
    }
}
