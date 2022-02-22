using Microsoft.AspNetCore.Http;
using SimpleApp_RoleBasedAuth.Business.CrossCuttingConcern;
using SimpleApp_RoleBasedAuth.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleApp_RoleBasedAuth.Business.Abstract
{
    public interface IProductService: IBusinessGenericRepository<Product>
    {
        List<Product> GetAllProductsByCategoryId(int? id);
        Product GetProductById(int? id);
        List<Category> GetCategoryForProductAdd();
        void AddPhotos(int? productId, string title, IEnumerable<IFormFile> images);
    }
}
