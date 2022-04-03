using System;
using System.Collections.Generic;

namespace TestApp.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        List<T> GetAll();
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        void CreateRange(List<T> entities);
        T FindById(Guid id);
        bool SaveChanges();
    }
}
