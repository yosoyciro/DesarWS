using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Configuration;
using System.IO;
using System.Xml.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Pkcs;

namespace PadronAFIP
{
    public class ClsLogin
    {
        public static ClsLogin instancia = new ClsLogin();
        private ClsLogin()
        {
        }

        public bool Login(string pMetodoPadron)
        {
            bool ret = false;
            try
            {
                if (VerificarTicket(pMetodoPadron) == false)
                {
                    if (PedirTicket(pMetodoPadron) == true)
                    {
                        ret = true;
                    }
                    else
                        ret = false;
                }
                else
                    ret = true;
            }
            catch (Exception e)
            {
                throw e;
            }
            return ret;
        }
        private bool VerificarTicket(string pMetodoPadron)
        {
            ClsLog.instancia.EscribirLog("vERIFICAR TICKET");
            bool ret = false;
            var appconfig = ConfigurationManager.AppSettings;
            //Veo si existe el ticket y leo la info a ver si es válido            
            XmlDocument XmlTicket = new XmlDocument();
            try
            {
                switch (pMetodoPadron)
                {
                    case "ws_sr_padron_a5":
                        XmlTicket.Load(appconfig["TicketA5"]);
                        break;

                    case "ws_sr_padron_a13":
                        XmlTicket.Load(appconfig["TicketA13"]);
                        break;

                    default:
                        break;
                }
                
                //busco el elemento <expirationTime>
                DateTime fechahoravalido = Convert.ToDateTime(XmlTicket.SelectSingleNode("//expirationTime").InnerText);
                DateTime fechahoraactual = System.DateTime.Now;

                //Comparo fecha/hora
                int valor = DateTime.Compare(fechahoravalido, fechahoraactual);
                if (valor > 0)
                {
                    if (XmlTicket.SelectSingleNode("//token") == null)
                    {
                        ClsLog.instancia.EscribirLog("No existe el token. Se pide ticket.");
                        ret = false; //esta generado pero no hay token
                    }
                    else
                    {
                        ClsLog.instancia.EscribirLog("Existe el token. Sirve el ticket.");
                        ret = true; //sirve el ticket
                    }
                }                
            }

            catch (Exception ex)
            {
                throw ex;
            }            

            return ret;
        }

        private bool PedirTicket(string pMetodoPadron)
        {
            //openssl pkcs12 -export -out autopiezasSHA2.pfx -inkey autopiezasSHA2.key -in autopiezasSHA2.crt
            bool ret = false;

            var appconfig = ConfigurationManager.AppSettings;
            Random random = new Random();
            XmlWriter XmlRequestLogin = null;
            try
            {
                //creo el xml
                switch (pMetodoPadron)
                {
                    case "ws_sr_padron_a5":
                        XmlRequestLogin = XmlWriter.Create(appconfig["TicketA5"]);
                        break;

                    case "ws_sr_padron_a13":
                        XmlRequestLogin = XmlWriter.Create(appconfig["TicketA13"]);
                        break;
                }
                
                //ClsLog.instancia.EscribirLog("Crea el ticket");

                //cabecera 
                XmlRequestLogin.WriteStartDocument();
                XmlRequestLogin.WriteStartElement("loginTicketRequest");
                XmlRequestLogin.WriteAttributeString("version", "1.0");

                XmlRequestLogin.WriteStartElement("header");

                XmlRequestLogin.WriteStartElement("uniqueId");
                XmlRequestLogin.WriteString(Convert.ToString(random.Next(1, 99999999)));
                XmlRequestLogin.WriteEndElement();

                XmlRequestLogin.WriteStartElement("generationTime");
                XmlRequestLogin.WriteString(DateTime.Now.AddMinutes(-10).ToString("s"));
                XmlRequestLogin.WriteEndElement();

                XmlRequestLogin.WriteStartElement("expirationTime");
                XmlRequestLogin.WriteString(DateTime.Now.AddMinutes(+10).ToString("s"));
                XmlRequestLogin.WriteEndElement();

                //cierra el header
                XmlRequestLogin.WriteEndElement();

                XmlRequestLogin.WriteStartElement("service");
                XmlRequestLogin.WriteString(appconfig["MetodoPadron"]);
                XmlRequestLogin.WriteEndElement();

                XmlRequestLogin.WriteEndDocument();
                XmlRequestLogin.Close();

                //ClsLog.instancia.EscribirLog("Escribe el ticket y cierra");

                //Cargo el xml en un objeto XmlDocument
                XmlDocument XmlLogin = new XmlDocument();
                switch (pMetodoPadron)
                {
                    case "ws_sr_padron_a5":
                        XmlLogin.Load(appconfig["TicketA5"]);
                        break;

                    case "ws_sr_padron_a13":
                        XmlLogin.Load(appconfig["TicketA13"]);
                        break;
                }
                
                //ClsLog.instancia.EscribirLog("Carga el XML");

                X509Certificate2 oCertificado ;
                switch (appconfig["WindowsVersion"])
                {
                    case "2012":
                        oCertificado = new X509Certificate2(appconfig["CRT"], appconfig["Password"], X509KeyStorageFlags.MachineKeySet | X509KeyStorageFlags.PersistKeySet | X509KeyStorageFlags.Exportable);
                        break;

                    default:
                        oCertificado = new X509Certificate2(appconfig["CRT"], appconfig["Password"], X509KeyStorageFlags.Exportable);
                        break;
                }

                //ClsLog.instancia.EscribirLog("Certificado X509 ok");

                byte[] msgByte = Encoding.UTF8.GetBytes(XmlLogin.OuterXml);

                //Firmo el xml
                ContentInfo infocontenido = new ContentInfo(msgByte);
                SignedCms cmsfirmado = new SignedCms(infocontenido);
                CmsSigner cmsfirmante = new CmsSigner(oCertificado)
                {
                    IncludeOption = X509IncludeOption.EndCertOnly
                };
                cmsfirmado.ComputeSignature(cmsfirmante);

                string cmsFirmadoBase64 = Convert.ToBase64String(cmsfirmado.Encode());
                //conexion
                AFIP.WSAA.LoginCMSService wslogin = new AFIP.WSAA.LoginCMSService();
                wslogin.Url = appconfig["URLTicketProduccion"];
                string xmlticketresponse = wslogin.loginCms(cmsFirmadoBase64);

                //Guardo la respuesta
                XmlDocument xmlloginticketresponse = new XmlDocument();
                xmlloginticketresponse.LoadXml(xmlticketresponse);
                //ClsLog.instancia.EscribirLog("xmlloginticketresponse: " + xmlloginticketresponse);
                //XmlWriter xmlrespuestalogin = XmlWriter.Create(appconfig["Ticket"]);
                //if (xmlticketresponse != null)
                //    xmlrespuestalogin.WriteString(xmlticketresponse);
                //else
                //    ret = false;
                if (xmlloginticketresponse != null)
                {
                    switch (pMetodoPadron)
                    {
                        case "ws_sr_padron_a5":
                            xmlloginticketresponse.Save(appconfig["TicketA5"]);
                            break;

                        case "ws_sr_padron_a13":
                            xmlloginticketresponse.Save(appconfig["TicketA13"]);
                            break;
                    }
                    
                    ret = true;
                }

                //Destruyo los objetos
                oCertificado.Dispose();
                XmlRequestLogin.Dispose();
                wslogin.Dispose();
            }
            catch (Exception ex)
            {
                //ClsLog.instancia.EscribirLog("Error " + ex.InnerException.Message);
                throw ex;
            }      

            finally
            {
                
            }
            
            return ret;
        }
    }
}
