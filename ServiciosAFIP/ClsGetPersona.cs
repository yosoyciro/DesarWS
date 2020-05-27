using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Configuration;

namespace PadronAFIP
{
    public class ClsGetPersona
    {
        public static ClsGetPersona instancia = new ClsGetPersona();
        private ClsGetPersona()
        {
        }

        public AFIP.PadronA13.personaReturn ConsultarA13(double pCUIT, string pMetodoPadron)
        {
            if (ClsLogin.instancia.Login(pMetodoPadron) == false)
            {
                return null;
            }

            ClsLog.instancia.EscribirLog("Ingresa a Consultar");
            var appconfig = ConfigurationManager.AppSettings;             

            //Leo xml del ticket con el token y el sign
            XmlDocument XmlTicket = new XmlDocument();
            XmlTicket.Load(appconfig["TicketA13"]);

            //Conecto
            string token = XmlTicket.SelectSingleNode("//token").InnerText;
            string sign = XmlTicket.SelectSingleNode("//sign").InnerText;
            Int64 cuitrepresentada = Convert.ToInt64(appconfig["CUIT"]);
            Int64 cuitconsultada = Convert.ToInt64(pCUIT);

            AFIP.PadronA13.PersonaServiceA13 padrona13 = new AFIP.PadronA13.PersonaServiceA13();
            AFIP.PadronA13.personaReturn personaReturn = new AFIP.PadronA13.personaReturn();

            padrona13.Url = appconfig["URLPadronProduccionA13"].ToString();
            personaReturn = padrona13.getPersona(token, sign, cuitrepresentada, cuitconsultada);

            return personaReturn;
        }

        public AFIP.PadronA5.personaReturn ConsultarA5(double pCUIT, string pMetodoPadron)
        {
            ClsLog.instancia.EscribirLog("Ingresa a Consultar A5");
            if (ClsLogin.instancia.Login(pMetodoPadron) == false)
            {
                ClsLog.instancia.EscribirLog("Error en Login");
                return null;
            }
            
            var appconfig = ConfigurationManager.AppSettings;

            //Leo xml del ticket con el token y el sign
            ClsLog.instancia.EscribirLog("Leo ticket A5");
            XmlDocument XmlTicket = new XmlDocument();
            XmlTicket.Load(appconfig["TicketA5"]);

            //Conecto
            string token = XmlTicket.SelectSingleNode("//token").InnerText;
            string sign = XmlTicket.SelectSingleNode("//sign").InnerText;
            Int64 cuitrepresentada = Convert.ToInt64(appconfig["CUIT"]);
            Int64 cuitconsultada = Convert.ToInt64(pCUIT);

            AFIP.PadronA5.PersonaServiceA5 padrona5 = new AFIP.PadronA5.PersonaServiceA5();
            AFIP.PadronA5.personaReturn personaA5Return = new AFIP.PadronA5.personaReturn();

            padrona5.Url = appconfig["URLPadronProduccionA5"].ToString();
            ClsLog.instancia.EscribirLog("GetPersona A5");
            personaA5Return = padrona5.getPersona(token, sign, cuitrepresentada, cuitconsultada);
            ClsLog.instancia.EscribirLog("personaA5Return A5");
            return personaA5Return;
        }
    }
}
