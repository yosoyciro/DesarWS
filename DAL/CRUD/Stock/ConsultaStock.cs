using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;

namespace DAL.CRUD.Stock
{
    public class ConsultaStock
    {
        private static ISession session;
        public static ConsultaStock instancia = new ConsultaStock();
        private ConsultaStock()
        {
            session = DAL.Sesion.GenerarSesion.Instancia.Session;
        }

        public IList<BE.Stock.ConsultaStock> ConsultarStock(int pMarca, int pModelo, int pArticulo)
        {
            try
            {
                return session.CreateSQLQuery("exec ConsultaStock @pMarca = N'" + pMarca + "', @pModelo = N'" + pModelo + "', @pArticulo = N'" + pArticulo + "'")
                    .AddScalar("ArticulosStockId", NHibernateUtil.Int32)
                    .AddScalar("CodigoBarra", NHibernateUtil.String)
                    .AddScalar("Articulo", NHibernateUtil.String)
                    .AddScalar("Marca", NHibernateUtil.String)
                    .AddScalar("Modelo", NHibernateUtil.String)
                    .AddScalar("Descripcion", NHibernateUtil.String)
                    .AddScalar("Motor", NHibernateUtil.String)
                    .AddScalar("TipoVehiculo", NHibernateUtil.String)
                    .AddScalar("Anio", NHibernateUtil.Int32)
                    .AddScalar("Color", NHibernateUtil.String)
                    .AddScalar("TipoCombustible", NHibernateUtil.String)
                    .AddScalar("TipoCaja", NHibernateUtil.String)
                    .AddScalar("Categoria", NHibernateUtil.String)
                    .AddScalar("PrecioVenta", NHibernateUtil.Decimal)
                    .AddScalar("Patente", NHibernateUtil.String)
                    .AddScalar("ArticulosId", NHibernateUtil.Int32)
                    .AddScalar("VehiculosId", NHibernateUtil.Int32)
                    .AddScalar("EstadosId", NHibernateUtil.Int32)
                    .AddScalar("SectoresId", NHibernateUtil.Int32)
                    .AddScalar("Ubicacion", NHibernateUtil.String)
                    .SetResultTransformer(NHibernate.Transform.Transformers.AliasToBean(typeof(BE.Stock.ConsultaStock)))
                    .List<BE.Stock.ConsultaStock>()
                    .ToList();
            }

            catch (Exception e)
            {
                throw e;
            }

        }
    }
}
