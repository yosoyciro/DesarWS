using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers.Stock
{
    [RoutePrefix("api/ConsultaStockAsociado")]
    public class ConsultaStockAsociadoController : ApiController
    {
        [HttpGet]
        [Route("Consultar")]
        public IHttpActionResult Consultar(int pVehiculosId)
        {
            try
            {
                IList<BE.Stock.ConsultaStock> consultaStockAsociado = DAL.CRUD.Stock.ConsultaStockAsociado.instancia.ConsultarStockAsociado(pVehiculosId);
                return Content(HttpStatusCode.OK, consultaStockAsociado);
            }

            catch (Exception e)
            {
                return Content(HttpStatusCode.InternalServerError, e.Message + '-' + e.InnerException.Message);
            }

        }
    }
}
