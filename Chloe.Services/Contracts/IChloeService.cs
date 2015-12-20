using Chloe.ViewModels.Contracts;
using System.Collections.Generic;
using System.Net.Http;
using System.Web;

namespace Chloe.Services.Contracts
{
    public interface IChloeService
    {
        IHome GetHomePageViewModel(Dictionary<string,string> routeParams = null);
    }
}
