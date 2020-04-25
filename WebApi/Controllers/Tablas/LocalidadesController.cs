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
    [RoutePrefix("api/Localidades")]
    public class LocalidadesController : ApiController
    {
        [HttpGet]
        [Route("Consultar")]
        public IHttpActionResult Consultar(int pProvinciasId)
        {
            if (!ModelState.IsValid)
            {
                return Content(HttpStatusCode.BadRequest, ModelState); //BadRequest(ModelState);
            }
            try
            {
                IList<Localidades> localidades = CRUDLocalidades.instancia.Consultar(pProvinciasId);
                return Content(HttpStatusCode.OK, localidades);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex.InnerException.InnerException);
            }

        }

        [HttpGet]
        [Route("ConsultarPorId")]
        public IHttpActionResult ConsultarPorId(int pLocalidadesId)
        {
            if (!ModelState.IsValid)
            {
                return Content(HttpStatusCode.BadRequest, ModelState); //BadRequest(ModelState);
            }
            try
            {
                Localidades localidades = CRUDLocalidades.instancia.ConsultarPorId(pLocalidadesId);
                return Content(HttpStatusCode.OK, localidades);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex.InnerException.InnerException);
            }

        }
    }
}
