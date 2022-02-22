using Microsoft.AspNetCore.Http;
using SimpleApp_RoleBasedAuth.Core.DataAccess;
using SimpleApp_RoleBasedAuth.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleApp_RoleBasedAuth.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        List<Product> GetAllIncluding();
        List<Product> GetAllProductsByCategoryId(int? id);
        Product GetProductById(int? id);
        List<Category> GetCategoryForProductAdd();
        void AddPhotos(int? productId, string title, IEnumerable<IFormFile> images);
    }
}
