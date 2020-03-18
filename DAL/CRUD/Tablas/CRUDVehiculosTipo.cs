using System;
using System.Collections.Generic;
using System.Linq;
using NHibernate;
using BE.Tablas;

namespace DAL.CRUD.Tablas
{
    public class CRUDVehiculosTipo
    {
        #region Singleton
        private static ISession session;
        public static CRUDVehiculosTipo instancia = new CRUDVehiculosTipo();

        private CRUDVehiculosTipo()
        {
            session = DAL.Sesion.GenerarSesion.Instancia.Session;
        }
        #endregion        

        #region Consultar
        public IList<VehiculosTipo> Consultar()
        {
            return session.Query<VehiculosTipo>().ToList();
        }
        #endregion
    }
}
