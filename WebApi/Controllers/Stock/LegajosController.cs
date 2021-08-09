using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers.Stock
{
    [RoutePrefix("api/Legajos")]
    public class LegajosController : ApiController
    {
        [HttpGet]
        [Route("ImagenesPieza")]
        public IHttpActionResult ImagenesPieza(string pPatente, string pCodigoOblea)
        {
            var legajo = new DAL.CRUD.Stock.Legajos();
            var leg = legajo.ObtenerImagenes(pPatente, pCodigoOblea);
            return Content(HttpStatusCode.OK, leg);
        }
        
    }
}
