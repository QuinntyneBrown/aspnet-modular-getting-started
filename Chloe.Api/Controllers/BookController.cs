using Chloe.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Chloe.Api.Controllers
{
    public class BookController : ApiController
    {
        public BookController(IBookService bookService)
        {
            this.bookService = bookService;
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok();
        }

        protected readonly IBookService bookService;
    }
}
