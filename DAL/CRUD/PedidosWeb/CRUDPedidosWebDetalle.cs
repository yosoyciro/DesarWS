using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;


namespace DAL.CRUD.PedidosWeb
{
    public class CRUDPedidosWebDetalle
    {
        #region Singleton
        private static ISession session;
        public static CRUDPedidosWebDetalle instancia = new CRUDPedidosWebDetalle();

        private CRUDPedidosWebDetalle()
        {
            session = DAL.Sesion.GenerarSesion.Instancia.Session;
        }
        #endregion        

        #region Guardar
        public BE.Pedidos.PedidosWebDetalle Guardar(BE.Pedidos.PedidosWebDetalle pPedidosWebDetalle)
        {
            ITransaction transaction = session.BeginTransaction();
            try
            {
                return pPedidosWebDetalle;
            }
            catch (Exception e)
            {
                transaction.Rollback();
                throw e;
            }
        }
        #endregion
    }
}
