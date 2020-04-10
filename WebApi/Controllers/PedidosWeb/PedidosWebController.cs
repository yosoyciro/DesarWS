using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DAL.CRUD.PedidosWeb;

namespace WebApi.Controllers.PedidosWeb
{
    [RoutePrefix("api/PedidosWeb")]
    public class PedidosWebController : ApiController
    {
        [HttpPost]
        [Route("Guardar")]
        public IHttpActionResult Consultar(BE.Pedidos.PedidosWeb pPedidosWeb)
        {
            if (!ModelState.IsValid)
            {
                return Content(HttpStatusCode.BadRequest, ModelState); //BadRequest(ModelState);
            }
            try
            {
                BE.Pedidos.PedidosWeb pedidosWeb = CRUDPedidosWeb.instancia.Guardar(pPedidosWeb);
                return Content(HttpStatusCode.OK, pedidosWeb);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex.InnerException.InnerException);
            }

        }
    }
}
