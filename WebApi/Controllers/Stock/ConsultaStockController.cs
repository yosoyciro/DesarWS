using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers.Stock
{
    [RoutePrefix("api/ConsultaStock")]
    public class ConsultaStockController : ApiController
    {
        [HttpGet]
        [Route("Consultar")]
        public IHttpActionResult Consultar(int pMarca, int pModelo, int pArticulo)
        {
            try
            {
                IList<BE.Stock.ConsultaStock> consultaStock = DAL.CRUD.Stock.ConsultaStock.instancia.ConsultarStock(pMarca, pModelo, pArticulo);
                return Content(HttpStatusCode.OK, consultaStock);
            }

            catch (Exception e)
            {
                return Content(HttpStatusCode.InternalServerError, e.Message + '-' + e.InnerException.Message);
            }

        }
    }
}
