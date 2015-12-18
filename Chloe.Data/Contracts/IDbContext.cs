using System;
using System.Data.Entity.Infrastructure;

namespace Chloe.Data.Contracts
{
    public interface IDbContext : IDisposable, IObjectContextAdapter
    {
        int SaveChanges();

        DbContextConfiguration Configuration { get; }
    }
}