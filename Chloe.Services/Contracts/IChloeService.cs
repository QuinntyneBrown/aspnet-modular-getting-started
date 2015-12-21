using Chloe.ViewComponents.Contracts;
using System.Collections.Generic;
using System.Net.Http;
using System.Web;

namespace Chloe.Services.Contracts
{
    public interface IChloeService
    {
        IPageViewModel GetPageViewModel();
    }
}
