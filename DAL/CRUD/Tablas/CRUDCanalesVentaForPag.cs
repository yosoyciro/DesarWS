using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Tablas;
using NHibernate;

namespace DAL.CRUD.Tablas
{
    public class CRUDCanalesVentaForPag
    {
        #region Singleton
        private static ISession session;
        public static CRUDCanalesVentaForPag instancia = new CRUDCanalesVentaForPag();

        private CRUDCanalesVentaForPag()
        {
            session = DAL.Sesion.GenerarSesion.Instancia.Session;
        }
        #endregion        

        #region Consultar
        public IList<CanalesVentaForPag> Consultar()
        {
            return session.Query<CanalesVentaForPag>().ToList();
        }
        #endregion
    }
}
