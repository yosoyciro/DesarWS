using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;


namespace DAL.CRUD.Stock
{
    public class CRUDDaniosFotos
    {
        #region Singleton
        private static ISession session;
        public static CRUDDaniosFotos instancia = new CRUDDaniosFotos();

        private CRUDDaniosFotos()
        {
            session = DAL.Sesion.GenerarSesion.Instancia.Session;
        }
        #endregion        

        public IList<BE.Stock.DaniosFotos> ConsultarPorFoto(int pDaniosFotosId)
        {
            return session.Query<BE.Stock.DaniosFotos>().Where(a => a.DANIOSFOTOSID == pDaniosFotosId).ToList();
        }
    }
}
