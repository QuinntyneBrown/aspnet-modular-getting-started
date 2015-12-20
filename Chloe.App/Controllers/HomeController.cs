using Chloe.Services.Contracts;
using System.Web.Mvc;

namespace Chloe.App.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(IChloeService chloeService)
            :base(chloeService)
        {

        }

        public ActionResult Index()
        {           
            return View(chloeService.GetHomePageViewModel());
        }
        
    }
}