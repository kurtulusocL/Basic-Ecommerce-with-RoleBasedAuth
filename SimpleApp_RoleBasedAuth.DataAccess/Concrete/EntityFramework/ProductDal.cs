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
    public class ProductDal : EntityRepositoryBase<Product, ApplicationDbContext>, IProductDal
    {
        public List<Category> GetCategoryForProductAdd()
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                return context.Set<Category>().Include("Products").OrderBy(i => i.Products.Count()).ToList();
            }
        }

        public List<Product> GetAllIncluding()
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                return context.Set<Product>().Include("Pictures").Include("Orders").Include("Category").OrderByDescending(i => i.CreatedDate).ToList();
            }
        }

        public List<Product> GetAllProductsByCategoryId(int? id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                return context.Set<Product>().Include("Pictures").Include("Orders").Include("Category").Where(i => i.CategoryId == id).OrderByDescending(i => i.CreatedDate).ToList();
            }
        }

        public Product GetProductById(int? id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                return context.Set<Product>().Include("Pictures").Include("Orders").Include("Category").Where(i => i.Id == id).FirstOrDefault();
            }
        }

        public void AddPhotos(int? productId, string title, IEnumerable<IFormFile> images)
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
                    context.Pictures.Add(model);
                    context.Entry(model).State = EntityState.Added;
                    context.SaveChanges();
                }
            }            
        }
    }
}
