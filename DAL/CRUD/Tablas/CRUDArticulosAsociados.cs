using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Tablas;
using NHibernate;

namespace DAL.CRUD.Tablas
{
    public class CRUDArticulosAsociados
    {
        #region Singleton
        private static ISession session;
        public static CRUDArticulosAsociados instancia = new CRUDArticulosAsociados();

        private CRUDArticulosAsociados()
        {
            session = DAL.Sesion.GenerarSesion.Instancia.Session;
        }
        #endregion        

        #region Consultar
        public IList<ArticulosAsociados> Consultar()
        {
            return session.Query<ArticulosAsociados>().ToList();
        }
        #endregion
    }
}
