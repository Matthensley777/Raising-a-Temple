using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace MyHumidor.Controllers
{
    [RoutePrefix("api/cigars")]
    public class RATController : ApiController
    {
        [Route, HttpGet]
        public HttpResponseMessage GetList()
        {
            var repository = new RATRepository();
            var result = repository.ListAllCigars();

            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

       
    }
}