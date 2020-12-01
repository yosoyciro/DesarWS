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

        public Localidades Agregar(Localidades pLocalidad)
        {
            var localidad = session.Query<BE.Tablas.Localidades>().Where(a => a.NOMBRE == pLocalidad.NOMBRE && a.PROVINCIASID == pLocalidad.PROVINCIASID).SingleOrDefault();
            if (localidad == null)
            {
                ITransaction transaction = session.BeginTransaction();
                try
                {
                    localidad = pLocalidad;
                    session.Save(localidad);

                    //session.Flush();
                    transaction.Commit();
                }

                catch (Exception e)
                {
                    transaction.Rollback();
                    throw e;
                }
            }
            else
            {
                localidad = pLocalidad;
            }
            
            return localidad;
           
        }
    }
}
