using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DAL.CRUD.PedidosWeb;

namespace WebApi.Controllers.PedidosWeb
{
    [RoutePrefix("api/Personas")]
    public class PersonasController : ApiController
    {
        [HttpGet]
        [Route("Consultar")]
        public IHttpActionResult Consultar(int pTiposDocumentoId, double pNroDocumento)
        {
            if (!ModelState.IsValid)
            {
                return Content(HttpStatusCode.BadRequest, ModelState); //BadRequest(ModelState);
            }
            try
            {
                IList<BE.Pedidos.Personas> personas = CRUDPersonas.instancia.Consultar(pTiposDocumentoId, pNroDocumento);
                return Content(HttpStatusCode.OK, personas);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex.InnerException.InnerException);
            }

        }

        [HttpGet]
        [Route("ConsultarPorNombre")]
        public IHttpActionResult ConsultarPorNombre(string pNombre)
        {
            if (!ModelState.IsValid)
            {
                return Content(HttpStatusCode.BadRequest, ModelState); //BadRequest(ModelState);
            }
            try
            {
                IList<BE.Pedidos.Personas> personas = CRUDPersonas.instancia.ConsultarPorNombre(pNombre);
                return Content(HttpStatusCode.OK, personas);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex.InnerException.InnerException);
            }

        }
    }
}
