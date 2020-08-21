using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;

namespace DAL.Mapeos
{
    public class MapPedidosWebTarjetasCupones : ClassMapping<BE.Pedidos.PedidosWebTarjetasCupones>
    {
        public MapPedidosWebTarjetasCupones()
        {
            Id(x => x.PEDIDOSWEBTARJETASCUPONESID, id =>
            {
                id.Generator(
                    Generators.Identity
                    );
            });
            Property(p => p.TARJETASENTIDADESID);
            Property(p => p.PEDIDOSWEBFORMASPAGOID);
            Property(p => p.NROCUPON);
            Property(p => p.NROTARJETA);
            Property(p => p.IMPORTE);
            Property(p => p.TARJETASPLANESEMISORID);
            Property(p => p.TARJETASPLANESID);
        }
    }
}
