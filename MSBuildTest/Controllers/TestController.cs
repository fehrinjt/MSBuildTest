using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MSBuildTest.Models;

namespace MSBuildTest.Controllers
{
    [RoutePrefix("api/test")]
    public class TestController : ApiController
    {
        [HttpGet]
        [Route]
        public IHttpActionResult Get()
        {
            try
            {
                var result = BuildReturnList();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        private List<Book> BuildReturnList()
        {
            var list = new List<Book>();

            list.Add(new Book("Red Rising", "Pierce Brown"));
            list.Add(new Book("Homeland", "R.A. Salvatore"));

            return list;
        }
    }
}
