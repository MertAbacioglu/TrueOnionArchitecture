using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrueOnion.APPLICATION.Repositories;
using TrueOnion.APPLICATION.UnitOfWork;
using TrueOnion.DOMAIN.Entities.Common;
using TrueOnion.PERSISTINCE.Context;
using TrueOnion.PERSISTINCE.Repositories;

namespace TrueOnion.PERSISTINCE.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        #region variables

        private readonly AppDbContext _appDbContext;
        private readonly Dictionary<Type, object> _repositories = new Dictionary<Type, object>();
        public Dictionary<Type, object> Repositories
        {
            get { return _repositories; }
            set { Repositories = value; }
        }

        private IDbContextTransaction _transation;
        private bool _disposed;

        #endregion

        public UnitOfWork(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IGenericRepository<T> GetRepository<T>() where T : BaseEntity
        {
            if(Repositories.Keys.Contains(typeof(T)))
            {
                return Repositories[typeof(T)] as IGenericRepository<T>;
            }

            //IGenericRepository<T> repo = new IGenericRepository<T>(_appDbContext);
            //Repositories.Add(typeof(T), repo);
            return new GenericRepository<T>(_appDbContext);
        }

        public bool BeginNewTransaction()
        {
            try
            {
                _transation = _appDbContext.Database.BeginTransaction();
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }



        public bool RollBackTransaction()
        {
            try
            {
                _transation.Rollback();
                _transation = null;
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public int SaveChanges(bool ensureAutoHistory=false)
        {

            IDbContextTransaction transaction=_transation ?? _appDbContext.Database.BeginTransaction();
            using (transaction)
            {
                if (_appDbContext==null)
                {
                    throw new ArgumentException("Context is null");
                }
                if (ensureAutoHistory)
                {
                    //_appDbContext.EnsureAutoHistory();
                }

                int result = _appDbContext.SaveChanges();


                transaction.Commit();

                return result;
            }
            throw new NotImplementedException();
        }
    }
}
