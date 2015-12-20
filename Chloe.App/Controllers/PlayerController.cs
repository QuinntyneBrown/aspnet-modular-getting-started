using Chloe.Services.Contracts;
using System.Web.Mvc;

namespace Chloe.App.Controllers
{
    public class PlayerController : BaseController
    {
        public PlayerController(IChloeService chloeService):
            base(chloeService)
        {

        }

        public ActionResult Index()
        {
            return View();
        }
    }
}