using Microsoft.AspNetCore.Mvc;
using SimpleApp_RoleBasedAuth.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleApp_RoleBasedAuth.WebUI.ViewComponents
{
    public class HomeProductPicture:ViewComponent
    {
        IPictureService _pictureServie;
        public HomeProductPicture(IPictureService pictureService)
        {
            _pictureServie = pictureService;
        }
        public IViewComponentResult Invoke(int? id)
        {
            return View(_pictureServie.GetPictureByProductId(id));
        }
    }
}
