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
    [RoutePrefix("api/Empleados")]
    public class EmpleadosController : ApiController
    {
        [HttpPost]
        [Route("Login")]
        public IHttpActionResult Login(Empleados pEmpleados)
        {
            if (!ModelState.IsValid)
            {
                return Content(HttpStatusCode.BadRequest, ModelState); //BadRequest(ModelState);
            }
            try
            {
                /*IList<Empleados> empleados = CRUDEmpleados.instancia.Login(pEmpleados);
                switch (empleados.Count)
                {
                    case 0:
                        return Content(HttpStatusCode.NotFound, empleados);

                    default:
                        return Content(HttpStatusCode.OK, empleados);
                }    */
                bool ret = CRUDEmpleados.instancia.Login(pEmpleados);
                switch (ret)
                {
                    case true:
                        return Content(HttpStatusCode.OK, "Login exitoso");

                    case false:
                        return Content(HttpStatusCode.NotFound, "Usuario/password incorrecto");

                    default:
                        return Content(HttpStatusCode.NoContent, "");
                }
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex.InnerException.InnerException);
            }

        }
    }
}
