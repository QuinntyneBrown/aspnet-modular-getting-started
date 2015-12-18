using Chloe.Data.Contracts;
using Chloe.Models;
using System.Data.Entity;

namespace Chloe.Data
{
    public class ChloeContext : System.Data.Entity.DbContext, IDbContext
    {
        public ChloeContext()
            : base(nameOrConnectionString: "chloe")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
            Configuration.AutoDetectChangesEnabled = true;
        }

        public DbSet<Book> Books { get; set; }

        int IDbContext.SaveChanges()
        {
            return this.SaveChanges();
        }

        System.Data.Entity.Infrastructure.DbContextConfiguration IDbContext.Configuration
        {
            get { return this.Configuration; }
        }

        void System.IDisposable.Dispose()
        {
            this.Dispose();
        }

        System.Data.Entity.Core.Objects.ObjectContext System.Data.Entity.Infrastructure.IObjectContextAdapter.ObjectContext
        {
            get { throw new System.NotImplementedException(); }
        }
    }
}
