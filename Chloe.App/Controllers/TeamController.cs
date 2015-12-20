using Chloe.Services.Contracts;
using System.Web.Mvc;

namespace Chloe.App.Controllers
{
    public class TeamController : BaseController
    {
        public TeamController(IChloeService chloeService):
            base(chloeService)
        {

        }

        public ActionResult Index()
        {
            return View();
        }
    }
}