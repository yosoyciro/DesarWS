using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using BE.Tablas;

namespace DAL.CRUD.Tablas
{
    public class CRUDMarcas
    {
        #region Singleton
        private static ISession session;
        public static CRUDMarcas instancia = new CRUDMarcas();

        private CRUDMarcas()
        {
            session = DAL.Sesion.GenerarSesion.Instancia.Session;
        }
        #endregion        

        #region Consultar
        public IList<Marcas> Consultar()
        {
            return session.Query<Marcas>().ToList();
        }
        #endregion
    }
}
