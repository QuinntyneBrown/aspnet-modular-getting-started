using Chloe.Data.Contracts;
using Chloe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chloe.Data
{
    public class ChloeUow: IChloeUow
    {
        public ChloeUow(IDbContext dbContext = null)
        {
            this.dbContext = dbContext;

            ConfigureDbContext(this.dbContext);

            var repositoryProvider = new RepositoryProvider(new RepositoryFactories());

            repositoryProvider.dbContext = this.dbContext;

            RepositoryProvider = repositoryProvider;
        }

        public ChloeUow(IRepositoryProvider repositoryProvider, IDbContext dbContext = null)
        {
            this.dbContext = dbContext;

            ConfigureDbContext(this.dbContext);

            repositoryProvider.dbContext = this.dbContext;

            RepositoryProvider = repositoryProvider;
        }

        public IRepository<Book> Books { get { return GetStandardRepo<Book>(); } }

        protected void ConfigureDbContext(IDbContext dbContext)
        {
            dbContext.Configuration.ProxyCreationEnabled = false;
            dbContext.Configuration.LazyLoadingEnabled = false;
            dbContext.Configuration.ValidateOnSaveEnabled = false;
        }

        protected IRepository<T> GetStandardRepo<T>() where T : class
        {
            return RepositoryProvider.GetRepositoryForEntityType<T>();
        }

        protected T GetRepo<T>() where T : class
        {
            return RepositoryProvider.GetRepository<T>();
        }

        public void SaveChanges()
        {
            this.dbContext.SaveChanges();
        }

        #region IDisposable

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.dbContext != null)
                {
                    this.dbContext.Dispose();
                }
            }
        }

        #endregion

        protected IDbContext dbContext;

        protected IRepositoryProvider RepositoryProvider { get; set; }
    }
}
