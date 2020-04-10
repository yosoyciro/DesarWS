using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;

namespace DAL.CRUD.PedidosWeb
{
    public class CRUDPersonasWeb
    {
        #region Singleton
        private static ISession session;
        public static CRUDPersonasWeb instancia = new CRUDPersonasWeb();

        private CRUDPersonasWeb()
        {
            session = DAL.Sesion.GenerarSesion.Instancia.Session;
        }
        #endregion        

        #region Consultar
        public IList<BE.Pedidos.PersonasWeb> Consultar(int pCodigoDocumento, int pNroDocumento)
        {
            return session.Query<BE.Pedidos.PersonasWeb>().Where(a => a.CODIGODOCUMENTO == pCodigoDocumento && a.NRODOCUMENTO == pNroDocumento).ToList();
        }
        #endregion
    }
}
