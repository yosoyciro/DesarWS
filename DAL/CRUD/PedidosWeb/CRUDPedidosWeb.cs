using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;

namespace DAL.CRUD.PedidosWeb
{
    public class CRUDPedidosWeb
    {
        #region Singleton
        private static ISession session;
        public static CRUDPedidosWeb instancia = new CRUDPedidosWeb();

        private CRUDPedidosWeb()
        {
            session = DAL.Sesion.GenerarSesion.Instancia.Session;
        }
        #endregion        

        #region Guardar
        public BE.Pedidos.PedidosWeb Guardar(BE.Pedidos.PedidosWeb pPedidosWeb)
        {
            ITransaction transaction = session.BeginTransaction();
            try
            {
                //Persona
                var persona = session.Get<BE.Pedidos.Personas>(pPedidosWeb.Persona.PERSONASID);
                if (persona == null)
                {
                    persona = pPedidosWeb.Persona;
                    session.Save(persona);
                    pPedidosWeb.PERSONASID = persona.PERSONASID;
                    pPedidosWeb.Persona.PERSONASID = persona.PERSONASID;
                }                   
                else
                {
                    persona = pPedidosWeb.Persona;
                    session.Merge(persona);
                }
                    
                //Guardo el pedido
                session.Save(pPedidosWeb);

                //Detalle
                int pedidosWebId = pPedidosWeb.PEDIDOSWEBID;                
                foreach (var item in pPedidosWeb.PedidosWebDetalle)
                {
                    var pedidosWebDetalle = session.Get<BE.Pedidos.PedidosWebDetalle>(item.PEDIDOSWEBDETALLEID);
                    if (pedidosWebDetalle == null)
                    {
                        item.PEDIDOSWEBID = pedidosWebId;
                        session.Save(item);
                    }
                    
                }

                transaction.Commit();
                session.Flush();
                return pPedidosWeb;
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
