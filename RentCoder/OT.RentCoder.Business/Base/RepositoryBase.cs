using System;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;

namespace OT.RentCoder.Business
{
    public class RepositoryBase<C> : IDisposable
        where C : DbContext, IDisposeTracker, new()
    {
        private C _DataContext;
        public virtual C DataContext
        {
            get
            {
                if (_DataContext == null || _DataContext.IsDisposed)
                {
                    _DataContext = new C();
                    AllowSerialization = true;
                }
                return _DataContext;
            }
        }

        public virtual bool AllowSerialization
        {
            get
            {
                //return ((IObjectContextAdapter) _DataContext)
                //.ObjectContext.ContextOptions.ProxyCreationEnabled = false;
                return _DataContext.Configuration.ProxyCreationEnabled;
            }
            set
            {
                _DataContext.Configuration.ProxyCreationEnabled = !value;
            }
        }

        /// <summary>
        /// Method to validate if date is not null and not min or max date
        /// </summary>
        /// <param name="dateValue"></param>
        /// <returns></returns>
        protected bool IsValidDate(DateTime? dateValue)
        {
            return (dateValue.HasValue && dateValue.Value != DateTime.MinValue && dateValue != DateTime.MaxValue);
        }


        public virtual T Get<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            if (predicate != null)
            {
                using (DataContext)
                {
                    return DataContext.Set<T>().Where(predicate).SingleOrDefault();
                }
            }
            else
            {
                throw new ApplicationException("Predicate value must be passed to Get<T>.");
            }
        }

        public virtual IQueryable<T> GetList<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            try
            {
                return DataContext.Set<T>().Where(predicate);
            }
            catch (Exception ex)
            {
            }
            return null;
        }

        public virtual IQueryable<T> GetList<T, TKey>(Expression<Func<T, bool>> predicate,
            Expression<Func<T, TKey>> orderBy) where T : class
        {
            try
            {
                return GetList(predicate).OrderBy(orderBy);
            }
            catch (Exception ex)
            {
            }
            return null;
        }

        public virtual IQueryable<T> GetList<T, TKey>(Expression<Func<T, TKey>> orderBy) where T : class
        {
            try
            {
                return GetList<T>().OrderBy(orderBy);
            }
            catch (Exception ex)
            {
            }
            return null;
        }

        public virtual IQueryable<T> GetList<T>() where T : class
        {
            try
            {
                return DataContext.Set<T>();
            }
            catch (Exception ex)
            {
            }
            return null;
        }     

        public void Dispose()
        {
            if (DataContext != null) DataContext.Dispose();
        }
    }
}