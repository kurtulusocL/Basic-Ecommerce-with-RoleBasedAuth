using Microsoft.AspNetCore.Http;
using SimpleApp_RoleBasedAuth.Business.Abstract;
using SimpleApp_RoleBasedAuth.DataAccess.Abstract;
using SimpleApp_RoleBasedAuth.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleApp_RoleBasedAuth.Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public void Add(Product entity)
        {
            _productDal.Add(entity);
        }

        public List<Category> GetCategoryForProductAdd()
        {
            return _productDal.GetCategoryForProductAdd();
        }

        public void Delete(Product entity)
        {
            _productDal.Delete(entity);
        }

        public Product Get(int? id)
        {
            return _productDal.Get(i => i.Id == id);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAllIncluding();
        }

        public List<Product> GetAllProductsByCategoryId(int? id)
        {
            return _productDal.GetAllProductsByCategoryId(id);
        }

        public void Update(Product entity)
        {
            _productDal.Update(entity);
        }

        public Product GetProductById(int? id)
        {
            return _productDal.GetProductById(id);
        }

        public void AddPhotos(int? productId, string title, IEnumerable<IFormFile> images)
        {
            _productDal.AddPhotos(productId, title, images);
        }
    }
}