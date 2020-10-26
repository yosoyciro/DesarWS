using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DAL.CRUD.Stock;

namespace WebApi.Controllers.Stock
{
    [RoutePrefix("api/DaniosSecuencias")]
    public class DaniosSecuenciasController : ApiController
    {
        [HttpGet]
        [Route("ConsultarPorDanio")]
        public IHttpActionResult ConsultarPorDanio(int pDaniosId)
        {
            if (!ModelState.IsValid)
            {
                return Content(HttpStatusCode.BadRequest, ModelState); //BadRequest(ModelState);
            }
            try
            {
                IList<BE.Stock.DaniosSecuencias> daniosSecuencias = CRUDDaniosSecuencias.instancia.ConsultarPorDanio(pDaniosId);
                return Content(HttpStatusCode.OK, daniosSecuencias);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex.InnerException.InnerException);
            }

        }
    }
}
