using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DAL.CRUD.PedidosWeb;

namespace WebApi.Controllers.PedidosWeb
{
    [RoutePrefix("api/PedidosWebArchivos")]
    public class PedidosWebArchivosController : ApiController
    {
        [HttpPost]
        [Route("Guardar")]
        public IHttpActionResult Guardar(BE.Pedidos.PedidosWebArchivos pPedidosWebArchivos)
        {
            if (!ModelState.IsValid)
            {
                return Content(HttpStatusCode.BadRequest, ModelState); //BadRequest(ModelState);
            }
            try
            {
                bool pedidosWebArchivos = CRUDPedidosWebArchivos.instancia.Guardar(pPedidosWebArchivos);
                return Content(HttpStatusCode.OK, pedidosWebArchivos);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex.InnerException.Message);
            }


        }

        [HttpGet]
        [Route("ConsultarFactura")]
        public IHttpActionResult ConsultarFactura(int pPedidosWebId)
        {
            if (!ModelState.IsValid)
            {
                return Content(HttpStatusCode.BadRequest, ModelState); //BadRequest(ModelState);
            }
            try
            {
                BE.Pedidos.PedidosWebArchivos pedidosWebArchivos = CRUDPedidosWebArchivos.instancia.ConsultarFactura(pPedidosWebId);
                return Content(HttpStatusCode.OK, pedidosWebArchivos);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex.InnerException.Message);
            }
        }
    }
}
