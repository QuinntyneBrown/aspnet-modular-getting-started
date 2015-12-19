using Chloe.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Chloe.Api.Controllers
{
    public class HomeController : ApiController
    {
        public HomeController(IChloeService chloeService)
        {
            this.chloeService = chloeService;
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(chloeService.GetHomePageViewModel());
        }

        protected readonly IChloeService chloeService;
    }
}
