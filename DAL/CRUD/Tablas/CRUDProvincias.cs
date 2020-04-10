using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using BE.Tablas;

namespace DAL.CRUD.Tablas
{
    public class CRUDProvincias
    {
        #region Singleton
        private static ISession session;
        public static CRUDProvincias instancia = new CRUDProvincias();

        private CRUDProvincias()
        {
            session = DAL.Sesion.GenerarSesion.Instancia.Session;
        }
        #endregion        

        #region Consultar
        public IList<Provincias> Consultar()
        {
            return session.Query<Provincias>().ToList();
        }
        #endregion
    }
}
