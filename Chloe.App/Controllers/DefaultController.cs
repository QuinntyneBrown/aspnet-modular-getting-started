using Chloe.Metal.Filter;
using Chloe.Services.Contracts;
using System.Web.Mvc;

namespace Chloe.App.Controllers
{
    public class DefaultController : BaseController
    {
        public DefaultController(IChloeService chloeService)
            :base(chloeService)
        {

        }

        [ChloeRoute]
        public ActionResult Index()
        {           
            return View(chloeService.GetPageViewModel());
        }
        
    }
}