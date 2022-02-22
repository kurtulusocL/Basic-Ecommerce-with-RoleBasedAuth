using Microsoft.AspNetCore.Http;
using SimpleApp_RoleBasedAuth.Business.Abstract;
using SimpleApp_RoleBasedAuth.DataAccess.Abstract;
using SimpleApp_RoleBasedAuth.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleApp_RoleBasedAuth.Business.Concrete
{
    public class PictureManager : IPictureService
    {
        IPictureDal _pictureDal;
        public PictureManager(IPictureDal pictureDal)
        {
            _pictureDal = pictureDal;
        }
        public void Add(Picture entity)
        {
            _pictureDal.Add(entity);
        }

        public void Delete(Picture entity)
        {
            _pictureDal.Delete(entity);
        }

        public Picture Get(int? id)
        {
            return _pictureDal.Get(i => i.Id == id);
        }

        public List<Picture> GetAll()
        {
            return _pictureDal.GetAllIncluding();
        }

        public List<Picture> GetAllPicturesByProductId(int? id)
        {
            return _pictureDal.GetAllPicturesByProductId(id);
        }

        public Picture GetPictureByProductId(int? id)
        {
            return _pictureDal.GetPictureByProductId(id);
        }

        public void Update(Picture entity)
        {
            _pictureDal.Update(entity);
        }

        public void UpdatePhotos(int? productId, string title, IEnumerable<IFormFile> images)
        {
            _pictureDal.UpdatePhotos(productId, title, images);
        }
    }
}
