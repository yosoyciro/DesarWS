using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Tablas;
using NHibernate;

namespace DAL.CRUD.Tablas
{
    public class CRUDCanalesVenta
    {
        #region Singleton
        private static ISession session;
        public static CRUDCanalesVenta instancia = new CRUDCanalesVenta();

        private CRUDCanalesVenta()
        {
            session = DAL.Sesion.GenerarSesion.Instancia.Session;
        }
        #endregion        

        #region Consultar
        public IList<CanalesVenta> Consultar()
        {
            return session.Query<CanalesVenta>().ToList();
        }
        #endregion
    }
}

