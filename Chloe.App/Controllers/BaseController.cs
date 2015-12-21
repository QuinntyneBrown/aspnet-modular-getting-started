using Chloe.Services.Contracts;
using System.Web.Mvc;

namespace Chloe.Web.Controllers
{
    public class BaseController : Controller
    {
        public BaseController(IChloeService chloeService)
        {
            this.chloeService = chloeService;
        }
        
        protected readonly IChloeService chloeService;
    }
}