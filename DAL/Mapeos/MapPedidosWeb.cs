using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;

namespace DAL.Mapeos
{
    public class MapPedidosWeb : ClassMapping<BE.Pedidos.PedidosWeb>
    {
        public MapPedidosWeb()
        {
            Id(x => x.PEDIDOSWEBID, id =>
            {
                id.Generator(
                    Generators.Identity
                    );
            });
            Property(p => p.PERSONASID);
            Property(p => p.FECHAPEDIDO);
            Property(p => p.TOTALPEDIDO);
            Property(p => p.PEDIDOSESTADOID);
            Property(p => p.USUARIO);
            Property(p => p.NOMBRE);
            Property(p => p.PORCDESCUENTO);
            Property(p => p.DESCUENTOSID);
            Property(p => p.IMPORTEDESCUENTO);
            Property(p => p.PEDIDOSORIGENID);
            Property(p => p.PEDIDOSID);
            //Property(p => p.ROWGUID);
            Property(p => p.FechaPedidoS, m => {
                m.Formula("dbo.ConvFechaSQL(FechaPedido)");
            });
            /*ManyToOne(p => p.Persona, map =>
            {
                map.Column("PERSONASID");
                map.Class(typeof(BE.Pedidos.Personas));
                map.Fetch(FetchKind.Join); // or FetchKind.Select
                map.NotNullable(true);
                map.UniqueKey("PERSONASID");
                map.Lazy(LazyRelation.NoLazy);
            }
            );*/
        }
    }
}
