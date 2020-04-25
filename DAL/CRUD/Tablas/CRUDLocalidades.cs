using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using BE.Tablas;

namespace DAL.CRUD.Tablas
{
    public class CRUDLocalidades
    {
        #region Singleton
        private static ISession session;
        public static CRUDLocalidades instancia = new CRUDLocalidades();

        private CRUDLocalidades()
        {
            session = DAL.Sesion.GenerarSesion.Instancia.Session;
        }
        #endregion        

        #region Consultar
        public IList<Localidades> Consultar(int pProvinciasId)
        {
            return session.Query<Localidades>()
                .Where(a => a.PROVINCIASID == pProvinciasId)
                .OrderBy(a => a.NOMBRE)
                .ToList();
        }
        #endregion

        #region ConsultarPorId
        public Localidades ConsultarPorId(int pLocalidadesId)
        {
            return session.Get<Localidades>(pLocalidadesId);
        }
        #endregion
    }
}
