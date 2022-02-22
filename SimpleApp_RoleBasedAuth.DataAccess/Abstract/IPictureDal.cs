using Microsoft.AspNetCore.Http;
using SimpleApp_RoleBasedAuth.Core.DataAccess;
using SimpleApp_RoleBasedAuth.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleApp_RoleBasedAuth.DataAccess.Abstract
{
    public interface IPictureDal : IEntityRepository<Picture>
    {
        List<Picture> GetAllIncluding();
        List<Picture> GetAllPicturesByProductId(int? id);
        Picture GetPictureByProductId(int? id);
        void UpdatePhotos(int? productId, string title, IEnumerable<IFormFile> images);
    }
}
