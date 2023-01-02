using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TrueOnion.APPLICATION.Repositories;
using TrueOnion.DOMAIN.Entities.Abstarct;
using TrueOnion.DOMAIN.Entities.Common;
using TrueOnion.DOMAIN.Enums;
using TrueOnion.PERSISTINCE.Context;

namespace TrueOnion.PERSISTINCE.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class,IEntity
    {
        protected readonly AppDbContext _appDbContext;
        protected readonly DbSet<T> _dbSet;

        public GenericRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            _dbSet = _appDbContext.Set<T>();

        }


        //Find Comand

        public async Task<T> FindAsync(params object[] values)
        {
            return await _dbSet.FindAsync(values);
        }
        public async Task<bool> AnyAsync(Expression<Func<T, bool>> expression)
        {
            return await _dbSet.AnyAsync(expression);
        }

        public async Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> exp)
        {
            return await GetAllAsIQueryable().FirstOrDefaultAsync(exp);
        }

        public async Task<IEnumerable<T>> Where(Expression<Func<T, bool>> expression)
        {
            return await GetActivesAsIQueryable().Where(expression).ToListAsync();
        }

        public IQueryable<T> GetAllAsIQueryable()
        {
            return _dbSet.AsNoTracking();
        }

        public async Task<object> Select(Expression<Func<T, object>> expression)
        {
            return await _dbSet.Select(expression).ToListAsync();
        }


        //Modify Commands
        public async Task<T>  AddAsync(T entity)
        {
            entity.Status = DataStatus.Inserted;
            entity.InsertedDate = DateTime.Now;
            await _appDbContext.AddAsync(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
            
        }

        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            foreach (T entity in entities)
                await AddAsync(entity);
        }


        public async Task UpdateAsync(T entity)
        {
            entity.LastModifiedDate = DateTime.Now;
            entity.Status = DataStatus.Modified;
            //T toBeUpdated = await FindAsync(entity.ID);
            //_appDbContext.Entry(toBeUpdated).CurrentValues.SetValues(entity);
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task UpdateRangeAsync(IEnumerable<T> entities)
        {
            foreach (T entity in entities)
                await UpdateAsync(entity);
        }

        public async Task Destroy(T entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();

        }

        public async Task  DestroyRange(IEnumerable<T> entities)
        {
           _appDbContext.RemoveRange(entities);
            await _appDbContext.SaveChangesAsync();

        }

        public IQueryable<T> GetActivesAsIQueryable()
        {
            return _dbSet.AsNoTracking().Where(x => x.Status != DataStatus.Deleted);
        }

        public async Task DeleteAsync(T entity)
        {
            entity.LastModifiedDate = DateTime.Now;
            entity.Status = DataStatus.Deleted;
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task DeleteRangeAsync(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
                await DeleteAsync(entity);
        }
    }
}