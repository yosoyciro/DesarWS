using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using BE.Tablas;

namespace DAL.CRUD.Tablas
{
    public class CRUDModelos
    {
        #region Singleton
        private static ISession session;
        public static CRUDModelos instancia = new CRUDModelos();

        private CRUDModelos()
        {
            session = DAL.Sesion.GenerarSesion.Instancia.Session;
        }
        #endregion        

        #region Consultar
        public IList<Modelos> Consultar()
        {
            return session.Query<Modelos>().ToList();
        }
        #endregion
    }
}
