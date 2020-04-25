using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BE.Tablas;
using DAL.CRUD.Tablas;

namespace WebApi.Controllers.Tablas
{

    [RoutePrefix("api/CanalesVenta")]
    public class CanalesVentaController : ApiController
    {
        [HttpGet]
        [Route("Consultar")]
        public IHttpActionResult Consultar()
        {
            if (!ModelState.IsValid)
            {
                return Content(HttpStatusCode.BadRequest, ModelState); //BadRequest(ModelState);
            }
            try
            {
                IList<CanalesVenta> canalesVenta = CRUDCanalesVenta.instancia.Consultar();
                return Content(HttpStatusCode.OK, canalesVenta);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex.InnerException.InnerException);
            }

        }
    }
}
