using System;
using System.Collections.Generic;
using System.Linq;
using NHibernate;
using BE.Tablas;

namespace DAL.CRUD.Tablas
{
    public class CRUDTiposCombustible
    {
        #region Singleton
        private static ISession session;
        public static CRUDTiposCombustible instancia = new CRUDTiposCombustible();

        private CRUDTiposCombustible()
        {
            session = DAL.Sesion.GenerarSesion.Instancia.Session;
        }
        #endregion        

        #region Consultar
        public IList<TiposCombustible> Consultar()
        {
            return session.Query<TiposCombustible>().ToList();
        }
        #endregion
    }
}
