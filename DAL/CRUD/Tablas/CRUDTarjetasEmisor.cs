using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Tablas;
using NHibernate;

namespace DAL.CRUD.Tablas
{
    public class CRUDTarjetasEmisor
    {
        #region Singleton
        private static ISession session;
        public static CRUDTarjetasEmisor instancia = new CRUDTarjetasEmisor();

        private CRUDTarjetasEmisor()
        {
            session = DAL.Sesion.GenerarSesion.Instancia.Session;
        }
        #endregion        

        #region Consultar
        public IList<TarjetasEmisor> Consultar()
        {
            return session.Query<TarjetasEmisor>().ToList();
        }
        #endregion
    }
}
