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
            var leg = legajo.ObtenerListaImagenes(pPatente, pCodigoOblea);
            return Content(HttpStatusCode.OK, leg);
        }

        [HttpGet]
        [Route("ObtenerImagen")]
        public IHttpActionResult ObtenerImagen(string pPatente, string pImagen)
        {
            var legajo = new DAL.CRUD.Stock.Legajos();
            var leg = legajo.ObtenerImagen(pPatente, pImagen);
            return Content(HttpStatusCode.OK, leg);
        }
    }
}
