using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;

namespace DAL.CRUD.PedidosWeb
{
    public class CRUDPersonas
    {
        #region Singleton
        private static ISession session;
        public static CRUDPersonas instancia = new CRUDPersonas();

        private CRUDPersonas()
        {
            session = DAL.Sesion.GenerarSesion.Instancia.Session;
        }
        #endregion        

        #region Consultar
        public IList<BE.Pedidos.Personas> Consultar(int pTiposDocumentoId, double pNroDocumento)
        {
            return session.Query<BE.Pedidos.Personas>().Where(a => a.TIPOSDOCUMENTOID == pTiposDocumentoId && a.NRODOCUMENTO == pNroDocumento).ToList();
        }

        public IList<BE.Pedidos.Personas> ConsultarPorNombre(string pNombre)
        {
            var personas = session.Query<BE.Pedidos.Personas>().Where(a => a.NOMBRE.Contains(pNombre)).ToList();


            /*List<BE.Pedidos.PersonasConsulta> oPersonaConsulta = new List<BE.Pedidos.PersonasConsulta>();

            foreach (var item in personas)
            {
                BE.Pedidos.PersonasConsulta personasConsulta = new BE.Pedidos.PersonasConsulta
                {
                    PERSONASID = item.PERSONASID,
                    NOMBRE = item.NOMBRE,
                    DIRECCION1 = item.DIRECCION1,
                    NRODOCUMENTO = item.NRODOCUMENTO,
                };
                oPersonaConsulta.Add(personasConsulta);
            }

            return oPersonaConsulta;*/
            return personas;
        }
        #endregion
    }
}
