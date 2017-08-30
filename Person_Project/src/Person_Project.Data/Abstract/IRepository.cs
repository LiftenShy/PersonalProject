﻿
using System.Linq;

namespace Person_Project.Data.Abstract
{
    public interface IRepository<T> where T : class
    {
        T GetById(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        IQueryable<T> Table { get; }
    }
}
