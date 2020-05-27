using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DAL.CRUD.PedidosWeb;
using BLL;

namespace WebApi.Controllers.PedidosWeb
{
    [RoutePrefix("api/PedidosWeb")]
    public class PedidosWebController : ApiController
    {
        [HttpPost]
        [Route("Guardar")]
        public IHttpActionResult Guardar(BE.Pedidos.PedidosWeb pPedidosWeb)
        {
            if (!ModelState.IsValid)
            {
                DAL.Otros.ClsLog.instancia.EscribirLog("Error en ModelState");
                return Content(HttpStatusCode.BadRequest, ModelState); //BadRequest(ModelState);
            }
            try
            {
                DAL.Otros.ClsLog.instancia.EscribirLog("Entrando a guardar");
                BE.Pedidos.PedidosWeb pedidosWeb = CRUDPedidosWeb.instancia.Guardar(pPedidosWeb);
                return Content(HttpStatusCode.OK, pedidosWeb);
            }
            catch (Exception ex)
            {                
                return Content(HttpStatusCode.InternalServerError, ex.InnerException.Message);
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
                IList<BE.Pedidos.PedidosWeb> pedidosWeb = CRUDPedidosWeb.instancia.ConsultarPorNombre(pNombre);
                return Content(HttpStatusCode.OK, pedidosWeb);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex.InnerException.Message);
            }

        }

        [HttpGet]
        [Route("ConsultarPorFecha")]
        public IHttpActionResult ConsultarPorFecha(int pFechaDesde, int pFechaHasta)
        {
            if (!ModelState.IsValid)
            {
                return Content(HttpStatusCode.BadRequest, ModelState); //BadRequest(ModelState);
            }
            try
            {
                IList<BE.Pedidos.PedidosWeb> pedidosWeb = CRUDPedidosWeb.instancia.ConsultarPorFecha(pFechaDesde, pFechaHasta);
                return Content(HttpStatusCode.OK, pedidosWeb);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex.InnerException.Message);
            }

        }
    }
}
