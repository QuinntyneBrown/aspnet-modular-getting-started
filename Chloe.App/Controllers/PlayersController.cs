using Chloe.Services.Contracts;
using System.Web.Mvc;

namespace Chloe.App.Controllers
{
    public class PlayersController : BaseController
    {
        public PlayersController(IChloeService chloeService):
            base(chloeService)
        {

        }
        public ActionResult Index()
        {
            return View();
        }
    }
}