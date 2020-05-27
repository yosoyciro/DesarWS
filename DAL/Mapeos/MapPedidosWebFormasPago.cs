using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
namespace DAL.Mapeos
{
    public class MapPedidosWebFormasPago : ClassMapping<BE.Pedidos.PedidosWebFormasPago>
    {
        public MapPedidosWebFormasPago()
        {
            Id(x => x.PEDIDOSWEBFORMASPAGOID, id =>
            {
                id.Generator(
                    Generators.Identity
                    );
            });
            Property(p => p.PEDIDOSWEBID);
            Property(p => p.FORMASPAGOID);
            Property(p => p.FORMASPAGOID);
            Property(p => p.IMPORTE);
        }
    }
}
