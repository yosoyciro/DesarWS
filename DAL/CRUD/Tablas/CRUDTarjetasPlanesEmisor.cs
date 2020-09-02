using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Tablas;
using NHibernate;

namespace DAL.CRUD.Tablas
{
    public class CRUDTarjetasPlanesEmisor
    {
        #region Singleton
        private static ISession session;
        public static CRUDTarjetasPlanesEmisor instancia = new CRUDTarjetasPlanesEmisor();

        private CRUDTarjetasPlanesEmisor()
        {
            session = DAL.Sesion.GenerarSesion.Instancia.Session;
        }
        #endregion        

        #region Consultar
        public IList<TarjetasPlanesEmisor> Consultar()
        {
            return session.Query<TarjetasPlanesEmisor>().ToList();
        }
        #endregion
    }
}
