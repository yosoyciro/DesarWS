using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;

namespace DAL.CRUD.PedidosWeb
{
    public class CRUDPedidosWebArchivos
    {
        #region Singleton
        private static ISession session;
        public static CRUDPedidosWebArchivos instancia = new CRUDPedidosWebArchivos();

        private CRUDPedidosWebArchivos()
        {
            session = DAL.Sesion.GenerarSesion.Instancia.Session;
        }
        #endregion    

        public bool Guardar(BE.Pedidos.PedidosWebArchivos pPedidosWebArchivos)
        {
            ITransaction transaction = session.BeginTransaction();
            try
            {
                session.Save(pPedidosWebArchivos);
                transaction.Commit();
                session.Flush();

                return true;
            }

            catch(Exception ex)
            {
                throw ex;
            }                
        }
    }
}
