using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using taskApi.Models;

namespace taskApi.Generics.Repository.Interface
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> getAll();
        IQueryable<T> findByPredicate(Expression<Func<T, bool>> predicate);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        void SaveChanges();
    }
}