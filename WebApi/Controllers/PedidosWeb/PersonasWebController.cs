using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DAL.CRUD.PedidosWeb;

namespace WebApi.Controllers.PedidosWeb
{
    [RoutePrefix("api/PersonasWeb")]
    public class PersonasWebController : ApiController
    {
        [HttpGet]
        [Route("Consultar")]
        public IHttpActionResult Consultar(int pCodigoDocumento, int pNroDocumento)
        {
            if (!ModelState.IsValid)
            {
                return Content(HttpStatusCode.BadRequest, ModelState); //BadRequest(ModelState);
            }
            try
            {
                IList<BE.Pedidos.PersonasWeb> personasWeb = CRUDPersonasWeb.instancia.Consultar(pCodigoDocumento, pNroDocumento);
                return Content(HttpStatusCode.OK, personasWeb);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex.InnerException.InnerException);
            }

        }
    }
}
