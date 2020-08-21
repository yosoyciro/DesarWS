using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Tablas;
using NHibernate;

namespace DAL.CRUD.Tablas
{
    public class CRUDTarjetasPlanes
    {
        #region Singleton
        private static ISession session;
        public static CRUDTarjetasPlanes instancia = new CRUDTarjetasPlanes();

        private CRUDTarjetasPlanes()
        {
            session = DAL.Sesion.GenerarSesion.Instancia.Session;
        }
        #endregion        

        #region Consultar
        public IList<TarjetasPlanes> Consultar()
        {
            return session.Query<TarjetasPlanes>().ToList();
        }
        #endregion
    }
}
