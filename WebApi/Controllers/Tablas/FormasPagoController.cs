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
    [RoutePrefix("api/FormasPago")]
    public class FormasPagoController : ApiController
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
                IList<FormasPago> formasPago = CRUDFormasPago.instancia.Consultar();
                return Content(HttpStatusCode.OK, formasPago);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex.InnerException.InnerException);
            }

        }
    }
}
