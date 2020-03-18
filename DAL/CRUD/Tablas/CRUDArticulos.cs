using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Tablas;
using NHibernate;

namespace DAL.CRUD.Tablas
{
    public class CRUDArticulos
    {
        #region Singleton
        private static ISession session;
        public static CRUDArticulos instancia = new CRUDArticulos();

        private CRUDArticulos()
        {
            session = DAL.Sesion.GenerarSesion.Instancia.Session;
        }
        #endregion        

        #region Consultar
        public IList<Articulos> Consultar()
        {
            return session.Query<Articulos>().Where(a => a.USAREN04D == 1).ToList();
        }
        #endregion
    }
}
