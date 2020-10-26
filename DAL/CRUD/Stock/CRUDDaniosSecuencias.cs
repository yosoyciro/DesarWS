using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;


namespace DAL.CRUD.Stock
{
    public class CRUDDaniosSecuencias
    {
        #region Singleton
        private static ISession session;
        public static CRUDDaniosSecuencias instancia = new CRUDDaniosSecuencias();

        private CRUDDaniosSecuencias()
        {
            session = DAL.Sesion.GenerarSesion.Instancia.Session;
        }
        #endregion        

        public IList<BE.Stock.DaniosSecuencias> ConsultarPorDanio(int pDaniosId)
        {
            return session.Query<BE.Stock.DaniosSecuencias>().Where(a => a.DANIOSID == pDaniosId).ToList();
        }
    }
}
