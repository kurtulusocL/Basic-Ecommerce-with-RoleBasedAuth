using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleApp_RoleBasedAuth.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleApp_RoleBasedAuth.WebUI.Controllers
{
    [Authorize(Policy = "RequireAdminRole")]
    public class PictureController : Controller
    {
        IPictureService _pictureService;
        public PictureController(IPictureService pictureService)
        {
            _pictureService = pictureService;
        }
        public IActionResult Index()
        {
            return View(_pictureService.GetAll());
        }
        public IActionResult ProductPictureList(int? id)
        {
            return View(_pictureService.GetAllPicturesByProductId(id));
        }

        public IActionResult Edit(int? id)
        {
            var updatePicture = _pictureService.Get(id);
            if (updatePicture != null)
            {
                return View(updatePicture);
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int? productId, string title, IEnumerable<IFormFile> images)
        {
            _pictureService.UpdatePhotos(productId, title, images);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int? id)
        {
            var deletePicture = _pictureService.Get(id);
            if (deletePicture != null)
            {
                _pictureService.Delete(deletePicture);
                return RedirectToAction(nameof(Index));
            }
            return ViewBag.Error = "There is a mistake";
        }
    }
}
