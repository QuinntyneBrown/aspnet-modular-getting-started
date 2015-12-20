using Chloe.Services.Contracts;
using System.Web.Mvc;

namespace Chloe.App.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(IChloeService chloeService)
        {
            this.chloeService = chloeService;
        }

        public ActionResult Index()
        {
            return View(chloeService.GetHomePageViewModel());
        }

        protected readonly IChloeService chloeService;
    }
}