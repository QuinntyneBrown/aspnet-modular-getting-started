using Chloe.Data.Contracts;
using Chloe.Services.Contracts;
using Chloe.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chloe.Services
{
    public class BookService: IBookService
    {
        public BookService(IChloeUow uow)
        {
            this.uow = uow;
        }

        public Page GetPageViewModel()
        {
            throw new NotImplementedException();
        }

        protected readonly IChloeUow uow;
    }
}
