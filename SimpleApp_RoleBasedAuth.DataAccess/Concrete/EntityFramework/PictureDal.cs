using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SimpleApp_RoleBasedAuth.Core.DataAccess.EntityFramework;
using SimpleApp_RoleBasedAuth.DataAccess.Abstract;
using SimpleApp_RoleBasedAuth.DataAccess.Concrete.EntityFramework.Context;
using SimpleApp_RoleBasedAuth.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SimpleApp_RoleBasedAuth.DataAccess.Concrete.EntityFramework
{
    public class PictureDal : EntityRepositoryBase<Picture, ApplicationDbContext>, IPictureDal
    {
        public List<Picture> GetAllIncluding()
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                return context.Set<Picture>().Include("Product").OrderByDescending(i => i.CreatedDate).ToList();
            }
        }

        public List<Picture> GetAllPicturesByProductId(int? id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                return context.Set<Picture>().Include("Product").Where(i => i.ProductId == id).OrderByDescending(i => i.CreatedDate).ToList();
            }
        }

        public Picture GetPictureByProductId(int? id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                return context.Set<Picture>().Include("Product").Where(i => i.ProductId == id).FirstOrDefault();
            }
        }

        public void UpdatePhotos(int? productId, string title, IEnumerable<IFormFile> images)
        {
            foreach (var image in images)
            {
                var model = new Picture
                {
                    ProductId = productId,
                    Title = title
                };
                var path = Path.GetExtension(image.FileName);
                var photoName = Guid.NewGuid() + path;
                var upload = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/product/" + photoName);
                var stream = new FileStream(upload, FileMode.Create);
                image.CopyTo(stream);
                model.ImageUrl = photoName;

                using (ApplicationDbContext context = new ApplicationDbContext())
                {
                    context.Pictures.Update(model);
                    context.Entry(model).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
        }
    }
}
