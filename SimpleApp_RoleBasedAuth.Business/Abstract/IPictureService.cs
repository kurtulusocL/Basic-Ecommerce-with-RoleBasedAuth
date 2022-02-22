using Microsoft.AspNetCore.Http;
using SimpleApp_RoleBasedAuth.Business.CrossCuttingConcern;
using SimpleApp_RoleBasedAuth.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleApp_RoleBasedAuth.Business.Abstract
{
    public interface IPictureService: IBusinessGenericRepository<Picture>
    {
        List<Picture> GetAllPicturesByProductId(int? id);
        Picture GetPictureByProductId(int? id);
        void UpdatePhotos(int? productId, string title, IEnumerable<IFormFile> images);
    }
}
