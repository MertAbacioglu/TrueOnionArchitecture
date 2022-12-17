using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TrueOnion.APPLICATION.Repositories;
using TrueOnion.DOMAIN.Entities.Common;
using TrueOnion.DOMAIN.Enums;
using TrueOnion.PERSISTINCE.Context;

namespace TrueOnion.PERSISTINCE.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
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

        public async Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>> expression)
        {
            return await GetAllAsIQueryable().Where(expression).ToListAsync();
        }

        public  IQueryable<T> GetAllAsIQueryable()
        {
            return  _dbSet.AsNoTracking();
        }

        public async Task<object> Select(Expression<Func<T, object>> expression)
        {
            return await _dbSet.Select(expression).ToListAsync();
        }


        //Modify Commands
        public async Task AddAsync(T entity)
        {
           await _dbSet.AddAsync(entity);
            _appDbContext.SaveChanges();
        }

        public Task AddRangeAsync(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }
        public void Remove(T entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateRange(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public void Destroy(T entity)
        {
            throw new NotImplementedException();
        }

        public void DestroyRange(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }
































        //public Task AddAsync(T entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public async Task<bool> AnyAsync(Expression<Func<T, bool>> expression)
        //{
        //    return await _dbSet.AnyAsync(expression);
        //}

        //public async Task<T> FindAsync(params object[] values)
        //{
        //    return await _dbSet.FindAsync(values);
        //}

        //public async Task<T> FirstOrDefault(Expression<Func<T, bool>> expression, params Expression<Func<T, object>>[] includeProperties)
        //{
        //    IQueryable<T> query = GetAllAsIQueryable(x => x.Status != DOMAIN.Enums.DataStatus.Deleted);

        //    if (includeProperties.Any())
        //        foreach (Expression<Func<T, object>> include in includeProperties)
        //            query = query.Include(include);

        //    return await query.FirstOrDefaultAsync(expression);

        //}

        //public IQueryable<T> GetAllAsIQueryable(Expression<Func<T, bool>> expression)
        //{
        //    IQueryable<T> query = _dbSet.AsQueryable();
        //    if (expression != null)
        //        query = query.Where(expression);
        //    return query;
        //}

        //public void Remove(T entity)
        //{
        //    entity.Status = DataStatus.Deleted;
        //    _dbSet.Update(entity);
        //}

        //public async void Update(T entity)
        //{
        //    entity.Status = DataStatus.Modified;
        //    entity.ModifiedDate = DateTime.Now;
        //    T toBeUpdated = await FindAsync(entity.ID);
        //    _dbSet.Entry(toBeUpdated).CurrentValues.SetValues(entity);
        //    Save();
        //}

        //public IQueryable<T> Where(Expression<Func<T, bool>> expression, params Expression<Func<T, object>>[] includeProperties)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
