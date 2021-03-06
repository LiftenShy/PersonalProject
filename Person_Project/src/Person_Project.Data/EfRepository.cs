﻿using System;
using System.Data.Common;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Person_Project.Data.Abstract;
using Person_Project.Models.EntityModels.BaseModels;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Person_Project.Data
{
    public class EfRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly PersonContext _context;

        private DbSet<T> _entities;

        public EfRepository(PersonContext context)
        {
            _context = context;
        }

        public async Task<T> GetById(int id)
        {
            return await Entities.FindAsync(id);
        }

        public async Task Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            await Entities.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            await _context.SaveChangesAsync();
        }

        public async Task Delete(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }

                Entities.Remove(entity);
                await _context.SaveChangesAsync();
            }
            catch (DbException ex)
            {
                throw ex.InnerException;
            }
        }

        public async Task<List<T>> GetAll()
        {
            return await Entities.ToListAsync();
        }

        public virtual IQueryable<T> Table => Entities;

        private DbSet<T> Entities => _entities ?? (_entities = _context.Set<T>());

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
