using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Tablas;
using NHibernate;

namespace DAL.CRUD.Tablas
{
    public class CRUDTarjetasEntidades
    {
        #region Singleton
        private static ISession session;
        public static CRUDTarjetasEntidades instancia = new CRUDTarjetasEntidades();

        private CRUDTarjetasEntidades()
        {
            session = DAL.Sesion.GenerarSesion.Instancia.Session;
        }
        #endregion        

        #region Consultar
        public IList<TarjetasEntidades> Consultar()
        {
            return session.Query<TarjetasEntidades>().ToList();
        }
        #endregion
    }
}
