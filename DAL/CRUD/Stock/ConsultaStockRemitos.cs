using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;

namespace DAL.CRUD.Stock
{
    public class ConsultaStockRemitos
    {
        private static ISession session;
        public static ConsultaStockRemitos instancia = new ConsultaStockRemitos();
        private ConsultaStockRemitos()
        {
            session = DAL.Sesion.GenerarSesion.Instancia.Session;
        }

        public IList<BE.Stock.ConsultaStockRemitos> ConsultarStockRemitos(string pPatente, int pLegajo)
        {
            try
            {
                return session.CreateSQLQuery("exec ConsultaStockRemitos @pPatente = N'" + pPatente + "', @pLegajo = N'" + pLegajo + "'")
                    .AddScalar("ArticulosStockId", NHibernateUtil.Int32)
                    .AddScalar("CodigoBarra", NHibernateUtil.String)
                    .AddScalar("Articulo", NHibernateUtil.String)
                    .AddScalar("Marca", NHibernateUtil.String)
                    .AddScalar("Modelo", NHibernateUtil.String)
                    .AddScalar("Descripcion", NHibernateUtil.String)
                    .AddScalar("Motor", NHibernateUtil.String)
                    .AddScalar("TipoVehiculo", NHibernateUtil.String)
                    .AddScalar("Anio", NHibernateUtil.Int32)
                    .AddScalar("Patente", NHibernateUtil.String)
                    .AddScalar("ArticulosId", NHibernateUtil.Int32)
                    .AddScalar("VehiculosId", NHibernateUtil.Int32)
                    .SetResultTransformer(NHibernate.Transform.Transformers.AliasToBean(typeof(BE.Stock.ConsultaStockRemitos)))
                    .List<BE.Stock.ConsultaStockRemitos>()
                    .ToList();
            }

            catch (Exception e)
            {
                throw e;
            }

        }
    }
}
