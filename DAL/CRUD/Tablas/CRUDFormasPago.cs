using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Tablas;
using NHibernate;

namespace DAL.CRUD.Tablas
{
    public class CRUDFormasPago
    {
        #region Singleton
        private static ISession session;
        public static CRUDFormasPago instancia = new CRUDFormasPago();

        private CRUDFormasPago()
        {
            session = DAL.Sesion.GenerarSesion.Instancia.Session;
        }
        #endregion        

        #region Consultar
        public IList<FormasPago> Consultar()
        {
            return session.Query<FormasPago>().ToList();
        }
        #endregion
    }
}
