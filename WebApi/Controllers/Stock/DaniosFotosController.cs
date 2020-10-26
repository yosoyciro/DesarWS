using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DAL.CRUD.Stock;

namespace WebApi.Controllers.Stock
{
    [RoutePrefix("api/DaniosFotos")]
    public class DaniosFotosController : ApiController
    {
        [HttpGet]
        [Route("ConsultarPorFoto")]
        public IHttpActionResult ConsultarPorFoto(int pDaniosFotosId)
        {
            if (!ModelState.IsValid)
            {
                return Content(HttpStatusCode.BadRequest, ModelState); //BadRequest(ModelState);
            }
            try
            {
                IList<BE.Stock.DaniosFotos> daniosFotos = CRUDDaniosFotos.instancia.ConsultarPorFoto(pDaniosFotosId);
                return Content(HttpStatusCode.OK, daniosFotos);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex.InnerException.InnerException);
            }

        }
    }
}
