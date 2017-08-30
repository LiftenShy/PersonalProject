using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Person_Project.Data.Abstract;

namespace Person_Project.Data
{
    public class EfRepository<T> : IRepository<T> where T : class
    {
        private readonly PersonContext _context;

        private DbSet<T> _entities;

        public EfRepository(PersonContext context)
        {
            _context = context;
        }

        public T GetById(int id)
        {
            return Entities.Find(id);
        }

        public void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            Entities.Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }

                Entities.Remove(entity);
                _context.SaveChanges();
            }
            catch (DbException ex)
            {
                throw ex.InnerException;
            }
        }

        public virtual IQueryable<T> Table => this.Entities;

        private DbSet<T> Entities => _entities ?? (_entities = _context.Set<T>());

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
