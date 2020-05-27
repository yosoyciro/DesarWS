using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Configuration;

namespace WebApi.Controllers.AFIP
{
    [RoutePrefix("api/AFIP/ConsultaPadron")]
    public class ConsultaPadronController : ApiController
    {
        [HttpGet]
        [Route("ConsultaPadron")]
        public IHttpActionResult ConsultaPadron(Int64 pCUIT)
        {
            var appconfig = ConfigurationManager.AppSettings;

            try
            {
                switch (appconfig["MetodoPadron"])
                {
                    case "ws_sr_padron_a13":
                        return Content(HttpStatusCode.OK, PadronAFIP.ClsGetPersona.instancia.ConsultarA13(pCUIT, appconfig["MetodoPadron"].ToString()));

                    case "ws_sr_padron_a5":
                        return Content(HttpStatusCode.OK, PadronAFIP.ClsGetPersona.instancia.ConsultarA5(pCUIT, appconfig["MetodoPadron"].ToString()));

                    default:
                        return Content(HttpStatusCode.NotFound, "Recurso no encontrado");
                }
            }                       

            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex.InnerException.Message);
            }           
        }
    }
}
