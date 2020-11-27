using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers.Stock
{
    [RoutePrefix("api/ConsultaStockRemitos")]
    public class ConsultaStockRemitosController : ApiController
    {
        [HttpGet]
        [Route("Consultar")]
        public IHttpActionResult Consultar(string pPatente, int pLegajo)
        {
            try
            {
                IList<BE.Stock.ConsultaStockRemitos> consultaStock = DAL.CRUD.Stock.ConsultaStockRemitos.instancia.ConsultarStockRemitos(pPatente, pLegajo);
                return Content(HttpStatusCode.OK, consultaStock);
            }

            catch (Exception e)
            {
                return Content(HttpStatusCode.InternalServerError, e.Message + '-' + e.InnerException.Message);
            }

        }
    }
}
