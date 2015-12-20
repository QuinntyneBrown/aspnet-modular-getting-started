using Chloe.ViewModels.Contracts;
using System.Collections.Generic;
using System.Net.Http;
using System.Web;

namespace Chloe.Services.Contracts
{
    public interface IChloeService
    {
        IHome GetHomePageViewModel();
        IPlayer GetPlayerPageViewModel();
    }
}
