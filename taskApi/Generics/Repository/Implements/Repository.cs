using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using taskApi.Generics.Repository.Interface;
using taskApi.Models;

namespace taskApi.Generics.Repository.Impl
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public SUPERO_INTELBRASContext _Context { get; set; }

        public Repository(SUPERO_INTELBRASContext Context)
        {
            _Context = Context;
        }
        public void Create(T entity)
        {
            _Context.Add(entity);
        }

        public void Delete(T entity)
        {
            _Context.Set<T>().Remove(entity);
        }

        public IQueryable<T> findByPredicate(Expression<Func<T, bool>> predicate)
        {
            return _Context.Set<T>().Where(predicate).AsNoTracking();
        }

        public IQueryable<T> getAll()
        {
            return _Context.Set<T>();
        }

        public void Update(T entity)
        {
            _Context.Set<T>().Update(entity);
        }

        public void SaveChanges()
        {
            _Context.SaveChanges();
        }
    }
}