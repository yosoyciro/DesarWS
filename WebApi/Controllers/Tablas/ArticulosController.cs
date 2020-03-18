using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BE.Tablas;
using DAL.CRUD.Tablas;

namespace WebApi.Controllers.Tablas
{
    [RoutePrefix("api/Articulos")]
    public class ArticulosController : ApiController
    {
        [HttpGet]
        [Route("Consultar")]
        public IHttpActionResult Consultar()
        {
            if (!ModelState.IsValid)
            {
                return Content(HttpStatusCode.BadRequest, ModelState); //BadRequest(ModelState);
            }
            try
            {
                IList<Articulos> articulos = CRUDArticulos.instancia.Consultar();
                return Content(HttpStatusCode.OK, articulos);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex.InnerException.InnerException);
            }

        }
    }
}
