using Chloe.Metal.Filters;
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
        [MetaData]
        public ActionResult Index()
        {           
            return View(chloeService.GetPageViewModel());
        }
        
    }
}