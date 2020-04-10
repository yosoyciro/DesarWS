using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;

namespace DAL.Mapeos
{
    public class MapPedidosWeDetalle : ClassMapping<BE.Pedidos.PedidosWebDetalle>
    {
        public MapPedidosWeDetalle()
        {
            Id(x => x.PEDIDOSWEBDETALLEID, id =>
            {
                id.Generator(
                    Generators.Identity
                    );
            });
            Property(p => p.PEDIDOSWEBID);
            Property(p => p.CANTIDAD);
            Property(p => p.ARTICULOSSTOCKID);
            Property(p => p.UNITARIO);
            Property(p => p.TOTAL);
            Property(p => p.OBSERVACIONES);
            Property(p => p.UNITARIOORIGINAL);
            Property(p => p.IMPORTEDESCUENTO);
            //Property(p => p.ROWGUID);
        }
    }
}
