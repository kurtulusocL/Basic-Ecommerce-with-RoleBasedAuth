using SimpleApp_RoleBasedAuth.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleApp_RoleBasedAuth.Business.CrossCuttingConcern
{
    public interface IBusinessGenericRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll();
        T Get(int? id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
