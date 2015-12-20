using Chloe.Metal.Contracts;
using Chloe.Services.Contracts;
using System.Web.Mvc;

namespace Chloe.App.Controllers
{
    public class PlayerController : BaseController
    {
        public PlayerController(IChloeService chloeService, IRouteParamsProvider routeParamsProvider):
            base(chloeService)
        {

        }

        public ActionResult Index(string name)
        {
            routeParamsProvider.Set("playerName", name);
            return View(chloeService.GetPlayerPageViewModel());
        }

        protected readonly IRouteParamsProvider routeParamsProvider;
    }
}