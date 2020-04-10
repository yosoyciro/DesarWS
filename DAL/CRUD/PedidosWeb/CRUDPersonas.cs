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
        public IList<BE.Pedidos.Personas> Consultar(int pTiposDocumentoId, int pNroDocumento)
        {
            return session.Query<BE.Pedidos.Personas>().Where(a => a.TIPOSDOCUMENTOID == pTiposDocumentoId && a.NRODOCUMENTO == pNroDocumento).ToList();
        }
        #endregion
    }
}
