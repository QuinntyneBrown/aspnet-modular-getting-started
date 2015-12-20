using Chloe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chloe.Data.Contracts
{
    public interface IChloeUow: IDisposable
    {
        IRepository<Page> Pages { get; }

        IRepository<Component> Components { get; }

        void SaveChanges();
    }
}
